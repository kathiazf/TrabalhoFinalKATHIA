using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Biblioteca.Infra;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for CreateEmprestimoDominioTeste
    /// </summary>
    [TestClass]
    public class CreateEmprestimoDominioTeste
    {
        public CreateEmprestimoDominioTeste()
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Id = 1;
            emprestimo.DataEmprestimo = DateTime.Now;
            emprestimo.DataDevolução = DateTime.Now;
          //  emprestimo.Livro.Titulo = "Aprendendoo Teste";
            emprestimo.Usuario = "Pedro da Silva";

            Assert.AreEqual("", string.Empty);

        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void EmprestimoCreatedInvalidTest()
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.LivroId = 1;
            emprestimo.Usuario = "123456";
            emprestimo.DataDevolução = DateTime.Now;
            emprestimo.DataDevolução = DateTime.Now;
            Validador.Validate(emprestimo);
        }

   
    }
}
