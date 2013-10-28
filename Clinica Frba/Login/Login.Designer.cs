namespace Clinica_Frba.Login
{
    partial class frmLogin
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
            this.GpbIngreso = new System.Windows.Forms.GroupBox();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GpbIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbIngreso
            // 
            this.GpbIngreso.Controls.Add(this.BtnCliente);
            this.GpbIngreso.Controls.Add(this.BtnLogin);
            this.GpbIngreso.Controls.Add(this.txtPassword);
            this.GpbIngreso.Controls.Add(this.label2);
            this.GpbIngreso.Controls.Add(this.txtUser);
            this.GpbIngreso.Controls.Add(this.label1);
            this.GpbIngreso.Location = new System.Drawing.Point(8, 12);
            this.GpbIngreso.Name = "GpbIngreso";
            this.GpbIngreso.Size = new System.Drawing.Size(297, 137);
            this.GpbIngreso.TabIndex = 1;
            this.GpbIngreso.TabStop = false;
            this.GpbIngreso.Text = "Ingresar Datos";
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(35, 99);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(114, 23);
            this.BtnCliente.TabIndex = 5;
            this.BtnCliente.Text = "Soy cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click_1);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(155, 99);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(114, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "w23e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(108, 30);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(175, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 159);
            this.Controls.Add(this.GpbIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.GpbIngreso.ResumeLayout(false);
            this.GpbIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbIngreso;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
    }
}