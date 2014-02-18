using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;

namespace Onion.Demo.Root
{
    public static class ModuleManager
    {
        private static List<Assembly> Assemblies;
 
        //static ModuleManager()
        //{
        //    //Assemblies = new List<Assembly>();
        //    //Assemblies.Add(typeof(DomainServiciesModule).Assembly);
        //}

        public static void RegisterAssemblyModules1(this ContainerBuilder builder, string assemblyName)
        {
            builder.RegisterAssemblyModules(Ass);
        }
    }
}
