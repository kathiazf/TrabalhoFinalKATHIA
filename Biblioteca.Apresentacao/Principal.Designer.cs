namespace Biblioteca.Apresentacao
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.caToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.description = new System.Windows.Forms.ToolStripLabel();
            this.tituloLabel = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panControl = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuárioCtrlFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // caToolStripMenuItem
            // 
            this.caToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosMenuItem,
            this.contatosToolStripMenuItem,
            this.usuárioCtrlFToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.caToolStripMenuItem.Name = "caToolStripMenuItem";
            this.caToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.caToolStripMenuItem.Text = "Cadastros";
            // 
            // livrosMenuItem
            // 
            this.livrosMenuItem.Name = "livrosMenuItem";
            this.livrosMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.livrosMenuItem.Size = new System.Drawing.Size(157, 22);
            this.livrosMenuItem.Text = "Livros";
            this.livrosMenuItem.Click += new System.EventHandler(this.tarefasMenuItem_Click);
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.contatosToolStripMenuItem.Text = "Autores";
            this.contatosToolStripMenuItem.Click += new System.EventHandler(this.contatosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolbar
            // 
            this.toolbar.Enabled = false;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.description,
            this.tituloLabel});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(695, 31);
            this.toolbar.TabIndex = 9;
            this.toolbar.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Uniplac.eAgenda.WindowsApp.Properties.Resources.Symbol_Add;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(40, 28);
            this.btnAdd.Text = "toolStripButton1";
            this.btnAdd.ToolTipText = "Adicionar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Uniplac.eAgenda.WindowsApp.Properties.Resources.Symbol_Pencil;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(40, 28);
            this.btnEdit.Text = "toolStripButton2";
            this.btnEdit.ToolTipText = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Uniplac.eAgenda.WindowsApp.Properties.Resources.Symbol_Delete;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(40, 28);
            this.btnDelete.Text = "toolStripButton3";
            this.btnDelete.ToolTipText = "Deletar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // description
            // 
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 28);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(98, 28);
            this.tituloLabel.Tag = "description";
            this.tituloLabel.Text = " Tipo de cadastro";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 17);
            this.lblStatus.Text = "mensagem";
            // 
            // panControl
            // 
            this.panControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panControl.Location = new System.Drawing.Point(12, 58);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(671, 373);
            this.panControl.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuárioCtrlFToolStripMenuItem
            // 
            this.usuárioCtrlFToolStripMenuItem.Name = "usuárioCtrlFToolStripMenuItem";
            this.usuárioCtrlFToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.usuárioCtrlFToolStripMenuItem.Text = "Usuário     Ctrl+ F";
            this.usuárioCtrlFToolStripMenuItem.Click += new System.EventHandler(this.usuárioCtrlFToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 465);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Biblioteca";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem caToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripLabel description;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripLabel tituloLabel;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioCtrlFToolStripMenuItem;
    }
}

