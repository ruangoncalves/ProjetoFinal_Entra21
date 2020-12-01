using System;
using System.Linq;

namespace Domain
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public void Registrar(string nome, DateTime dataNascimento, string email, int telefone)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Telefone = telefone;
        }

        protected bool ValidarNome()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }

            var words = Nome.Split(' ');
            if (words.Length < 2)
            {
                return false;
            }

            foreach (var word in words)
            {
                if (word.Trim().Length < 2)
                {
                    return false;
                }
                if (word.Any(x => !char.IsLetter(x)))
                {
                    return false;
                }
            }

            return true;
        }

        
        
    }    
}

