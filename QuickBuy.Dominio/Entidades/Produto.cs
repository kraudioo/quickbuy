using System;
namespace QuickBuy.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
