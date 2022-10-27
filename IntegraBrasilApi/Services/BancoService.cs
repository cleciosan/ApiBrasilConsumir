using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        public Task<ResponseGenerico<BancoResponse>> BuscaBancos(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}