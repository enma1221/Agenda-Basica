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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AccesoDatos
{
    public partial class Agenda : Form
    {
        private SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = AgendaElectronica; " +
            "integrated security = true");



        public Agenda()
        {
            InitializeComponent();
        }


        public void llenar_tabla()
        {

            string consultar = "select * from [dbo].[TablaAgenda]";

            SqlDataAdapter adapter = new SqlDataAdapter(consultar, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvTabla.DataSource = dt;


        }


        public void limpiarTex()
        {

            String genero1 = cmbGenero.Text;
            String estadoCi = cmbEstadoCivil.Text;
            txtnombre.Clear();
            txtapellido.Clear();
            txtfecha.Clear();
            txtdireccion.Clear();
            txtmovil.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();

            genero1 = "";

        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            conexion.Open();

            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;
            String fechaNacimiento = txtfecha.Text;
            String direccion = txtdireccion.Text;
            String movil = txtmovil.Text;
            String telefono = txttelefono.Text;
            String correoElectronico = txtcorreo.Text;

            String genero1 = cmbGenero.Text;
            String estadoCi = cmbEstadoCivil.Text;





            String insertar = "insert into TablaAgenda(Nombre, Apellido, Fecha, Dirección, Genero, EstadoCivil, Móvil, Telefono," +
                " CorreoElectronico) " +
                                        "values('" + nombre + "','" + apellido + "','" + fechaNacimiento + "','" + direccion + "'," +
                                        "'" + genero1 + "','" + estadoCi + "','" + movil + "','" + telefono + "', '" + correoElectronico + "')";

            SqlCommand comando = new SqlCommand(insertar, conexion);


            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se insertaron correctamente");

            limpiarTex();
            llenar_tabla();


            conexion.Close();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string BuscarID = textnombreBuscar.Text;

            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;
            String fechaNacimiento = txtfecha.Text;
            String direccion = txtdireccion.Text;
            String movil = txtmovil.Text;
            String telefono = txttelefono.Text;
            String correoElectronico = txtcorreo.Text;




            string cadena = "DELETE FROM TablaAgenda where ID = " + BuscarID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;



            try
            {
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Registro Eliminado");
                    limpiarTex();

                    llenar_tabla();
                }
                else
                    MessageBox.Show("No existe el registro");

            }
            catch (Exception)
            {

                MessageBox.Show("No se han encontrado registros para eliminar");
            }

            conexion.Close();







        }

        private void tbTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            llenar_tabla();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {


            conexion.Open();
            string BuscarID = textnombreBuscar.Text;

            string cadena = "select * from TablaAgenda where ID = " + BuscarID + "";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            try
            {
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {

                    txtnombre.Text = registro["Nombre"].ToString();
                    txtapellido.Text = registro["Apellido"].ToString();
                    txtfecha.Text = registro["Fecha"].ToString();
                    txtdireccion.Text = registro["Dirección"].ToString();
                    cmbGenero.Text = registro["Genero"].ToString();
                    cmbEstadoCivil.Text = registro["EstadoCivil"].ToString();
                    txtmovil.Text = registro["Móvil"].ToString();
                    txttelefono.Text = registro["Telefono"].ToString();
                    txtcorreo.Text = registro["CorreoElectronico"].ToString();

                    btnmodificar.Enabled = true;
                    btneliminar.Enabled = true;


                }
                else
                    MessageBox.Show("No existe registro");


            }
            catch (Exception)
            {


                MessageBox.Show("No pusiste el ID");
            }

            conexion.Close();



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string BuscarID = textnombreBuscar.Text;

            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;
            String fechaNacimiento = txtfecha.Text;
            String direccion = txtdireccion.Text;
            String movil = txtmovil.Text;
            String telefono = txttelefono.Text;
            String correoElectronico = txtcorreo.Text;

            String genero1 = cmbGenero.Text;
            String estadoCi = cmbEstadoCivil.Text;




            string cadena = "UPDATE TablaAgenda SET Nombre = '" + nombre + "', Apellido = '" + apellido + "', " +
                "Fecha = '" + fechaNacimiento + "', Dirección = '" + direccion + "', Genero = '" + genero1 + "', " +
                "EstadoCivil = '" + estadoCi + "', Móvil = '" + movil + "', Telefono = '" + telefono + "'," +
                " CorreoElectronico = '" + correoElectronico + "' WHERE ID = " + BuscarID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;

            try
            {
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Registro modificado");

                    limpiarTex();
                    llenar_tabla();

                }
                else
                    MessageBox.Show("No existe registro");
                conexion.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("No se ha econtrado ningun registro para modificar");
            }
            conexion.Close();


        }

        private void txtTabla_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


/*
             SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = AgendaElectronica; integrated security = true");
            conexion.Open();
            MessageBox.Show("se abrio");

            conexion.Close();
            MessageBox.Show("se cerro");
 
 */

/*
            SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = AgendaElectronica; integrated security = true");

            conexion.Open();

            string mostrar = "select * from TablaAgenda";
            SqlCommand comando = new SqlCommand(mostrar, conexion);

            SqlDataReader Datos = comando.ExecuteReader();

            while (Datos.Read())
            {
                txtTabla.AppendText(Datos["ID"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Nombre"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Apellido"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Fecha"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Dirección"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Genero"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["EstadoCivil"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Móvil"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["Telefono"].ToString());
                txtTabla.AppendText("-");

                txtTabla.AppendText(Datos["CorreoElectronico"].ToString());

                txtTabla.AppendText(Environment.NewLine);
            }
            conexion.Close();
 */
