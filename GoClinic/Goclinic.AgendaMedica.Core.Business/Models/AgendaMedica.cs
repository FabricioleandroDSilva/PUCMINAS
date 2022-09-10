using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.AgendaMedica.Core.Business.Models
{
    public class AgendaMedicas
    {
        public virtual  int MedicoId { get; set; }

        public virtual ICollection<Agenda> Agendas {get;set;}
    }
}
