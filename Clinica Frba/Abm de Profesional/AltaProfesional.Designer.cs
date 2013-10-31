namespace Clinica_Frba.NewFolder13
{
    partial class frmAltaProfesional
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
            this.gbProfesional = new System.Windows.Forms.GroupBox();
            this.MskTxtTelefono = new System.Windows.Forms.MaskedTextBox();
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Matricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.chkEspecialidades = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbProfesional.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfesional
            // 
            this.gbProfesional.Controls.Add(this.btnCancelar);
            this.gbProfesional.Controls.Add(this.btnGuardar);
            this.gbProfesional.Controls.Add(this.label2);
            this.gbProfesional.Controls.Add(this.chkEspecialidades);
            this.gbProfesional.Controls.Add(this.Matricula);
            this.gbProfesional.Controls.Add(this.txtMatricula);
            this.gbProfesional.Controls.Add(this.label1);
            this.gbProfesional.Controls.Add(this.txtMail);
            this.gbProfesional.Controls.Add(this.MskTxtTelefono);
            this.gbProfesional.Controls.Add(this.RdoFemenino);
            this.gbProfesional.Controls.Add(this.RdoMasculino);
            this.gbProfesional.Controls.Add(this.LblSexo);
            this.gbProfesional.Controls.Add(this.LblFechaNacimiento);
            this.gbProfesional.Controls.Add(this.DtpFechaNacimiento);
            this.gbProfesional.Controls.Add(this.TxtDireccion);
            this.gbProfesional.Controls.Add(this.MskTxtNumero);
            this.gbProfesional.Controls.Add(this.TxtApellido);
            this.gbProfesional.Controls.Add(this.TxtNombre);
            this.gbProfesional.Controls.Add(this.LblTelefono);
            this.gbProfesional.Controls.Add(this.LblDireccion);
            this.gbProfesional.Controls.Add(this.LblNumero);
            this.gbProfesional.Controls.Add(this.CmbTipo);
            this.gbProfesional.Controls.Add(this.LblTipo);
            this.gbProfesional.Controls.Add(this.LblApellido);
            this.gbProfesional.Controls.Add(this.LblNombre);
            this.gbProfesional.Location = new System.Drawing.Point(12, 12);
            this.gbProfesional.Name = "gbProfesional";
            this.gbProfesional.Size = new System.Drawing.Size(298, 477);
            this.gbProfesional.TabIndex = 9;
            this.gbProfesional.TabStop = false;
            this.gbProfesional.Text = "Datos del Profesional";
            // 
            // MskTxtTelefono
            // 
            this.MskTxtTelefono.Enabled = false;
            this.MskTxtTelefono.Location = new System.Drawing.Point(133, 148);
            this.MskTxtTelefono.Mask = "9999-9999";
            this.MskTxtTelefono.Name = "MskTxtTelefono";
            this.MskTxtTelefono.Size = new System.Drawing.Size(146, 20);
            this.MskTxtTelefono.TabIndex = 6;
            this.MskTxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RdoFemenino
            // 
            this.RdoFemenino.AutoSize = true;
            this.RdoFemenino.Location = new System.Drawing.Point(210, 203);
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
            this.RdoMasculino.Location = new System.Drawing.Point(136, 203);
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
            this.LblSexo.Location = new System.Drawing.Point(16, 206);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(31, 13);
            this.LblSexo.TabIndex = 17;
            this.LblSexo.Text = "Sexo";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(15, 182);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LblFechaNacimiento.TabIndex = 16;
            this.LblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(133, 175);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(146, 20);
            this.DtpFechaNacimiento.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(133, 122);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(146, 20);
            this.TxtDireccion.TabIndex = 5;
            // 
            // MskTxtNumero
            // 
            this.MskTxtNumero.Enabled = false;
            this.MskTxtNumero.Location = new System.Drawing.Point(133, 96);
            this.MskTxtNumero.Mask = "99999999";
            this.MskTxtNumero.Name = "MskTxtNumero";
            this.MskTxtNumero.Size = new System.Drawing.Size(146, 20);
            this.MskTxtNumero.TabIndex = 4;
            this.MskTxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(133, 41);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(146, 20);
            this.TxtApellido.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(133, 15);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(146, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(13, 156);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 10;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(13, 130);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 8;
            this.LblDireccion.Text = "Direccion";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(13, 104);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(102, 13);
            this.LblNumero.TabIndex = 6;
            this.LblNumero.Text = "Numero Documento";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(133, 69);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(146, 21);
            this.CmbTipo.TabIndex = 3;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(13, 77);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(86, 13);
            this.LblTipo.TabIndex = 4;
            this.LblTipo.Text = "Tipo Documento";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(13, 50);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(13, 23);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(133, 226);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(146, 20);
            this.txtMail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mail";
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Location = new System.Drawing.Point(16, 256);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(50, 13);
            this.Matricula.TabIndex = 21;
            this.Matricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(133, 253);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(146, 20);
            this.txtMatricula.TabIndex = 20;
            // 
            // chkEspecialidades
            // 
            this.chkEspecialidades.FormattingEnabled = true;
            this.chkEspecialidades.Location = new System.Drawing.Point(133, 281);
            this.chkEspecialidades.Name = "chkEspecialidades";
            this.chkEspecialidades.Size = new System.Drawing.Size(148, 139);
            this.chkEspecialidades.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Especialidades";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(61, 437);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(153, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAltaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 501);
            this.Controls.Add(this.gbProfesional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAltaProfesional";
            this.Text = "Alta Profesional";
            this.Load += new System.EventHandler(this.frmAltaProfesional_Load);
            this.gbProfesional.ResumeLayout(false);
            this.gbProfesional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProfesional;
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefono;
        private System.Windows.Forms.RadioButton RdoFemenino;
        private System.Windows.Forms.RadioButton RdoMasculino;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.MaskedTextBox MskTxtNumero;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkEspecialidades;
    }
}