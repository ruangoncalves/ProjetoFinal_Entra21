using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Domain
{
    public class Usuario : Pessoa
    {
        public Perfil Perfil { get; set; }

        public Usuario(Perfil perfil, string nome, DateTime dataNascimento, string email, long telefone) : 
            base(nome,dataNascimento,email,telefone)
        {
            Perfil = perfil;
        }

        private bool ValidarEmail()
        {
            return Regex.IsMatch(
                Email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase
            );

            // try
            // {
            //     MailAddress m = new MailAddress(Email);

            //     return true;
            // }
            // catch (FormatException)
            // {
            //     return false;
            // }
        }

        public (IList<string> errors, bool isValid) Validar()
        {
            var errors = new List<string>();
            if (!ValidarNome())
            {
                errors.Add("Nome inválido.");
            }

            if (!ValidarEmail())
            {
                errors.Add("Email inválido.");
            }

            return (errors, errors.Count == 0);
        }

    }    
}

