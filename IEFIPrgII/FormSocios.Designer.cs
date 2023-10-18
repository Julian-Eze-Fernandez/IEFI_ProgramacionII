﻿namespace IEFIPrgII
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagSocios = new System.Windows.Forms.TabPage();
            this.PagBarrios = new System.Windows.Forms.TabPage();
            this.PagProvincias = new System.Windows.Forms.TabPage();
            this.PagSexos = new System.Windows.Forms.TabPage();
            this.PagCuotas = new System.Windows.Forms.TabPage();
            this.dgv_Socios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NombreSoc = new System.Windows.Forms.TextBox();
            this.txt_ApellidoSoc = new System.Windows.Forms.TextBox();
            this.txt_DomicilioSoc = new System.Windows.Forms.TextBox();
            this.cmbBox_Sexo = new System.Windows.Forms.ComboBox();
            this.txt_BarrioSoc = new System.Windows.Forms.TextBox();
            this.txt_MontoMes = new System.Windows.Forms.TextBox();
            this.txt_FechaAlta = new System.Windows.Forms.TextBox();
            this.txt_FechaBaja = new System.Windows.Forms.TextBox();
            this.cmbBox_Activo = new System.Windows.Forms.ComboBox();
            this.btn_CargarSocio = new System.Windows.Forms.Button();
            this.btn_ModificarSocio = new System.Windows.Forms.Button();
            this.btn_BorrarSocio = new System.Windows.Forms.Button();
            this.dgv_CuotasSociales = new System.Windows.Forms.DataGridView();
            this.txt_SocioCod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Anio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBox_Mes = new System.Windows.Forms.ComboBox();
            this.txt_MontoCuota = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBox_Pagada = new System.Windows.Forms.ComboBox();
            this.btn_BorrarCuota = new System.Windows.Forms.Button();
            this.btn_ModificarCuota = new System.Windows.Forms.Button();
            this.btn_CargarCuota = new System.Windows.Forms.Button();
            this.dgv_Barrios = new System.Windows.Forms.DataGridView();
            this.txt_BarrCod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_BarrNombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_ProvCod = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_BorrarBarrios = new System.Windows.Forms.Button();
            this.btn_ModificarBarrios = new System.Windows.Forms.Button();
            this.btn_CargarBarrios = new System.Windows.Forms.Button();
            this.btn_BorrarProvincias = new System.Windows.Forms.Button();
            this.btn_ModificarProvincias = new System.Windows.Forms.Button();
            this.btn_CargarProvincias = new System.Windows.Forms.Button();
            this.dgv_Provincias = new System.Windows.Forms.DataGridView();
            this.txt_CodProv = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_ProvNombre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_BorrarSexos = new System.Windows.Forms.Button();
            this.btn_ModificarSexos = new System.Windows.Forms.Button();
            this.btn_CargarSexos = new System.Windows.Forms.Button();
            this.dgv_Sexos = new System.Windows.Forms.DataGridView();
            this.txt_CodigoSexo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_Sexo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PagSocios.SuspendLayout();
            this.PagBarrios.SuspendLayout();
            this.PagProvincias.SuspendLayout();
            this.PagSexos.SuspendLayout();
            this.PagCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuotasSociales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Barrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sexos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagSocios);
            this.tabControl1.Controls.Add(this.PagCuotas);
            this.tabControl1.Controls.Add(this.PagBarrios);
            this.tabControl1.Controls.Add(this.PagProvincias);
            this.tabControl1.Controls.Add(this.PagSexos);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // PagSocios
            // 
            this.PagSocios.Controls.Add(this.btn_BorrarSocio);
            this.PagSocios.Controls.Add(this.btn_ModificarSocio);
            this.PagSocios.Controls.Add(this.btn_CargarSocio);
            this.PagSocios.Controls.Add(this.cmbBox_Activo);
            this.PagSocios.Controls.Add(this.txt_FechaBaja);
            this.PagSocios.Controls.Add(this.txt_FechaAlta);
            this.PagSocios.Controls.Add(this.txt_MontoMes);
            this.PagSocios.Controls.Add(this.txt_BarrioSoc);
            this.PagSocios.Controls.Add(this.cmbBox_Sexo);
            this.PagSocios.Controls.Add(this.txt_DomicilioSoc);
            this.PagSocios.Controls.Add(this.txt_ApellidoSoc);
            this.PagSocios.Controls.Add(this.txt_NombreSoc);
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
            // PagBarrios
            // 
            this.PagBarrios.Controls.Add(this.btn_BorrarBarrios);
            this.PagBarrios.Controls.Add(this.btn_ModificarBarrios);
            this.PagBarrios.Controls.Add(this.btn_CargarBarrios);
            this.PagBarrios.Controls.Add(this.txt_ProvCod);
            this.PagBarrios.Controls.Add(this.label17);
            this.PagBarrios.Controls.Add(this.txt_BarrNombre);
            this.PagBarrios.Controls.Add(this.label16);
            this.PagBarrios.Controls.Add(this.txt_BarrCod);
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
            // PagProvincias
            // 
            this.PagProvincias.Controls.Add(this.txt_ProvNombre);
            this.PagProvincias.Controls.Add(this.label19);
            this.PagProvincias.Controls.Add(this.txt_CodProv);
            this.PagProvincias.Controls.Add(this.label18);
            this.PagProvincias.Controls.Add(this.dgv_Provincias);
            this.PagProvincias.Controls.Add(this.btn_BorrarProvincias);
            this.PagProvincias.Controls.Add(this.btn_ModificarProvincias);
            this.PagProvincias.Controls.Add(this.btn_CargarProvincias);
            this.PagProvincias.Location = new System.Drawing.Point(4, 22);
            this.PagProvincias.Name = "PagProvincias";
            this.PagProvincias.Size = new System.Drawing.Size(768, 400);
            this.PagProvincias.TabIndex = 2;
            this.PagProvincias.Text = "Provincias";
            this.PagProvincias.UseVisualStyleBackColor = true;
            // 
            // PagSexos
            // 
            this.PagSexos.Controls.Add(this.txt_Sexo);
            this.PagSexos.Controls.Add(this.label21);
            this.PagSexos.Controls.Add(this.txt_CodigoSexo);
            this.PagSexos.Controls.Add(this.label20);
            this.PagSexos.Controls.Add(this.dgv_Sexos);
            this.PagSexos.Controls.Add(this.btn_BorrarSexos);
            this.PagSexos.Controls.Add(this.btn_ModificarSexos);
            this.PagSexos.Controls.Add(this.btn_CargarSexos);
            this.PagSexos.Location = new System.Drawing.Point(4, 22);
            this.PagSexos.Name = "PagSexos";
            this.PagSexos.Size = new System.Drawing.Size(768, 400);
            this.PagSexos.TabIndex = 3;
            this.PagSexos.Text = "Sexos";
            this.PagSexos.UseVisualStyleBackColor = true;
            // 
            // PagCuotas
            // 
            this.PagCuotas.Controls.Add(this.btn_BorrarCuota);
            this.PagCuotas.Controls.Add(this.btn_ModificarCuota);
            this.PagCuotas.Controls.Add(this.btn_CargarCuota);
            this.PagCuotas.Controls.Add(this.cmbBox_Pagada);
            this.PagCuotas.Controls.Add(this.label14);
            this.PagCuotas.Controls.Add(this.txt_MontoCuota);
            this.PagCuotas.Controls.Add(this.label13);
            this.PagCuotas.Controls.Add(this.cmbBox_Mes);
            this.PagCuotas.Controls.Add(this.label12);
            this.PagCuotas.Controls.Add(this.txt_Anio);
            this.PagCuotas.Controls.Add(this.label11);
            this.PagCuotas.Controls.Add(this.txt_SocioCod);
            this.PagCuotas.Controls.Add(this.label10);
            this.PagCuotas.Controls.Add(this.dgv_CuotasSociales);
            this.PagCuotas.Location = new System.Drawing.Point(4, 22);
            this.PagCuotas.Name = "PagCuotas";
            this.PagCuotas.Size = new System.Drawing.Size(768, 400);
            this.PagCuotas.TabIndex = 4;
            this.PagCuotas.Text = "Cuotas_Sociales";
            this.PagCuotas.UseVisualStyleBackColor = true;
            // 
            // dgv_Socios
            // 
            this.dgv_Socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Socios.Location = new System.Drawing.Point(7, 178);
            this.dgv_Socios.Name = "dgv_Socios";
            this.dgv_Socios.Size = new System.Drawing.Size(756, 217);
            this.dgv_Socios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " Sexo_Cod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Domicilio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = " Barr_Cod:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = " Monto_Mes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = " Fecha_Alta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = " Fecha_Baja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = " Activo";
            // 
            // txt_NombreSoc
            // 
            this.txt_NombreSoc.Location = new System.Drawing.Point(18, 33);
            this.txt_NombreSoc.Name = "txt_NombreSoc";
            this.txt_NombreSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreSoc.TabIndex = 10;
            // 
            // txt_ApellidoSoc
            // 
            this.txt_ApellidoSoc.Location = new System.Drawing.Point(18, 80);
            this.txt_ApellidoSoc.Name = "txt_ApellidoSoc";
            this.txt_ApellidoSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoSoc.TabIndex = 11;
            // 
            // txt_DomicilioSoc
            // 
            this.txt_DomicilioSoc.Location = new System.Drawing.Point(18, 125);
            this.txt_DomicilioSoc.Name = "txt_DomicilioSoc";
            this.txt_DomicilioSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_DomicilioSoc.TabIndex = 12;
            // 
            // cmbBox_Sexo
            // 
            this.cmbBox_Sexo.FormattingEnabled = true;
            this.cmbBox_Sexo.Location = new System.Drawing.Point(162, 33);
            this.cmbBox_Sexo.Name = "cmbBox_Sexo";
            this.cmbBox_Sexo.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Sexo.TabIndex = 13;
            // 
            // txt_BarrioSoc
            // 
            this.txt_BarrioSoc.Location = new System.Drawing.Point(162, 80);
            this.txt_BarrioSoc.Name = "txt_BarrioSoc";
            this.txt_BarrioSoc.Size = new System.Drawing.Size(100, 20);
            this.txt_BarrioSoc.TabIndex = 14;
            // 
            // txt_MontoMes
            // 
            this.txt_MontoMes.Location = new System.Drawing.Point(162, 125);
            this.txt_MontoMes.Name = "txt_MontoMes";
            this.txt_MontoMes.Size = new System.Drawing.Size(100, 20);
            this.txt_MontoMes.TabIndex = 15;
            // 
            // txt_FechaAlta
            // 
            this.txt_FechaAlta.Location = new System.Drawing.Point(310, 34);
            this.txt_FechaAlta.Name = "txt_FechaAlta";
            this.txt_FechaAlta.Size = new System.Drawing.Size(100, 20);
            this.txt_FechaAlta.TabIndex = 16;
            // 
            // txt_FechaBaja
            // 
            this.txt_FechaBaja.Location = new System.Drawing.Point(310, 80);
            this.txt_FechaBaja.Name = "txt_FechaBaja";
            this.txt_FechaBaja.Size = new System.Drawing.Size(100, 20);
            this.txt_FechaBaja.TabIndex = 17;
            // 
            // cmbBox_Activo
            // 
            this.cmbBox_Activo.FormattingEnabled = true;
            this.cmbBox_Activo.Location = new System.Drawing.Point(310, 124);
            this.cmbBox_Activo.Name = "cmbBox_Activo";
            this.cmbBox_Activo.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Activo.TabIndex = 18;
            // 
            // btn_CargarSocio
            // 
            this.btn_CargarSocio.Location = new System.Drawing.Point(467, 34);
            this.btn_CargarSocio.Name = "btn_CargarSocio";
            this.btn_CargarSocio.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarSocio.TabIndex = 19;
            this.btn_CargarSocio.Text = "Cargar";
            this.btn_CargarSocio.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarSocio
            // 
            this.btn_ModificarSocio.Location = new System.Drawing.Point(467, 77);
            this.btn_ModificarSocio.Name = "btn_ModificarSocio";
            this.btn_ModificarSocio.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarSocio.TabIndex = 20;
            this.btn_ModificarSocio.Text = "Modificar";
            this.btn_ModificarSocio.UseVisualStyleBackColor = true;
            // 
            // btn_BorrarSocio
            // 
            this.btn_BorrarSocio.Location = new System.Drawing.Point(467, 122);
            this.btn_BorrarSocio.Name = "btn_BorrarSocio";
            this.btn_BorrarSocio.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarSocio.TabIndex = 21;
            this.btn_BorrarSocio.Text = "Borrar";
            this.btn_BorrarSocio.UseVisualStyleBackColor = true;
            // 
            // dgv_CuotasSociales
            // 
            this.dgv_CuotasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CuotasSociales.Location = new System.Drawing.Point(9, 209);
            this.dgv_CuotasSociales.Name = "dgv_CuotasSociales";
            this.dgv_CuotasSociales.Size = new System.Drawing.Size(762, 188);
            this.dgv_CuotasSociales.TabIndex = 0;
            // 
            // txt_SocioCod
            // 
            this.txt_SocioCod.Location = new System.Drawing.Point(21, 30);
            this.txt_SocioCod.Name = "txt_SocioCod";
            this.txt_SocioCod.Size = new System.Drawing.Size(100, 20);
            this.txt_SocioCod.TabIndex = 12;
            this.txt_SocioCod.Text = " ";
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
            // txt_Anio
            // 
            this.txt_Anio.Location = new System.Drawing.Point(21, 78);
            this.txt_Anio.Name = "txt_Anio";
            this.txt_Anio.Size = new System.Drawing.Size(100, 20);
            this.txt_Anio.TabIndex = 14;
            this.txt_Anio.Text = " ";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Mes:";
            // 
            // cmbBox_Mes
            // 
            this.cmbBox_Mes.FormattingEnabled = true;
            this.cmbBox_Mes.Location = new System.Drawing.Point(21, 129);
            this.cmbBox_Mes.Name = "cmbBox_Mes";
            this.cmbBox_Mes.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Mes.TabIndex = 17;
            // 
            // txt_MontoCuota
            // 
            this.txt_MontoCuota.Location = new System.Drawing.Point(168, 30);
            this.txt_MontoCuota.Name = "txt_MontoCuota";
            this.txt_MontoCuota.Size = new System.Drawing.Size(100, 20);
            this.txt_MontoCuota.TabIndex = 19;
            this.txt_MontoCuota.Text = " ";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Pagada:";
            // 
            // cmbBox_Pagada
            // 
            this.cmbBox_Pagada.FormattingEnabled = true;
            this.cmbBox_Pagada.Location = new System.Drawing.Point(168, 77);
            this.cmbBox_Pagada.Name = "cmbBox_Pagada";
            this.cmbBox_Pagada.Size = new System.Drawing.Size(100, 21);
            this.cmbBox_Pagada.TabIndex = 21;
            // 
            // btn_BorrarCuota
            // 
            this.btn_BorrarCuota.Location = new System.Drawing.Point(329, 118);
            this.btn_BorrarCuota.Name = "btn_BorrarCuota";
            this.btn_BorrarCuota.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarCuota.TabIndex = 24;
            this.btn_BorrarCuota.Text = "Borrar";
            this.btn_BorrarCuota.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarCuota
            // 
            this.btn_ModificarCuota.Location = new System.Drawing.Point(329, 73);
            this.btn_ModificarCuota.Name = "btn_ModificarCuota";
            this.btn_ModificarCuota.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarCuota.TabIndex = 23;
            this.btn_ModificarCuota.Text = "Modificar";
            this.btn_ModificarCuota.UseVisualStyleBackColor = true;
            // 
            // btn_CargarCuota
            // 
            this.btn_CargarCuota.Location = new System.Drawing.Point(329, 30);
            this.btn_CargarCuota.Name = "btn_CargarCuota";
            this.btn_CargarCuota.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarCuota.TabIndex = 22;
            this.btn_CargarCuota.Text = "Cargar";
            this.btn_CargarCuota.UseVisualStyleBackColor = true;
            // 
            // dgv_Barrios
            // 
            this.dgv_Barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Barrios.Location = new System.Drawing.Point(6, 244);
            this.dgv_Barrios.Name = "dgv_Barrios";
            this.dgv_Barrios.Size = new System.Drawing.Size(756, 150);
            this.dgv_Barrios.TabIndex = 0;
            // 
            // txt_BarrCod
            // 
            this.txt_BarrCod.Location = new System.Drawing.Point(23, 35);
            this.txt_BarrCod.Name = "txt_BarrCod";
            this.txt_BarrCod.Size = new System.Drawing.Size(100, 20);
            this.txt_BarrCod.TabIndex = 14;
            this.txt_BarrCod.Text = " ";
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
            // txt_BarrNombre
            // 
            this.txt_BarrNombre.Location = new System.Drawing.Point(23, 81);
            this.txt_BarrNombre.Name = "txt_BarrNombre";
            this.txt_BarrNombre.Size = new System.Drawing.Size(100, 20);
            this.txt_BarrNombre.TabIndex = 16;
            this.txt_BarrNombre.Text = " ";
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
            // txt_ProvCod
            // 
            this.txt_ProvCod.Location = new System.Drawing.Point(23, 131);
            this.txt_ProvCod.Name = "txt_ProvCod";
            this.txt_ProvCod.Size = new System.Drawing.Size(100, 20);
            this.txt_ProvCod.TabIndex = 18;
            this.txt_ProvCod.Text = " ";
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
            // btn_BorrarBarrios
            // 
            this.btn_BorrarBarrios.Location = new System.Drawing.Point(173, 123);
            this.btn_BorrarBarrios.Name = "btn_BorrarBarrios";
            this.btn_BorrarBarrios.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarBarrios.TabIndex = 27;
            this.btn_BorrarBarrios.Text = "Borrar";
            this.btn_BorrarBarrios.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarBarrios
            // 
            this.btn_ModificarBarrios.Location = new System.Drawing.Point(173, 78);
            this.btn_ModificarBarrios.Name = "btn_ModificarBarrios";
            this.btn_ModificarBarrios.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarBarrios.TabIndex = 26;
            this.btn_ModificarBarrios.Text = "Modificar";
            this.btn_ModificarBarrios.UseVisualStyleBackColor = true;
            // 
            // btn_CargarBarrios
            // 
            this.btn_CargarBarrios.Location = new System.Drawing.Point(173, 35);
            this.btn_CargarBarrios.Name = "btn_CargarBarrios";
            this.btn_CargarBarrios.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarBarrios.TabIndex = 25;
            this.btn_CargarBarrios.Text = "Cargar";
            this.btn_CargarBarrios.UseVisualStyleBackColor = true;
            // 
            // btn_BorrarProvincias
            // 
            this.btn_BorrarProvincias.Location = new System.Drawing.Point(156, 102);
            this.btn_BorrarProvincias.Name = "btn_BorrarProvincias";
            this.btn_BorrarProvincias.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarProvincias.TabIndex = 27;
            this.btn_BorrarProvincias.Text = "Borrar";
            this.btn_BorrarProvincias.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarProvincias
            // 
            this.btn_ModificarProvincias.Location = new System.Drawing.Point(156, 57);
            this.btn_ModificarProvincias.Name = "btn_ModificarProvincias";
            this.btn_ModificarProvincias.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarProvincias.TabIndex = 26;
            this.btn_ModificarProvincias.Text = "Modificar";
            this.btn_ModificarProvincias.UseVisualStyleBackColor = true;
            // 
            // btn_CargarProvincias
            // 
            this.btn_CargarProvincias.Location = new System.Drawing.Point(156, 14);
            this.btn_CargarProvincias.Name = "btn_CargarProvincias";
            this.btn_CargarProvincias.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarProvincias.TabIndex = 25;
            this.btn_CargarProvincias.Text = "Cargar";
            this.btn_CargarProvincias.UseVisualStyleBackColor = true;
            // 
            // dgv_Provincias
            // 
            this.dgv_Provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Provincias.Location = new System.Drawing.Point(3, 208);
            this.dgv_Provincias.Name = "dgv_Provincias";
            this.dgv_Provincias.Size = new System.Drawing.Size(762, 185);
            this.dgv_Provincias.TabIndex = 28;
            // 
            // txt_CodProv
            // 
            this.txt_CodProv.Location = new System.Drawing.Point(19, 30);
            this.txt_CodProv.Name = "txt_CodProv";
            this.txt_CodProv.Size = new System.Drawing.Size(100, 20);
            this.txt_CodProv.TabIndex = 30;
            this.txt_CodProv.Text = " ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Prov_Cod:";
            // 
            // txt_ProvNombre
            // 
            this.txt_ProvNombre.Location = new System.Drawing.Point(19, 78);
            this.txt_ProvNombre.Name = "txt_ProvNombre";
            this.txt_ProvNombre.Size = new System.Drawing.Size(100, 20);
            this.txt_ProvNombre.TabIndex = 32;
            this.txt_ProvNombre.Text = " ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Prov_Nombre:";
            // 
            // btn_BorrarSexos
            // 
            this.btn_BorrarSexos.Location = new System.Drawing.Point(306, 118);
            this.btn_BorrarSexos.Name = "btn_BorrarSexos";
            this.btn_BorrarSexos.Size = new System.Drawing.Size(75, 23);
            this.btn_BorrarSexos.TabIndex = 30;
            this.btn_BorrarSexos.Text = "Borrar";
            this.btn_BorrarSexos.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarSexos
            // 
            this.btn_ModificarSexos.Location = new System.Drawing.Point(306, 73);
            this.btn_ModificarSexos.Name = "btn_ModificarSexos";
            this.btn_ModificarSexos.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarSexos.TabIndex = 29;
            this.btn_ModificarSexos.Text = "Modificar";
            this.btn_ModificarSexos.UseVisualStyleBackColor = true;
            // 
            // btn_CargarSexos
            // 
            this.btn_CargarSexos.Location = new System.Drawing.Point(306, 30);
            this.btn_CargarSexos.Name = "btn_CargarSexos";
            this.btn_CargarSexos.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarSexos.TabIndex = 28;
            this.btn_CargarSexos.Text = "Cargar";
            this.btn_CargarSexos.UseVisualStyleBackColor = true;
            // 
            // dgv_Sexos
            // 
            this.dgv_Sexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sexos.Location = new System.Drawing.Point(3, 209);
            this.dgv_Sexos.Name = "dgv_Sexos";
            this.dgv_Sexos.Size = new System.Drawing.Size(762, 188);
            this.dgv_Sexos.TabIndex = 31;
            // 
            // txt_CodigoSexo
            // 
            this.txt_CodigoSexo.Location = new System.Drawing.Point(25, 42);
            this.txt_CodigoSexo.Name = "txt_CodigoSexo";
            this.txt_CodigoSexo.Size = new System.Drawing.Size(100, 20);
            this.txt_CodigoSexo.TabIndex = 34;
            this.txt_CodigoSexo.Text = " ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Sexo_cod:";
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.Location = new System.Drawing.Point(25, 88);
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Size = new System.Drawing.Size(100, 20);
            this.txt_Sexo.TabIndex = 36;
            this.txt_Sexo.Text = " ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Sexo:";
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSocios";
            this.Text = "FormSocios";
            this.tabControl1.ResumeLayout(false);
            this.PagSocios.ResumeLayout(false);
            this.PagSocios.PerformLayout();
            this.PagBarrios.ResumeLayout(false);
            this.PagBarrios.PerformLayout();
            this.PagProvincias.ResumeLayout(false);
            this.PagProvincias.PerformLayout();
            this.PagSexos.ResumeLayout(false);
            this.PagSexos.PerformLayout();
            this.PagCuotas.ResumeLayout(false);
            this.PagCuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Socios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuotasSociales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Barrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sexos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagSocios;
        private System.Windows.Forms.TabPage PagCuotas;
        private System.Windows.Forms.TabPage PagBarrios;
        private System.Windows.Forms.TabPage PagProvincias;
        private System.Windows.Forms.TabPage PagSexos;
        private System.Windows.Forms.TextBox txt_NombreSoc;
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
        private System.Windows.Forms.TextBox txt_ApellidoSoc;
        private System.Windows.Forms.Button btn_CargarSocio;
        private System.Windows.Forms.ComboBox cmbBox_Activo;
        private System.Windows.Forms.TextBox txt_FechaBaja;
        private System.Windows.Forms.TextBox txt_FechaAlta;
        private System.Windows.Forms.TextBox txt_MontoMes;
        private System.Windows.Forms.TextBox txt_BarrioSoc;
        private System.Windows.Forms.ComboBox cmbBox_Sexo;
        private System.Windows.Forms.TextBox txt_DomicilioSoc;
        private System.Windows.Forms.Button btn_BorrarSocio;
        private System.Windows.Forms.Button btn_ModificarSocio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_MontoCuota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBox_Mes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Anio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SocioCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_CuotasSociales;
        private System.Windows.Forms.Button btn_BorrarCuota;
        private System.Windows.Forms.Button btn_ModificarCuota;
        private System.Windows.Forms.Button btn_CargarCuota;
        private System.Windows.Forms.ComboBox cmbBox_Pagada;
        private System.Windows.Forms.DataGridView dgv_Barrios;
        private System.Windows.Forms.TextBox txt_BarrCod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_BarrNombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_BorrarBarrios;
        private System.Windows.Forms.Button btn_ModificarBarrios;
        private System.Windows.Forms.Button btn_CargarBarrios;
        private System.Windows.Forms.TextBox txt_ProvCod;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgv_Provincias;
        private System.Windows.Forms.Button btn_BorrarProvincias;
        private System.Windows.Forms.Button btn_ModificarProvincias;
        private System.Windows.Forms.Button btn_CargarProvincias;
        private System.Windows.Forms.TextBox txt_ProvNombre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_CodProv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_BorrarSexos;
        private System.Windows.Forms.Button btn_ModificarSexos;
        private System.Windows.Forms.Button btn_CargarSexos;
        private System.Windows.Forms.TextBox txt_Sexo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_CodigoSexo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgv_Sexos;
    }
}