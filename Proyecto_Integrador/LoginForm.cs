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

            var (esValido, rol) = ValidarCredencialesConSP(usuario, contrase�a);
            
            if (esValido)
            {
                MessageBox.Show($"�Bienvenido al sistema!\nRol: {rol}", "Login exitoso", 
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

        private (bool esValido, string rol) ValidarCredencialesConSP(string usuario, string contrase�a)
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
                    return (false, "");
                }

                using (MySqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    conexion.Open();
                    
                    using (MySqlCommand cmd = new MySqlCommand("ValidarUsuario", conexion))
                    {
                        // Configurar como stored procedure
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        
                        // Par�metros de entrada
                        cmd.Parameters.AddWithValue("@p_usuario", usuario);
                        cmd.Parameters.AddWithValue("@p_contrase�a", contrase�a);
                        
                        // Par�metros de salida
                        MySqlParameter paramResultado = new MySqlParameter("@p_resultado", MySqlDbType.Int32)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        cmd.Parameters.Add(paramResultado);
                        
                        MySqlParameter paramRol = new MySqlParameter("@p_rol", MySqlDbType.VarChar, 100)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        cmd.Parameters.Add(paramRol);
                        
                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();
                        
                        // Obtener los valores de salida
                        int resultado = Convert.ToInt32(paramResultado.Value ?? 0);
                        string rol = paramRol.Value?.ToString() ?? "";
                        
                        return (resultado > 0, rol);
                    }
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"Error de base de datos: {mysqlEx.Message}", "Error MySQL", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, "");
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