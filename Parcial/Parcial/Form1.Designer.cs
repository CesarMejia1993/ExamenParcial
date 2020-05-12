namespace Parcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(734, 45);
            this.label5.TabIndex = 82;
            this.label5.Text = "Mediciones De Lluvia Departamentales de Guatemala";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.acionesToolStripMenuItem,
            this.informacionActualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 44);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(111, 40);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // acionesToolStripMenuItem
            // 
            this.acionesToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acionesToolStripMenuItem.Name = "acionesToolStripMenuItem";
            this.acionesToolStripMenuItem.Size = new System.Drawing.Size(105, 40);
            this.acionesToolStripMenuItem.Text = "Aciones";
            this.acionesToolStripMenuItem.Click += new System.EventHandler(this.acionesToolStripMenuItem_Click);
            // 
            // informacionActualToolStripMenuItem
            // 
            this.informacionActualToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacionActualToolStripMenuItem.Name = "informacionActualToolStripMenuItem";
            this.informacionActualToolStripMenuItem.Size = new System.Drawing.Size(226, 40);
            this.informacionActualToolStripMenuItem.Text = "Informacion Actual";
            this.informacionActualToolStripMenuItem.Click += new System.EventHandler(this.informacionActualToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionActualToolStripMenuItem;
    }
}

