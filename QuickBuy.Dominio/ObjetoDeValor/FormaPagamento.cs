using System;
using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }

        public bool isBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }



        public bool isCartaroCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool isDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool isNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

     


    }
}
