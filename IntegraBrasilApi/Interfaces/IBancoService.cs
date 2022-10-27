using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();

        Task<ResponseGenerico<BancoResponse>> BuscaBancos(string codigoBanco);
    }
}