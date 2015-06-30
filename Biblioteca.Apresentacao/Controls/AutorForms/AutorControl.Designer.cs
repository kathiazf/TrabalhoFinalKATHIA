namespace Biblioteca.Apresentacao.Controls.AutorForms
{
    partial class AutorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listAutores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listAutores
            // 
            this.listAutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAutores.FormattingEnabled = true;
            this.listAutores.Location = new System.Drawing.Point(0, 0);
            this.listAutores.Name = "listAutores";
            this.listAutores.Size = new System.Drawing.Size(251, 196);
            this.listAutores.TabIndex = 0;
            // 
            // AutorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listAutores);
            this.Name = "AutorControl";
            this.Size = new System.Drawing.Size(251, 196);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAutores;

    }
}
