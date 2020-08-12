using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(StatusCode);

        }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch 
            {
                400 => "You have made a bad Request",
                401 => "You are not allowed user",
                404 => "Resources Not Found",
                500 => "Error",
                _=> null
            };
        }
    }
}