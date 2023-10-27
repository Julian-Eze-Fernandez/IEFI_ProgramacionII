using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entity;

namespace IEFIPrgII
{
    public partial class FormSocios : Form
    {

        NegSocio objNegSocio = new NegSocio();
        NegCuotaSocial objNegCuotaSocial = new NegCuotaSocial();

        public FormSocios()
        {
            InitializeComponent();
            CrearDGVS();
            LLenarDGVSocios();
            LLenarDGVCuotasSociales();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iEFIPrgDataSet2.barrios' Puede moverla o quitarla según sea necesario.
            this.barriosTableAdapter.Fill(this.iEFIPrgDataSet2.barrios);
            // TODO: esta línea de código carga datos en la tabla 'iEFIPrgDataSet1.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.iEFIPrgDataSet1.provincias);
            // TODO: esta línea de código carga datos en la tabla 'iEFIPrgDataSet.sexos' Puede moverla o quitarla según sea necesario.
            this.sexosTableAdapter.Fill(this.iEFIPrgDataSet.sexos);

        }

        private void CrearDGVS()
        {
            // Data Grid View SOCIOS
            dgv_Socios.Columns.Add("0", "Código");
            dgv_Socios.Columns.Add("1", "Nombre");
            dgv_Socios.Columns.Add("2", "Apellido");
            dgv_Socios.Columns.Add("3", "Sexo");
            dgv_Socios.Columns.Add("4", "Domicilio");
            dgv_Socios.Columns.Add("5", "Barrio");
            dgv_Socios.Columns.Add("6", "Monto Mes");
            dgv_Socios.Columns.Add("7", "Fecha Alta");
            dgv_Socios.Columns.Add("8", "Fecha Baja");
            dgv_Socios.Columns.Add("9", "Activo");

            dgv_Socios.Columns[0].Width = 100;
            dgv_Socios.Columns[1].Width = 100;
            dgv_Socios.Columns[2].Width = 100;
            dgv_Socios.Columns[3].Width = 100;
            dgv_Socios.Columns[4].Width = 100;
            dgv_Socios.Columns[5].Width = 100;
            dgv_Socios.Columns[6].Width = 100;
            dgv_Socios.Columns[7].Width = 100;
            dgv_Socios.Columns[8].Width = 100;
            dgv_Socios.Columns[9].Width = 100;

            // Data Grid View CUOTA SOCIALES
            dgv_CuotasSociales.Columns.Add("0", "Socio");
            dgv_CuotasSociales.Columns.Add("1", "Año");
            dgv_CuotasSociales.Columns.Add("2", "Mes");
            dgv_CuotasSociales.Columns.Add("3", "Monto x Cuota");
            dgv_CuotasSociales.Columns.Add("4", "Pagada");

            dgv_CuotasSociales.Columns[0].Width = 100;
            dgv_CuotasSociales.Columns[1].Width = 100;
            dgv_CuotasSociales.Columns[2].Width = 100;
            dgv_CuotasSociales.Columns[3].Width = 100;
            dgv_CuotasSociales.Columns[4].Width = 100;

        }
        

        //Socios
        private void LLenarDGVSocios()
        {
            dgv_Socios.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegSocio.listadoSocios("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgv_Socios.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                }
            }
            else
                MessageBox.Show("No hay Socios cargados en el sistema.");
        }
        private void btn_CargarSocio_Click(object sender, EventArgs e)
        {
            Socio NuevoSocio = new Socio(txt_SocioCod.Text,txt_NombreSoc.Text,txt_ApellidoSoc.Text, char.Parse(cmbBox_Sexo.Text),
                                        txt_DomicilioSoc.Text, cmbbox_BarrCod.Text, decimal.Parse(txt_MontoMes.Text),
                                        DateTimePick_FecAlt.Value, DateTimePick_FecBaj.Value, char.Parse(cmbBox_Activo.Text));

            MessageBox.Show("Socio Instanciado");
        }

        private void btn_ModificarSocio_Click(object sender, EventArgs e)
        {

        }

        private void btn_BorrarSocio_Click(object sender, EventArgs e)
        {

        }


        //Cuotas Sociales
        private void LLenarDGVCuotasSociales()
        {
            dgv_CuotasSociales.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegCuotaSocial.listadoCuotas_Sociales("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgv_CuotasSociales.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
            }
            else
                MessageBox.Show("No hay Cuotas Sociales cargadas en el sistema.");
        }

        private void btn_CargarCuota_Click(object sender, EventArgs e)
        {
            Cuota_Social NuevaCuotaSocial = new Cuota_Social(txt_SocioCod.Text,char.Parse(txt_Anio.Text),char.Parse(cmbBox_Mes.Text),
                                                            decimal.Parse(txt_MontoCuota.Text),char.Parse(cmbBox_Pagada.Text));

            MessageBox.Show("Cuota Social Instanciada");
        }

        private void btn_ModificarCuota_Click(object sender, EventArgs e)
        {

        }

        private void btn_BorrarCuota_Click(object sender, EventArgs e)
        {

        }
    }
}
