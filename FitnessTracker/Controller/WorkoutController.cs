using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using FitnessTracker.View;

namespace FitnessTracker.Controller
{
    internal class WorkoutController
    {
        public APIResponseWrapper<WorkoutModel> LogWorkout(WorkoutModel workout)
        {
            HttpResponseMessage response = APIHandler
                .DoPost("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout/users/"+workout.User.Id, ref workout);

            APIResponseWrapper<WorkoutModel> responseWrapper = new APIResponseWrapper<WorkoutModel>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public APIResponseWrapper<List<WorkoutModel>> Search(WorkoutModel workoutSearch, int page, int size)
        {
            var queryParams = new Dictionary<string, string>
            {
                ["type"] = workoutSearch.Type == null ? "" : workoutSearch.Type.Name,
                ["page"] = page.ToString(),
                ["size"] = size.ToString(),
            };

            HttpResponseMessage response = APIHandler
                .DoGet("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout/users/"+workoutSearch.User.Id+"/search", queryParams);

            APIResponseWrapper<List<WorkoutModel>> responseWrapper = new APIResponseWrapper<List<WorkoutModel>>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public APIResponseWrapper<Object> RemoveWorkout(long workoutId, long userId)
        {
            HttpResponseMessage response = APIHandler
                .DoDelete("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout/users/"+userId+"/workouts/"+workoutId);

            APIResponseWrapper<Object> responseWrapper = new APIResponseWrapper<Object>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, true);
        }

        public APIResponseWrapper<WorkoutModel> GetWorkoutById(long workoutId, long userId)
        {
            HttpResponseMessage response = APIHandler
                .DoGet("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout/users/"+userId+"/workouts/"+workoutId);

            APIResponseWrapper<WorkoutModel> responseWrapper = new APIResponseWrapper<WorkoutModel>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public WorkoutModel UpdateWorkout(WorkoutModel workout)
        {
            WorkoutModel workoutModel = WorkoutRepository.GetById(workout.Id, workout.Id);

            if (workoutModel == null)
            {
                FormsHandler.OperationFailedErrorMessage("Workout id invalid.");
            }

            workoutModel.Date = workout.Date;
            workoutModel.Name = workout.Name;
            workoutModel.Type = workout.Type;
            workoutModel.Reps = workout.Reps;
            workoutModel.Sets = workout.Sets;
            workoutModel.Comment = workout.Comment;
            workoutModel.StartTime = workout.StartTime;
            workoutModel.EndTime = workout.EndTime; 
            workoutModel.IsRecurring = workout.IsRecurring; 
            workoutModel.RecurringType = workout.RecurringType;
            workoutModel.RecurrsionDate = workout.RecurrsionDate;
            workoutModel.Weight = workout.Weight;

            return workoutModel;
        }

        public APIResponseWrapper<List<WorkoutModel>> GetAllByUser(long userId)
        {
            HttpResponseMessage response = APIHandler
                .DoGet("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/workout/users/1"+userId);

            APIResponseWrapper<List<WorkoutModel>> responseWrapper = new APIResponseWrapper<List<WorkoutModel>>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }
    }
}
