using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer
{
    public class Program
    {

        /// <summary>
        ///     função inicial
        ///     
        ///     padrão de retorno função main
        ///     1 -> erro    :: em caso de erro na execução
        ///     0 -> sucesso :: em caso de fim de processamento
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static int Main(string[] args)
        {
            // padrão build do design pattern
            IHost host = CreateHostBuilder(args)
                .Build();

            // espaço reservado para inicialização de serviços
            // exemplo seed e migration
            try { }
            catch (Exception error) { 
                Console.WriteLine(
                    String.Format(
                        "error in start services: {0}\n\n  {1}", error.Message, error.StackTrace.ToString()
                    )
                );
            }
            finally { 
                // configure o que devera ser feito em caso de erro
            }

            // espaço reservado para código ao inicializar o servidor
            try {
                host.Run();
            } 
            catch (Exception error) {
                Console.WriteLine(
                    String.Format(
                        "error in start server: {0}\n\n  {1}", error.Message, error.StackTrace.ToString()
                    )
                );
                return 1;
            }

            return 0;
        }

        // criação do build do projeto .net core
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }
        );
    }
}
