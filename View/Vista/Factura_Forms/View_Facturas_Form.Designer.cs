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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv_Factura).BeginInit();
            SuspendLayout();
            // 
            // Dgv_Factura
            // 
            Dgv_Factura.AllowUserToAddRows = false;
            Dgv_Factura.AllowUserToDeleteRows = false;
            Dgv_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Factura.Location = new Point(12, 98);
            Dgv_Factura.Name = "Dgv_Factura";
            Dgv_Factura.ReadOnly = true;
            Dgv_Factura.RowHeadersWidth = 51;
            Dgv_Factura.Size = new Size(901, 420);
            Dgv_Factura.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 62);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Tabla de Facturas:";
            // 
            // View_Facturas_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 530);
            Controls.Add(label1);
            Controls.Add(Dgv_Factura);
            Name = "View_Facturas_Form";
            Text = "View_Facturas_Form";
            Load += View_Facturas_Form_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Factura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgv_Factura;
        private Label label1;
    }
}