using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlerMiddleware> logger;

        public ExceptionHandlerMiddleware(RequestDelegate next , ILogger<ExceptionHandlerMiddleware> Logger)
        {
            this.next = next;
            logger = Logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next.Invoke(context);

            }
            catch (Exception ex)
            {
                //Hata Yonetimi
                logger.LogError(ex.Message);
            }
        }
    }
}
