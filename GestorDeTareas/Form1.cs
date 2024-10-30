namespace GestorDeTareas
{
    public partial class Form1 : Form
    {
        List<string> tareas = new List<string>(); // Lista de tareas

        public Form1()
        {
            InitializeComponent();

            toolStripStatusLabel1.Text = string.Empty;
        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarTarea(object sender, EventArgs e)
        {
            string nuevaTarea = Prompt.ShowDialog(
                "Ingrese la nueva tarea:", "Agregar Tarea");
            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                tareas.Add(nuevaTarea);
                lstTareas.Items.Add(nuevaTarea);
                ActualizarEstado("Tarea agregada");
            }
        }

        private void EditarTarea(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                string tareaActual = lstTareas.SelectedItem.ToString();
                string tareaEditada = Prompt.ShowDialog("Editar tarea:",
                    "Editar Tarea", tareaActual);
                if (!string.IsNullOrEmpty(tareaEditada))
                {
                    int index = lstTareas.SelectedIndex;
                    tareas[index] = tareaEditada;
                    lstTareas.Items[index] = tareaEditada;
                    ActualizarEstado("Tarea editada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar",
                    "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void EliminarTarea(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                int index = lstTareas.SelectedIndex;
                tareas.RemoveAt(index);
                lstTareas.Items.RemoveAt(index);
                ActualizarEstado("Tarea eliminada");
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar",
                    "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ActualizarEstado(string mensaje)
        {
            toolStripStatusLabel1.Text = mensaje;
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
                Left = 20,
                Top = 20,
                Text = texto,
                Width = 350
            };
            TextBox txtInput = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 350,
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
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnConfirmation);
            prompt.AcceptButton = btnConfirmation;

            return prompt.ShowDialog() == DialogResult.OK
                ? txtInput.Text : "";
        }
    }
}