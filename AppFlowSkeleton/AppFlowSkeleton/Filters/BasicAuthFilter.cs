namespace AppFlowSkeleton.Filters
{
    using System;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class BasicAuthfilter : Attribute, IAsyncActionFilter
    {
        private const string appUsername = "shopska_salata";
        private const string appPassword = "s_luk";

        private const int basicLenght = 6;
        private const string headerName = "authorization";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var header = context.HttpContext.Request.Headers[headerName].ToString();

            if (string.IsNullOrWhiteSpace(header))
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }

            var usernameAndPassEncoded = header.Substring(basicLenght);
            var bytes = Convert.FromBase64String(usernameAndPassEncoded);

            var decodedUsernameAndPass = Encoding.UTF8.GetString(bytes);
            var parts =decodedUsernameAndPass.Split(':');

            var username =parts[0];
            var pass = parts[1];

            if(username != appUsername || pass != appPassword)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }

            await next();
            
       
            }
    }
}

