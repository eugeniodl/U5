namespace SistemaDeReservas
{
    public partial class MainForm : Form
    {
        bool isMenuVisible = false;
        FormReservar? formReservar;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AlternarVisibilidad(object sender, EventArgs e)
        {
            isMenuVisible = !isMenuVisible;
            panelMenu.Visible = isMenuVisible;
        }

        private void Reservar(object sender, EventArgs e)
        {
            if (formReservar == null)
            {
                formReservar = new FormReservar();
            }
            MostrarFormularioEnTabPage(formReservar, tabPage1);
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            // Configura y muestra el formulario dentro de la pesta�a proporcionada
            tabPage.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            // Selecciona la pesta�a actual
            tabControlCentral.SelectedTab = tabPage;
        }

        private void Salir(object sender, EventArgs e)
        {
            // Cierra la aplicaci�n con confirmaci�n
            DialogResult result =
                MessageBox.Show("�Est� seguro de que desea salir?",
                "Confirmaci�n", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void VerReservas(object sender, EventArgs e)
        {
            if(formReservar == null)
            {
                MessageBox.Show("Debe crear una reserva antes de visualizarla.", 
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Reserva> reservas = formReservar.ObtenerReservas();

            if(reservas.Count == 0)
            {
                MessageBox.Show("No hay reservas para mostrar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formVerReservas = new FormVerReservas(reservas);
            MostrarFormularioEnTabPage(formVerReservas, tabPage2);
        }
    }
}