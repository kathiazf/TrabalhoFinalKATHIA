using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using Infra.Data;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for UsuarioRepositoryTest
    /// </summary>
    [TestClass]
    public class UsuarioRepositoryTest
    {
        private IUsuarioRepository _repository;
        private UsuarioRepository _usuario;

        [TestInitialize]
        public void Setup()
        {
            //Inicializa a base da dados, recriando-a
            Database.SetInitializer(new DropCreateDatabaseAlways<BibliotecaContext>());

            //Inicializa os objetos utilizados no teste
            _repository = new UsuarioRepository(new BibliotecaContext());
         //   _usuario = ObjectMother.GetUsuario;

            //Criar registro inicial na base da dados
            BibliotecaContext context = new BibliotecaContext();
        //    _usuario = context.Usuarios.Add(_usuario);
            context.SaveChanges();
        }


        [TestMethod]
        public void CreateUsuarioPersistenceTest()
        {
            //ACTION
            //Autor usuarioPersisted = _repository.Save(_usuario);
 

            //ASSERT
       //     Assert.IsTrue(usuarioPersisted.Id > 0);
        }
    }

}
