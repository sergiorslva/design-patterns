using Newtonsoft.Json;

namespace Adapter
{
    public class AdapterCEP : ITargetCEP
    {
        public async Task<CEPModel> GetDadosCEPAsync(string cep)
        {
            AdapteeCEP adaptee = new AdapteeCEP();
            var dadosCEP = await adaptee.GetDadosCEP(cep);            
            return JsonConvert.DeserializeObject<CEPModel>(dadosCEP);            
        }
    }
}