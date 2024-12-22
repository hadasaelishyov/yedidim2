using Yedidim.Api.Middlewares;

namespace Yedidim.Api.Models
{
    public static  class TrackMiddlewareExtensions
    {
        public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TrackMiddleware>();
        }
    }
}
