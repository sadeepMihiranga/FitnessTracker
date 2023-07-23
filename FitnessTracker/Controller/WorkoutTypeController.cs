using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.View;
using System.Configuration;

namespace FitnessTracker.Controller
{
    internal class WorkoutTypeController
    {
        private string _BaseURL = "";

        public WorkoutTypeController()
        {
            _BaseURL = ConfigurationManager.AppSettings.Get("BaseURL");
        }

        public List<ComboboxModel> ToComboboxList()
        {
            List<ComboboxModel>  comboboxList = new List<ComboboxModel>();

            try
            {
                HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/workout-type");

                APIResponseWrapper<List<WorkoutTypeModel>> responseWrapper = new APIResponseWrapper<List<WorkoutTypeModel>>();
                responseWrapper = APIHandler.HandleAPIResponse(response, responseWrapper, false);

                if (responseWrapper.Success == true)
                {
                    if (responseWrapper.SuccessReponse != null)
                    {
                        comboboxList = responseWrapper.SuccessReponse.Select(i => new ComboboxModel(Int32.Parse(i.Id.ToString()), i.Name)).ToList();
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching workout types");
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
                FormsHandler.OperationFailedErrorMessage("Error while fetching workout types");
                return null;
            }
            finally
            {

            }

            return comboboxList;
        }

        public WorkoutTypeModel GetById(long id)
        {
            try
            {
                HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/workout-type/" + id);

                APIResponseWrapper<WorkoutTypeModel> responseWrapper = new APIResponseWrapper<WorkoutTypeModel>();
                responseWrapper = APIHandler.HandleAPIResponse(response, responseWrapper, false);

                if (responseWrapper.Success == true)
                {
                    if (responseWrapper.SuccessReponse != null)
                    {
                        return responseWrapper.SuccessReponse;
                    }
                    else
                    {
                        FormsHandler.OperationFailedErrorMessage("Error while fetching workout type");
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
                FormsHandler.OperationFailedErrorMessage("Error while fetching workout type");
                return null;
            }
            finally
            {

            }
        }
    }
}
