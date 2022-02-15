using AppFlowSkeleton.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace AppFlowSkeleton.ApplicationExtensions
{
    public static class ApplicationExtensions
    {
        public static IApplicationBuilder UseEvenMinutechecker(
             this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<EvenMinuteCheckerMiddleware>();
        }
    }
}
