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
    public class BuscaCepService : IBuscaCepService
    {
        public BuscaCepService()
        {
        }

        public async Task<RetornoSearchCep> BuscaCep(string cep)
        {
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                Console.WriteLine(response);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    RetornoSearchCep retornoBuscaCep = JsonConvert.DeserializeObject<RetornoSearchCep>(responseBody);
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
