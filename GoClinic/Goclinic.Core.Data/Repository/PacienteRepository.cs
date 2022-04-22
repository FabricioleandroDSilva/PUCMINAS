using Goclinic.Agendamento.Business.Interfaces;
using Goclinic.Agendamento.Core.Data;
using Goclinic.Core.Business;
using Goclinic.Goclinic.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Goclinic.Agendamento.Data.Repository
{
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(Contexto context) : base(context) { }

        public bool AgendarPaciente(string cpf)
        {
            throw new System.NotImplementedException();
        }

        public List<Agenda> ListarAgendamento(string cpf)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Paciente> ObterPorIdComObjetos(int id)
        {
            return await (Db as Contexto).Pacientes.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
