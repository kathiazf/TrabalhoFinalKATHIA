using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniplac.eAgenda.WindowsApp.Controls.UsuarioForms
{
    public partial class UsuarioControl : UserControl
    {
        private Biblioteca.Dominio.Repositorios.IUsuarioRepository _repository;

        public UsuarioControl()
        {
            InitializeComponent();
        }

        public UsuarioControl(Biblioteca.Dominio.Repositorios.IUsuarioRepository _repository)
        {
            // TODO: Complete member initialization
            this._repository = _repository;
        }

        internal void RefreshGrid()
        {
            throw new NotImplementedException();
        }

        internal Biblioteca.Dominio.Usuario GetUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
