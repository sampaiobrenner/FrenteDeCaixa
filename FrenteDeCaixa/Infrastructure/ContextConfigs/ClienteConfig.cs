﻿using FrenteDeCaixa.Model;
using FrenteDeCaixa.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.ClienteDB);

            Property(x => x.Nome).IsRequired();
            Property(x => x.CpfCnpj).IsRequired();
            Property(x => x.Tipo).IsRequired();
        }
    }
}
