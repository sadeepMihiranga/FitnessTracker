using FitnessTracker.DTOs;
using FitnessTracker.Model;
using System.Configuration;

namespace FitnessTracker.Controller
{
    internal class CheatMealController
    {
        private string _BaseURL = "";

        public CheatMealController()
        {
            _BaseURL = ConfigurationManager.AppSettings.Get("BaseURL");
        }

        public APIResponseWrapper<CheatMealModel> LogCheatMeal(CheatMealModel cheatMeal)
        {
            HttpResponseMessage response = APIHandler.DoPost(_BaseURL + "/cheat-meal/users/" + cheatMeal.User.Id, ref cheatMeal);

            APIResponseWrapper<CheatMealModel> responseWrapper = new APIResponseWrapper<CheatMealModel>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public APIResponseWrapper<Object> RemoveCheatMeal(long cheatMealId, long userId)
        {
            HttpResponseMessage response = APIHandler.DoDelete(_BaseURL + "/cheat-meal/users/" + userId + "/cheat-meals/" + cheatMealId);

            APIResponseWrapper<Object> responseWrapper = new APIResponseWrapper<Object>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, true);
        }

        public APIResponseWrapper<CheatMealModel> GetCheatMealById(long cheatMealId, long userId)
        {
            HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal/users/" + userId + "/cheat-meals/" + cheatMealId);

            APIResponseWrapper<CheatMealModel> responseWrapper = new APIResponseWrapper<CheatMealModel>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public APIResponseWrapper<List<CheatMealModel>> Search(CheatMealModel cheatMealSearch, int page, int size)
        {
            var queryParams = new Dictionary<string, string>
            {
                ["type"] = cheatMealSearch.MealType == null ? "" : cheatMealSearch.MealType.Name,
                ["page"] = page.ToString(),
                ["size"] = size.ToString(),
            };

            HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal/users/" + cheatMealSearch.User.Id + "/search", queryParams);

            APIResponseWrapper<List<CheatMealModel>> responseWrapper = new APIResponseWrapper<List<CheatMealModel>>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public APIResponseWrapper<List<CheatMealModel>> SearchForReport(long userId, DateTime from, DateTime to)
        {
            var queryParams = new Dictionary<string, string>
            {
                ["fromDate"] = from.ToString("yyyy-MM-dd"),
                ["toDate"] = to.ToString("yyyy-MM-dd"),
            };

            HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal/users/" + userId + "/report", queryParams);

            APIResponseWrapper<List<CheatMealModel>> responseWrapper = new APIResponseWrapper<List<CheatMealModel>>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        public APIResponseWrapper<List<CheatMealModel>> GetAllByUser(long userId)
        {
            HttpResponseMessage response = APIHandler.DoGet(_BaseURL + "/cheat-meal/users/" + userId);

            APIResponseWrapper<List<CheatMealModel>> responseWrapper = new APIResponseWrapper<List<CheatMealModel>>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }
    }
}
