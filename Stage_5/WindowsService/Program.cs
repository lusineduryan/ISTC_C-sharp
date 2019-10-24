using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(serviceConfig =>
                              {
                                  serviceConfig.Service<ConverterService>(serviceInstance =>
                                                                            {
                                                                                serviceInstance.ConstructUsing(() => new ConverterService());
                                                                                serviceInstance.WhenStarted(execute => execute.Start());
                                                                                serviceInstance.WhenStarted(execute => execute.Stop());
                                                                            });
                                  serviceConfig.SetServiceName("AwesomeFileConverter");
                                  serviceConfig.SetDisplayName("Awesome File Converter");

                                  serviceConfig.StartAutomatically();
                              });   
        }
    }
}
