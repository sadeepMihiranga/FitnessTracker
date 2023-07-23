using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.View;
using System.Configuration;

namespace FitnessTracker.Controller
{
    internal class CheatMealTypeController
    {
        private string _BaseURL = "";

        public CheatMealTypeController()
        {
            _BaseURL = ConfigurationManager.AppSettings.Get("BaseURL");
        }

        public List<ComboboxModel> ToComboboxList()
        {
            List<ComboboxModel> comboboxList = null;

            try
            {
                HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal-type");

                APIResponseWrapper<List<CheatMealModel>> responseWrapper = new APIResponseWrapper<List<CheatMealModel>>();
                responseWrapper = APIHandler.HandleAPIResponse(response, responseWrapper, false);

                if (responseWrapper.Success == true)
                {
                    if (responseWrapper.SuccessReponse != null)
                    {
                        comboboxList = responseWrapper.SuccessReponse.Select(i => new ComboboxModel(Int32.Parse(i.Id.ToString()), i.Name)).ToList();
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching meal types");
                        return null;
                    }
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage(responseWrapper.ErrorResponse.Title);
                    return null;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while fetching meal types");
                return null;
            }
            finally
            {

            }

            return comboboxList;
        }

        public CheatMealTypeModel GetById(long id)
        {
            try
            {
                HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal-type/" + id);

                APIResponseWrapper<CheatMealTypeModel> responseWrapper = new APIResponseWrapper<CheatMealTypeModel>();
                responseWrapper = APIHandler.HandleAPIResponse(response, responseWrapper, false);

                if (responseWrapper.Success == true)
                {
                    if (responseWrapper.SuccessReponse != null)
                    {
                        return responseWrapper.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching meal type");
                        return null;
                    }
                }
                else
                {
                    FormsHandler.OperationFailedErrorMessage(responseWrapper.ErrorResponse.Title);
                    return null;
                }
            }
            catch (Exception ex)
            {
                FormsHandler.OperationFailedErrorMessage("Error while fetching meal type");
                return null;
            }
            finally
            {

            }
        }
    }
}
