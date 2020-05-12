namespace Parcial
{
    partial class FormActual
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReguistrsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDepartamenroConRegusitroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarDepartamentosToolStripMenuItem,
            this.listarReguistrsoToolStripMenuItem,
            this.listarDepartamenroConRegusitroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listarDepartamentosToolStripMenuItem
            // 
            this.listarDepartamentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarDepartamentosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.listarDepartamentosToolStripMenuItem.Name = "listarDepartamentosToolStripMenuItem";
            this.listarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            this.listarDepartamentosToolStripMenuItem.Text = "Listar Departamentos ";
            this.listarDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.listarDepartamentosToolStripMenuItem_Click);
            // 
            // listarReguistrsoToolStripMenuItem
            // 
            this.listarReguistrsoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarReguistrsoToolStripMenuItem.Name = "listarReguistrsoToolStripMenuItem";
            this.listarReguistrsoToolStripMenuItem.Size = new System.Drawing.Size(222, 25);
            this.listarReguistrsoToolStripMenuItem.Text = "Listar Reguistros Ingresados ";
            this.listarReguistrsoToolStripMenuItem.Click += new System.EventHandler(this.listarReguistrsoToolStripMenuItem_Click);
            // 
            // listarDepartamenroConRegusitroToolStripMenuItem
            // 
            this.listarDepartamenroConRegusitroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarDepartamenroConRegusitroToolStripMenuItem.Name = "listarDepartamenroConRegusitroToolStripMenuItem";
            this.listarDepartamenroConRegusitroToolStripMenuItem.Size = new System.Drawing.Size(265, 25);
            this.listarDepartamenroConRegusitroToolStripMenuItem.Text = "Listar Departamenro con regusitro ";
            this.listarDepartamenroConRegusitroToolStripMenuItem.Click += new System.EventHandler(this.listarDepartamenroConRegusitroToolStripMenuItem_Click);
            // 
            // FormActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 50);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormActual";
            this.Text = "FormActual";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarReguistrsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDepartamenroConRegusitroToolStripMenuItem;
    }
}