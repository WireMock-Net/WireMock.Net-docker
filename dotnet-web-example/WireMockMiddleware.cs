using System;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace dotnet_web_example
{
    internal class WireMockMiddleware
    {
        private static readonly Task CompletedTask = Task.FromResult(false);

        public WireMockMiddleware(RequestDelegate next) {
            
        }

        public Task Invoke(HttpContext ctx)
        {
            ctx.Response.WriteAsync("Hello !");

            return CompletedTask;
        }
    }
}