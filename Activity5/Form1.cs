using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Background
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = lBoxItems.SelectedIndices.Count - 1; i >= 0; i--)
            {
                cmbo_BoxItems.Items.Add(lBoxItems.SelectedItems[i]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cmbo_BoxItems.Items.RemoveAt(cmbo_BoxItems.SelectedIndex);
        }
    }
}
