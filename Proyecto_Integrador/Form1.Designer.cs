namespace Proyecto_Integrador
{
    partial class Form1
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnRegistroMiembros = new Button();
            btnGestionPagos = new Button();
            btnControlAcceso = new Button();
            btnGestionPersonal = new Button();
            btnTurnosNutricion = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(231, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(483, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestión - Club deportivo";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Microsoft Sans Serif", 12F);
            lblSubtitulo.Location = new Point(377, 79);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(173, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione una opción:";
            // 
            // btnRegistroMiembros
            // 
            btnRegistroMiembros.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRegistroMiembros.Location = new Point(150, 130);
            btnRegistroMiembros.Name = "btnRegistroMiembros";
            btnRegistroMiembros.Size = new Size(180, 70);
            btnRegistroMiembros.TabIndex = 2;
            btnRegistroMiembros.Text = "Registro de\nMiembros";
            btnRegistroMiembros.UseVisualStyleBackColor = true;
            btnRegistroMiembros.Click += btnRegistroMiembros_Click;
            // 
            // btnGestionPagos
            // 
            btnGestionPagos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnGestionPagos.Location = new Point(370, 130);
            btnGestionPagos.Name = "btnGestionPagos";
            btnGestionPagos.Size = new Size(180, 70);
            btnGestionPagos.TabIndex = 3;
            btnGestionPagos.Text = "Gestión de\nPagos";
            btnGestionPagos.UseVisualStyleBackColor = true;
            btnGestionPagos.Click += btnGestionPagos_Click;
            // 
            // btnControlAcceso
            // 
            btnControlAcceso.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnControlAcceso.Location = new Point(590, 130);
            btnControlAcceso.Name = "btnControlAcceso";
            btnControlAcceso.Size = new Size(180, 70);
            btnControlAcceso.TabIndex = 4;
            btnControlAcceso.Text = "Control de\nAcceso";
            btnControlAcceso.UseVisualStyleBackColor = true;
            btnControlAcceso.Click += btnControlAcceso_Click;
            // 
            // btnGestionPersonal
            // 
            btnGestionPersonal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnGestionPersonal.Location = new Point(260, 240);
            btnGestionPersonal.Name = "btnGestionPersonal";
            btnGestionPersonal.Size = new Size(180, 70);
            btnGestionPersonal.TabIndex = 5;
            btnGestionPersonal.Text = "Gestión de\nPersonal";
            btnGestionPersonal.UseVisualStyleBackColor = true;
            btnGestionPersonal.Click += btnGestionPersonal_Click;
            // 
            // btnTurnosNutricion
            // 
            btnTurnosNutricion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTurnosNutricion.Location = new Point(480, 240);
            btnTurnosNutricion.Name = "btnTurnosNutricion";
            btnTurnosNutricion.Size = new Size(180, 70);
            btnTurnosNutricion.TabIndex = 6;
            btnTurnosNutricion.Text = "Turnos\nNutrición";
            btnTurnosNutricion.UseVisualStyleBackColor = true;
            btnTurnosNutricion.Click += btnTurnosNutricion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 400);
            Controls.Add(btnTurnosNutricion);
            Controls.Add(btnGestionPersonal);
            Controls.Add(btnControlAcceso);
            Controls.Add(btnGestionPagos);
            Controls.Add(btnRegistroMiembros);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión - Club deportivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnRegistroMiembros;
        private Button btnGestionPagos;
        private Button btnControlAcceso;
        private Button btnGestionPersonal;
        private Button btnTurnosNutricion;
    }
}
