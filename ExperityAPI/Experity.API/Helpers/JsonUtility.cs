using Experity.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experity.API.Helpers
{
    public class JsonUtility
    {
        public JsonActionResult Success(object resultData = null, string message = "")
        {
            return new JsonActionResult
            {
                IsSuccess = true,
                DisplayMessage = message,
                Result = resultData
            };
        }

        public JsonActionResult Error(string errorMsg = "")
        {
            return new JsonActionResult
            {
                IsSuccess = false,
                ErrorMessages = new List<string> { errorMsg }
            };
        }

        public JsonActionResult Error(Exception ex, string message = "")
        {
            return new JsonActionResult
            {
                IsSuccess = false,
                DisplayMessage = message,
                ErrorMessages = new List<string> { ex.ToString() }
            };
        }
    }
}
