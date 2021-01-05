using System;
using Xunit;
using Domain;

namespace Testes
{
    public class UsuarioTeste
    {
        [Theory]
        [InlineData(Perfil.Fornecedor,"Alberto Dantas","alberto@gmail.com")]
        [InlineData(Perfil.Consumidor,"Alberto Silva","alberto.silva@bol.com.br")]
        public void DeveCadastrarUsuario(Perfil perfil,string nome, string email)
        {
            DateTime data1 = new DateTime(1991,2,25);
            var usu = new Usuario(perfil, nome, data1, email, 47991919895);

            var usuarioValido = usu.Validar().isValid;

            Assert.True(usuarioValido);           
        }

        [Theory]
        [InlineData(Perfil.Fornecedor,"Alberto","alberto@gmail.com")]
        [InlineData(Perfil.Consumidor,"Alberto Silva","alberto.silva@")]
        [InlineData(Perfil.Fornecedor,"Alberto Silva","alberto.silva@com")]
        [InlineData(Perfil.Consumidor,"Alberto Silva","alberto.silva.com")]
        public void NaoDeveCadastrarUsuario(Perfil perfil,string nome, string email)
        {
            DateTime data1 = new DateTime(1991,2,25);
            var usu = new Usuario(perfil, nome, data1, email, 47991919895);

            var usuarioValido = usu.Validar().isValid;

            Assert.False(usuarioValido);           
        }




    }
}
