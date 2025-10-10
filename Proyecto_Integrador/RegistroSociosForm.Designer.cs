namespace Proyecto_Integrador
{
    partial class RegistroSociosForm
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
            this.lblFechaNacimiento = new Label();
            this.dtpFechaNacimiento = new DateTimePicker();
            this.lblDni = new Label();
            this.txtDni = new TextBox();
            this.lblTelefono = new Label();
            this.txtTelefono = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.chkCarnetEntregado = new CheckBox();
            this.btnGuardar = new Button();
            this.btnLimpiar = new Button();
            this.btnCerrar = new Button();
            this.panel1 = new Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Location = new Point(150, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(200, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Socios";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new Size(101, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new Point(30, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(250, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new Point(300, 70);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new Size(106, 15);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new Point(300, 90);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new Size(150, 23);
            this.dtpFechaNacimiento.TabIndex = 4;
            this.dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new Point(30, 130);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new Size(30, 15);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new Point(30, 150);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new Size(150, 23);
            this.txtDni.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new Point(200, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new Size(55, 15);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new Point(200, 150);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new Size(120, 23);
            this.txtTelefono.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(340, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(39, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(340, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(180, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // chkCarnetEntregado
            // 
            this.chkCarnetEntregado.AutoSize = true;
            this.chkCarnetEntregado.Location = new Point(30, 200);
            this.chkCarnetEntregado.Name = "chkCarnetEntregado";
            this.chkCarnetEntregado.Size = new Size(118, 19);
            this.chkCarnetEntregado.TabIndex = 11;
            this.chkCarnetEntregado.Text = "Carnet Entregado";
            this.chkCarnetEntregado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = Color.FromArgb(46, 125, 50);
            this.btnGuardar.FlatStyle = FlatStyle.Flat;
            this.btnGuardar.ForeColor = Color.White;
            this.btnGuardar.Location = new Point(30, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(100, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = Color.FromArgb(255, 152, 0);
            this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.ForeColor = Color.White;
            this.btnLimpiar.Location = new Point(150, 250);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = Color.FromArgb(244, 67, 54);
            this.btnCerrar.FlatStyle = FlatStyle.Flat;
            this.btnCerrar.ForeColor = Color.White;
            this.btnCerrar.Location = new Point(420, 250);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new Size(100, 35);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.White;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblFechaNacimiento);
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.chkCarnetEntregado);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(560, 320);
            this.panel1.TabIndex = 15;
            // 
            // RegistroSociosForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.ClientSize = new Size(600, 360);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegistroSociosForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Registro de Socios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private CheckBox chkCarnetEntregado;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Panel panel1;
    }
}