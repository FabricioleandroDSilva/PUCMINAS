using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.Agendamento.Core.Business.Models
{
   public  class Usuario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] 
        public string Login { get; set; }

        [Required] 
        public string Senha { get; set; }

        [Required]
        public TipoAcesso TipoAcesso { get; set; }

    }
    public enum TipoAcesso
    {
        Paciente = 1,
        Medico =2 
    }
}
