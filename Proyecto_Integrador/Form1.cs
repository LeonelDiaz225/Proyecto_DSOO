namespace Proyecto_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistroMiembros_Click(object sender, EventArgs e)
        {
            // Mostrar formulario de selección de tipo de registro
            TipoRegistroForm tipoForm = new TipoRegistroForm();
            DialogResult resultado = tipoForm.ShowDialog();
            
            if (resultado == DialogResult.OK)
            {
                if (tipoForm.TipoSeleccionado == "Socio")
                {
                    // Abrir formulario de registro de socios completo
                    RegistroSociosForm formSocio = new RegistroSociosForm();
                    formSocio.ShowDialog();
                }
                else if (tipoForm.TipoSeleccionado == "NoSocio")
                {
                    // Abrir formulario de registro simplificado para no socios
                    RegistroNoSocioForm formNoSocio = new RegistroNoSocioForm();
                    formNoSocio.ShowDialog();
                }
            }
        }

        private void btnGestionPagos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo: GESTIÓN DE PAGOS\n\nFuncionalidades:\n• Registrar pagos de cuotas\n• Consultar estado de pagos\n• Generar reportes de ingresos",
                "Gestión de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Abrir formulario específico para gestión de pagos
            // GestionPagosForm form = new GestionPagosForm();
            // form.Show();
        }

        private void btnControlAcceso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo: CONTROL DE ACCESO\n\nFuncionalidades:\n• Registrar entrada/salida de miembros\n• Control de horarios\n• Historial de accesos",
                "Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Abrir formulario específico para control de acceso
            // ControlAccesoForm form = new ControlAccesoForm();
            // form.Show();
        }

        private void btnGestionPersonal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo: GESTIÓN DE PERSONAL\n\nFuncionalidades:\n• Administrar empleados\n• Control de horarios del personal\n• Gestión de roles y permisos",
                "Gestión de Personal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Abrir formulario específico para gestión de personal
            // GestionPersonalForm form = new GestionPersonalForm();
            // form.Show();
        }

        private void btnTurnosNutricion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo: TURNOS NUTRICIÓN\n\nFuncionalidades:\n• Agendar citas con nutricionista\n• Gestionar horarios disponibles\n• Seguimiento nutricional",
                "Turnos Nutrición", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Abrir formulario específico para turnos de nutrición
            // TurnosNutricionForm form = new TurnosNutricionForm();
            // form.Show();
        }
    }
}
