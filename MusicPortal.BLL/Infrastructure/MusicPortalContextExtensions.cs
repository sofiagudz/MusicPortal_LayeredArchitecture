using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.EF;


namespace MusicPortal.BLL.Infrastructure
{
    public static class MusicPortalContextExtensions
    {
        public static void AddSoccerContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<MusicPortalContext>(options => options.UseSqlServer(connection));
        }
    }
}
