namespace Clinica_Frba.Abm_Rol
{
    partial class AltaRol
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
            this.GbRol = new System.Windows.Forms.GroupBox();
            this.ChkLstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.LblFuncionalidades = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GbRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(139, 253);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 38);
            this.BtnClean.TabIndex = 7;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(58, 253);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 38);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "Alta";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // GbRol
            // 
            this.GbRol.Controls.Add(this.ChkLstFuncionalidades);
            this.GbRol.Controls.Add(this.LblFuncionalidades);
            this.GbRol.Controls.Add(this.TxtNombre);
            this.GbRol.Controls.Add(this.LblNombre);
            this.GbRol.Location = new System.Drawing.Point(8, 7);
            this.GbRol.Name = "GbRol";
            this.GbRol.Size = new System.Drawing.Size(277, 233);
            this.GbRol.TabIndex = 5;
            this.GbRol.TabStop = false;
            this.GbRol.Text = "Datos del Rol";
            // 
            // ChkLstFuncionalidades
            // 
            this.ChkLstFuncionalidades.FormattingEnabled = true;
            this.ChkLstFuncionalidades.Location = new System.Drawing.Point(25, 83);
            this.ChkLstFuncionalidades.Name = "ChkLstFuncionalidades";
            this.ChkLstFuncionalidades.Size = new System.Drawing.Size(229, 139);
            this.ChkLstFuncionalidades.TabIndex = 2;
            // 
            // LblFuncionalidades
            // 
            this.LblFuncionalidades.AutoSize = true;
            this.LblFuncionalidades.Location = new System.Drawing.Point(22, 57);
            this.LblFuncionalidades.Name = "LblFuncionalidades";
            this.LblFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.LblFuncionalidades.TabIndex = 2;
            this.LblFuncionalidades.Text = "Funcionalidades";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(98, 24);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(156, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(22, 31);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 303);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.GbRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AltaRol";
            this.Text = "Alta Rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            this.GbRol.ResumeLayout(false);
            this.GbRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.GroupBox GbRol;
        private System.Windows.Forms.CheckedListBox ChkLstFuncionalidades;
        private System.Windows.Forms.Label LblFuncionalidades;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
    }
}