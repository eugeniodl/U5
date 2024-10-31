namespace SistemaDeReservas
{
    public partial class Form1 : Form
    {
        private bool _isMenuVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AlternarVisibilidad(object sender, EventArgs e)
        {
            _isMenuVisible = !_isMenuVisible;
            panelMenu.Visible = _isMenuVisible;
        }
    }
}