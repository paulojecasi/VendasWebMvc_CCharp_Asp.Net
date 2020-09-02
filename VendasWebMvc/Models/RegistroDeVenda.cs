using System;
using System.Collections.Generic;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class RegistroDeVenda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double Quantidade { get; set; }
        public StatusDaVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVenda()
        {
        }

        public RegistroDeVenda(int id, DateTime dataVenda, double quantidade, StatusDaVenda status, Vendedor vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
