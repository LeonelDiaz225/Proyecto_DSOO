using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Datos
{
    internal class Conexion
    {
        // Parámetros de conexión a la base de datos MySQL
        private string servidor;
        private string baseDatos;
        private string puerto;
        private string usuario;
        private string clave;

        // Constructor con parámetros de conexión
        public Conexion(string servidor = "localhost", string baseDatos = "", string puerto = "3306", string usuario = "root", string clave = "")
        {
            this.servidor = servidor;
            this.baseDatos = baseDatos;
            this.puerto = puerto;
            this.usuario = usuario;
            this.clave = clave;
        }

        // Método para obtener la cadena de conexión
        private string ObtenerCadenaConexion()
        {
            return $"Server={servidor};Port={puerto};Database={baseDatos};Uid={usuario};Pwd={clave};";
        }

        // Método para obtener una conexión MySQL
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(ObtenerCadenaConexion());
        }

        // Método para probar la conexión
        public bool ProbarConexion()
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Propiedades para acceder a los parámetros de conexión
        public string Servidor
        {
            get => servidor;
            set => servidor = value;
        }

        public string BaseDatos
        {
            get => baseDatos;
            set => baseDatos = value;
        }

        public string Puerto
        {
            get => puerto;
            set => puerto = value;
        }

        public string Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public string Clave
        {
            get => clave;
            set => clave = value;
        }
    }
}

