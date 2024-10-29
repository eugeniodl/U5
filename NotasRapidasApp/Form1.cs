namespace NotasRapidasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarNota(object sender, EventArgs e)
        {
            MessageBox.Show("Nota guardada exitosamente",
                "Guardar", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LimpiarNota(object sender, EventArgs e)
        {
            txtNota.Clear();
        }

        private void AtajosDeTeclado(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Guardar con Ctrl+S
            {
                GuardarNota(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.L) // Limpiar con Ctrl+L
            {
                LimpiarNota(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.Q) // Cerrar con Ctrl+Q
            {
                Close();
            }
        }

        private void DestacarNota(object sender, EventArgs e)
        {
            txtNota.BackColor = Color.Yellow;
            MessageBox.Show("¡Nota destacada!", "Destacar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Variables para arrastrar el cuadro de texto
        private Point _puntoInicial;
        private bool _arrastrando = false;

        // Inicar arrastre al presionar el botón izquierdo del mouse
        private void IniciarArrastre(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _arrastrando = true;
                _puntoInicial = e.Location;
            }
        }

        // Mover el cuadro de texto mientras se arrastra
        private void ArrastrarControl(object sender, MouseEventArgs e)
        {
            if (_arrastrando)
            {
                txtNota.Left += e.X - _puntoInicial.X;
                txtNota.Top += e.Y - _puntoInicial.Y;
            }
        }

        // Terminar el arrastre al soltar el botón izquierdo del mouse
        private void TerminarArrastre(object sender, MouseEventArgs e)
        {
            _arrastrando = false;
        }
    }
}