namespace Proyecto_Integrador
{
    partial class TipoRegistroForm
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
            this.lblTitulo = new Label();
            this.lblSubtitulo = new Label();
            this.btnSocio = new Button();
            this.btnNoSocio = new Button();
            this.btnCancelar = new Button();
            this.panel1 = new Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Location = new Point(110, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(180, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tipo de Registro";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSubtitulo.Location = new Point(80, 70);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(240, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "¿Qué tipo de registro desea hacer?";
            // 
            // btnSocio
            // 
            this.btnSocio.BackColor = Color.FromArgb(46, 125, 50);
            this.btnSocio.FlatStyle = FlatStyle.Flat;
            this.btnSocio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnSocio.ForeColor = Color.White;
            this.btnSocio.Location = new Point(50, 120);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new Size(120, 60);
            this.btnSocio.TabIndex = 2;
            this.btnSocio.Text = "Socio";
            this.btnSocio.UseVisualStyleBackColor = false;
            this.btnSocio.Click += new EventHandler(this.btnSocio_Click);
            // 
            // btnNoSocio
            // 
            this.btnNoSocio.BackColor = Color.FromArgb(33, 150, 243);
            this.btnNoSocio.FlatStyle = FlatStyle.Flat;
            this.btnNoSocio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnNoSocio.ForeColor = Color.White;
            this.btnNoSocio.Location = new Point(230, 120);
            this.btnNoSocio.Name = "btnNoSocio";
            this.btnNoSocio.Size = new Size(120, 60);
            this.btnNoSocio.TabIndex = 3;
            this.btnNoSocio.Text = "No Socio";
            this.btnNoSocio.UseVisualStyleBackColor = false;
            this.btnNoSocio.Click += new EventHandler(this.btnNoSocio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = Color.FromArgb(244, 67, 54);
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCancelar.ForeColor = Color.White;
            this.btnCancelar.Location = new Point(170, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(80, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.White;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblSubtitulo);
            this.panel1.Controls.Add(this.btnSocio);
            this.panel1.Controls.Add(this.btnNoSocio);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(400, 260);
            this.panel1.TabIndex = 5;
            // 
            // TipoRegistroForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.ClientSize = new Size(440, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoRegistroForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Tipo de Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnSocio;
        private Button btnNoSocio;
        private Button btnCancelar;
        private Panel panel1;
    }
}