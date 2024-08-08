namespace View.Vista.Factura_Forms
{
    partial class Form_Factura
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
            total_text = new TextBox();
            sub_text = new TextBox();
            label9 = new Label();
            label8 = new Label();
            paciente_text = new TextBox();
            medico_text = new TextBox();
            id_turno_text = new TextBox();
            fecha_text = new TextBox();
            id_cita_text = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Guardar = new Button();
            label11 = new Label();
            hora_text = new TextBox();
            groupBox1 = new GroupBox();
            especialidad_text = new TextBox();
            label3 = new Label();
            label5 = new Label();
            precio_text = new TextBox();
            SuspendLayout();
            // 
            // total_text
            // 
            total_text.Enabled = false;
            total_text.Location = new Point(436, 264);
            total_text.Margin = new Padding(3, 2, 3, 2);
            total_text.Name = "total_text";
            total_text.ReadOnly = true;
            total_text.Size = new Size(161, 23);
            total_text.TabIndex = 37;
            // 
            // sub_text
            // 
            sub_text.Enabled = false;
            sub_text.Location = new Point(179, 264);
            sub_text.Margin = new Padding(3, 2, 3, 2);
            sub_text.Name = "sub_text";
            sub_text.ReadOnly = true;
            sub_text.Size = new Size(139, 23);
            sub_text.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(355, 256);
            label9.Name = "label9";
            label9.Size = new Size(73, 43);
            label9.TabIndex = 35;
            label9.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 256);
            label8.Name = "label8";
            label8.Size = new Size(102, 43);
            label8.TabIndex = 34;
            label8.Text = "Subtotal:";
            // 
            // paciente_text
            // 
            paciente_text.Enabled = false;
            paciente_text.Location = new Point(613, 104);
            paciente_text.Margin = new Padding(3, 2, 3, 2);
            paciente_text.Name = "paciente_text";
            paciente_text.ReadOnly = true;
            paciente_text.Size = new Size(237, 23);
            paciente_text.TabIndex = 33;
            // 
            // medico_text
            // 
            medico_text.Enabled = false;
            medico_text.Location = new Point(172, 142);
            medico_text.Margin = new Padding(3, 2, 3, 2);
            medico_text.Name = "medico_text";
            medico_text.ReadOnly = true;
            medico_text.Size = new Size(238, 23);
            medico_text.TabIndex = 32;
            // 
            // id_turno_text
            // 
            id_turno_text.Enabled = false;
            id_turno_text.Location = new Point(172, 182);
            id_turno_text.Margin = new Padding(3, 2, 3, 2);
            id_turno_text.Name = "id_turno_text";
            id_turno_text.ReadOnly = true;
            id_turno_text.Size = new Size(259, 23);
            id_turno_text.TabIndex = 30;
            // 
            // fecha_text
            // 
            fecha_text.Enabled = false;
            fecha_text.Location = new Point(172, 220);
            fecha_text.Margin = new Padding(3, 2, 3, 2);
            fecha_text.Name = "fecha_text";
            fecha_text.ReadOnly = true;
            fecha_text.Size = new Size(110, 23);
            fecha_text.TabIndex = 29;
            // 
            // id_cita_text
            // 
            id_cita_text.Enabled = false;
            id_cita_text.Location = new Point(172, 104);
            id_cita_text.Margin = new Padding(3, 2, 3, 2);
            id_cita_text.Name = "id_cita_text";
            id_cita_text.ReadOnly = true;
            id_cita_text.Size = new Size(110, 23);
            id_cita_text.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(56, 96);
            label7.Name = "label7";
            label7.Size = new Size(92, 43);
            label7.TabIndex = 26;
            label7.Text = "ID Cita:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 212);
            label6.Name = "label6";
            label6.Size = new Size(79, 43);
            label6.TabIndex = 25;
            label6.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 174);
            label4.Name = "label4";
            label4.Size = new Size(80, 43);
            label4.TabIndex = 23;
            label4.Text = "Turno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 135);
            label2.Name = "label2";
            label2.Size = new Size(93, 43);
            label2.TabIndex = 21;
            label2.Text = "Medico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(496, 96);
            label1.Name = "label1";
            label1.Size = new Size(103, 43);
            label1.TabIndex = 20;
            label1.Text = "Paciente:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(395, 386);
            btn_Guardar.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(130, 32);
            btn_Guardar.TabIndex = 40;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(337, 212);
            label11.Name = "label11";
            label11.Size = new Size(70, 43);
            label11.TabIndex = 41;
            label11.Text = "Hora:";
            // 
            // hora_text
            // 
            hora_text.Enabled = false;
            hora_text.Location = new Point(416, 220);
            hora_text.Margin = new Padding(3, 2, 3, 2);
            hora_text.Name = "hora_text";
            hora_text.ReadOnly = true;
            hora_text.Size = new Size(110, 23);
            hora_text.TabIndex = 42;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 48);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(855, 281);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Ticket";
            // 
            // especialidad_text
            // 
            especialidad_text.Enabled = false;
            especialidad_text.Location = new Point(613, 142);
            especialidad_text.Margin = new Padding(3, 2, 3, 2);
            especialidad_text.Name = "especialidad_text";
            especialidad_text.ReadOnly = true;
            especialidad_text.Size = new Size(237, 23);
            especialidad_text.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(455, 135);
            label3.Name = "label3";
            label3.Size = new Size(142, 43);
            label3.TabIndex = 22;
            label3.Text = "Especialidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 174);
            label5.Name = "label5";
            label5.Size = new Size(83, 43);
            label5.TabIndex = 24;
            label5.Text = "Precio:";
            // 
            // precio_text
            // 
            precio_text.Enabled = false;
            precio_text.Location = new Point(613, 182);
            precio_text.Margin = new Padding(3, 2, 3, 2);
            precio_text.Name = "precio_text";
            precio_text.ReadOnly = true;
            precio_text.Size = new Size(135, 23);
            precio_text.TabIndex = 28;
            // 
            // Form_Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(889, 464);
            Controls.Add(hora_text);
            Controls.Add(label11);
            Controls.Add(btn_Guardar);
            Controls.Add(total_text);
            Controls.Add(sub_text);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(paciente_text);
            Controls.Add(medico_text);
            Controls.Add(especialidad_text);
            Controls.Add(id_turno_text);
            Controls.Add(fecha_text);
            Controls.Add(precio_text);
            Controls.Add(id_cita_text);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Factura";
            Text = "Form_Factura";
            Load += Form_Factura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox total_text;
        private TextBox sub_text;
        private Label label9;
        private Label label8;
        private TextBox paciente_text;
        private TextBox medico_text;
        private TextBox id_turno_text;
        private TextBox fecha_text;
        private TextBox id_cita_text;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btn_Guardar;
        private Label label11;
        private TextBox hora_text;
        private GroupBox groupBox1;
        private TextBox especialidad_text;
        private Label label3;
        private Label label5;
        private TextBox precio_text;
    }
}