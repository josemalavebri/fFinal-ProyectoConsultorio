namespace ConsultorioPrivado.Vista.Paciente
{
    partial class Form_BuscarPaciente
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
            btn_guardar = new Button();
            buscar_button = new Button();
            cedula_text = new TextBox();
            label4 = new Label();
            label1 = new Label();
            dgv_paciente = new DataGridView();
            label2 = new Label();
            txt_pacienteSelec = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_paciente).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(729, 35);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(106, 41);
            resetear_button.TabIndex = 29;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(70, 133, 133);
            btn_guardar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = SystemColors.ButtonHighlight;
            btn_guardar.Location = new Point(791, 455);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(197, 63);
            btn_guardar.TabIndex = 28;
            btn_guardar.Text = "Seleccionar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(598, 36);
            buscar_button.Margin = new Padding(3, 4, 3, 4);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(110, 39);
            buscar_button.TabIndex = 27;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            buscar_button.Click += buscar_button_Click;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(383, 39);
            cedula_text.Margin = new Padding(3, 4, 3, 4);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(196, 30);
            cedula_text.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 45);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 25;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 151);
            label1.Name = "label1";
            label1.Size = new Size(206, 21);
            label1.TabIndex = 24;
            label1.Text = "Pacientes Agregados:";
            // 
            // dgv_paciente
            // 
            dgv_paciente.AllowUserToAddRows = false;
            dgv_paciente.AllowUserToDeleteRows = false;
            dgv_paciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_paciente.Location = new Point(74, 192);
            dgv_paciente.Margin = new Padding(3, 4, 3, 4);
            dgv_paciente.Name = "dgv_paciente";
            dgv_paciente.ReadOnly = true;
            dgv_paciente.RowHeadersWidth = 51;
            dgv_paciente.Size = new Size(963, 255);
            dgv_paciente.TabIndex = 23;
            dgv_paciente.CellContentClick += dgv_paciente_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 479);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 30;
            label2.Text = "Paciente Seleccionado";
            // 
            // txt_pacienteSelec
            // 
            txt_pacienteSelec.Location = new Point(460, 477);
            txt_pacienteSelec.Margin = new Padding(3, 4, 3, 4);
            txt_pacienteSelec.Name = "txt_pacienteSelec";
            txt_pacienteSelec.Size = new Size(146, 27);
            txt_pacienteSelec.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(156, 219, 166);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cedula_text);
            panel3.Controls.Add(buscar_button);
            panel3.Controls.Add(resetear_button);
            panel3.Font = new Font("Century Gothic", 10.8F);
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 111);
            panel3.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(76, -7);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 96);
            panel2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = View.Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(10, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 133, 133);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 18);
            panel1.TabIndex = 35;
            // 
            // Form_BuscarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 554);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txt_pacienteSelec);
            Controls.Add(label2);
            Controls.Add(btn_guardar);
            Controls.Add(label1);
            Controls.Add(dgv_paciente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_BuscarPaciente";
            Text = "Pacientes";
            Load += Form_BuscarPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_paciente).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetear_button;
        private Button btn_guardar;
        private Button buscar_button;
        private TextBox cedula_text;
        private Label label4;
        private Label label1;
        private DataGridView dgv_paciente;
        private Label label2;
        private TextBox txt_pacienteSelec;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}