namespace View.Vista.Turnos
{
    partial class Form_Turno
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
            dgv_turnos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_turnos).BeginInit();
            SuspendLayout();
            // 
            // dgv_turnos
            // 
            dgv_turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turnos.Location = new Point(33, 63);
            dgv_turnos.Name = "dgv_turnos";
            dgv_turnos.Size = new Size(750, 236);
            dgv_turnos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Turnos:";
            // 
            // Form_Turnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 450);
            Controls.Add(label1);
            Controls.Add(dgv_turnos);
            Name = "Form_Turnos";
            Text = "Form_Turnos";
            Load += Form_Turnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_turnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_turnos;
        private Label label1;
    }
}