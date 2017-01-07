﻿using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.ItemVenda.Builder
{
    class ItemVendaBuilder : IItemVendaBuilder
    {
        public Guid Id { get; set; }
        public Guid? VendaId { get; set; }
        public VendaDomain Venda { get; set; }
        public Guid? ProdutoId { get; set; }
        public ProdutoDomain Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemVendaBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public ItemVendaBuilder WithProduto(ProdutoDomain Produto)
        {
            this.Produto = Produto;
            return this;
        }

        public ItemVendaBuilder WithProdutoId(Guid? ProdutoId)
        {
            this.ProdutoId = ProdutoId;
            return this;
        }

        public ItemVendaBuilder WithQuantidade(int Quantidade)
        {
            this.Quantidade = Quantidade;
            return this;
        }

        public ItemVendaBuilder WithVenda(VendaDomain Venda)
        {
            this.Venda = Venda;
            return this;
        }

        public ItemVendaBuilder WithVendaId(Guid? VendaId)
        {
            this.VendaId = VendaId;
            return this;
        }

        public ItemVendaDomain Build()
        {
            return new ItemVendaDomain (Id, VendaId, Venda, ProdutoId, Produto, Quantidade);
        }
    }
}
