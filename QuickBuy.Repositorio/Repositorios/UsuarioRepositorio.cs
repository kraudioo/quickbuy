using System;
using System.Linq;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyContexto quickyBuyContexto) : base(quickyBuyContexto)
        {
        }

        public Usuario Obter (string email, string senha)
        {

            return QuickBuyContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            throw new NotImplementedException();
        }
    }
}
