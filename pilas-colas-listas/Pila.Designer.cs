namespace pilas_colas_listas
{
    partial class Pila
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtIdentificacionUsuario = new System.Windows.Forms.TextBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNombreCanal = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(56, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Identificación";
            // 
            // txtIdentificacionUsuario
            // 
            this.txtIdentificacionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacionUsuario.Location = new System.Drawing.Point(226, 73);
            this.txtIdentificacionUsuario.Name = "txtIdentificacionUsuario";
            this.txtIdentificacionUsuario.Size = new System.Drawing.Size(219, 26);
            this.txtIdentificacionUsuario.TabIndex = 6;
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbEstrato.Location = new System.Drawing.Point(226, 129);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(219, 21);
            this.cmbEstrato.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de ubicación";
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Items.AddRange(new object[] {
            "Rural",
            "Urbana"});
            this.cmbUbicacion.Location = new System.Drawing.Point(226, 176);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(219, 21);
            this.cmbUbicacion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre canal";
            // 
            // cmbNombreCanal
            // 
            this.cmbNombreCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCanal.FormattingEnabled = true;
            this.cmbNombreCanal.Items.AddRange(new object[] {
            "Canal 1",
            "Canal Institucional",
            "Caracol",
            "RCN"});
            this.cmbNombreCanal.Location = new System.Drawing.Point(226, 229);
            this.cmbNombreCanal.Name = "cmbNombreCanal";
            this.cmbNombreCanal.Size = new System.Drawing.Size(219, 21);
            this.cmbNombreCanal.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registratToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.saliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registratToolStripMenuItem
            // 
            this.registratToolStripMenuItem.Name = "registratToolStripMenuItem";
            this.registratToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registratToolStripMenuItem.Text = "Registrar";
            this.registratToolStripMenuItem.Click += new System.EventHandler(this.registratToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // saliToolStripMenuItem
            // 
            this.saliToolStripMenuItem.Name = "saliToolStripMenuItem";
            this.saliToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saliToolStripMenuItem.Text = "Sali";
            this.saliToolStripMenuItem.Click += new System.EventHandler(this.saliToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNombreCanal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtIdentificacionUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pila";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtIdentificacionUsuario;
        private System.Windows.Forms.ComboBox cmbEstrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNombreCanal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saliToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}