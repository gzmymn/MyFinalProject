using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions //Extention metodu yazabilmek için o class'ın static olması gerekiyor
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules) //neyi genişletmek istiyorsak onu this ile veriyoruz
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection); //bizim core katmanı da dahil olmak üzere ekleyecğimiz bütün injection'ları bir araya getirebileceğimiz bir yapıya dönüştü
        }
    }
}
