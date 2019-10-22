using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public decimal Quantidade { get; set; }
        public int PedidoId { get; set; }
      


    }
}
