using Biblioteca.Apresentacao;
using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniplac.eAgenda.WindowsApp.Controls.UsuarioForms
{
    public partial class UsuarioDialog : Form
    {
        private Usuario _usuario;

        
        public Usuario Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }
              


        public UsuarioDialog()
        {
            InitializeComponent();
        }

        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _usuario.Nome = txtUsuNome.Text;
                _usuario.Matricula = txtMatricula.Text;
                _usuario.Validate();
            }
            catch (Exception exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }
        }
            
             private void UsuarioDialog_Load(object sender, EventArgs e)
             {    
            if(_usuario != null)
            {
                txtUsuNumero.Text = _usuario.Id.ToString();
                txtUsuNome.Text = _usuario.Nome;
                txtMatricula.Text = _usuario.Matricula;
            }
            }
             
        }
         
    }



