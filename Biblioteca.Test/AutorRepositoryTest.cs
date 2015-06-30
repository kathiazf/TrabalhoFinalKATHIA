using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using Infra.Data;
using System.Data.Entity;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for AutorRepositoryTest
    /// </summary>
    [TestClass]
    public class AutorRepositoryTest
    {
        private IAutorRepository _repository;
        private Autor _autor;


        [TestInitialize]
        public void Setup()
        {
            //Inicializa a base da dados, recriando-a
            Database.SetInitializer(new DropCreateDatabaseAlways<BibliotecaContext>());

            
            _autor = ObjectMother.GetAutor();

            //Criar registro inicial na base da dados
            BibliotecaContext context = new BibliotecaContext();
            _autor = context.Autores.Add(_autor);
            context.SaveChanges();

            //Inicializa os objetos utilizados no teste
            _repository = new AutorRepository();
        }

        [TestMethod]
        public void CreateAutorPersistenceTest()
        {
            //ACTION
            Autor autorPersisted = _repository.Save(_autor);

            //ASSERT
            Assert.IsTrue(autorPersisted.Id > 0);
        }

        [TestMethod]
        public void RetrieveAutorPersistedTest()
        {
            //ACTION
           Autor persistedAutor = _repository.Get(1);

            //ASSERT
            Assert.IsNull(persistedAutor);
            //Assert.AreEqual("Sabrina Bet", persistedAutor.Nome);
        }

        
        [TestMethod]
        public void UpdateAutorPersistedTest()
        {
            //ARRANGE
            Autor persistedAutor = _repository.Get(1);
            persistedAutor.Nome = "Sabrina Bet";


            //ACTION
            Autor updatedAutor = _repository.Update(persistedAutor);

            //ASSERT
            Autor autor = _repository.Get(1);
            Assert.AreEqual(autor.Nome, updatedAutor.Nome);

        }

        
        [TestMethod]
        public void DeleteAutorPersistedTest()
        {

            //ACTION
            Autor deletedAutor = _repository.Delete(1);

            //ASSERT
            Autor autor = _repository.Get(1);
            Assert.IsNull(autor);


        }

             

    }
}
