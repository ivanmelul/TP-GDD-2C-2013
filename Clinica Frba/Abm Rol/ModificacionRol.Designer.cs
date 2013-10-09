namespace Clinica_Frba.Abm_Rol
{
    partial class ModificacionRol
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
            this.DgvRoles = new System.Windows.Forms.DataGridView();
            this.BtnModify = new System.Windows.Forms.Button();
            this.ChkHabilitado = new System.Windows.Forms.CheckBox();
            this.GbRol = new System.Windows.Forms.GroupBox();
            this.ChkLstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.LblFuncionalidades = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.GbHolder = new System.Windows.Forms.GroupBox();
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.ChkSearchExact = new System.Windows.Forms.CheckBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblNombreRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).BeginInit();
            this.GbRol.SuspendLayout();
            this.GbHolder.SuspendLayout();
            this.GbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRoles
            // 
            this.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRoles.Location = new System.Drawing.Point(16, 98);
            this.DgvRoles.MultiSelect = false;
            this.DgvRoles.Name = "DgvRoles";
            this.DgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRoles.Size = new System.Drawing.Size(346, 247);
            this.DgvRoles.TabIndex = 4;
            this.DgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRoles_CellContentClick);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(94, 308);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 38);
            this.BtnModify.TabIndex = 8;
            this.BtnModify.Text = "Modificar";
            this.BtnModify.UseVisualStyleBackColor = true;
            // 
            // ChkHabilitado
            // 
            this.ChkHabilitado.AutoSize = true;
            this.ChkHabilitado.Location = new System.Drawing.Point(98, 50);
            this.ChkHabilitado.Name = "ChkHabilitado";
            this.ChkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.ChkHabilitado.TabIndex = 6;
            this.ChkHabilitado.Text = "Habilitado";
            this.ChkHabilitado.UseVisualStyleBackColor = true;
            // 
            // GbRol
            // 
            this.GbRol.Controls.Add(this.ChkHabilitado);
            this.GbRol.Controls.Add(this.ChkLstFuncionalidades);
            this.GbRol.Controls.Add(this.LblFuncionalidades);
            this.GbRol.Controls.Add(this.TxtNombre);
            this.GbRol.Controls.Add(this.LblNombre);
            this.GbRol.Location = new System.Drawing.Point(26, 20);
            this.GbRol.Name = "GbRol";
            this.GbRol.Size = new System.Drawing.Size(277, 276);
            this.GbRol.TabIndex = 2;
            this.GbRol.TabStop = false;
            this.GbRol.Text = "Datos del Rol";
            // 
            // ChkLstFuncionalidades
            // 
            this.ChkLstFuncionalidades.FormattingEnabled = true;
            this.ChkLstFuncionalidades.Location = new System.Drawing.Point(25, 95);
            this.ChkLstFuncionalidades.Name = "ChkLstFuncionalidades";
            this.ChkLstFuncionalidades.Size = new System.Drawing.Size(229, 169);
            this.ChkLstFuncionalidades.TabIndex = 7;
            // 
            // LblFuncionalidades
            // 
            this.LblFuncionalidades.AutoSize = true;
            this.LblFuncionalidades.Location = new System.Drawing.Point(22, 73);
            this.LblFuncionalidades.Name = "LblFuncionalidades";
            this.LblFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.LblFuncionalidades.TabIndex = 2;
            this.LblFuncionalidades.Text = "Funcionalidades";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(98, 24);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(156, 20);
            this.TxtNombre.TabIndex = 4;
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
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(175, 308);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 38);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Restablecer";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(197, 55);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(98, 33);
            this.BtnClean.TabIndex = 3;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // GbHolder
            // 
            this.GbHolder.Controls.Add(this.BtnBack);
            this.GbHolder.Controls.Add(this.BtnModify);
            this.GbHolder.Controls.Add(this.GbRol);
            this.GbHolder.Enabled = false;
            this.GbHolder.Location = new System.Drawing.Point(411, 12);
            this.GbHolder.Name = "GbHolder";
            this.GbHolder.Size = new System.Drawing.Size(331, 356);
            this.GbHolder.TabIndex = 11;
            this.GbHolder.TabStop = false;
            this.GbHolder.Text = "Modificar Rol";
            // 
            // GbBuscar
            // 
            this.GbBuscar.Controls.Add(this.BtnClean);
            this.GbBuscar.Controls.Add(this.ChkSearchExact);
            this.GbBuscar.Controls.Add(this.BtnSearch);
            this.GbBuscar.Controls.Add(this.TxtSearch);
            this.GbBuscar.Controls.Add(this.LblNombreRol);
            this.GbBuscar.Controls.Add(this.DgvRoles);
            this.GbBuscar.Location = new System.Drawing.Point(12, 12);
            this.GbBuscar.Name = "GbBuscar";
            this.GbBuscar.Size = new System.Drawing.Size(385, 356);
            this.GbBuscar.TabIndex = 10;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "Buscar Rol";
            // 
            // ChkSearchExact
            // 
            this.ChkSearchExact.AutoSize = true;
            this.ChkSearchExact.Location = new System.Drawing.Point(255, 28);
            this.ChkSearchExact.Name = "ChkSearchExact";
            this.ChkSearchExact.Size = new System.Drawing.Size(110, 17);
            this.ChkSearchExact.TabIndex = 1;
            this.ChkSearchExact.Text = "Busqueda Exacta";
            this.ChkSearchExact.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(93, 55);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(98, 33);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(101, 26);
            this.TxtSearch.MaxLength = 25;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(135, 20);
            this.TxtSearch.TabIndex = 0;
            // 
            // LblNombreRol
            // 
            this.LblNombreRol.AutoSize = true;
            this.LblNombreRol.Location = new System.Drawing.Point(25, 28);
            this.LblNombreRol.Name = "LblNombreRol";
            this.LblNombreRol.Size = new System.Drawing.Size(63, 13);
            this.LblNombreRol.TabIndex = 1;
            this.LblNombreRol.Text = "Nombre Rol";
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 377);
            this.Controls.Add(this.GbHolder);
            this.Controls.Add(this.GbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModificacionRol";
            this.Text = "Modificacion Rol";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).EndInit();
            this.GbRol.ResumeLayout(false);
            this.GbRol.PerformLayout();
            this.GbHolder.ResumeLayout(false);
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRoles;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.CheckBox ChkHabilitado;
        private System.Windows.Forms.GroupBox GbRol;
        private System.Windows.Forms.CheckedListBox ChkLstFuncionalidades;
        private System.Windows.Forms.Label LblFuncionalidades;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.GroupBox GbHolder;
        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.CheckBox ChkSearchExact;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblNombreRol;
    }
}