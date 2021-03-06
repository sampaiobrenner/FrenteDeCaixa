﻿using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;

namespace FrenteDeCaixa.Domain.Cliente
{
    public class ClienteDomain : ICliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        public string Tipo { get; set; }

        public ClienteDomain() { }

        public ClienteDomain(Guid id, string nome, DocumentoDeIdentificacaoDomain documentoDeIdentificacao, string tipo)
        {
            Id = id;
            Nome = nome;
            DocumentoDeIdentificacao = documentoDeIdentificacao;
            Tipo = tipo;
        }
    }
}
