namespace Proyecto_Integrador
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblUsuario = new Label();
            this.txtUsuario = new TextBox();
            this.lblContrase�a = new Label();
            this.txtContrase�a = new TextBox();
            this.btnLogin = new Button();
            this.btnCancelar = new Button();
            this.lblTitulo = new Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new Point(30, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new Size(50, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new Point(30, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new Size(200, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContrase�a
            // 
            this.lblContrase�a.AutoSize = true;
            this.lblContrase�a.Location = new Point(30, 120);
            this.lblContrase�a.Name = "lblContrase�a";
            this.lblContrase�a.Size = new Size(70, 15);
            this.lblContrase�a.TabIndex = 2;
            this.lblContrase�a.Text = "Contrase�a:";
            // 
            // txtContrase�a
            // 
            this.txtContrase�a.Location = new Point(30, 140);
            this.txtContrase�a.Name = "txtContrase�a";
            this.txtContrase�a.PasswordChar = '*';
            this.txtContrase�a.Size = new Size(200, 23);
            this.txtContrase�a.TabIndex = 3;
            this.txtContrase�a.KeyPress += new KeyPressEventHandler(this.txtContrase�a_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(30, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(90, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new Point(140, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(90, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Location = new Point(70, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(120, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Iniciar Sesi�n";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(264, 241);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContrase�a);
            this.Controls.Add(this.lblContrase�a);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContrase�a;
        private TextBox txtContrase�a;
        private Button btnLogin;
        private Button btnCancelar;
        private Label lblTitulo;
    }
}