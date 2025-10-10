using MySql.Data.MySqlClient;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador
{
    public partial class RegistroSociosForm : Form
    {
        public RegistroSociosForm()
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
                    
                    string query = @"INSERT INTO Socio (nombre_completo, fecha_nacimiento, dni, telefono, email, 
                                   estado_cuota, fecha_vencimiento_cuota, carnet_entregado) 
                                   VALUES (@nombre, @fecha_nacimiento, @dni, @telefono, @email, 
                                   @estado_cuota, @fecha_vencimiento, @carnet_entregado)";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", dtpFechaNacimiento.Value.Date);
                        cmd.Parameters.AddWithValue("@dni", txtDni.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@estado_cuota", "Válido");
                        cmd.Parameters.AddWithValue("@fecha_vencimiento", DateTime.Now.AddDays(30));
                        cmd.Parameters.AddWithValue("@carnet_entregado", chkCarnetEntregado.Checked);
                        
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Socio registrado exitosamente!", "Registro Exitoso", 
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
                    MessageBox.Show("El DNI o Email ya están registrados en el sistema.", "Error", 
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

            if (dtpFechaNacimiento.Value >= DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("El socio debe tener al menos 16 años.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
            chkCarnetEntregado.Checked = false;
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