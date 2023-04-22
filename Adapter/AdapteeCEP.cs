namespace Adapter
{
    public class AdapteeCEP
    {
        public async Task<string> GetDadosCEP(string cep)
        {
            using (var http = new HttpClient())
            {
                string response = await http.GetStringAsync($"https://viacep.com.br/ws/{cep}/json");
                return response;
            }
        }
    }
}
