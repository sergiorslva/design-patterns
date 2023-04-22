namespace Adapter
{
    public interface ITargetCEP
    {
        Task<CEPModel> GetDadosCEPAsync(string cep);
    }
}
