using Newtonsoft.Json;
using ProjectPilot.Applicantion.Dto;
using ProjectPilot.Applicantion.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPilot.Applicantion.Service
{
    public class ConsultaCpfService : IConsultaCpfService
    {
        public ConsultaCpfService()
        {
        }

        public async Task<RetornoCpf> Validacpf(string cpf)

        {

            string token = "5677|uIGALAaBGM9TuWBqE0RQubvdzpJcbBHc";



            string apiUrl = $"https://api.invertexto.com/v1/validator?token={token}&value={cpf}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                Console.WriteLine(response);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    RetornoCpf retornoBuscaCep = JsonConvert.DeserializeObject<RetornoCpf>(responseBody);
                    return retornoBuscaCep;
                }
                else
                {
                    
                    Console.WriteLine($"Erro na requisição. Código de status: {response.StatusCode}");
                    return null;
                }
            }
        }



    }
}
