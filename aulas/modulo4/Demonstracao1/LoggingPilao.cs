using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

public class LoggingPilaoMiddleware
    {
        private readonly string _caminho;
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;

        public LoggingPilaoMiddleware(RequestDelegate next,IConfiguration configuration,IHostingEnvironment environment)
        {
            _next = next;
            this._configuration = configuration;
            _environment = environment;
            _caminho = Path.Combine(_environment.ContentRootPath, "arquivo.txt");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await LogAsync(httpContext);
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                //await LogAsync(httpContext, ex);
            }
        }

        private async Task LogAsync(HttpContext context)
        {
            var mensagem = string.Empty;
            mensagem += context.Request.Path + "pips";
            File.AppendAllLines(_caminho, new string[]{mensagem});
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoggingPilaoMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingPilaoMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingPilaoMiddleware>();
        }
    }