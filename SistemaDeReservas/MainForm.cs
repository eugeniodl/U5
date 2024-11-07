namespace SistemaDeReservas
{
    public partial class MainForm : Form
    {
        private bool _isMenuVisible = false;
        FormReservar? formReservar;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AlternarVisibilidad(object sender, EventArgs e)
        {
            _isMenuVisible = !_isMenuVisible;
            panelMenu.Visible = _isMenuVisible;
        }

        private void Salir(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Reservar(object sender, EventArgs e)
        {
            // Crea y muestra el formulario de reservas en la pestaña correspondiente
            if (formReservar == null)
            {
                formReservar = new FormReservar();
            }

            MostrarFormularioEnTabPage(formReservar, tabPage1);
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            // Configura y muestra el formulario dentro de la pestaña proporcionada
            tabPage.Controls.Clear(); // Limpia los controles existentes en la pestaña
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            // Selecciona la pestaña actual
            tabControlCentral.SelectedTab = tabPage;
        }

        private void VerReservas(object sender, EventArgs e)
        {
            // Muestra el formulario para ver reservas en una pestaña

            // Verifica si hay un formulario de reservas creado para 
            // obtener la lista de reservas
            if(formReservar == null)
            {
                MessageBox.Show("Debe crear una reserva antes de visualizarla.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Reserva> reservas = formReservar.ObtenerListaReservas();

            // Verifica si hay reservas antes de mostrar el formulario de visualización
            if(reservas.Count == 0)
            {
                MessageBox.Show("No hay reservas para mostrar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formVerReservas = new FormVerReservas(reservas);
            MostrarFormularioEnTabPage(formVerReservas, tabPage2);
        }
    }
}