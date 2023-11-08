using System;
using System.Collections;
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
        NegBarrio objNegBarrio = new NegBarrio();


        public FormSocios()
        {
            InitializeComponent();
            CrearDGVS();
            LLenarDGVSocios();
            LLenarDGVCuotasSociales();
            LLenarDGVBarrios();
            LlenarCombos();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iEFIPrgDataSet2.barrios' Puede moverla o quitarla según sea necesario.
            //this.barriosTableAdapter.Fill(this.iEFIPrgDataSet2.barrios);
            // TODO: esta línea de código carga datos en la tabla 'iEFIPrgDataSet1.provincias' Puede moverla o quitarla según sea necesario.
            //this.provinciasTableAdapter.Fill(this.iEFIPrgDataSet1.provincias);
            // TODO: esta línea de código carga datos en la tabla 'iEFIPrgDataSet.sexos' Puede moverla o quitarla según sea necesario.
            //this.sexosTableAdapter.Fill(this.iEFIPrgDataSet.sexos);

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


            // Data Grid View BARRIOS
            dgv_Barrios.Columns.Add("0", "Codigo");
            dgv_Barrios.Columns.Add("1", "Nombre");
            dgv_Barrios.Columns.Add("2", "Cod_Provincia");
            
            dgv_Barrios.Columns[0].Width = 100;
            dgv_Barrios.Columns[1].Width = 100;
            dgv_Barrios.Columns[2].Width = 100;
            
        }

        void LlenarCombos()
        { //llena un combo desde una lista con descripcion y código
            cmbbox_BarrCod.DataSource = objNegBarrio.ObtenerBarrios(); // se define el origen con la Lista
            cmbbox_BarrCod.DisplayMember = "Barr_Cod";
            cmbbox_BarrCod.ValueMember = "Barr_Cod";

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
            int nGrabados = -1;

            Socio NuevoSocio = new Socio(txt_Socio_SocioCod.Text,txt_NombreSoc.Text,txt_ApellidoSoc.Text, char.Parse(cmbBox_Sexo.Text),
                                        txt_DomicilioSoc.Text, cmbbox_BarrCod.Text, decimal.Parse(txt_MontoMes.Text),
                                        DateTimePick_FecAlt.Value, DateTimePick_FecBaj.Value, char.Parse(cmbBox_Activo.Text));


            nGrabados = objNegSocio.abmSocios("Alta", NuevoSocio);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el socio en el sistema");
            }
            else
            {
                MessageBox.Show("Socio Instanciado");
                LLenarDGVSocios();
                LimpiarCuota_Social();
            }
        }

        private void btn_ModificarSocio_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            Socio NuevoSocio = new Socio(txt_Socio_SocioCod.Text, txt_NombreSoc.Text, txt_ApellidoSoc.Text, char.Parse(cmbBox_Sexo.Text),
                            txt_DomicilioSoc.Text, cmbbox_BarrCod.Text, decimal.Parse(txt_MontoMes.Text),
                            DateTimePick_FecAlt.Value, DateTimePick_FecBaj.Value, char.Parse(cmbBox_Activo.Text));

            nResultado = objNegSocio.abmSocios("Modificar", NuevoSocio); //invoco a la capa de negocio


            if (nResultado != -1)
            {
                MessageBox.Show("El Socio fue Modificado con éxito", "Aviso");
                LimpiarSocio();
                LLenarDGVSocios();

                txt_Socio_SocioCod.Enabled = true;

            }
            else
                MessageBox.Show("Se produjo un error al intentar modificar el socio", "Error");
        }
    

        private void btn_BorrarSocio_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el Socio numero " + txt_Socio_SocioCod.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Socio NuevoSocio = new Socio(txt_Socio_SocioCod.Text);
                nGrabados = objNegSocio.abmSocios("Borrar", NuevoSocio);
                LLenarDGVSocios();
                txt_Socio_SocioCod.Text = "";

            }

        }

        private void LimpiarSocio()
        {
            txt_NombreSoc.Text = string.Empty;
            txt_ApellidoSoc.Text = string.Empty;
            txt_DomicilioSoc.Text = string.Empty;
            cmbBox_Sexo.Text = string.Empty;
            cmbbox_BarrCod.Text = string.Empty;
            txt_MontoMes.Text = string.Empty;
            cmbBox_Activo.Text = string.Empty;
            txt_Socio_SocioCod.Text = string.Empty;
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
            int nGrabados = -1;

            string codigoSocio = txt_Cuota_SocioCod.Text;

            if (objNegCuotaSocial.ExisteCodigoSocio(codigoSocio))
            {
                // El código de socio existe, puedes realizar la operación correspondiente.
                Cuota_Social NuevaCuotaSocial = new Cuota_Social(txt_Cuota_SocioCod.Text, txt_Anio.Text, cmbBox_Mes.Text,
                                                            decimal.Parse(txt_MontoCuota.Text), char.Parse(cmbBox_Pagada.Text));

                nGrabados = objNegCuotaSocial.abmCuotas_Sociales("Alta", NuevaCuotaSocial);

                if (nGrabados == -1)
                {
                    MessageBox.Show("No se pudo grabar la cuota en el sistema");
                }
                else
                {
                    MessageBox.Show("Cuota Social Instanciada");
                    LLenarDGVCuotasSociales();
                    LimpiarCuota_Social();
                }
            }
            else
            {
                // El código de socio no existe, muestra un mensaje de error o realiza otra acción.
                MessageBox.Show("ERROR, EL CODIGO DEL SOCIO INGRESADO NO EXISTE.");
            }

        }

        private void btn_ModificarCuota_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            Cuota_Social NuevaCuotaSocial = new Cuota_Social(txt_Cuota_SocioCod.Text, txt_Anio.Text, cmbBox_Mes.Text,
                                                            decimal.Parse(txt_MontoCuota.Text), char.Parse(cmbBox_Pagada.Text));

            nResultado = objNegCuotaSocial.abmCuotas_Sociales("Modificar", NuevaCuotaSocial); //invoco a la capa de negocio


            if (nResultado != -1)
            {
                MessageBox.Show("La cuota fue Modificada con éxito", "Aviso");
                LimpiarSocio();
                LLenarDGVCuotasSociales();

                txt_Cuota_SocioCod.Enabled = true;

            }
            else
                MessageBox.Show("Se produjo un error al intentar modificar la cuota", "Error");
        }

        private void btn_BorrarCuota_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la cuota del socio numero " + txt_Cuota_SocioCod.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Cuota_Social NuevaCuotaSocial = new Cuota_Social(txt_Cuota_SocioCod.Text, txt_Anio.Text, cmbBox_Mes.Text);
                nGrabados = objNegCuotaSocial.abmCuotas_Sociales("Borrar", NuevaCuotaSocial);
                LLenarDGVCuotasSociales();
                txt_Cuota_SocioCod.Text = "";

            }
        }
        private void LimpiarCuota_Social() 
        {
            txt_Cuota_SocioCod.Text = string.Empty;
            txt_Anio.Text = string.Empty;
            cmbBox_Mes.Text = string.Empty;
            txt_MontoCuota.Text = string.Empty;
            cmbBox_Pagada .Text = string.Empty;
        }

        //Barrios
        private void LLenarDGVBarrios()
        {
            dgv_Barrios.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegBarrio.listadoBarrios("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgv_Barrios.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            else
                MessageBox.Show("No hay Barrios cargados en el sistema.");
        }

        private void btn_CargarBarrios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barrio Instanciado");

            int nGrabados = -1;

            Barrio NuevoBarrio = new Barrio(txt_BarrCod.Text, txt_BarrNombre.Text, char.Parse(txt_ProvCod.Text));


            nGrabados = objNegBarrio.abmBarrios("Alta", NuevoBarrio);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el barrio en el sistema");
            }
            else
            {
                MessageBox.Show("Barrio Instanciado");
                LLenarDGVBarrios();
                LimpiarBarrios();
            }

        }

        private void btn_ModificarBarrios_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            Barrio NuevoBarrio = new Barrio(txt_BarrCod.Text, txt_BarrNombre.Text, char.Parse(txt_ProvCod.Text));

            nResultado = objNegBarrio.abmBarrios("Modificar", NuevoBarrio); //invoco a la capa de negocio


            if (nResultado != -1)
            {
                MessageBox.Show("El Barrio fue Modificado con éxito", "Aviso");
                LimpiarBarrios();
                LLenarDGVBarrios();
                
                txt_BarrCod.Enabled = true;

            }
            else
                MessageBox.Show("Se produjo un error al intentar modificar el barrio", "Error");
        }

        private void btn_BorrarBarrios_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el Barrio con codigo " + txt_BarrCod.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Barrio NuevoBarrio = new Barrio(txt_BarrCod.Text);
                nGrabados = objNegBarrio.abmBarrios("Borrar", NuevoBarrio);
                LLenarDGVBarrios();
                txt_BarrCod.Text = "";

            }
        }
        private void LimpiarBarrios()
        {
            txt_BarrCod.Text = string.Empty;
            txt_BarrNombre.Text = string.Empty;
            txt_ProvCod.Text = string.Empty;    
        }


    }
}
