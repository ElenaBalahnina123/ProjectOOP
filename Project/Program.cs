using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
                    .AddTransient<PositionEditorForm>()
                    .AddTransient<ListEmployee>()
                    .AddTransient<ListMaterial>()
                    .AddTransient<ColorListForm>()
                    .AddTransient<DirectorForm>()
                    .AddSingleton<HostHolder>()
                    .AddSingleton<AppDbContext>()
                ).Build();

            host.StartAsync();

            using(host)
            {
                var hostHolder = host.Services.GetRequiredService<HostHolder>();
                hostHolder.host = host;

                var loginForm = host.Services.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            }
        }
    }

    public class HostHolder : IDisposable
    {
        public IHost host;

        public void Dispose()
        {
            host = null;
        }
    }
}
