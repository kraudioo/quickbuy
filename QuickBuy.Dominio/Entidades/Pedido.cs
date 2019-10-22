using System;
using System.Collections.Generic;
using QuickBuy.Dominio.ObjetoDeValor;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido 
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
       // public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public String Cep { get; set; }
        public String Estado { get; set; }
        public String Cidade { get; set; }
        public String EnderecoCompleto { get; set; }
        public String NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
       public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection <ItemPedido> ItensPedidos{ get; set; }

        //public override void Validate()
        //{
        //    LimparMensagensValidacao();
        //    if (!ItensPedidos.Any())
        //    {
        //        MensagemValidacao.Add("Item de Pedido está Vazio");
        //    }
        //    throw new NotImplementedException();
        //}
    }
}
