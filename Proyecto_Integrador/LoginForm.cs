using MySql.Data.MySqlClient;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrase�a = txtContrase�a.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("Por favor ingrese usuario y contrase�a", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCredenciales(usuario, contrase�a))
            {
                MessageBox.Show("�Bienvenido al sistema!", "Login exitoso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error de autenticaci�n", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrase�a.Clear();
                txtUsuario.Focus();
            }
        }

        private bool ValidarCredenciales(string usuario, string contrase�a)
        {
            try
            {
                // Crear conexi�n usando la clase Conexion
                Conexion conexionDB = new Conexion();

                // Primero probamos la conexi�n
                if (!conexionDB.ProbarConexion())
                {
                    MessageBox.Show("No se puede conectar a la base de datos", "Error de conexi�n", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    conexion.Open();
                    
                    // Query actualizado para tu estructura de tabla
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contrase�a = @contrase�a";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrase�a", contrase�a);
                        
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"Error de base de datos: {mysqlEx.Message}", "Error MySQL", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void txtContrase�a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContrase�a.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}