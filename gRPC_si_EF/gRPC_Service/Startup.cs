using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace gRPC_Service
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ModelPostCommentContainer>(options => options.UseSqlServer(@"Data Source=BOGDANLAPTOP\\SQLEXPRESS;Initial Catalog=PostComment;Integrated Security=True"));
            services.AddScoped<IPostCommentRepository, PostCommentRepository>();
            services.AddGrpc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<PostCommentService>();
            });
        }
    }
}
