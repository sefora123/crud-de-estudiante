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
    public partial class FRMINICIO : Form
    {

        string DOCUMENTO = "DNI";
        string CONTRASEÑA= "1234";
        public FRMINICIO()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != DOCUMENTO || txtContraseña2.Text != CONTRASEÑA)
            {
                if (txtUsuario.Text != DOCUMENTO)
                {
                    MessageBox.Show("Usuario Incorrecto", "ERROR",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }
                if (txtContraseña2.Text != CONTRASEÑA)
                {
                    MessageBox.Show("Contraseña Incorrecto", "ERROR",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    txtContraseña2.Clear();
                    txtContraseña2.Focus();
                    return;
                }
            }
            else


            {
                txtUsuario.Clear();
                txtContraseña2.Clear();
                FRMPRINCIPAL form = new FRMPRINCIPAL();
                form.ShowDialog();


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
    }

