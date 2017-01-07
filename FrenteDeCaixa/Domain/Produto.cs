﻿using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain
{
    public class Produto : IProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public ClienteDomain Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
