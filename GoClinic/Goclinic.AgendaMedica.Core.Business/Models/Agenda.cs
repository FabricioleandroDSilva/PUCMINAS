using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.AgendaMedica.Core.Business.Models
{
   public class Agenda
    {
            
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime DataInicialAtendimento { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime DataFinalAtendimento { get; set; }

            [Required]
            public string DiasSemanaAtendimento { get; set; }

            [Required]
            [DataType(DataType.Time)]
            public string HorarioInicialAtendimento { get; set; }
            [Required]
            [DataType(DataType.Time)]
            public string HorarioFinalAtendimento { get; set; }

            [Required]
            [DataType(DataType.Time)]
            public string TempoAgendamento { get; set; }
            
            public int MedicoResponsavelId { get; set; }

    }
}
