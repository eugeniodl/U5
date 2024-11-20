using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangoDefinidoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateValues(hScrollBar.Value);
        }

        private void UpdateValues(int value)
        {
            hScrollBar.Value = value;
            trackBar.Value = value;
            progressBar.Value = value;

            lblValue.Text = $"Valor actual: {value}";
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            UpdateValues(trackBar.Value);
        }
    }
}
