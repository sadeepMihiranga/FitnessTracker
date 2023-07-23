using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.View;
using System.Configuration;

namespace FitnessTracker.Controller
{
    internal class CheatMealReasonController
    {
        private string _BaseURL = "";

        public CheatMealReasonController()
        {
            _BaseURL = ConfigurationManager.AppSettings.Get("BaseURL");
        }

        public List<ComboboxModel> ToComboboxList()
        {
            List<ComboboxModel> comboboxList = null;

            try
            {
                HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal-reason");

                APIResponseWrapper<List<CheatMealReasonModel>> responseWrapper = new APIResponseWrapper<List<CheatMealReasonModel>>();
                responseWrapper = APIHandler.HandleAPIResponse(response, responseWrapper, false);

                if (responseWrapper.Success == true)
                {
                    if (responseWrapper.SuccessReponse != null)
                    {
                        comboboxList = responseWrapper.SuccessReponse.Select(i => new ComboboxModel(Int32.Parse(i.Id.ToString()), i.Name)).ToList();
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching meal reasons");
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
                FormsHandler.OperationFailedErrorMessage("Error while fetching meal reasons");
                return null;
            }
            finally
            {

            }

            return comboboxList;
        }

        public CheatMealReasonModel GetById(long id)
        {
            try
            {
                HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal-reason/" + id);

                APIResponseWrapper<CheatMealReasonModel> responseWrapper = new APIResponseWrapper<CheatMealReasonModel>();
                responseWrapper = APIHandler.HandleAPIResponse(response, responseWrapper, false);

                if (responseWrapper.Success == true)
                {
                    if (responseWrapper.SuccessReponse != null)
                    {
                        return responseWrapper.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching meal reason");
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
                FormsHandler.OperationFailedErrorMessage("Error while fetching meal reason");
                return null;
            }
            finally
            {

            }
        }
    }
}
