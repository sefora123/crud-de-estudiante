using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTRO_ESTUDIANTE
{
    public partial class FRMPRINCIPAL : Form
    {
        public FRMPRINCIPAL()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            REGISTRO r03 = new REGISTRO();
            r03.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            libro r03 = new libro();
            r03.ShowDialog();
        }
    }
}
