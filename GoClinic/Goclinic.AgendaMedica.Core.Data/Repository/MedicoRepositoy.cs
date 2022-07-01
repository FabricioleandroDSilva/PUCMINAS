using Goclinic.AgendaMedica.Core.Business.Interfaces;
using Goclinic.AgendaMedica.Core.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.AgendaMedica.Core.Data.Repository
{
    public class MedicoRepositoy : Repository<Medico>, IMedicoRepository
    {
        public MedicoRepositoy(Contexto context) : base(context) { }
    }
}
