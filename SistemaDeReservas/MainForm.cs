namespace SistemaDeReservas
{
    public partial class MainForm : Form
    {
        private bool _isMenuVisible = false;

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
    }
}