namespace Proyecto_Integrador
{
    public partial class TipoRegistroForm : Form
    {
        public string TipoSeleccionado { get; private set; } = "";

        public TipoRegistroForm()
        {
            InitializeComponent();
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            TipoSeleccionado = "Socio";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNoSocio_Click(object sender, EventArgs e)
        {
            TipoSeleccionado = "NoSocio";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}