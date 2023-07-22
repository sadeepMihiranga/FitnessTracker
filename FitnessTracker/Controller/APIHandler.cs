using FitnessTracker.DTOs;
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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
    }
}
