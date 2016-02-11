using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace Application.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome do Aluno")]
        public string Nome { get; set; }
        
        [DisplayName("Mãe")]
        public string Mae { get; set; }
        
        [DisplayName("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataNascimento { get; set; }

        [DisplayName("Sexo")]
        public int ci_sexo { get; set; }
        public string dc_sexo { get; set; }

        [DisplayName("Raca")]
        public int? ci_raca { get; set; }
        public string dc_raca { get; set; }

        [DisplayName("Cadeirante?")]
        public bool ci_Cadeirante { get; set; }

        [DisplayName("Fala?")]
        public bool ci_Fala { get; set; }

        [DisplayName("Trabalha atualmente?")]
        public string p172 { get; set; }
        public string dc_p172 { get; set; }

        [DisplayName("Qual é a ultima ou atual ocupação?")]
        [StringLength(10)]
        public string p15 { get; set; }

        [DisplayName("Idade")]
        public int? nr_idade { get; set; }

        [DisplayName("Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O email informado não é valido")]
        public string nm_email { get; set; }

        [DisplayName("Dinheiro")]
        public decimal? nr_dinheiro { get; set; }

        [DisplayName("Observação")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A observação deve ter entre 5 e 50 caracteres")]
        public string dc_obs { get; set; }

        [DisplayName("CPF")]
        [Remote("ValidarCpf", "Home", AdditionalFields = "Id", ErrorMessage = "Este CPF não é valido")]
        public string nr_cpf { get; set; }

        [DisplayName("Usuario")]
        [Required(ErrorMessage = "O Login deve ser preenchido")]
        [Remote("LoginUnico", "Home", ErrorMessage = "Este nome de login já existe")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Login deve possuir somente letras e deve ter de 5 a 15 caracteres")]
        public string nm_usuario { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "A senha deve ser informada")]
        public string nm_senha { get; set; }

        [DisplayName("Confirmar Senha")]
        [System.ComponentModel.DataAnnotations.Compare("nm_senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}

