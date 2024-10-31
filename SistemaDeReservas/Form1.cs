namespace SistemaDeReservas
{
    public partial class Form1 : Form
    {
        bool isMenuVisible = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void AlternarVisibilidad(object sender, EventArgs e)
        {
            isMenuVisible = !isMenuVisible;
            panelMenu.Visible = isMenuVisible;
        }
    }
}