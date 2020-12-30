using System;
using System.Collections.Generic;
using Aplicacao.Core.Models;
using Aplicacao.Business.Interfaces;

namespace Aplicacao.Business.Services
{
    public class EnderecoService : IEnderecoService
    {
        private IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository) => _repository = repository;

        public Endereco GetEnderecoByCep(string CEP)
        {
            Endereco endereco = _repository.FindByCEP(CEP);
            return endereco;
        }
    }
}