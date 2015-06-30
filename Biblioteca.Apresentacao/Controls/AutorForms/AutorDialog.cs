using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Biblioteca.Apresentacao.Controls.AutorForms
{
    public partial class AutorDialog : Form
    {
        private Autor _autor;

        public Autor Autor
        {
            get
            {
                return _autor;
            }
            set
            {
                _autor = value;
            }
        }

        public AutorDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _autor.Nome = txtNome.Text;
                _autor.CodigoCutter = txtCutter.Text;
                _autor.Validate();
            }
            catch (Exception exc)
            {
                Principal.Instance.ShowMessageInFooter(exc.Message);

                DialogResult = DialogResult.None;
            }
        }

        private void AutorDialog_Load(object sender, EventArgs e)
        {
            if(_autor != null)
            {
                txtNumero.Text = _autor.Id.ToString();
                txtNome.Text = _autor.Nome;
                txtCutter.Text = _autor.CodigoCutter;
            }
        }

        
    }
}
