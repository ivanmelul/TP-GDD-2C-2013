namespace Clinica_Frba
{
    partial class Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.LblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GpbRoles = new System.Windows.Forms.GroupBox();
            this.BtnBajaRol = new System.Windows.Forms.Button();
            this.BtnModificacionRol = new System.Windows.Forms.Button();
            this.BtnAltaRol = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.gpbFuncionalidades = new System.Windows.Forms.GroupBox();
            this.btnComprarBono = new System.Windows.Forms.Button();
            this.btnPedidoTurno = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnCancelarAtencion = new System.Windows.Forms.Button();
            this.btnRegistrarLlegada = new System.Windows.Forms.Button();
            this.btnRegitrarResultado = new System.Windows.Forms.Button();
            this.btnEmitirReceta = new System.Windows.Forms.Button();
            this.btnRegitrarAgenda = new System.Windows.Forms.Button();
            this.gpbProfesionales = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gpbAfiliados = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GpbRoles.SuspendLayout();
            this.gpbFuncionalidades.SuspendLayout();
            this.gpbProfesionales.SuspendLayout();
            this.gpbAfiliados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Elija el rol que quiere utilizar para esta sesion";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(247, 12);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(140, 21);
            this.BtnLogout.TabIndex = 35;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.Location = new System.Drawing.Point(161, 21);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(41, 13);
            this.LblRol.TabIndex = 34;
            this.LblRol.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usted ha ingresado como:";
            // 
            // GpbRoles
            // 
            this.GpbRoles.Controls.Add(this.BtnBajaRol);
            this.GpbRoles.Controls.Add(this.BtnModificacionRol);
            this.GpbRoles.Controls.Add(this.BtnAltaRol);
            this.GpbRoles.Location = new System.Drawing.Point(15, 21);
            this.GpbRoles.Name = "GpbRoles";
            this.GpbRoles.Size = new System.Drawing.Size(344, 74);
            this.GpbRoles.TabIndex = 26;
            this.GpbRoles.TabStop = false;
            this.GpbRoles.Text = "Roles";
            this.GpbRoles.Visible = false;
            // 
            // BtnBajaRol
            // 
            this.BtnBajaRol.Location = new System.Drawing.Point(228, 19);
            this.BtnBajaRol.Name = "BtnBajaRol";
            this.BtnBajaRol.Size = new System.Drawing.Size(102, 43);
            this.BtnBajaRol.TabIndex = 8;
            this.BtnBajaRol.Text = "Baja Rol";
            this.BtnBajaRol.UseVisualStyleBackColor = true;
            // 
            // BtnModificacionRol
            // 
            this.BtnModificacionRol.Location = new System.Drawing.Point(120, 19);
            this.BtnModificacionRol.Name = "BtnModificacionRol";
            this.BtnModificacionRol.Size = new System.Drawing.Size(102, 43);
            this.BtnModificacionRol.TabIndex = 7;
            this.BtnModificacionRol.Text = "Modificacion Rol";
            this.BtnModificacionRol.UseVisualStyleBackColor = true;
            // 
            // BtnAltaRol
            // 
            this.BtnAltaRol.Location = new System.Drawing.Point(12, 19);
            this.BtnAltaRol.Name = "BtnAltaRol";
            this.BtnAltaRol.Size = new System.Drawing.Size(102, 43);
            this.BtnAltaRol.TabIndex = 0;
            this.BtnAltaRol.Text = "Alta Rol";
            this.BtnAltaRol.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(247, 43);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(140, 21);
            this.cmbRoles.TabIndex = 37;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // gpbFuncionalidades
            // 
            this.gpbFuncionalidades.Controls.Add(this.btnComprarBono);
            this.gpbFuncionalidades.Controls.Add(this.btnPedidoTurno);
            this.gpbFuncionalidades.Controls.Add(this.btnEstadisticas);
            this.gpbFuncionalidades.Controls.Add(this.btnCancelarAtencion);
            this.gpbFuncionalidades.Controls.Add(this.btnRegistrarLlegada);
            this.gpbFuncionalidades.Controls.Add(this.btnRegitrarResultado);
            this.gpbFuncionalidades.Controls.Add(this.btnEmitirReceta);
            this.gpbFuncionalidades.Controls.Add(this.btnRegitrarAgenda);
            this.gpbFuncionalidades.Controls.Add(this.gpbProfesionales);
            this.gpbFuncionalidades.Controls.Add(this.gpbAfiliados);
            this.gpbFuncionalidades.Controls.Add(this.GpbRoles);
            this.gpbFuncionalidades.Location = new System.Drawing.Point(28, 82);
            this.gpbFuncionalidades.Name = "gpbFuncionalidades";
            this.gpbFuncionalidades.Size = new System.Drawing.Size(631, 280);
            this.gpbFuncionalidades.TabIndex = 38;
            this.gpbFuncionalidades.TabStop = false;
            this.gpbFuncionalidades.Text = "Funcionalidades";
            this.gpbFuncionalidades.Visible = false;
            // 
            // btnComprarBono
            // 
            this.btnComprarBono.Location = new System.Drawing.Point(504, 40);
            this.btnComprarBono.Name = "btnComprarBono";
            this.btnComprarBono.Size = new System.Drawing.Size(102, 43);
            this.btnComprarBono.TabIndex = 37;
            this.btnComprarBono.Text = "Comprar Bono";
            this.btnComprarBono.UseVisualStyleBackColor = true;
            this.btnComprarBono.Visible = false;
            // 
            // btnPedidoTurno
            // 
            this.btnPedidoTurno.Location = new System.Drawing.Point(381, 91);
            this.btnPedidoTurno.Name = "btnPedidoTurno";
            this.btnPedidoTurno.Size = new System.Drawing.Size(102, 43);
            this.btnPedidoTurno.TabIndex = 36;
            this.btnPedidoTurno.Text = "Pedir Turno";
            this.btnPedidoTurno.UseVisualStyleBackColor = true;
            this.btnPedidoTurno.Visible = false;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(381, 145);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(102, 43);
            this.btnEstadisticas.TabIndex = 35;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Visible = false;
            // 
            // btnCancelarAtencion
            // 
            this.btnCancelarAtencion.Location = new System.Drawing.Point(381, 205);
            this.btnCancelarAtencion.Name = "btnCancelarAtencion";
            this.btnCancelarAtencion.Size = new System.Drawing.Size(102, 43);
            this.btnCancelarAtencion.TabIndex = 34;
            this.btnCancelarAtencion.Text = "Cancelar Atencion Medica";
            this.btnCancelarAtencion.UseVisualStyleBackColor = true;
            this.btnCancelarAtencion.Visible = false;
            // 
            // btnRegistrarLlegada
            // 
            this.btnRegistrarLlegada.Location = new System.Drawing.Point(504, 91);
            this.btnRegistrarLlegada.Name = "btnRegistrarLlegada";
            this.btnRegistrarLlegada.Size = new System.Drawing.Size(102, 43);
            this.btnRegistrarLlegada.TabIndex = 33;
            this.btnRegistrarLlegada.Text = "Registrar Llegada Paciente";
            this.btnRegistrarLlegada.UseVisualStyleBackColor = true;
            this.btnRegistrarLlegada.Visible = false;
            // 
            // btnRegitrarResultado
            // 
            this.btnRegitrarResultado.Location = new System.Drawing.Point(504, 145);
            this.btnRegitrarResultado.Name = "btnRegitrarResultado";
            this.btnRegitrarResultado.Size = new System.Drawing.Size(102, 43);
            this.btnRegitrarResultado.TabIndex = 32;
            this.btnRegitrarResultado.Text = "Registrar Resultado";
            this.btnRegitrarResultado.UseVisualStyleBackColor = true;
            this.btnRegitrarResultado.Visible = false;
            // 
            // btnEmitirReceta
            // 
            this.btnEmitirReceta.Location = new System.Drawing.Point(504, 205);
            this.btnEmitirReceta.Name = "btnEmitirReceta";
            this.btnEmitirReceta.Size = new System.Drawing.Size(102, 43);
            this.btnEmitirReceta.TabIndex = 31;
            this.btnEmitirReceta.Text = "Emitir Receta";
            this.btnEmitirReceta.UseVisualStyleBackColor = true;
            this.btnEmitirReceta.Visible = false;
            // 
            // btnRegitrarAgenda
            // 
            this.btnRegitrarAgenda.Location = new System.Drawing.Point(381, 40);
            this.btnRegitrarAgenda.Name = "btnRegitrarAgenda";
            this.btnRegitrarAgenda.Size = new System.Drawing.Size(102, 43);
            this.btnRegitrarAgenda.TabIndex = 29;
            this.btnRegitrarAgenda.Text = "Registrar Agenda";
            this.btnRegitrarAgenda.UseVisualStyleBackColor = true;
            this.btnRegitrarAgenda.Visible = false;
            // 
            // gpbProfesionales
            // 
            this.gpbProfesionales.Controls.Add(this.button4);
            this.gpbProfesionales.Controls.Add(this.button5);
            this.gpbProfesionales.Controls.Add(this.button6);
            this.gpbProfesionales.Location = new System.Drawing.Point(15, 188);
            this.gpbProfesionales.Name = "gpbProfesionales";
            this.gpbProfesionales.Size = new System.Drawing.Size(344, 74);
            this.gpbProfesionales.TabIndex = 28;
            this.gpbProfesionales.TabStop = false;
            this.gpbProfesionales.Text = "Profesionales";
            this.gpbProfesionales.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "Baja Profesional";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "Modificacion Profesional";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 43);
            this.button6.TabIndex = 0;
            this.button6.Text = "Alta Profesional";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gpbAfiliados
            // 
            this.gpbAfiliados.Controls.Add(this.button1);
            this.gpbAfiliados.Controls.Add(this.button2);
            this.gpbAfiliados.Controls.Add(this.button3);
            this.gpbAfiliados.Location = new System.Drawing.Point(15, 102);
            this.gpbAfiliados.Name = "gpbAfiliados";
            this.gpbAfiliados.Size = new System.Drawing.Size(344, 74);
            this.gpbAfiliados.TabIndex = 27;
            this.gpbAfiliados.TabStop = false;
            this.gpbAfiliados.Text = "Afiliados";
            this.gpbAfiliados.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Baja Afiliado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modificacion Afiliado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "Alta Afiliado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 371);
            this.Controls.Add(this.gpbFuncionalidades);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.GpbRoles.ResumeLayout(false);
            this.gpbFuncionalidades.ResumeLayout(false);
            this.gpbProfesionales.ResumeLayout(false);
            this.gpbAfiliados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GpbRoles;
        private System.Windows.Forms.Button BtnBajaRol;
        private System.Windows.Forms.Button BtnModificacionRol;
        private System.Windows.Forms.Button BtnAltaRol;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.GroupBox gpbFuncionalidades;
        private System.Windows.Forms.GroupBox gpbAfiliados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gpbProfesionales;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRegitrarAgenda;
        private System.Windows.Forms.Button btnEmitirReceta;
        private System.Windows.Forms.Button btnRegitrarResultado;
        private System.Windows.Forms.Button btnCancelarAtencion;
        private System.Windows.Forms.Button btnRegistrarLlegada;
        private System.Windows.Forms.Button btnComprarBono;
        private System.Windows.Forms.Button btnPedidoTurno;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

