using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace App4.Models
{
    public class Pessoa
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
		[Display(Name = "Nome completo")]
		public string NomePessoa { get; set; }

		[Required(ErrorMessage = "O Obs é obrigatório")]
		[Display(Name = "Observação")]
		public string Obs { get; set; }

		[Required(ErrorMessage = "O E-mail é obrigatório")]
		[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
		[EmailAddress(ErrorMessage ="O Email não é válido")]
		[Display(Name = "E-mail")]
		public string Email { get; set; }

		[Required(ErrorMessage = "O login é obrigatório")]
		[Display(Name = "Login")]
		public string? Login { get; set; }

		[Display(Name = "Senha")]
		[Required(ErrorMessage = "O Senha é obrigatório")]
		public string? Senha { get; set; }
		
		[Compare("Senha", ErrorMessage = "As senhas são diferentes")]
		public string? ConfirmaSenha { get; set; }


	}
}
