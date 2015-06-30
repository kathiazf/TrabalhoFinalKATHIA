using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Biblioteca.Infra;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for CreateAutorDominioTest
    /// </summary>
    [TestClass]
    public class CreateAutorDominioTeste
    {
        public CreateAutorDominioTeste()
        { 
        
           Autor autor = new Autor();
           autor.Id = 1;
           autor.Nome = "Roberto T. Kiyosaki";
           autor.CodigoCutter = "A848";

           Assert.AreEqual("", string.Empty);

        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void AutorNameInvalidTest()
        {
            Autor autor = new Autor();
            Validador.Validate(autor);
        }


        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void AutorCreatedInvalidTest()
        {
            Autor autor = new Autor();
            autor.Nome = "";
            Validador.Validate(autor);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void AutorCreatedInvalidCodigoCutterTest()
        {
            Autor autor = new Autor();
            autor.CodigoCutter = "";
            Validador.Validate(autor);
        
        }


        [TestMethod]
        public void CreateAutorTest()
        {
            Autor autor = new Autor();
            autor.Id = 1;
            autor.Nome = "Roberto T. Kiyosaki";
            autor.CodigoCutter = "A848";
          
        }

          


        public IObjectValidation autor { get; set; }

        public IObjectValidation Nome { get; set; }
    }
}
