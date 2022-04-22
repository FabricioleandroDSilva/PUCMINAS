using Goclinic.Core.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.Goclinic.Business.Models
{
   public class Agenda
    {
        public int Id { get; set; }

        [ForeignKey("PacienteId")]
        public Paciente IdPaciente { get; set; }

        [ForeignKey("MedicoId")]
        public int IdMedico { get; set; }
        public DateTime? DataHoraAtendimento { get; set; }
        public int? IdPlano { get; set; }
        public string observacoes { get; set; }
        public DateTime DatainicialAtendimentoMedico { get; set; }
        public DateTime DatafinalAtendimentoMedico { get; set; }
        public string TempoAtendimento { get; set; }
        public string semanasAtendimento { get; set; }
        
    }
}
