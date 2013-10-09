namespace Clinica_Frba.Abm_Rol
{
    partial class BajaRol
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
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.BtnClean = new System.Windows.Forms.Button();
            this.ChkSearchExact = new System.Windows.Forms.CheckBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblNombreRol = new System.Windows.Forms.Label();
            this.DgvRoles = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).BeginInit();
            this.SuspendLayout();
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
            this.GbBuscar.Size = new System.Drawing.Size(363, 356);
            this.GbBuscar.TabIndex = 10;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "Eliminar Rol";
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(191, 52);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(98, 33);
            this.BtnClean.TabIndex = 3;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // ChkSearchExact
            // 
            this.ChkSearchExact.AutoSize = true;
            this.ChkSearchExact.Location = new System.Drawing.Point(228, 28);
            this.ChkSearchExact.Name = "ChkSearchExact";
            this.ChkSearchExact.Size = new System.Drawing.Size(110, 17);
            this.ChkSearchExact.TabIndex = 1;
            this.ChkSearchExact.Text = "Busqueda Exacta";
            this.ChkSearchExact.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(87, 52);
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
            this.TxtSearch.Size = new System.Drawing.Size(113, 20);
            this.TxtSearch.TabIndex = 0;
            // 
            // LblNombreRol
            // 
            this.LblNombreRol.AutoSize = true;
            this.LblNombreRol.Location = new System.Drawing.Point(27, 28);
            this.LblNombreRol.Name = "LblNombreRol";
            this.LblNombreRol.Size = new System.Drawing.Size(63, 13);
            this.LblNombreRol.TabIndex = 1;
            this.LblNombreRol.Text = "Nombre Rol";
            // 
            // DgvRoles
            // 
            this.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnDelete});
            this.DgvRoles.Location = new System.Drawing.Point(16, 98);
            this.DgvRoles.MultiSelect = false;
            this.DgvRoles.Name = "DgvRoles";
            this.DgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRoles.Size = new System.Drawing.Size(324, 247);
            this.DgvRoles.TabIndex = 4;
            // 
            // BtnDelete
            // 
            this.BtnDelete.HeaderText = "Baja";
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Text = "Baja";
            this.BtnDelete.Width = 50;
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 377);
            this.Controls.Add(this.GbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BajaRol";
            this.Text = "Baja Rol";
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.CheckBox ChkSearchExact;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblNombreRol;
        private System.Windows.Forms.DataGridView DgvRoles;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}