using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;

namespace hosting
{
    public  class MyMiddleware
    {
        private RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            
            //Request
            var star = DateTime.Now;
                        
            await this._next(context);
            
            //Response
            var finish = DateTime.Now;

            var diff = finish.Subtract(star);
            await context.Response.WriteAsync($"The time was {diff.Milliseconds}");

        }
    }
 
}