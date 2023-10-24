using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace IEFIPrgII
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
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

        private void btn_CargarSocio_Click(object sender, EventArgs e)
        {
            Socio NuevoSocio = new Socio(txt_SocioCod.Text,txt_NombreSoc.Text,txt_ApellidoSoc.Text, char.Parse(cmbBox_Sexo.Text),
                                        txt_DomicilioSoc.Text, cmbbox_BarrCod.Text, decimal.Parse(txt_MontoMes.Text),
                                        DateTimePick_FecAlt.Value, DateTimePick_FecBaj.Value, char.Parse(cmbBox_Activo.Text));

            MessageBox.Show("Socio Instanciado");
        }
    }
}
