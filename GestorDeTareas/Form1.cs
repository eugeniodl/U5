namespace GestorDeTareas
{
    public partial class Form1 : Form
    {
        private List<string> _tareas = new List<string>(); // Lista de tareas

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
            string nuevaTarea =
                Prompt.ShowDialog("Ingrese la nueva tarea:",
                "Agregar Tarea");
            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                _tareas.Add(nuevaTarea);
                lstTareas.Items.Add(nuevaTarea);
            }
        }

        private void EditarTarea(object sender, EventArgs e)
        {
            if(lstTareas.SelectedItem != null)
            {
                string tareaActual = lstTareas.SelectedItem.ToString();
                string tareaEditada = Prompt.ShowDialog("Editar tarea:",
                    "Editar Tarea", tareaActual);
                if(!string.IsNullOrEmpty(tareaEditada))
                {
                    int index = lstTareas.SelectedIndex;
                    _tareas[index] = tareaEditada;
                    lstTareas.Items[index] = tareaEditada;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar",
                    "Advetencia", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string texto,
            string titulo, string valorInicial = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = texto,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label lblTexto = new Label()
            {
                Left = 20,
                Top = 20,
                Text = texto,
                Width = 350
            };
            TextBox txtTexto = new TextBox()
            {
                Left = 20,
                Top = 50,
                Text = valorInicial
            };
            Button btnConfirmation = new Button()
            {
                Text = "Aceptar",
                Left = 250,
                Width = 120,
                Top = 80,
                DialogResult = DialogResult.OK
            };
            btnConfirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(lblTexto);
            prompt.Controls.Add(txtTexto);
            prompt.Controls.Add(btnConfirmation);
            prompt.AcceptButton = btnConfirmation;

            return prompt.ShowDialog() ==
                DialogResult.OK ? txtTexto.Text : "";
        }
    }
}