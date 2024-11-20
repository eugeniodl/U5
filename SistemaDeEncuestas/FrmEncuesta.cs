using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEncuestas
{
    public partial class FrmEncuesta : Form
    {
        private Encuesta _encuesta;

        public FrmEncuesta()
        {
            InitializeComponent();
            _encuesta = new Encuesta();
            CargarSecciones();
        }

        private void CargarSecciones()
        {
            foreach (var seccion in _encuesta.Secciones)
            {
                var nodoSeccion = new TreeNode(seccion.Nombre);
                nodoSeccion.Tag = seccion;
                tvSecciones.Nodes.Add(nodoSeccion);
            }
        }

        private void tvSecciones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is SeccionEncuesta seccion)
            {
                lvPreguntas.Items.Clear();
                foreach (var pregunta in seccion.Preguntas)
                {
                    var itemPregunta = new ListViewItem(pregunta.Texto);
                    itemPregunta.Tag = pregunta;
                    itemPregunta.Checked = pregunta.Estado; // Refleja el estado de la pregunta
                    itemPregunta.SubItems
                        .Add(pregunta.TipoRespuesta.ToString());
                    itemPregunta.SubItems
                        .Add(pregunta.Estado ? "Respondida" : "No Respondida");
                    lvPreguntas.Items.Add(itemPregunta);
                }
            }
        }

        private void lvPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPreguntas.SelectedItems.Count > 0)
            {
                var pregunta = (Pregunta)lvPreguntas.SelectedItems[0].Tag;
                dgvDetallesPregunta.DataSource = new[] { pregunta };
                tbPonderacion.Value = pregunta.Ponderacion;
            }
        }

        private void tbPonderacion_Scroll(object sender, EventArgs e)
        {
            if(lvPreguntas.SelectedItems.Count > 0)
            {
                var pregunta = (Pregunta)lvPreguntas.SelectedItems[0].Tag;
                pregunta.Ponderacion = tbPonderacion.Value;
            }
        }
    }
}
