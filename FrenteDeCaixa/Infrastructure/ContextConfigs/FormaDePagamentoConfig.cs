﻿using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class FormaDePagamentoConfig : EntityTypeConfiguration<FormaDePagamentoDomain>
    {
        public FormaDePagamentoConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.FormaDePagamentoDB);

            Property(x => x.Nome).IsRequired();
        }
    }
}
