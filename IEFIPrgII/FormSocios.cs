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
using System.Xml.Linq;
using CapaNegocio;
using Entity;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace IEFIPrgII
{
    public partial class FormSocios : Form
    {
        NegSocio objNegSocio = new NegSocio();
        NegCuotaSocial objNegCuotaSocial = new NegCuotaSocial();
        NegBarrio objNegBarrio = new NegBarrio();
        NegProvincia objProvincia = new NegProvincia();

        public FormSocios()
        {
            InitializeComponent();
            CrearDGVS();
            LLenarDGVSocios();
            LLenarDGVCuotasSociales();
            LLenarDGVBarrios();
            LLenarDGVProvincias();
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

            // Data Grid View PROVINCIAS
            dgv_Provincias.Columns.Add("0", "Codigo");
            dgv_Provincias.Columns.Add("1", "Nombre");

            dgv_Provincias.Columns[0].Width = 100;
            dgv_Provincias.Columns[1].Width = 100;

        }
        void LlenarCombos()
        { //llena un combo desde una lista con descripcion y código
            cmbbox_BarrCod.DataSource = objNegBarrio.ObtenerBarrios(); // se define el origen con la Lista
            cmbbox_BarrCod.DisplayMember = "Barr_Cod";
            cmbbox_BarrCod.ValueMember = "Barr_Cod";

            cmbBox_Provincias.DataSource = objProvincia.ObtenerProvincias(); // se define el origen con la Lista
            cmbBox_Provincias.DisplayMember = "Prov_Cod";
            cmbBox_Provincias.ValueMember = "Prov_Cod";

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

            string codigoSocio = txt_Socio_SocioCod.Text;


            if (SociosCamposNoVacios() && MontoMesNoCaracteres())
            {
                if (objNegSocio.ExisteCodigoSocio(codigoSocio))
                {
                    MessageBox.Show(this, "El código de socio ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Socio NuevoSocio = new Socio(txt_Socio_SocioCod.Text, txt_NombreSoc.Text, txt_ApellidoSoc.Text, char.Parse(cmbBox_Sexo.Text),
                                txt_DomicilioSoc.Text, cmbbox_BarrCod.Text, decimal.Parse(txt_MontoMes.Text),
                                DateTimePick_FecAlt.Value, char.Parse(cmbBox_Activo.Text));


                    nGrabados = objNegSocio.abmSocios("Alta", NuevoSocio);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo grabar el socio en el sistema");
                    }
                    else
                    {
                        MessageBox.Show("Socio Instanciado");
                        LLenarDGVSocios();
                        LimpiarSocio();
                    }
                }
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
                MessageBox.Show("Se produjo un error al intentar modificar el socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_BorrarSocio_Click(object sender, EventArgs e)
        {
            string codigoSocio = txt_SocioBorrar.Text;

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el Socio numero " + txt_SocioBorrar.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Socio NuevoSocio = new Socio(txt_SocioBorrar.Text);

                if (!objNegSocio.ExisteCodigoSocio(txt_SocioBorrar.Text))
                {
                    MessageBox.Show(this, $"No existe el socio codigo {txt_SocioBorrar.Text}.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nGrabados = objNegSocio.abmSocios("Baja", NuevoSocio);
                    LLenarDGVSocios();
                    LimpiarSocio();
                    txt_SocioBorrar.Text = "";
                }



            }
            else if (resultado == DialogResult.No)
            {
                LimpiarSocio();
            }

        }
        private void LimpiarSocio()
        {
            txt_NombreSoc.Text = string.Empty;
            txt_ApellidoSoc.Text = string.Empty;
            txt_DomicilioSoc.Text = string.Empty;
            cmbBox_Sexo.SelectedIndex = -1;
            cmbbox_BarrCod.SelectedIndex = -1;
            txt_MontoMes.Text = string.Empty;
            cmbBox_Activo.SelectedIndex = -1;
            txt_Socio_SocioCod.Text = string.Empty;
            DateTimePick_FecAlt.Text = string.Empty;
            DateTimePick_FecBaj.Text = string.Empty;

        }
        private void btn_ReporteSocios_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Descargas|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgv_Socios, outputPath, " Socios ");
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
        private void dgv_Socios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Socio_SocioCod.Text = dgv_Socios.CurrentRow.Cells[0].Value.ToString();
            txt_NombreSoc.Text = dgv_Socios.CurrentRow.Cells[1].Value.ToString();
            txt_ApellidoSoc.Text = dgv_Socios.CurrentRow.Cells[2].Value.ToString();
            cmbBox_Sexo.Text = dgv_Socios.CurrentRow.Cells[3].Value.ToString();
            txt_DomicilioSoc.Text = dgv_Socios.CurrentRow.Cells[4].Value.ToString();
            cmbbox_BarrCod.Text = dgv_Socios.CurrentRow.Cells[5].Value.ToString();
            txt_MontoMes.Text = dgv_Socios.CurrentRow.Cells[6].Value.ToString();
            DateTimePick_FecAlt.Text = dgv_Socios.CurrentRow.Cells[7].Value.ToString();
            DateTimePick_FecBaj.Text = dgv_Socios.CurrentRow.Cells[8].Value.ToString();
            cmbBox_Activo.Text = dgv_Socios.CurrentRow.Cells[9].Value.ToString();
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

            if (CuotasCamposNoVacios() && MontoCuotaNoCaracteres())
            {
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
                    MessageBox.Show("El codigo del socio ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la cuota del socio numero " + txt_CuotaBorrar.Text + " del año " + txt_AnioBorrar.Text + " en el mes " + cmb_MesBorrar + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Cuota_Social NuevaCuotaSocial = new Cuota_Social(txt_CuotaBorrar.Text, txt_AnioBorrar.Text, cmb_MesBorrar.Text);
                nGrabados = objNegCuotaSocial.abmCuotas_Sociales("Borrar", NuevaCuotaSocial);
                LLenarDGVCuotasSociales();
                LimpiarCuota_Social();
                txt_CuotaBorrar.Text = "";

            }
        }
        private void LimpiarCuota_Social()
        {
            txt_Cuota_SocioCod.Text = string.Empty;
            txt_Anio.Text = string.Empty;
            cmbBox_Mes.SelectedIndex = -1;
            txt_MontoCuota.Text = string.Empty;
            cmbBox_Pagada.SelectedIndex = -1;
            txt_SocioBorrar.Text = string.Empty;
            txt_AnioBorrar.Text = string.Empty;
            cmbBox_Mes.SelectedIndex = -1;
        }
        private void btn_ReporteCuotas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgv_CuotasSociales, outputPath, " Cuotas ");
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
        private void dgv_CuotasSociales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Cuota_SocioCod.Text = dgv_CuotasSociales.CurrentRow.Cells[0].Value.ToString();
            txt_Anio.Text = dgv_CuotasSociales.CurrentRow.Cells[1].Value.ToString();
            cmbBox_Mes.Text = dgv_CuotasSociales.CurrentRow.Cells[2].Value.ToString();
            txt_MontoCuota.Text = dgv_CuotasSociales.CurrentRow.Cells[3].Value.ToString();
            cmbBox_Pagada.Text = dgv_CuotasSociales.CurrentRow.Cells[4].Value.ToString();
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


            int nGrabados = -1;

            if (BarriosCamposNoVacios())
            {

                Barrio NuevoBarrio = new Barrio(txt_BarrCod.Text, txt_BarrNombre.Text, char.Parse(cmbBox_Provincias.Text));


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
        }
        private void btn_ModificarBarrios_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            Barrio NuevoBarrio = new Barrio(txt_BarrCod.Text, txt_BarrNombre.Text, char.Parse(cmbBox_Provincias.Text));

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
                LimpiarBarrios();
                LLenarDGVBarrios();
                txt_BarrCod.Text = "";

            }
        }
        private void LimpiarBarrios()
        {
            txt_BarrCod.Text = string.Empty;
            txt_BarrNombre.Text = string.Empty;
            cmbBox_Provincias.SelectedIndex = -1;
        }
        private void btn_ReporteBarrios_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgv_Barrios, outputPath, " Barrios ");
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
        private void dgv_Barrios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_BarrCod.Text = dgv_Barrios.CurrentRow.Cells[0].Value.ToString();
            txt_BarrNombre.Text = dgv_Barrios.CurrentRow.Cells[1].Value.ToString();
            cmbBox_Provincias.Text = dgv_Barrios.CurrentRow.Cells[2].Value.ToString();
        }

        //Provincias
        private void LLenarDGVProvincias()
        {
            dgv_Provincias.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objProvincia.listadoProvincias("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgv_Provincias.Rows.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
            else
                MessageBox.Show("No hay Provincias cargadas en el sistema.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgv_Provincias, outputPath, " Provincias ");
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }

        //Reporte
        private void CrearReportePdf(DataGridView dataGridView, string outputPath, string titulo)
        {
            PdfWriter writer = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document doc = new Document(pdf);

            Paragraph title = new Paragraph(titulo);
            title.SetFontSize(16f).SetFontColor(ColorConstants.BLUE).SetTextAlignment(TextAlignment.CENTER);
            doc.Add(title);

            // Crea la tabla con las columnas que tenga el dataGridView
            iText.Layout.Element.Table pdfTable = new iText.Layout.Element.Table(dataGridView.Columns.Count);

            // Añade titulos
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                pdfTable.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }


            // Añade los datos del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Valida si es nulo
                    if (cell != null && cell.Value != null)
                    {
                        pdfTable.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                    }
                    else
                    {
                        // En caso de que sea null
                        pdfTable.AddCell(new Cell().Add(new Paragraph("")));
                    }
                }
            }

            pdfTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            // Añade la tabla al documento
            doc.Add(pdfTable);

            doc.Close();
        }

        //Validaciones
        private bool SociosCamposNoVacios()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = { txt_Socio_SocioCod, txt_NombreSoc, txt_ApellidoSoc, txt_DomicilioSoc, cmbbox_BarrCod, cmbBox_Sexo, cmbBox_Activo, txt_MontoMes };

            foreach (Control campo in campos)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show(this, "Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está vacío, la validación falla.
                    }
                }
                else if (campo is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Por favor, seleccione una opción en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está sin selección, la validación falla.
                    }
                }
            }

            return true; // Todos los campos están completos, la validación pasa.
        }
        private bool CuotasCamposNoVacios()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = { txt_Cuota_SocioCod, txt_Anio, cmbBox_Mes, txt_MontoCuota, cmbBox_Pagada };

            foreach (Control campo in campos)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show(this, "Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está vacío, la validación falla.
                    }
                }
                else if (campo is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Por favor, seleccione una opción en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está sin selección, la validación falla.
                    }
                }
            }

            return true; // Todos los campos están completos, la validación pasa.
        }
        private bool BarriosCamposNoVacios()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = { txt_BarrCod, txt_BarrNombre, cmbBox_Provincias };

            foreach (Control campo in campos)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show(this, "Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está vacío, la validación falla.
                    }
                }
                else if (campo is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Por favor, seleccione una opción en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está sin selección, la validación falla.
                    }
                }
            }

            return true; // Todos los campos están completos, la validación pasa.
        }
        private bool MontoMesNoCaracteres()
        {
            TextBox[] campos = { txt_MontoMes };

            foreach (TextBox campo in campos)
            {
                if (!EsNumero(campo.Text))
                {
                    //MessageBox.Show(this, "Por favor, numeros en el monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epv_MontoMes.SetError(txt_MontoMes, "No se aceptan caracteres en este campo.");
                    return false; // Devuelve false si al menos uno de los campos contiene caracteres no numéricos.
                }
            }

            return true; // Devuelve true si ambos campos solo contienen números.
        }
        private bool MontoCuotaNoCaracteres()
        {
            TextBox[] campos = { txt_MontoMes, txt_MontoCuota };

            foreach (TextBox campo in campos)
            {
                if (!EsNumero(campo.Text))
                {
                    //MessageBox.Show(this, "Por favor, numeros en el monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epv_MontoCuota.SetError(txt_MontoCuota, "No se aceptan caracteres en este campo.");
                    return false; // Devuelve false si al menos uno de los campos contiene caracteres no numéricos.
                }
            }

            return true; // Devuelve true si ambos campos solo contienen números.
        }
        private bool EsNumero(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter))
                {
                    return false; // Devuelve false si encuentra un carácter no numérico.
                }
            }

            return true; // Devuelve true si todos los caracteres son numéricos.
        }
        
    }
}
