using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace eTicketsCustomMiddleware.UnhandledExceptions
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exeption)
            {
                await HandleExceptionAsync(context, exeption);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exeption)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            var result = string.Empty;

            switch (exeption)
            {
                case ValidationException validationException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException.Message);
                    break;
                case OperationCanceledException operationCanceledException:
                    statusCode = HttpStatusCode.InternalServerError;
                    result = JsonSerializer.Serialize(operationCanceledException.Message);
                    break;
                case SqlException sqlException:
                    statusCode = HttpStatusCode.InternalServerError;
                    result = JsonSerializer.Serialize(sqlException.Message);
                    break;
                case InvalidOperationException invalidOperationException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(invalidOperationException.Message);
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            if (result == string.Empty)
                result = JsonSerializer.Serialize(new { error = exeption.Message });

            return context.Response.WriteAsync(result);
        }
    }
}