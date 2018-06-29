using System;
using System.Linq;
using boot;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IUnityContainer container = new UnityContainer()
                .LoadConfiguration();

            var startups = container.ResolveAll<IMyStartup>();

            foreach (var startup in startups)
            {
                startup.InitializeContainer(container);
            }


            var boom = container.Resolve<IMyInterface>();
            
            Console.WriteLine("Hello World!");
        }
    }
}
