using MySql.Data.MySqlClient;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador
{
    public partial class RegistroNoSocioForm : Form
    {
        public RegistroNoSocioForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Conexion conexionDB = new Conexion();
                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    conexion.Open();
                    
                    string query = @"INSERT INTO NoSocio (nombre_completo, dni) 
                                   VALUES (@nombre, @dni)";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@dni", txtDni.Text.Trim());
                        
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡No Socio registrado exitosamente!", "Registro Exitoso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                        }
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                if (mysqlEx.Number == 1062) // Duplicate entry
                {
                    MessageBox.Show("El DNI ya está registrado en el sistema.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Error de base de datos: {mysqlEx.Message}", "Error MySQL", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre completo es obligatorio.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}