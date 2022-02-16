using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation_Tier_SEP3.Authentication;
using Presentation_Tier_SEP3.Data.GroupData;
using Presentation_Tier_SEP3.Data.GroupMembersData;
using Presentation_Tier_SEP3.Data.InvitationData;
using Presentation_Tier_SEP3.Data.NoteData;
using Presentation_Tier_SEP3.Data.Notifications;
using Presentation_Tier_SEP3.Data.Refresh;
using Presentation_Tier_SEP3.Data.UserData;


namespace Presentation_Tier_SEP3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInvitationService, InvitationService>();
            services.AddScoped<IGroupMembersService, GroupMembersService>();
            services.AddScoped<IRefreshServiceInvGroup, RefreshServiceInvGroup>();
            services.AddScoped<IRefreshServiceNavMem, RefreshServiceNavMem>();
            services.AddSingleton<NotificationManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}