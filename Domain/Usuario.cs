using System;
using System.Linq;

namespace Domain
{
    public class Usuario : Pessoa
    {
        public Perfil Perfil { get; set; }

        public Usuario(Perfil perfil, string nome, DateTime dataNascimento, string email, int telefone) : 
            base(nome,dataNascimento,email,telefone)
        {
            Perfil = perfil;
        }

        
        
    }    
}

