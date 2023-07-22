using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View;

namespace FitnessTracker.Controller
{
    internal class WorkoutTypeController
    {
        public long InsertWorkoutType(WorkoutTypeModel workoutType)
        {
            workoutType.Id = WorkoutTypeRepository.GetNextAvailableId();
            workoutType.Status = Enums.CommonStatusEnum.ACTIVE;

            return WorkoutTypeRepository.Save(workoutType).Id;
        }

        public List<ComboboxModel> ToComboboxList()
        {
            List<ComboboxModel>  comboboxList = new List<ComboboxModel>();

            try
            {
                HttpResponseMessage response = APIHandler
                    .DoGet("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout-type");

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
                HttpResponseMessage response = APIHandler
                    .DoGet("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout-type/"+id);

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
