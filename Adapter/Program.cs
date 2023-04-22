// See https://aka.ms/new-console-template for more information
using Adapter;

string cep = "01001000";

ITargetCEP target = new AdapterCEP();
CEPModel cepModel = await target.GetDadosCEPAsync(cep);

Console.ReadKey();