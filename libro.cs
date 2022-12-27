using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace REGISTRO_ESTUDIANTE
{
    public partial class libro : Form
    {
        public libro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void libro_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexion exitosa");

            dataGridView2.DataSource = llenar_grid();
        }


        public DataTable llenar_grid()
            {
                Conexion.Conectar();
                DataTable dt = new DataTable();
                string consulta = "Select * from LIBRO";
                SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;
            }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "insert into libro(CODIGO ,TITULO,AUTOR,AREA,PRECIO,NHOJAS,FECHA)values (@CODIGO,@TITULO,@AUTOR,@AREA,@PRECIO,@NHOJAS,@FECHA)";
            SqlCommand cmd4 = new SqlCommand(insertar, Conexion.Conectar());
            cmd4.Parameters.AddWithValue("@CODIGO", txtCodlib.Text);
            cmd4.Parameters.AddWithValue("@TITULO", txtTitulo.Text);
            cmd4.Parameters.AddWithValue("@AUTOR", txtAutor.Text);
            cmd4.Parameters.AddWithValue("@AREA", TXTaREA.Text);
            cmd4.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
            cmd4.Parameters.AddWithValue("@NHOJAS", cbmHojas.Text);
            cmd4.Parameters.AddWithValue("@FECHA", dtmFechaedi.Text);

            cmd4.ExecuteNonQuery();

            MessageBox.Show("los datos fueron agregados con exito");

            dataGridView2.DataSource = llenar_grid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string modificar = "UPDATE ALUMNO SET CODIGO = @CODIGO, TITULO=@TITULO ,  AREA = @AREA , PRECIO = @PRECIO, HOJAS=@NHOJAS, FECHA=@FECHA WHERE CODIGO = @CODIGO";
            SqlCommand cmd5 = new SqlCommand(modificar, Conexion.Conectar());
            cmd5.Parameters.AddWithValue("@CODIGO", txtCodlib.Text);
            cmd5.Parameters.AddWithValue("@TITULO", txtTitulo.Text);
            cmd5.Parameters.AddWithValue("@AREA", TXTaREA.Text);
            cmd5.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
            cmd5.Parameters.AddWithValue("@NHOJAS", cbmHojas.Text);
            cmd5.Parameters.AddWithValue("@FECHA", dtmFechaedi.Text);

            cmd5.ExecuteNonQuery();

            MessageBox.Show("LOS DATOS FUERON ACTUALIZADOS");
            dataGridView2.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Conexion.Conectar();
            string eliminar = "DELETE  FROM  libro WHERE CODIGO = @CODIGO";
            SqlCommand cmd6 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd6.Parameters.AddWithValue("@CODIGO", txtCodlib.Text);

            cmd6.ExecuteNonQuery();




            MessageBox.Show("LOS DATOS FUERON ELIMINADOS CON EXITO");
            dataGridView2.DataSource = llenar_grid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodlib.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtAutor.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                TXTaREA.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtTitulo.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtEditorial.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                cbmHojas.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                dtmFechaedi.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }
    }
    }

