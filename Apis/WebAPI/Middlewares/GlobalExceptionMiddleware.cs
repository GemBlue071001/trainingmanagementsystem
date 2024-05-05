using Newtonsoft.Json;
using System.Net;
using WebAPI.Commons;

namespace WebAPI.Middlewares
{
    public class GlobalExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                //push notification & writing log
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                ApiResponse apiResponse = new ApiResponse().SetApiResponse(
                    statusCode: HttpStatusCode.InternalServerError,
                    isSuccess: false,
                    message: ex.Message
                    );
                await context.Response.WriteAsync(JsonConvert.SerializeObject(apiResponse));
            }
        }
    }
}
