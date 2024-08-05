﻿namespace ConsultorioPrivado.Vista.Paciente
{
    partial class Paciente_form
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
            resetear_button = new Button();
            nuevo_button = new Button();
            buscar_button = new Button();
            cedula_text = new TextBox();
            label4 = new Label();
            label1 = new Label();
            paciente_dgv = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(637, 25);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(93, 31);
            resetear_button.TabIndex = 29;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // nuevo_button
            // 
            nuevo_button.Location = new Point(745, 18);
            nuevo_button.Name = "nuevo_button";
            nuevo_button.Size = new Size(172, 47);
            nuevo_button.TabIndex = 28;
            nuevo_button.Text = "Nuevo";
            nuevo_button.UseVisualStyleBackColor = true;
            nuevo_button.Click += nuevo_button_Click;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(513, 26);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(96, 29);
            buscar_button.TabIndex = 27;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            buscar_button.Click += buscar_button_Click;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(336, 29);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(148, 25);
            cedula_text.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 33);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 25;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 121);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 24;
            label1.Text = "Pacientes Agregados:";
            // 
            // paciente_dgv
            // 
            paciente_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paciente_dgv.Location = new Point(74, 154);
            paciente_dgv.Name = "paciente_dgv";
            paciente_dgv.RowHeadersWidth = 51;
            paciente_dgv.Size = new Size(843, 191);
            paciente_dgv.TabIndex = 23;
            paciente_dgv.CellClick += paciente_dgv_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(156, 219, 166);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(resetear_button);
            panel3.Controls.Add(cedula_text);
            panel3.Controls.Add(nuevo_button);
            panel3.Controls.Add(buscar_button);
            panel3.Font = new Font("Century Gothic", 10.8F);
            panel3.Location = new Point(-1, 9);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1021, 83);
            panel3.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(66, -5);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 72);
            panel2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = View.Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(9, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 133, 133);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 14);
            panel1.TabIndex = 37;
            // 
            // Paciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(971, 380);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(paciente_dgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Paciente_form";
            Text = "Pacientes";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetear_button;
        private Button nuevo_button;
        private Button buscar_button;
        private TextBox cedula_text;
        private Label label4;
        private Label label1;
        private DataGridView paciente_dgv;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminado;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}