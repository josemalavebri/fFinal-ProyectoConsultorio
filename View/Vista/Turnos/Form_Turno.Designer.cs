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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            lbl_pendientes = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lbl_completados = new Label();
            label2 = new Label();
            btn_turnoIndi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_turnos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_turnos
            // 
            dgv_turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turnos.Location = new Point(25, 36);
            dgv_turnos.Name = "dgv_turnos";
            dgv_turnos.RowHeadersWidth = 51;
            dgv_turnos.Size = new Size(589, 264);
            dgv_turnos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 13);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Turnos:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 133, 133);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 14);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(65, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 72);
            panel2.TabIndex = 39;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(156, 219, 166);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btn_turnoIndi);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dgv_turnos);
            panel3.Location = new Point(12, 78);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(922, 340);
            panel3.TabIndex = 40;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lbl_pendientes);
            panel6.Controls.Add(label4);
            panel6.Font = new Font("Century Gothic", 10.8F);
            panel6.Location = new Point(761, 63);
            panel6.Name = "panel6";
            panel6.Size = new Size(123, 86);
            panel6.TabIndex = 5;
            // 
            // lbl_pendientes
            // 
            lbl_pendientes.AutoSize = true;
            lbl_pendientes.Location = new Point(53, 51);
            lbl_pendientes.Name = "lbl_pendientes";
            lbl_pendientes.Size = new Size(17, 20);
            lbl_pendientes.TabIndex = 3;
            lbl_pendientes.Text = "0";
            lbl_pendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 16);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 2;
            label4.Text = "Pendientes:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lime;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lbl_completados);
            panel4.Controls.Add(label2);
            panel4.Font = new Font("Century Gothic", 10.8F);
            panel4.Location = new Point(630, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(123, 86);
            panel4.TabIndex = 4;
            // 
            // lbl_completados
            // 
            lbl_completados.AutoSize = true;
            lbl_completados.Location = new Point(52, 51);
            lbl_completados.Name = "lbl_completados";
            lbl_completados.Size = new Size(17, 20);
            lbl_completados.TabIndex = 1;
            lbl_completados.Text = "0";
            lbl_completados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 16);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Completados:";
            // 
            // btn_turnoIndi
            // 
            btn_turnoIndi.Font = new Font("Century Gothic", 10.8F);
            btn_turnoIndi.Location = new Point(683, 203);
            btn_turnoIndi.Name = "btn_turnoIndi";
            btn_turnoIndi.Size = new Size(189, 50);
            btn_turnoIndi.TabIndex = 2;
            btn_turnoIndi.Text = "Crear Turno";
            btn_turnoIndi.UseVisualStyleBackColor = true;
            btn_turnoIndi.Click += btn_turnoIndi_Click;
            // 
            // Form_Turno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(946, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Turno";
            Text = "Form_Turnos";
            Load += Form_Turnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_turnos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_turnos;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_turnoIndi;
        private Panel panel6;
        private Panel panel4;
        private Label lbl_pendientes;
        private Label label4;
        private Label lbl_completados;
        private Label label2;
    }
}