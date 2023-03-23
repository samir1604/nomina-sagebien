namespace ExlsToDbf
{
    partial class HomeForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenuDbf = new System.Windows.Forms.Button();
            this.btnMenuXls = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnMenuDbf);
            this.panelMenu.Controls.Add(this.btnMenuXls);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMenuDbf
            // 
            this.btnMenuDbf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuDbf.FlatAppearance.BorderSize = 0;
            this.btnMenuDbf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuDbf.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuDbf.Image = global::ExlsToDbf.Properties.Resources.pngwing1;
            this.btnMenuDbf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDbf.Location = new System.Drawing.Point(0, 140);
            this.btnMenuDbf.Name = "btnMenuDbf";
            this.btnMenuDbf.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuDbf.Size = new System.Drawing.Size(200, 60);
            this.btnMenuDbf.TabIndex = 2;
            this.btnMenuDbf.Text = "DBF";
            this.btnMenuDbf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDbf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuDbf.UseVisualStyleBackColor = true;
            this.btnMenuDbf.Click += new System.EventHandler(this.btnMenuDbf_Click);
            // 
            // btnMenuXls
            // 
            this.btnMenuXls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuXls.FlatAppearance.BorderSize = 0;
            this.btnMenuXls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuXls.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuXls.Image = global::ExlsToDbf.Properties.Resources.menu_button_excel;
            this.btnMenuXls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuXls.Location = new System.Drawing.Point(0, 80);
            this.btnMenuXls.Name = "btnMenuXls";
            this.btnMenuXls.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuXls.Size = new System.Drawing.Size(200, 60);
            this.btnMenuXls.TabIndex = 1;
            this.btnMenuXls.Text = "Prenómima";
            this.btnMenuXls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuXls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuXls.UseVisualStyleBackColor = true;
            this.btnMenuXls.Click += new System.EventHandler(this.btnMenuXls_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "HomeForm";
            this.Text = "Creador de Pago";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnMenuXls;
        private Panel panelLogo;
        private Button btnMenuDbf;
    }
}