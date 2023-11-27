using System.ComponentModel.DataAnnotations;

namespace MtecDevs.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nome", Prompt = "Informe seu Nome")]
        [Required(ErrorMessage = "Por favor, informe seu nome")]
        public string Nome { get; set; }

        [Display(Name = "Email", Prompt = "Informe seu Email")]
        [Required(ErrorMessage = "Por favor, informe seu email")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email { get; set; }

        [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha de Acesso")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação de senha não coincidem")]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }

        [Display(Name = "Manter Conectado?")]
        public bool Lembrar { get; set; } = false;

        public string UrlRetorno { get; set; }
    }
}