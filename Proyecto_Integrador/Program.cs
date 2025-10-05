namespace Proyecto_Integrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Mostrar el formulario de login primero
            LoginForm loginForm = new LoginForm();
            DialogResult resultado = loginForm.ShowDialog();
            
            // Si el login es exitoso, abrir el formulario principal
            if (resultado == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}