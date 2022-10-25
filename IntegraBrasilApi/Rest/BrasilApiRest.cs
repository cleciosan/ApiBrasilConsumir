using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
        public Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }
    }
}