using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goclinic.Core.Business
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "O campo {0} é obrigatório")]
        public string Cpf { get; set; }


        [Required]
        [StringLength(1, ErrorMessage = "O campo {0} é obrigatório")]
        public string Sexo { get; set; }

        [Required]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} é obrigatório")]
        public string Endereco { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "O campo {0} é obrigatório")]
        public string Numero { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "O campo {0} é obrigatório")]
        public string Cep { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "O campo {0} é obrigatório")]
        public string Celular { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "O campo {0} é obrigatório")]
        public string Cidade { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "O campo {0} é obrigatório")]
        public string Estado { get; set; }

        

    }
}
