using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidingSources.Models
{
    public class PessoaRepository
    {
        private readonly List<Pessoa> pessoa;
        public PessoaRepository()
        {
            pessoa = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Davi",
                    Sobrenome = " Abreu dos Reis",
                    Email = "davi.areis1@senacsp.edu.br",
                    Telefone = "(11) 95829-9492",
                    DataNascimento = new DateTime(1979, 7, 24),
                },
                new Pessoa()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Pedro",
                    Sobrenome = "de Oliveira Boa Sorte",
                    Email = "pedro.obsorte@senacsp.edu.br",
                    Telefone = "(11) 96189-1620",
                    DataNascimento = new DateTime(1979, 7, 24),
                }, 
                new Pessoa()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Gustavo",
                    Sobrenome = "Oliveira Pereira",
                    Email = "gustavo.opereira4@senacsp.edu.br",
                    Telefone = "(11) 95929-0830",
                    DataNascimento = new DateTime(1979, 7, 24),
                },
                new Pessoa()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Giovane",
                    Sobrenome = " Facundes Feitosa",
                    Email = "gustavo.opereira4@senacsp.edu.br",
                    Telefone = "(11) 99255-3895",
                    DataNascimento = new DateTime(1979, 7, 24),
                }
            };
        }
        public List<Pessoa> GetAll()
        {
            return pessoa.Select(p => new Pessoa()
            {
                Id = p.Id,
                Nome = p.Nome,
                Sobrenome =  p.Sobrenome,
                DataNascimento = p.DataNascimento,
                Email = p.Email,
                Telefone = p.Telefone,
            }).ToList();
        }
    }
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
