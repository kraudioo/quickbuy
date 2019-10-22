using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
       public int Id { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Nome  { get; set; }
        public String Sobrenome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
