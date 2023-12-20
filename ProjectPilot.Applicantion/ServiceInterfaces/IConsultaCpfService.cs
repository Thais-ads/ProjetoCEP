using ProjectPilot.Applicantion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPilot.Applicantion.ServiceInterfaces
{
    public interface IConsultaCpfService
    {
        Task<RetornoCpf> Validacpf(string cep);
    }
}
