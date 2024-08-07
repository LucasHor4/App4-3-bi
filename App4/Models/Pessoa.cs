using System.ComponentModel.DataAnnotations;

namespace App4.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomePessoa { get; set; }

        public string? Obs { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }



    }
}
