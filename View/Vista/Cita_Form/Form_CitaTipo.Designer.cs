namespace View.Vista.Cita_Form
{
    partial class Form_CitaTipo
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
            btn_pacienteRecurrente = new Button();
            btn_pacienteNuevo = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_pacienteRecurrente
            // 
            btn_pacienteRecurrente.BackColor = Color.FromArgb(70, 133, 133);
            btn_pacienteRecurrente.FlatAppearance.BorderSize = 0;
            btn_pacienteRecurrente.FlatStyle = FlatStyle.Flat;
            btn_pacienteRecurrente.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pacienteRecurrente.ForeColor = SystemColors.ButtonFace;
            btn_pacienteRecurrente.Location = new Point(187, 211);
            btn_pacienteRecurrente.Margin = new Padding(3, 4, 3, 4);
            btn_pacienteRecurrente.Name = "btn_pacienteRecurrente";
            btn_pacienteRecurrente.Size = new Size(164, 80);
            btn_pacienteRecurrente.TabIndex = 1;
            btn_pacienteRecurrente.Text = "Paciente Recurrente";
            btn_pacienteRecurrente.UseVisualStyleBackColor = false;
            btn_pacienteRecurrente.Click += btn_pacienteRecurrente_Click;
            // 
            // btn_pacienteNuevo
            // 
            btn_pacienteNuevo.BackColor = Color.FromArgb(70, 133, 133);
            btn_pacienteNuevo.FlatAppearance.BorderSize = 0;
            btn_pacienteNuevo.FlatStyle = FlatStyle.Flat;
            btn_pacienteNuevo.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pacienteNuevo.ForeColor = SystemColors.ButtonFace;
            btn_pacienteNuevo.Location = new Point(187, 91);
            btn_pacienteNuevo.Margin = new Padding(3, 4, 3, 4);
            btn_pacienteNuevo.Name = "btn_pacienteNuevo";
            btn_pacienteNuevo.Size = new Size(164, 80);
            btn_pacienteNuevo.TabIndex = 0;
            btn_pacienteNuevo.Text = "Paciente Nuevo";
            btn_pacienteNuevo.UseVisualStyleBackColor = false;
            btn_pacienteNuevo.Click += btn_pacienteNuevo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 133, 133);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 23);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(39, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 96);
            panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(11, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 133, 133);
            panel3.Location = new Point(0, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(522, 25);
            panel3.TabIndex = 33;
            // 
            // Form_CitaTipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(519, 399);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_pacienteRecurrente);
            Controls.Add(btn_pacienteNuevo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_CitaTipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cita";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_pacienteRecurrente;
        private Button btn_pacienteNuevo;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
    }
}