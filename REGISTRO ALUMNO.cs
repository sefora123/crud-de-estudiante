using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace REGISTRO_ESTUDIANTE
{
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");

            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Select * from alumno";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "insert into alumno(CODIGO , NOMBRE ,APELLIDO,DIRECCION)values (@CODIGO,@NOMBRE,@APELLIDO,@DIRECCION)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
            cmd1.Parameters.AddWithValue("@DIRECCION", txtDirrecion.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("los datos fueron agregados con exito");

            dataGridView1.DataSource = llenar_grid();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            
            string ACTUALIZAR = "UPDATE ALUMNO SET CODIGO = @CODIGO, NOMBRE=@NOMBRE ,  APELLIDO= @APELLIDO , DIRECCION = @DIRECCION";
            SqlCommand cmd2 = new SqlCommand(ACTUALIZAR, Conexion.Conectar());


            cmd2.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            cmd2.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
            cmd2.Parameters.AddWithValue("@DIRECCION", txtDirrecion.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("LOS DATOS FUERON ACTUALIZADOS");
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDirrecion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            Conexion.Conectar();
            string eliminar = "DELETE  FROM  ALUMNO WHERE CODIGO = @CODIGO"; 
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);

            cmd3.ExecuteNonQuery();


            

            MessageBox.Show("LOS DATOS FUERON ELIMINADOS CON EXITO");
            dataGridView1.DataSource = llenar_grid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDirrecion.Clear();
            txtCodigo.Focus();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            R01 REPORTE = new R01();
            REPORTE.ShowDialog();
        }
    }
}
