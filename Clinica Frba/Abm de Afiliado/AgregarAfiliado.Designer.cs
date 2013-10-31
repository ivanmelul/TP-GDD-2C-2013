namespace Clinica_Frba.ABM_Afiliado
{
    partial class AgregarAfiliado
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
            this.GbAfiliado = new System.Windows.Forms.GroupBox();
            this.MskTxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.RdoFemenino = new System.Windows.Forms.RadioButton();
            this.RdoMasculino = new System.Windows.Forms.RadioButton();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.MskTxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.BtnAddFamiliar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddConyugue = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.GbAfiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbAfiliado
            // 
            this.GbAfiliado.Controls.Add(this.MskTxtTelefono);
            this.GbAfiliado.Controls.Add(this.TxtApellido);
            this.GbAfiliado.Controls.Add(this.LblNombre);
            this.GbAfiliado.Controls.Add(this.LblApellido);
            this.GbAfiliado.Controls.Add(this.TxtNombre);
            this.GbAfiliado.Controls.Add(this.CmbEstadoCivil);
            this.GbAfiliado.Controls.Add(this.LblEstadoCivil);
            this.GbAfiliado.Controls.Add(this.RdoFemenino);
            this.GbAfiliado.Controls.Add(this.RdoMasculino);
            this.GbAfiliado.Controls.Add(this.LblSexo);
            this.GbAfiliado.Controls.Add(this.LblFechaNacimiento);
            this.GbAfiliado.Controls.Add(this.DtpFechaNacimiento);
            this.GbAfiliado.Controls.Add(this.TxtDireccion);
            this.GbAfiliado.Controls.Add(this.MskTxtNumero);
            this.GbAfiliado.Controls.Add(this.LblTelefono);
            this.GbAfiliado.Controls.Add(this.LblDireccion);
            this.GbAfiliado.Controls.Add(this.LblNumero);
            this.GbAfiliado.Controls.Add(this.CmbTipo);
            this.GbAfiliado.Controls.Add(this.LblTipo);
            this.GbAfiliado.Location = new System.Drawing.Point(12, 12);
            this.GbAfiliado.Name = "GbAfiliado";
            this.GbAfiliado.Size = new System.Drawing.Size(324, 284);
            this.GbAfiliado.TabIndex = 9;
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
            this.MskTxtTelefono.TabIndex = 5;
            this.MskTxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(146, 112);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(146, 20);
            this.TxtApellido.TabIndex = 3;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(26, 94);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(26, 121);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(146, 86);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(146, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // CmbEstadoCivil
            // 
            this.CmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoCivil.FormattingEnabled = true;
            this.CmbEstadoCivil.Location = new System.Drawing.Point(146, 245);
            this.CmbEstadoCivil.Name = "CmbEstadoCivil";
            this.CmbEstadoCivil.Size = new System.Drawing.Size(146, 21);
            this.CmbEstadoCivil.TabIndex = 9;
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
            this.RdoFemenino.TabIndex = 8;
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
            this.RdoMasculino.TabIndex = 7;
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
            this.DtpFechaNacimiento.TabIndex = 6;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(146, 141);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(146, 20);
            this.TxtDireccion.TabIndex = 4;
            // 
            // MskTxtNumero
            // 
            this.MskTxtNumero.Enabled = false;
            this.MskTxtNumero.Location = new System.Drawing.Point(146, 56);
            this.MskTxtNumero.Mask = "99999999";
            this.MskTxtNumero.Name = "MskTxtNumero";
            this.MskTxtNumero.Size = new System.Drawing.Size(146, 20);
            this.MskTxtNumero.TabIndex = 1;
            this.MskTxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.LblNumero.Location = new System.Drawing.Point(26, 64);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(102, 13);
            this.LblNumero.TabIndex = 6;
            this.LblNumero.Text = "Numero Documento";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(146, 29);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(146, 21);
            this.CmbTipo.TabIndex = 0;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(26, 37);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(86, 13);
            this.LblTipo.TabIndex = 4;
            this.LblTipo.Text = "Tipo Documento";
            // 
            // BtnAddFamiliar
            // 
            this.BtnAddFamiliar.Location = new System.Drawing.Point(58, 302);
            this.BtnAddFamiliar.Name = "BtnAddFamiliar";
            this.BtnAddFamiliar.Size = new System.Drawing.Size(75, 41);
            this.BtnAddFamiliar.TabIndex = 11;
            this.BtnAddFamiliar.Text = "Agregar";
            this.BtnAddFamiliar.UseVisualStyleBackColor = true;
            this.BtnAddFamiliar.Click += new System.EventHandler(this.BtnAddFamiliar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(220, 302);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 41);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddConyugue
            // 
            this.BtnAddConyugue.Location = new System.Drawing.Point(58, 302);
            this.BtnAddConyugue.Name = "BtnAddConyugue";
            this.BtnAddConyugue.Size = new System.Drawing.Size(75, 41);
            this.BtnAddConyugue.TabIndex = 10;
            this.BtnAddConyugue.Text = "Agregar";
            this.BtnAddConyugue.UseVisualStyleBackColor = true;
            this.BtnAddConyugue.Click += new System.EventHandler(this.BtnAddConyugue_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(139, 302);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 41);
            this.BtnClean.TabIndex = 12;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // AgregarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 355);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnAddConyugue);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddFamiliar);
            this.Controls.Add(this.GbAfiliado);
            this.Name = "AgregarAfiliado";
            this.Text = "AgregarAfiliado";
            this.GbAfiliado.ResumeLayout(false);
            this.GbAfiliado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbAfiliado;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CmbEstadoCivil;
        private System.Windows.Forms.Label LblEstadoCivil;
        private System.Windows.Forms.RadioButton RdoFemenino;
        private System.Windows.Forms.RadioButton RdoMasculino;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.MaskedTextBox MskTxtNumero;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Button BtnAddFamiliar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddConyugue;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefono;
        private System.Windows.Forms.Button BtnClean;
    }
}