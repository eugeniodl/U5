namespace GestorDeTareas
{
    public partial class Form1 : Form
    {
        List<string> tareas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarTarea(object sender, EventArgs e)
        {
            string nuevaTarea = Prompt.ShowDialog("Ingrese la nueva tarea:",
                "Agregar Tarea");
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string texto, string titulo,
            string valorInicial = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titulo,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblTexto = new Label()
            {
                Left = 20, Top = 20, Text = texto, Width = 350
            };
            TextBox txtInput = new TextBox()
            {
                Left = 20, Top = 50, Width = 350, Text = valorInicial
            };
            Button btnConfirmation = new Button()
            {
                Text = "Aceptar", Left = 250, Width = 120, Top = 80,
                DialogResult = DialogResult.OK
            };

            btnConfirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(lblTexto);
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnConfirmation);
            prompt.AcceptButton = btnConfirmation;

            return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
        }
    }
}