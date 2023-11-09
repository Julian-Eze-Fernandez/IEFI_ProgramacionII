namespace IEFIPrgII
{
    partial class FormSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEFIPrgDataSet2 = new IEFIPrgII.IEFIPrgDataSet2();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEFIPrgDataSet1 = new IEFIPrgII.IEFIPrgDataSet1();
            this.sexosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEFIPrgDataSet = new IEFIPrgII.IEFIPrgDataSet();
            this.sexosTableAdapter = new IEFIPrgII.IEFIPrgDataSetTableAdapters.sexosTableAdapter();
            this.provinciasTableAdapter = new IEFIPrgII.IEFIPrgDataSet1TableAdapters.provinciasTableAdapter();
            this.barriosTableAdapter = new IEFIPrgII.IEFIPrgDataSet2TableAdapters.barriosTableAdapter();
            this.PagBarrios = new System.Windows.Forms.TabPage();
            this.btn_BorrarBarrios = new System.Windows.Forms.Button();
            this.btn_ModificarBarrios = new System.Windows.Forms.Button();
            this.btn_CargarBarrios = new System.Windows.Forms.Button();
            this.txt_BarrNombre = new System.Windows.Forms.TextBox();
            this.txt_BarrCod = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_Barrios = new System.Windows.Forms.DataGridView();
            this.PagCuotas = new System.Windows.Forms.TabPage();
            this.btn_BorrarCuota = new System.Windows.Forms.Button();
            this.btn_ModificarCuota = new System.Windows.Forms.Button();
            this.btn_CargarCuota = new System.Windows.Forms.Button();
            this.cmbBox_Pagada = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_MontoCuota = new System.Windows.Forms.TextBox();
            this.txt_Anio = new System.Windows.Forms.TextBox();
            this.txt_Cuota_SocioCod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBox_Mes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_CuotasSociales = new System.Windows.Forms.DataGridView();
            this.PagSocios = new System.Windows.Forms.TabPage();
            this.txt_Socio_SocioCod = new System.Windows.Forms.TextBox();
            this.txt_MontoMes = new System.Windows.Forms.TextBox();
            this.txt_DomicilioSoc = new System.Windows.Forms.TextBox();
            this.txt_ApellidoSoc = new System.Windows.Forms.TextBox();
            this.txt_NombreSoc = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DateTimePick_FecBaj = new System.Windows.Forms.DateTimePicker();
            this.DateTimePick_FecAlt = new System.Windows.Forms.DateTimePicker();
            this.cmbbox_BarrCod = new System.Windows.Forms.ComboBox();
            this.btn_BorrarSocio = new System.Windows.Forms.Button();
            this.btn_ModificarSocio = new System.Windows.Forms.Button();
            this.btn_CargarSocio = new System.Windows.Forms.Button();
            this.cmbBox_Activo = new System.Windows.Forms.ComboBox();
            this.cmbBox_Sexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Socios = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cmbBox_Provincias = new System.Windows.Forms.ComboBox();
            this.PagProvincias = new System.Windows.Forms.TabPage();
            this.dgv_Provincias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFIPrgDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFIPrgDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFIPrgDataSet)).BeginInit();
            this.PagBarrios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Barrios)).BeginInit();
            this.PagCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuotasSociales)).BeginInit();
            this.PagSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PagProvincias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataMember = "barrios";
            this.barriosBindingSource.DataSource = this.iEFIPrgDataSet2;
            // 
            // iEFIPrgDataSet2
            // 
            this.iEFIPrgDataSet2.DataSetName = "IEFIPrgDataSet2";
            this.iEFIPrgDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.iEFIPrgDataSet1;
            // 
            // iEFIPrgDataSet1
            // 
            this.iEFIPrgDataSet1.DataSetName = "IEFIPrgDataSet1";
            this.iEFIPrgDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexosBindingSource
            // 
            this.sexosBindingSource.DataMember = "sexos";
            this.sexosBindingSource.DataSource = this.iEFIPrgDataSet;
            // 
            // iEFIPrgDataSet
            // 
            this.iEFIPrgDataSet.DataSetName = "IEFIPrgDataSet";
            this.iEFIPrgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexosTableAdapter
            // 
            this.sexosTableAdapter.ClearBeforeFill = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // barriosTableAdapter
            // 
            this.barriosTableAdapter.ClearBeforeFill = true;
            // 
            // PagBarrios
            // 
            this.PagBarrios.Controls.Add(this.cmbBox_Provincias);
            this.PagBarrios.Controls.Add(this.btn_BorrarBarrios);
            this.PagBarrios.Controls.Add(this.btn_ModificarBarrios);
            this.PagBarrios.Controls.Add(this.btn_CargarBarrios);
            this.PagBarrios.Controls.Add(this.txt_BarrNombre);
            this.PagBarrios.Controls.Add(this.txt_BarrCod);
            this.PagBarrios.Controls.Add(this.label17);
            this.PagBarrios.Controls.Add(this.label16);
            this.PagBarrios.Controls.Add(this.label15);
            this.PagBarrios.Controls.Add(this.dgv_Barrios);
            this.PagBarrios.Location = new System.Drawing.Point(4, 22);
            this.PagBarrios.Name = "PagBarrios";
            this.PagBarrios.Padding = new System.Windows.Forms.Padding(3);
            this.PagBarrios.Size = new System.Drawing.Size(768, 400);
            this.PagBarrios.TabIndex = 1;
            this.PagBarrios.Text = "Barrios";
            this.PagBarrios.UseVisualStyleBackColor = true;
            // 
            // btn_BorrarBarrios
            // 
            this.btn_BorrarBarrios.Location = new System.Drawing.Point(173, 123);
            this.btn_BorrarBarrios.Name = "btn_BorrarBarrios";
            this.btn_BorrarBarrios.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarBarrios.TabIndex = 27;
            this.btn_BorrarBarrios.Text = "Borrar";
            this.btn_BorrarBarrios.UseVisualStyleBackColor = true;
            this.btn_BorrarBarrios.Click += new System.EventHandler(this.btn_BorrarBarrios_Click);
            // 
            // btn_ModificarBarrios
            // 
            this.btn_ModificarBarrios.Location = new System.Drawing.Point(173, 78);
            this.btn_ModificarBarrios.Name = "btn_ModificarBarrios";
            this.btn_ModificarBarrios.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarBarrios.TabIndex = 26;
            this.btn_ModificarBarrios.Text = "Modificar";
            this.btn_ModificarBarrios.UseVisualStyleBackColor = true;
            this.btn_ModificarBarrios.Click += new System.EventHandler(this.btn_ModificarBarrios_Click);
            // 
            // btn_CargarBarrios
            // 
            this.btn_CargarBarrios.Location = new System.Drawing.Point(173, 35);
            this.btn_CargarBarrios.Name = "btn_CargarBarrios";
            this.btn_CargarBarrios.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarBarrios.TabIndex = 25;
            this.btn_CargarBarrios.Text = "Cargar";
            this.btn_CargarBarrios.UseVisualStyleBackColor = true;
            this.btn_CargarBarrios.Click += new System.EventHandler(this.btn_CargarBarrios_Click);
            // 
            // txt_BarrNombre
            // 
            this.txt_BarrNombre.Location = new System.Drawing.Point(23, 81);
            this.txt_BarrNombre.Name = "txt_BarrNombre";
            this.txt_BarrNombre.Size = new System.Drawing.Size(100, 20);
            this.txt_BarrNombre.TabIndex = 16;
            this.txt_BarrNombre.Text = " ";
            // 
            // txt_BarrCod
            // 
            this.txt_BarrCod.Location = new System.Drawing.Point(23, 35);
            this.txt_BarrCod.Name = "txt_BarrCod";
            this.txt_BarrCod.Size = new System.Drawing.Size(100, 20);
            this.txt_BarrCod.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Prov_Cod:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Barr_Nombre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Barr_Cod:";
            // 
            // dgv_Barrios
            // 
            this.dgv_Barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Barrios.Location = new System.Drawing.Point(349, 6);
            this.dgv_Barrios.Name = "dgv_Barrios";
            this.dgv_Barrios.Size = new System.Drawing.Size(361, 388);
            this.dgv_Barrios.TabIndex = 0;
            // 
            // PagCuotas
            // 
            this.PagCuotas.Controls.Add(this.btn_BorrarCuota);
            this.PagCuotas.Controls.Add(this.btn_ModificarCuota);
            this.PagCuotas.Controls.Add(this.btn_CargarCuota);
            this.PagCuotas.Controls.Add(this.cmbBox_Pagada);
            this.PagCuotas.Controls.Add(this.label14);
            this.PagCuotas.Controls.Add(this.txt_MontoCuota);
            this.PagCuotas.Controls.Add(this.txt_Anio);
            this.PagCuotas.Controls.Add(this.txt_Cuota_SocioCod);
            this.PagCuotas.Controls.Add(this.label13);
            this.PagCuotas.Controls.Add(this.cmbBox_Mes);
            this.PagCuotas.Controls.Add(this.label12);
            this.PagCuotas.Controls.Add(this.label11);
            this.PagCuotas.Controls.Add(this.label10);
            this.PagCuotas.Controls.Add(this.dgv_CuotasSociales);
            this.PagCuotas.Location = new System.Drawing.Point(4, 22);
            this.PagCuotas.Name = "PagCuotas";
            this.PagCuotas.Size = new System.Drawing.Size(768, 400);
            this.PagCuotas.TabIndex = 4;
            this.PagCuotas.Text = "Cuotas_Sociales";
            this.PagCuotas.UseVisualStyleBackColor = true;
            // 
            // btn_BorrarCuota
            // 
            this.btn_BorrarCuota.Location = new System.Drawing.Point(329, 118);
            this.btn_BorrarCuota.Name = "btn_BorrarCuota";
            this.btn_BorrarCuota.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarCuota.TabIndex = 24;
            this.btn_BorrarCuota.Text = "Borrar";
            this.btn_BorrarCuota.UseVisualStyleBackColor = true;
            this.btn_BorrarCuota.Click += new System.EventHandler(this.btn_BorrarCuota_Click);
            // 
            // btn_ModificarCuota
            // 
            this.btn_ModificarCuota.Location = new System.Drawing.Point(329, 73);
            this.btn_ModificarCuota.Name = "btn_ModificarCuota";
            this.btn_ModificarCuota.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarCuota.TabIndex = 23;
            this.btn_ModificarCuota.Text = "Modificar";
            this.btn_ModificarCuota.UseVisualStyleBackColor = true;
            this.btn_ModificarCuota.Click += new System.EventHandler(this.btn_ModificarCuota_Click);
            // 
            // btn_CargarCuota
            // 
            this.btn_CargarCuota.Location = new System.Drawing.Point(329, 30);
            this.btn_CargarCuota.Name = "btn_CargarCuota";
            this.btn_CargarCuota.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarCuota.TabIndex = 22;
            this.btn_CargarCuota.Text = "Cargar";
            this.btn_CargarCuota.UseVisualStyleBackColor = true;
            this.btn_CargarCuota.Click += new System.EventHandler(this.btn_CargarCuota_Click);
            // 
            // cmbBox_Pagada
            // 
            this.cmbBox_Pagada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Pagada.FormattingEnabled = true;
            this.cmbBox_Pagada.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbBox_Pagada.Location = new System.Drawing.Point(168, 77);
            this.cmbBox_Pagada.Name = "cmbBox_Pagada";
            this.cmbBox_Pagada.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Pagada.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Pagada:";
            // 
            // txt_MontoCuota
            // 
            this.txt_MontoCuota.Location = new System.Drawing.Point(168, 30);
            this.txt_MontoCuota.Name = "txt_MontoCuota";
            this.txt_MontoCuota.Size = new System.Drawing.Size(100, 20);
            this.txt_MontoCuota.TabIndex = 19;
            // 
            // txt_Anio
            // 
            this.txt_Anio.Location = new System.Drawing.Point(21, 78);
            this.txt_Anio.Name = "txt_Anio";
            this.txt_Anio.Size = new System.Drawing.Size(100, 20);
            this.txt_Anio.TabIndex = 14;
            // 
            // txt_Cuota_SocioCod
            // 
            this.txt_Cuota_SocioCod.Location = new System.Drawing.Point(21, 30);
            this.txt_Cuota_SocioCod.Name = "txt_Cuota_SocioCod";
            this.txt_Cuota_SocioCod.Size = new System.Drawing.Size(100, 20);
            this.txt_Cuota_SocioCod.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Monto_Cuota:";
            // 
            // cmbBox_Mes
            // 
            this.cmbBox_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Mes.FormattingEnabled = true;
            this.cmbBox_Mes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbBox_Mes.Location = new System.Drawing.Point(21, 129);
            this.cmbBox_Mes.Name = "cmbBox_Mes";
            this.cmbBox_Mes.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Mes.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Mes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Año:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Socio_Cod:";
            // 
            // dgv_CuotasSociales
            // 
            this.dgv_CuotasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CuotasSociales.Location = new System.Drawing.Point(9, 209);
            this.dgv_CuotasSociales.Name = "dgv_CuotasSociales";
            this.dgv_CuotasSociales.Size = new System.Drawing.Size(560, 188);
            this.dgv_CuotasSociales.TabIndex = 0;
            // 
            // PagSocios
            // 
            this.PagSocios.Controls.Add(this.txt_Socio_SocioCod);
            this.PagSocios.Controls.Add(this.txt_MontoMes);
            this.PagSocios.Controls.Add(this.txt_DomicilioSoc);
            this.PagSocios.Controls.Add(this.txt_ApellidoSoc);
            this.PagSocios.Controls.Add(this.txt_NombreSoc);
            this.PagSocios.Controls.Add(this.label20);
            this.PagSocios.Controls.Add(this.DateTimePick_FecBaj);
            this.PagSocios.Controls.Add(this.DateTimePick_FecAlt);
            this.PagSocios.Controls.Add(this.cmbbox_BarrCod);
            this.PagSocios.Controls.Add(this.btn_BorrarSocio);
            this.PagSocios.Controls.Add(this.btn_ModificarSocio);
            this.PagSocios.Controls.Add(this.btn_CargarSocio);
            this.PagSocios.Controls.Add(this.cmbBox_Activo);
            this.PagSocios.Controls.Add(this.cmbBox_Sexo);
            this.PagSocios.Controls.Add(this.label9);
            this.PagSocios.Controls.Add(this.label8);
            this.PagSocios.Controls.Add(this.label7);
            this.PagSocios.Controls.Add(this.label6);
            this.PagSocios.Controls.Add(this.label5);
            this.PagSocios.Controls.Add(this.label4);
            this.PagSocios.Controls.Add(this.label3);
            this.PagSocios.Controls.Add(this.label2);
            this.PagSocios.Controls.Add(this.label1);
            this.PagSocios.Controls.Add(this.dgv_Socios);
            this.PagSocios.Location = new System.Drawing.Point(4, 22);
            this.PagSocios.Name = "PagSocios";
            this.PagSocios.Padding = new System.Windows.Forms.Padding(3);
            this.PagSocios.Size = new System.Drawing.Size(768, 400);
            this.PagSocios.TabIndex = 0;
            this.PagSocios.Text = "Socios";
            this.PagSocios.UseVisualStyleBackColor = true;
            // 
            // txt_Socio_SocioCod
            // 
            this.txt_Socio_SocioCod.Location = new System.Drawing.Point(7, 30);
            this.txt_Socio_SocioCod.Name = "txt_Socio_SocioCod";
            this.txt_Socio_SocioCod.Size = new System.Drawing.Size(100, 20);
            this.txt_Socio_SocioCod.TabIndex = 26;
            // 
            // txt_MontoMes
            // 
            this.txt_MontoMes.Location = new System.Drawing.Point(430, 34);
            this.txt_MontoMes.Name = "txt_MontoMes";
            this.txt_MontoMes.Size = new System.Drawing.Size(100, 20);
            this.txt_MontoMes.TabIndex = 15;
            // 
            // txt_DomicilioSoc
            // 
            this.txt_DomicilioSoc.Location = new System.Drawing.Point(152, 121);
            this.txt_DomicilioSoc.Name = "txt_DomicilioSoc";
            this.txt_DomicilioSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_DomicilioSoc.TabIndex = 12;
            // 
            // txt_ApellidoSoc
            // 
            this.txt_ApellidoSoc.Location = new System.Drawing.Point(7, 121);
            this.txt_ApellidoSoc.Name = "txt_ApellidoSoc";
            this.txt_ApellidoSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoSoc.TabIndex = 11;
            // 
            // txt_NombreSoc
            // 
            this.txt_NombreSoc.Location = new System.Drawing.Point(7, 74);
            this.txt_NombreSoc.Name = "txt_NombreSoc";
            this.txt_NombreSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreSoc.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Socio_Cod:";
            // 
            // DateTimePick_FecBaj
            // 
            this.DateTimePick_FecBaj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePick_FecBaj.Location = new System.Drawing.Point(431, 81);
            this.DateTimePick_FecBaj.Name = "DateTimePick_FecBaj";
            this.DateTimePick_FecBaj.Size = new System.Drawing.Size(99, 20);
            this.DateTimePick_FecBaj.TabIndex = 24;
            this.DateTimePick_FecBaj.Tag = "";
            this.DateTimePick_FecBaj.Value = new System.DateTime(2023, 11, 8, 22, 56, 32, 0);
            // 
            // DateTimePick_FecAlt
            // 
            this.DateTimePick_FecAlt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePick_FecAlt.Location = new System.Drawing.Point(296, 81);
            this.DateTimePick_FecAlt.Name = "DateTimePick_FecAlt";
            this.DateTimePick_FecAlt.Size = new System.Drawing.Size(99, 20);
            this.DateTimePick_FecAlt.TabIndex = 23;
            // 
            // cmbbox_BarrCod
            // 
            this.cmbbox_BarrCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_BarrCod.FormattingEnabled = true;
            this.cmbbox_BarrCod.Location = new System.Drawing.Point(152, 75);
            this.cmbbox_BarrCod.Name = "cmbbox_BarrCod";
            this.cmbbox_BarrCod.Size = new System.Drawing.Size(100, 21);
            this.cmbbox_BarrCod.TabIndex = 22;
            // 
            // btn_BorrarSocio
            // 
            this.btn_BorrarSocio.Location = new System.Drawing.Point(574, 115);
            this.btn_BorrarSocio.Name = "btn_BorrarSocio";
            this.btn_BorrarSocio.Size = new System.Drawing.Size(92, 42);
            this.btn_BorrarSocio.TabIndex = 21;
            this.btn_BorrarSocio.Text = "Borrar";
            this.btn_BorrarSocio.UseVisualStyleBackColor = true;
            this.btn_BorrarSocio.Click += new System.EventHandler(this.btn_BorrarSocio_Click);
            // 
            // btn_ModificarSocio
            // 
            this.btn_ModificarSocio.Location = new System.Drawing.Point(574, 66);
            this.btn_ModificarSocio.Name = "btn_ModificarSocio";
            this.btn_ModificarSocio.Size = new System.Drawing.Size(92, 43);
            this.btn_ModificarSocio.TabIndex = 20;
            this.btn_ModificarSocio.Text = "Modificar";
            this.btn_ModificarSocio.UseVisualStyleBackColor = true;
            this.btn_ModificarSocio.Click += new System.EventHandler(this.btn_ModificarSocio_Click);
            // 
            // btn_CargarSocio
            // 
            this.btn_CargarSocio.Location = new System.Drawing.Point(574, 19);
            this.btn_CargarSocio.Name = "btn_CargarSocio";
            this.btn_CargarSocio.Size = new System.Drawing.Size(92, 40);
            this.btn_CargarSocio.TabIndex = 19;
            this.btn_CargarSocio.Text = "Cargar";
            this.btn_CargarSocio.UseVisualStyleBackColor = true;
            this.btn_CargarSocio.Click += new System.EventHandler(this.btn_CargarSocio_Click);
            // 
            // cmbBox_Activo
            // 
            this.cmbBox_Activo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Activo.FormattingEnabled = true;
            this.cmbBox_Activo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbBox_Activo.Location = new System.Drawing.Point(296, 33);
            this.cmbBox_Activo.Name = "cmbBox_Activo";
            this.cmbBox_Activo.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Activo.TabIndex = 18;
            // 
            // cmbBox_Sexo
            // 
            this.cmbBox_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Sexo.FormattingEnabled = true;
            this.cmbBox_Sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbBox_Sexo.Location = new System.Drawing.Point(152, 29);
            this.cmbBox_Sexo.Name = "cmbBox_Sexo";
            this.cmbBox_Sexo.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Sexo.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = " Activo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = " Fecha_Baja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = " Fecha_Alta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = " Monto_Mes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = " Barr_Cod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Domicilio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " Sexo_Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // dgv_Socios
            // 
            this.dgv_Socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Socios.Location = new System.Drawing.Point(7, 178);
            this.dgv_Socios.Name = "dgv_Socios";
            this.dgv_Socios.Size = new System.Drawing.Size(756, 217);
            this.dgv_Socios.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagSocios);
            this.tabControl1.Controls.Add(this.PagCuotas);
            this.tabControl1.Controls.Add(this.PagBarrios);
            this.tabControl1.Controls.Add(this.PagProvincias);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // cmbBox_Provincias
            // 
            this.cmbBox_Provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Provincias.FormattingEnabled = true;
            this.cmbBox_Provincias.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbBox_Provincias.Location = new System.Drawing.Point(23, 131);
            this.cmbBox_Provincias.Name = "cmbBox_Provincias";
            this.cmbBox_Provincias.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Provincias.TabIndex = 28;
            // 
            // PagProvincias
            // 
            this.PagProvincias.Controls.Add(this.dgv_Provincias);
            this.PagProvincias.Location = new System.Drawing.Point(4, 22);
            this.PagProvincias.Name = "PagProvincias";
            this.PagProvincias.Padding = new System.Windows.Forms.Padding(3);
            this.PagProvincias.Size = new System.Drawing.Size(768, 400);
            this.PagProvincias.TabIndex = 5;
            this.PagProvincias.Text = "Provincias";
            this.PagProvincias.UseVisualStyleBackColor = true;
            // 
            // dgv_Provincias
            // 
            this.dgv_Provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Provincias.Location = new System.Drawing.Point(0, 6);
            this.dgv_Provincias.Name = "dgv_Provincias";
            this.dgv_Provincias.Size = new System.Drawing.Size(263, 388);
            this.dgv_Provincias.TabIndex = 1;
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSocios";
            this.Text = "FormSocios";
            this.Load += new System.EventHandler(this.FormSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFIPrgDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFIPrgDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFIPrgDataSet)).EndInit();
            this.PagBarrios.ResumeLayout(false);
            this.PagBarrios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Barrios)).EndInit();
            this.PagCuotas.ResumeLayout(false);
            this.PagCuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuotasSociales)).EndInit();
            this.PagSocios.ResumeLayout(false);
            this.PagSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PagProvincias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IEFIPrgDataSet iEFIPrgDataSet;
        private System.Windows.Forms.BindingSource sexosBindingSource;
        private IEFIPrgDataSetTableAdapters.sexosTableAdapter sexosTableAdapter;
        private IEFIPrgDataSet1 iEFIPrgDataSet1;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private IEFIPrgDataSet1TableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private IEFIPrgDataSet2 iEFIPrgDataSet2;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private IEFIPrgDataSet2TableAdapters.barriosTableAdapter barriosTableAdapter;
        private System.Windows.Forms.TabPage PagBarrios;
        private System.Windows.Forms.Button btn_BorrarBarrios;
        private System.Windows.Forms.Button btn_ModificarBarrios;
        private System.Windows.Forms.Button btn_CargarBarrios;
        private System.Windows.Forms.TextBox txt_BarrNombre;
        private System.Windows.Forms.TextBox txt_BarrCod;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgv_Barrios;
        private System.Windows.Forms.TabPage PagCuotas;
        private System.Windows.Forms.Button btn_BorrarCuota;
        private System.Windows.Forms.Button btn_ModificarCuota;
        private System.Windows.Forms.Button btn_CargarCuota;
        private System.Windows.Forms.ComboBox cmbBox_Pagada;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_MontoCuota;
        private System.Windows.Forms.TextBox txt_Anio;
        private System.Windows.Forms.TextBox txt_Cuota_SocioCod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBox_Mes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_CuotasSociales;
        private System.Windows.Forms.TabPage PagSocios;
        private System.Windows.Forms.TextBox txt_Socio_SocioCod;
        private System.Windows.Forms.TextBox txt_MontoMes;
        private System.Windows.Forms.TextBox txt_DomicilioSoc;
        private System.Windows.Forms.TextBox txt_ApellidoSoc;
        private System.Windows.Forms.TextBox txt_NombreSoc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker DateTimePick_FecBaj;
        private System.Windows.Forms.DateTimePicker DateTimePick_FecAlt;
        private System.Windows.Forms.ComboBox cmbbox_BarrCod;
        private System.Windows.Forms.Button btn_BorrarSocio;
        private System.Windows.Forms.Button btn_ModificarSocio;
        private System.Windows.Forms.Button btn_CargarSocio;
        private System.Windows.Forms.ComboBox cmbBox_Activo;
        private System.Windows.Forms.ComboBox cmbBox_Sexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Socios;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cmbBox_Provincias;
        private System.Windows.Forms.TabPage PagProvincias;
        private System.Windows.Forms.DataGridView dgv_Provincias;
    }
}