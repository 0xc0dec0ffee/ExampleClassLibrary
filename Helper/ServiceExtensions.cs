using ExampleClassLibrary.Chapter2;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Helper
{
    public static class ServiceExtensions
    {
        public static void AddTaxEngine(this IServiceCollection services)
        {
            services.AddSingleton<TaxEngine>();
        }
    }
}
