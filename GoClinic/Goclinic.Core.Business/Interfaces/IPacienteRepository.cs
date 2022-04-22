using Goclinic.Core.Business;
using Goclinic.Goclinic.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Goclinic.Agendamento.Business.Interfaces.IRepository;

namespace Goclinic.Agendamento.Business.Interfaces
{
   public  interface IPacienteRepository: IRepository<Paciente>
    {
        public bool AgendarPaciente(string cpf);
        public List<Agenda> ListarAgendamento(string cpf);
        

    }
}
