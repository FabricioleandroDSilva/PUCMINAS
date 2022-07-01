using Goclinic.Agendamento.Core.Business.Models;
using System.Collections.Generic;
using static Goclinic.Agendamento.Business.Interfaces.IRepository;

namespace Goclinic.Agendamento.Core.Business.Interfaces
{
   public interface IUsuarioRepository : IRepository<Usuario>
    {
         public Usuario Autenticar(Usuario usuario);
    }
}
