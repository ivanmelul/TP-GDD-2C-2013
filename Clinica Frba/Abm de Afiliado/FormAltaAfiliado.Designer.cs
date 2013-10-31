namespace Clinica_Frba.ABM_Afiliado
{
    partial class FormAltaAfiliado
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
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.GbAfiliado = new System.Windows.Forms.GroupBox();
            this.BtnCleanAsociados = new System.Windows.Forms.Button();
            this.BtnAddAsociados = new System.Windows.Forms.Button();
            this.MskTxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.CmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.LblPlanMedico = new System.Windows.Forms.Label();
            this.TxtCantidadFamiliares = new System.Windows.Forms.MaskedTextBox();
            this.LblCantidadHijos = new System.Windows.Forms.Label();
            this.CmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.RdoFemenino = new System.Windows.Forms.RadioButton();
            this.RdoMasculino = new System.Windows.Forms.RadioButton();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.MskTxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GbAsociados = new System.Windows.Forms.GroupBox();
            this.BtnCleanFamiliares = new System.Windows.Forms.Button();
            this.BtnCleanFamiliar = new System.Windows.Forms.Button();
            this.BtnAddFamiliar = new System.Windows.Forms.Button();
            this.LstFamiliares = new System.Windows.Forms.ListBox();
            this.LblLstFamiliares = new System.Windows.Forms.Label();
            this.BtnCleanConyugue = new System.Windows.Forms.Button();
            this.BtnAddConyugue = new System.Windows.Forms.Button();
            this.TxtConyugue = new System.Windows.Forms.TextBox();
            this.LblConyugue = new System.Windows.Forms.Label();
            this.GbAfiliado.SuspendLayout();
            this.GbAsociados.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(282, 388);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 38);
            this.BtnClean.TabIndex = 23;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(201, 388);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 38);
            this.BtnCreate.TabIndex = 22;
            this.BtnCreate.Text = "Alta";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // GbAfiliado
            // 
            this.GbAfiliado.Controls.Add(this.BtnCleanAsociados);
            this.GbAfiliado.Controls.Add(this.BtnAddAsociados);
            this.GbAfiliado.Controls.Add(this.MskTxtTelefono);
            this.GbAfiliado.Controls.Add(this.CmbPlanMedico);
            this.GbAfiliado.Controls.Add(this.LblPlanMedico);
            this.GbAfiliado.Controls.Add(this.TxtCantidadFamiliares);
            this.GbAfiliado.Controls.Add(this.LblCantidadHijos);
            this.GbAfiliado.Controls.Add(this.CmbEstadoCivil);
            this.GbAfiliado.Controls.Add(this.LblEstadoCivil);
            this.GbAfiliado.Controls.Add(this.RdoFemenino);
            this.GbAfiliado.Controls.Add(this.RdoMasculino);
            this.GbAfiliado.Controls.Add(this.LblSexo);
            this.GbAfiliado.Controls.Add(this.LblFechaNacimiento);
            this.GbAfiliado.Controls.Add(this.DtpFechaNacimiento);
            this.GbAfiliado.Controls.Add(this.TxtDireccion);
            this.GbAfiliado.Controls.Add(this.MskTxtNumero);
            this.GbAfiliado.Controls.Add(this.TxtApellido);
            this.GbAfiliado.Controls.Add(this.TxtNombre);
            this.GbAfiliado.Controls.Add(this.LblTelefono);
            this.GbAfiliado.Controls.Add(this.LblDireccion);
            this.GbAfiliado.Controls.Add(this.LblNumero);
            this.GbAfiliado.Controls.Add(this.CmbTipo);
            this.GbAfiliado.Controls.Add(this.LblTipo);
            this.GbAfiliado.Controls.Add(this.LblApellido);
            this.GbAfiliado.Controls.Add(this.LblNombre);
            this.GbAfiliado.Location = new System.Drawing.Point(12, 12);
            this.GbAfiliado.Name = "GbAfiliado";
            this.GbAfiliado.Size = new System.Drawing.Size(325, 364);
            this.GbAfiliado.TabIndex = 8;
            this.GbAfiliado.TabStop = false;
            this.GbAfiliado.Text = "Datos del Afiliado";
            // 
            // BtnCleanAsociados
            // 
            this.BtnCleanAsociados.Location = new System.Drawing.Point(168, 329);
            this.BtnCleanAsociados.Name = "BtnCleanAsociados";
            this.BtnCleanAsociados.Size = new System.Drawing.Size(111, 23);
            this.BtnCleanAsociados.TabIndex = 14;
            this.BtnCleanAsociados.Text = "Limpiar Asociados";
            this.BtnCleanAsociados.UseVisualStyleBackColor = true;
            this.BtnCleanAsociados.Click += new System.EventHandler(this.BtnCleanAsociados_Click);
            // 
            // BtnAddAsociados
            // 
            this.BtnAddAsociados.Location = new System.Drawing.Point(54, 330);
            this.BtnAddAsociados.Name = "BtnAddAsociados";
            this.BtnAddAsociados.Size = new System.Drawing.Size(111, 23);
            this.BtnAddAsociados.TabIndex = 13;
            this.BtnAddAsociados.Text = "Agregar Asociados";
            this.BtnAddAsociados.UseVisualStyleBackColor = true;
            this.BtnAddAsociados.Click += new System.EventHandler(this.BtnAddAsociados_Click);
            // 
            // MskTxtTelefono
            // 
            this.MskTxtTelefono.Enabled = false;
            this.MskTxtTelefono.Location = new System.Drawing.Point(146, 167);
            this.MskTxtTelefono.Mask = "9999-9999";
            this.MskTxtTelefono.Name = "MskTxtTelefono";
            this.MskTxtTelefono.Size = new System.Drawing.Size(146, 20);
            this.MskTxtTelefono.TabIndex = 6;
            this.MskTxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbPlanMedico
            // 
            this.CmbPlanMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlanMedico.FormattingEnabled = true;
            this.CmbPlanMedico.Location = new System.Drawing.Point(146, 299);
            this.CmbPlanMedico.Name = "CmbPlanMedico";
            this.CmbPlanMedico.Size = new System.Drawing.Size(146, 21);
            this.CmbPlanMedico.TabIndex = 12;
            // 
            // LblPlanMedico
            // 
            this.LblPlanMedico.AutoSize = true;
            this.LblPlanMedico.Location = new System.Drawing.Point(30, 302);
            this.LblPlanMedico.Name = "LblPlanMedico";
            this.LblPlanMedico.Size = new System.Drawing.Size(66, 13);
            this.LblPlanMedico.TabIndex = 24;
            this.LblPlanMedico.Text = "Plan Medico";
            // 
            // TxtCantidadFamiliares
            // 
            this.TxtCantidadFamiliares.Enabled = false;
            this.TxtCantidadFamiliares.Location = new System.Drawing.Point(146, 274);
            this.TxtCantidadFamiliares.Mask = "99";
            this.TxtCantidadFamiliares.Name = "TxtCantidadFamiliares";
            this.TxtCantidadFamiliares.Size = new System.Drawing.Size(146, 20);
            this.TxtCantidadFamiliares.TabIndex = 11;
            this.TxtCantidadFamiliares.Text = "0";
            this.TxtCantidadFamiliares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCantidadHijos
            // 
            this.LblCantidadHijos.AutoSize = true;
            this.LblCantidadHijos.Location = new System.Drawing.Point(30, 276);
            this.LblCantidadHijos.Name = "LblCantidadHijos";
            this.LblCantidadHijos.Size = new System.Drawing.Size(92, 13);
            this.LblCantidadHijos.TabIndex = 23;
            this.LblCantidadHijos.Text = "Familiares a cargo";
            // 
            // CmbEstadoCivil
            // 
            this.CmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoCivil.FormattingEnabled = true;
            this.CmbEstadoCivil.Location = new System.Drawing.Point(146, 245);
            this.CmbEstadoCivil.Name = "CmbEstadoCivil";
            this.CmbEstadoCivil.Size = new System.Drawing.Size(146, 21);
            this.CmbEstadoCivil.TabIndex = 10;
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.AutoSize = true;
            this.LblEstadoCivil.Location = new System.Drawing.Point(29, 250);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.LblEstadoCivil.TabIndex = 21;
            this.LblEstadoCivil.Text = "Estado Civil";
            // 
            // RdoFemenino
            // 
            this.RdoFemenino.AutoSize = true;
            this.RdoFemenino.Location = new System.Drawing.Point(223, 222);
            this.RdoFemenino.Name = "RdoFemenino";
            this.RdoFemenino.Size = new System.Drawing.Size(71, 17);
            this.RdoFemenino.TabIndex = 9;
            this.RdoFemenino.TabStop = true;
            this.RdoFemenino.Text = "Femenino";
            this.RdoFemenino.UseVisualStyleBackColor = true;
            // 
            // RdoMasculino
            // 
            this.RdoMasculino.AutoSize = true;
            this.RdoMasculino.Location = new System.Drawing.Point(149, 222);
            this.RdoMasculino.Name = "RdoMasculino";
            this.RdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.RdoMasculino.TabIndex = 8;
            this.RdoMasculino.TabStop = true;
            this.RdoMasculino.Text = "Masculino";
            this.RdoMasculino.UseVisualStyleBackColor = true;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(29, 225);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 17;
            this.LblSexo.Text = "Sexo";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(28, 201);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LblFechaNacimiento.TabIndex = 16;
            this.LblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(146, 194);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(146, 20);
            this.DtpFechaNacimiento.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(146, 141);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(146, 20);
            this.TxtDireccion.TabIndex = 5;
            // 
            // MskTxtNumero
            // 
            this.MskTxtNumero.Enabled = false;
            this.MskTxtNumero.Location = new System.Drawing.Point(146, 115);
            this.MskTxtNumero.Mask = "99999999";
            this.MskTxtNumero.Name = "MskTxtNumero";
            this.MskTxtNumero.Size = new System.Drawing.Size(146, 20);
            this.MskTxtNumero.TabIndex = 4;
            this.MskTxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(146, 60);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(146, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(146, 34);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(146, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(26, 175);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 10;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(26, 149);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 8;
            this.LblDireccion.Text = "Direccion";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(26, 123);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(102, 13);
            this.LblNumero.TabIndex = 6;
            this.LblNumero.Text = "Numero Documento";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(146, 88);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(146, 21);
            this.CmbTipo.TabIndex = 3;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(26, 96);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(86, 13);
            this.LblTipo.TabIndex = 4;
            this.LblTipo.Text = "Tipo Documento";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(26, 69);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(26, 42);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // GbAsociados
            // 
            this.GbAsociados.Controls.Add(this.BtnCleanFamiliares);
            this.GbAsociados.Controls.Add(this.BtnCleanFamiliar);
            this.GbAsociados.Controls.Add(this.BtnAddFamiliar);
            this.GbAsociados.Controls.Add(this.LstFamiliares);
            this.GbAsociados.Controls.Add(this.LblLstFamiliares);
            this.GbAsociados.Controls.Add(this.BtnCleanConyugue);
            this.GbAsociados.Controls.Add(this.BtnAddConyugue);
            this.GbAsociados.Controls.Add(this.TxtConyugue);
            this.GbAsociados.Controls.Add(this.LblConyugue);
            this.GbAsociados.Enabled = false;
            this.GbAsociados.Location = new System.Drawing.Point(344, 13);
            this.GbAsociados.Name = "GbAsociados";
            this.GbAsociados.Size = new System.Drawing.Size(223, 363);
            this.GbAsociados.TabIndex = 11;
            this.GbAsociados.TabStop = false;
            this.GbAsociados.Text = "Asociados";
            // 
            // BtnCleanFamiliares
            // 
            this.BtnCleanFamiliares.Location = new System.Drawing.Point(21, 323);
            this.BtnCleanFamiliares.Name = "BtnCleanFamiliares";
            this.BtnCleanFamiliares.Size = new System.Drawing.Size(185, 23);
            this.BtnCleanFamiliares.TabIndex = 21;
            this.BtnCleanFamiliares.Text = "Borrar Todos";
            this.BtnCleanFamiliares.UseVisualStyleBackColor = true;
            this.BtnCleanFamiliares.Click += new System.EventHandler(this.BtnCleanFamiliares_Click);
            // 
            // BtnCleanFamiliar
            // 
            this.BtnCleanFamiliar.Location = new System.Drawing.Point(111, 298);
            this.BtnCleanFamiliar.Name = "BtnCleanFamiliar";
            this.BtnCleanFamiliar.Size = new System.Drawing.Size(96, 23);
            this.BtnCleanFamiliar.TabIndex = 20;
            this.BtnCleanFamiliar.Text = "Borrar";
            this.BtnCleanFamiliar.UseVisualStyleBackColor = true;
            this.BtnCleanFamiliar.Click += new System.EventHandler(this.BtnCleanFamiliar_Click);
            // 
            // BtnAddFamiliar
            // 
            this.BtnAddFamiliar.Location = new System.Drawing.Point(19, 298);
            this.BtnAddFamiliar.Name = "BtnAddFamiliar";
            this.BtnAddFamiliar.Size = new System.Drawing.Size(92, 23);
            this.BtnAddFamiliar.TabIndex = 19;
            this.BtnAddFamiliar.Text = "Agregar";
            this.BtnAddFamiliar.UseVisualStyleBackColor = true;
            this.BtnAddFamiliar.Click += new System.EventHandler(this.BtnAddFamiliar_Click);
            // 
            // LstFamiliares
            // 
            this.LstFamiliares.FormattingEnabled = true;
            this.LstFamiliares.Location = new System.Drawing.Point(21, 140);
            this.LstFamiliares.Name = "LstFamiliares";
            this.LstFamiliares.Size = new System.Drawing.Size(185, 147);
            this.LstFamiliares.TabIndex = 18;
            // 
            // LblLstFamiliares
            // 
            this.LblLstFamiliares.AutoSize = true;
            this.LblLstFamiliares.Location = new System.Drawing.Point(18, 112);
            this.LblLstFamiliares.Name = "LblLstFamiliares";
            this.LblLstFamiliares.Size = new System.Drawing.Size(92, 13);
            this.LblLstFamiliares.TabIndex = 15;
            this.LblLstFamiliares.Text = "Familiares a cargo";
            // 
            // BtnCleanConyugue
            // 
            this.BtnCleanConyugue.Location = new System.Drawing.Point(110, 76);
            this.BtnCleanConyugue.Name = "BtnCleanConyugue";
            this.BtnCleanConyugue.Size = new System.Drawing.Size(96, 23);
            this.BtnCleanConyugue.TabIndex = 17;
            this.BtnCleanConyugue.Text = "Borrar";
            this.BtnCleanConyugue.UseVisualStyleBackColor = true;
            this.BtnCleanConyugue.Click += new System.EventHandler(this.BtnCleanConyugue_Click);
            // 
            // BtnAddConyugue
            // 
            this.BtnAddConyugue.Location = new System.Drawing.Point(18, 76);
            this.BtnAddConyugue.Name = "BtnAddConyugue";
            this.BtnAddConyugue.Size = new System.Drawing.Size(92, 23);
            this.BtnAddConyugue.TabIndex = 16;
            this.BtnAddConyugue.Text = "Agregar";
            this.BtnAddConyugue.UseVisualStyleBackColor = true;
            this.BtnAddConyugue.Click += new System.EventHandler(this.BtnAddConyugue_Click);
            // 
            // TxtConyugue
            // 
            this.TxtConyugue.Location = new System.Drawing.Point(18, 49);
            this.TxtConyugue.Name = "TxtConyugue";
            this.TxtConyugue.Size = new System.Drawing.Size(188, 20);
            this.TxtConyugue.TabIndex = 15;
            // 
            // LblConyugue
            // 
            this.LblConyugue.AutoSize = true;
            this.LblConyugue.Location = new System.Drawing.Point(15, 32);
            this.LblConyugue.Name = "LblConyugue";
            this.LblConyugue.Size = new System.Drawing.Size(55, 13);
            this.LblConyugue.TabIndex = 1;
            this.LblConyugue.Text = "Conyugue";
            // 
            // FormAltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 439);
            this.Controls.Add(this.GbAsociados);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.GbAfiliado);
            this.Name = "FormAltaAfiliado";
            this.Text = "Alta Afiliado";
            this.Load += new System.EventHandler(this.FormAltaAfiliado_Load);
            this.GbAfiliado.ResumeLayout(false);
            this.GbAfiliado.PerformLayout();
            this.GbAsociados.ResumeLayout(false);
            this.GbAsociados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.GroupBox GbAfiliado;
        private System.Windows.Forms.MaskedTextBox MskTxtNumero;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox TxtCantidadFamiliares;
        private System.Windows.Forms.Label LblCantidadHijos;
        private System.Windows.Forms.ComboBox CmbEstadoCivil;
        private System.Windows.Forms.Label LblEstadoCivil;
        private System.Windows.Forms.RadioButton RdoFemenino;
        private System.Windows.Forms.RadioButton RdoMasculino;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.ComboBox CmbPlanMedico;
        private System.Windows.Forms.Label LblPlanMedico;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefono;
        private System.Windows.Forms.GroupBox GbAsociados;
        private System.Windows.Forms.Button BtnCleanConyugue;
        private System.Windows.Forms.Button BtnAddConyugue;
        private System.Windows.Forms.TextBox TxtConyugue;
        private System.Windows.Forms.Label LblConyugue;
        private System.Windows.Forms.Label LblLstFamiliares;
        private System.Windows.Forms.ListBox LstFamiliares;
        private System.Windows.Forms.Button BtnCleanFamiliares;
        private System.Windows.Forms.Button BtnCleanFamiliar;
        private System.Windows.Forms.Button BtnAddFamiliar;
        private System.Windows.Forms.Button BtnAddAsociados;
        private System.Windows.Forms.Button BtnCleanAsociados;
    }
}