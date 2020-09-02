using System;
using System.Collections.Generic;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double BaseSalarial { get; set; }
        public Departamento Departamento  { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double baseSalarial, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        public void AddVendas(RegistroDeVenda sr)
        {
            Vendas.Add(sr);
        }
        public void RemVendas(RegistroDeVenda sr)
        {
            Vendas.Remove(sr);
        }

    }
}
