using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectOop.Entities;

namespace Project
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<LoginForm>()
                    .AddTransient<ProductionForm>()
                    .AddTransient<ListEmployee>()
                    .AddTransient<ListMaterial>()
                    .AddTransient<ColorListForm>()
                    .AddTransient<DirectorForm>()
                    .AddSingleton<AppDbContext>()
                    .AddSingleton<ProgramContext>()
                    .AddTransient<DesignerForm>()
                ).Build();

            host.StartAsync();

            //var context = new ProgramContext(host);

            var context = host.Services.GetRequiredService<ProgramContext>();
            context.SetHost(host);
            Application.Run(context);

            context.OnStart();

            /*using(host)
            {
                var programState = host.Services.GetRequiredService<ProgramState>();
                programState.SetHost(host);
                programState.OnStart();
            }*/
        }
    }

    
}
