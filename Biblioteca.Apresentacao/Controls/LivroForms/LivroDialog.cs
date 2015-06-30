using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Biblioteca.Apresentacao.Controls.LivroForms
{
    public partial class LivroDialog : Form
    {
        private Livro _livro;
        private bool valido = true;

        public Livro Livro
        {
            get
            {
                return _livro;
            }
            set
            {
                _livro = value;
            }
        }

        public List<Autor> Autores { get; set; }

        public LivroDialog()
        {
            InitializeComponent();
        }

        private bool validarData(string data)
        {
            try
            {
                DateTime.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!validarData(txtAnoPublicacao.Text))
            {
                MessageBox.Show("Data de Publicação Inválida.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (cboAutor.SelectedValue == null)
            {
                MessageBox.Show("Selecione um Autor.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                valido = false;
            }

            if (valido)
            {
                try
                {
                    _livro.Titulo = txtTitulo.Text;
                    _livro.Editora = txtEditora.Text;
                    _livro.Edicao = txtEdicao.Text;
                    _livro.anoPublicacao = DateTime.Parse(txtAnoPublicacao.Text);
                    _livro.Autor = Autores.Find(a => a.Id == (int)cboAutor.SelectedValue);
                    _livro.Validate();
                }
                catch (Exception exc)
                {
                    Principal.Instance.ShowMessageInFooter(exc.Message);

                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void LivroDialog_Load(object sender, EventArgs e)
        {
            cboAutor.DataSource = Autores;
            cboAutor.DisplayMember = "Nome";
            cboAutor.ValueMember = "Id";
            cboAutor.SelectedIndex = -1;

            if(_livro.Id != 0)
            {
                txtNumero.Text = _livro.Id.ToString();
                txtTitulo.Text = _livro.Titulo;
                txtEditora.Text = _livro.Editora;
                txtEdicao.Text = _livro.Edicao;
                txtAnoPublicacao.Text = _livro.anoPublicacao.ToShortDateString();
                cboAutor.SelectedValue = _livro.Autor.Id;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
