using Microsoft.Extensions.DependencyInjection;
using ProjectPilot.Applicantion.Service;
using ProjectPilot.Applicantion.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPilot.Applicantion.Di
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IBuscaCepService, BuscaCepService>();

            services.AddScoped<IConsultaCpfService, ConsultaCpfService>();


        }
    }
}
