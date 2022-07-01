using Goclinic.AgendaMedica.Core.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.AgendaMedica.Core.Business.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        public Usuario Autenticar(Usuario usuario);
    }
}
