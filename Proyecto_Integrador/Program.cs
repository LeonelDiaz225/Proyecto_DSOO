namespace Proyecto_Integrador
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
        
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