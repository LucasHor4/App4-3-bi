using System.ComponentModel.DataAnnotations;

namespace App4.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é obrigatório!")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        [Display(Name = "Nome do produto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O E-mail do fornecedor é obrigatório!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        [EmailAddress(ErrorMessage = "O Email não é válido")]
        [Display(Name = "E-mail do Fornecedor")]
        public string FornecedorEmail { get; set; }

        [Required(ErrorMessage = "A quantidade do(e) produto(s) é obrigatório(a)!")]
        [Display(Name = "Quantidade")]
        public int Qtd { get; set; }


    }
}
