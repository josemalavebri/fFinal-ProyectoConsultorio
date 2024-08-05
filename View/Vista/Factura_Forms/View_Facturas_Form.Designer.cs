namespace View.Vista.Factura_Forms
{
    partial class View_Facturas_Form
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
            Dgv_Factura = new DataGridView();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Dgv_Factura).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Dgv_Factura
            // 
            Dgv_Factura.AllowUserToAddRows = false;
            Dgv_Factura.AllowUserToDeleteRows = false;
            Dgv_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Factura.Location = new Point(46, 55);
            Dgv_Factura.Margin = new Padding(3, 2, 3, 2);
            Dgv_Factura.Name = "Dgv_Factura";
            Dgv_Factura.ReadOnly = true;
            Dgv_Factura.RowHeadersWidth = 51;
            Dgv_Factura.Size = new Size(788, 315);
            Dgv_Factura.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(156, 219, 166);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Dgv_Factura);
            panel3.Location = new Point(3, 61);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(893, 375);
            panel3.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Factura:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(29, -3);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 72);
            panel2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(9, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // View_Facturas_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(908, 398);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "View_Facturas_Form";
            Text = "View_Facturas_Form";
            Load += View_Facturas_Form_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Factura).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Dgv_Factura;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}