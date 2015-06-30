﻿using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
   public interface ILivroService
    {
        void CreateLivro(Livro livro);
        void EditLivro(Livro livro);
        void DeleteLivro(int Id);
    }
}
