using FitnessTracker.DTOs;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Twilio.TwiML;

namespace FitnessTracker.Controller
{
    internal class APIHandler
    {
        public static HttpResponseMessage DoGet(string url, Dictionary<string, string> queryParams)
        {
            HttpClient client = HttpClientFactory.Create();

            HttpResponseMessage response = client.GetAsync(QueryHelpers.AddQueryString(url, queryParams)).Result;

            client.Dispose();
            return response;
        }

        public static HttpResponseMessage DoGet(string url)
        {
            HttpClient client = HttpClientFactory.Create();

            HttpResponseMessage response = client.GetAsync(url).Result;

            client.Dispose();
            return response;
        }

        public static HttpResponseMessage DoDelete(string url)
        {
            HttpClient client = HttpClientFactory.Create();

            HttpResponseMessage response = client.DeleteAsync(url).Result;

            client.Dispose();
            return response;
        }

        public static HttpResponseMessage DoPost<T>(string url, ref T jsonObject)
        {
            HttpClient client = HttpClientFactory.Create();

            string message = JsonSerializer.Serialize(jsonObject);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            var content = new ByteArrayContent(messageBytes);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;

            client.Dispose();
            return response;
        }

        public static HttpResponseMessage DoPostXML<T>(string url, ref T xmlObject)
        {
            HttpClient client = HttpClientFactory.Create();
            client.DefaultRequestHeaders.Add("Accept", "application/xml");

            string xml = "";
            XmlSerializer serializer = new XmlSerializer(xmlObject.GetType());
            using (var stringWriter = new Utf8StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Async = true }))
                {
                    serializer.Serialize(writer, xmlObject);
                    xml = stringWriter.ToString(); // Your XML
                }
            }

            HttpContent body = new StringContent(xml, Encoding.UTF8, "application/xml");
            var response = client.PostAsync(url, body).Result;

            client.Dispose();
            return response;
        }

        public static APIResponseWrapper<T> HandleAPIResponse<T>(HttpResponseMessage response, APIResponseWrapper<T> responseWrapper, bool isVoid)
        {
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // this is the point
                };
                options.Converters.Add(new JsonStringEnumConverter());

                responseWrapper.Success = true;

                if (!isVoid)
                {
                    // access the root element and extract the specific node from the JSON using the provided path
                    JsonElement specificNode = JsonDocument.Parse(response.Content.ReadAsStringAsync().Result).RootElement.GetProperty("data");
                    responseWrapper.SuccessReponse = JsonSerializer.Deserialize<T>(specificNode.GetRawText(), options);
                }
            }
            else
            {
                // access the root element and extract the specific node from the JSON using the provided path
                JsonElement specificNode = JsonDocument.Parse(response.Content.ReadAsStringAsync().Result).RootElement;

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // this is the point
                };

                ErrorResponseDTO error = JsonSerializer.Deserialize<ErrorResponseDTO>(specificNode.GetRawText(), options);

                responseWrapper.Success = false;
                responseWrapper.ErrorResponse = error;
            }

            return responseWrapper;
        }

        public static APIResponseWrapper<T> HandleAPIXMLResponse<T>(HttpResponseMessage response, APIResponseWrapper<T> responseWrapper)
        {
            if (response.IsSuccessStatusCode)
            {
                responseWrapper.Success = true;

                var content = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(content))
                {
                    var xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(content);
                    XmlNode xNode = xmlDocument.SelectSingleNode("//ResponseOfUserDTO/Data");

                    // Deserializing Response from XML to Object
                    /*XmlSerializer responseserializer = new XmlSerializer(respDataType.GetType());

                    using (StringReader reader = new StringReader(xNode.InnerXml))
                    {
                       
                        var responsesong = responseserializer.Deserialize(reader);
                        responseWrapper.SuccessReponse = (T?)responsesong;
                    }*/
                }
            }
            else 
            {
                responseWrapper.Success = false;

                var content = response.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(content))
                {
                    var xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(content);

                    // Set up a namespace manager to handle the XML namespace (if any)
                    XmlNamespaceManager nsManager = new XmlNamespaceManager(xmlDocument.NameTable);
                    nsManager.AddNamespace("ns", "urn:ietf:rfc:7807");

                  
                    XmlNode xNode = xmlDocument.SelectSingleNode("//ns:title", nsManager);
                    ErrorResponseDTO errorResponse = new()
                    {
                        Title = xNode.InnerText
                    };

                    responseWrapper.SuccessReponse = (T)(object)errorResponse;
                }
            }

            return responseWrapper;
        }
    }
}
