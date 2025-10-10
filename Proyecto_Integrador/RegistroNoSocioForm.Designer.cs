namespace Proyecto_Integrador
{
    partial class RegistroNoSocioForm
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
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblDni = new Label();
            this.txtDni = new TextBox();
            this.btnGuardar = new Button();
            this.btnLimpiar = new Button();
            this.btnCerrar = new Button();
            this.panel1 = new Panel();
            this.lblDescripcion = new Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Location = new Point(120, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(200, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro No Socio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblDescripcion.Location = new Point(80, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new Size(280, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Complete los datos básicos del no socio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblNombre.Location = new Point(30, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new Size(130, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtNombre.Location = new Point(30, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(350, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblDni.Location = new Point(30, 155);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new Size(35, 18);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtDni.Location = new Point(30, 180);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new Size(200, 24);
            this.txtDni.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = Color.FromArgb(46, 125, 50);
            this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGuardar.ForeColor = Color.White;
            this.btnGuardar.Location = new Point(30, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(100, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = Color.FromArgb(255, 152, 0);
            this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = Color.White;
            this.btnLimpiar.Location = new Point(150, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 35);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = Color.FromArgb(244, 67, 54);
            this.btnCerrar.FlatStyle = FlatStyle.Flat;
            this.btnCerrar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCerrar.ForeColor = Color.White;
            this.btnCerrar.Location = new Point(280, 230);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new Size(100, 35);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.White;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(420, 290);
            this.panel1.TabIndex = 9;
            // 
            // RegistroNoSocioForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.ClientSize = new Size(460, 330);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegistroNoSocioForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Registro No Socio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Panel panel1;
    }
}