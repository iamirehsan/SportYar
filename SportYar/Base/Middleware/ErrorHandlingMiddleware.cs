using Azure;
using SportYar.Infrastructure.Base;
using System;
using System.Net;
using System.Text.Json;

namespace SportYar.Base.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                dynamic message;  
                switch (exception)
                {
                    case ManagedException ex:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        message = ex.ErrorMessage;
                    
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        message = exception.Message;
                        break;
                }
                // Log the exception
                Console.WriteLine($"An error occurred: {exception}");

                // Return an error response to the client
                var result = JsonSerializer.Serialize(new { message = message });
                await response.WriteAsync(result);
            }
        }
    }
}