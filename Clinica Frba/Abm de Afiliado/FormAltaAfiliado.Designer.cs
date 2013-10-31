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
            this.GbAfiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(174, 359);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 38);
            this.BtnClean.TabIndex = 10;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(93, 359);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 38);
            this.BtnCreate.TabIndex = 9;
            this.BtnCreate.Text = "Alta";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // GbAfiliado
            // 
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
            this.GbAfiliado.Size = new System.Drawing.Size(325, 341);
            this.GbAfiliado.TabIndex = 8;
            this.GbAfiliado.TabStop = false;
            this.GbAfiliado.Text = "Datos del Afiliado";
            // 
            // MskTxtTelefono
            // 
            this.MskTxtTelefono.Enabled = false;
            this.MskTxtTelefono.Location = new System.Drawing.Point(146, 167);
            this.MskTxtTelefono.Mask = "9999-9999";
            this.MskTxtTelefono.Name = "MskTxtTelefono";
            this.MskTxtTelefono.Size = new System.Drawing.Size(146, 20);
            this.MskTxtTelefono.TabIndex = 26;
            this.MskTxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbPlanMedico
            // 
            this.CmbPlanMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlanMedico.FormattingEnabled = true;
            this.CmbPlanMedico.Location = new System.Drawing.Point(146, 299);
            this.CmbPlanMedico.Name = "CmbPlanMedico";
            this.CmbPlanMedico.Size = new System.Drawing.Size(146, 21);
            this.CmbPlanMedico.TabIndex = 25;
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
            this.TxtCantidadFamiliares.TabIndex = 22;
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
            this.CmbEstadoCivil.TabIndex = 20;
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
            this.RdoFemenino.TabIndex = 19;
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
            this.RdoMasculino.TabIndex = 18;
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
            this.DtpFechaNacimiento.TabIndex = 15;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(146, 141);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(146, 20);
            this.TxtDireccion.TabIndex = 13;
            // 
            // MskTxtNumero
            // 
            this.MskTxtNumero.Enabled = false;
            this.MskTxtNumero.Location = new System.Drawing.Point(146, 115);
            this.MskTxtNumero.Mask = "99999999";
            this.MskTxtNumero.Name = "MskTxtNumero";
            this.MskTxtNumero.Size = new System.Drawing.Size(146, 20);
            this.MskTxtNumero.TabIndex = 0;
            this.MskTxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(146, 60);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(146, 20);
            this.TxtApellido.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(146, 34);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(146, 20);
            this.TxtNombre.TabIndex = 11;
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
            this.LblNumero.Size = new System.Drawing.Size(44, 13);
            this.LblNumero.TabIndex = 6;
            this.LblNumero.Text = "Numero";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(146, 88);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(146, 21);
            this.CmbTipo.TabIndex = 2;
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
            // FormAltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 414);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.GbAfiliado);
            this.Name = "FormAltaAfiliado";
            this.Text = "Alta Afiliado";
            this.GbAfiliado.ResumeLayout(false);
            this.GbAfiliado.PerformLayout();
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
    }
}