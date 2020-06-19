namespace pilas_colas_listas
{
    partial class Menu
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
            this.btnPila = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPila
            // 
            this.btnPila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPila.FlatAppearance.BorderSize = 0;
            this.btnPila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(5)))), ((int)(((byte)(82)))));
            this.btnPila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPila.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPila.Location = new System.Drawing.Point(346, 149);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(100, 30);
            this.btnPila.TabIndex = 7;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = false;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(5)))), ((int)(((byte)(82)))));
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLista.Location = new System.Drawing.Point(346, 227);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(100, 30);
            this.btnLista.TabIndex = 8;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnCola
            // 
            this.btnCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCola.FlatAppearance.BorderSize = 0;
            this.btnCola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(5)))), ((int)(((byte)(82)))));
            this.btnCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCola.Location = new System.Drawing.Point(346, 307);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(100, 30);
            this.btnCola.TabIndex = 9;
            this.btnCola.Text = "Cola";
            this.btnCola.UseVisualStyleBackColor = false;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(251, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(290, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Menu estructuras de datos lineales";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnPila);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Label lblPassword;
    }
}