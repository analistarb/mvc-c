using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Application.Dominio
{
    public class Login
    {
        [DisplayName("Nome do Login")]
        [Required(ErrorMessage = "Preencha o Login")]
        public string nm_login { get; set; }
    }
}
