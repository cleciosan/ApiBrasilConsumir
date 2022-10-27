using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;

        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
        public Task<ResponseGenerico<BancoResponse>> BuscaBancos(string codigoBanco)
        {
            throw new NotImplementedException();
        }
    }
}