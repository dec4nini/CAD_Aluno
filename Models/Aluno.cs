using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CAD_Aluno.Models
{
    public class Aluno
    {
        [Key]
        [Display(Name = "ID: ")]
        public int Id { get; set; }
        [Display(Name = "Nome: ")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public String Nome { get; set; }
        [Display(Name = "Endereço: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Endereco { get; set; }
        [Display(Name = "Filiação: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Filiacao { get; set; }
        [Display(Name = "Curso: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Curso { get; set; }
        [Display(Name = "Telefone: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Telefone { get; set; }
        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Email { get; set; }


    }
}