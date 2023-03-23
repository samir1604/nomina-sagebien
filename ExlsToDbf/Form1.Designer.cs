namespace ExlsToDbf
{
    partial class Forma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxPath = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblSumaMoney = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xls:";
            // 
            // tBoxPath
            // 
            this.tBoxPath.Location = new System.Drawing.Point(43, 15);
            this.tBoxPath.Name = "tBoxPath";
            this.tBoxPath.Size = new System.Drawing.Size(442, 23);
            this.tBoxPath.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(636, 15);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(91, 26);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Crear Dbf";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(491, 15);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(36, 23);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 47);
            this.Grid.Name = "Grid";
            this.Grid.RowTemplate.Height = 25;
            this.Grid.Size = new System.Drawing.Size(717, 417);
            this.Grid.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Trabajadores:";
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Location = new System.Drawing.Point(122, 467);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(13, 15);
            this.lblSumTotal.TabIndex = 6;
            this.lblSumTotal.Text = "0";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(535, 467);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(65, 15);
            this.lblTotalMoney.TabIndex = 7;
            this.lblTotalMoney.Text = "Total Pago:";
            // 
            // lblSumaMoney
            // 
            this.lblSumaMoney.AutoSize = true;
            this.lblSumaMoney.Location = new System.Drawing.Point(606, 467);
            this.lblSumaMoney.Name = "lblSumaMoney";
            this.lblSumaMoney.Size = new System.Drawing.Size(13, 15);
            this.lblSumaMoney.TabIndex = 8;
            this.lblSumaMoney.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargar Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSumaMoney);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblSumTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tBoxPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xls To Dbf";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tBoxPath;
        private Button btnConvert;
        private Button btnPath;
        private DataGridView Grid;
        private Label lblTotal;
        private Label lblSumTotal;
        private Label lblTotalMoney;
        private Label lblSumaMoney;
        private Button button1;
    }
}