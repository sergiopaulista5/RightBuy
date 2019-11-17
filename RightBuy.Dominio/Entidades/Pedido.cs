﻿using RightBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace RightBuy.Dominio.Entidades
{
    public class Pedido : Entidade 
    {
        public int Id { get; set; }
        public DateTime DataPedido {get; set;}
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedidos
        /// </summary>

        public ICollection<ItemPedido> ItensPedido { get; set; }
        public object MensagemValidacao { get; private set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

           
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critica - Cep deve estar preenchido");

            if (FormaPagamentoId == 0 )
                AdicionarCritica("Critica - Não foi informado a forma de pagamento");
        }
               
            
        }
            
       
    }

