using ProjectPilot.Applicantion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPilot.Applicantion.ServiceInterfaces
{
    public interface IBuscaCepService
    {
        Task<RetornoSearchCep> BuscaCep(string cep);
    }
}
