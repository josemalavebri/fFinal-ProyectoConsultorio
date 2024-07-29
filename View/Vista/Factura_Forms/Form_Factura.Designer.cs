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
            combo_Metodo = new ComboBox();
            label10 = new Label();
            total_text = new TextBox();
            sub_text = new TextBox();
            label9 = new Label();
            label8 = new Label();
            paciente_text = new TextBox();
            medico_text = new TextBox();
            especialidad_text = new TextBox();
            id_turno_text = new TextBox();
            fecha_text = new TextBox();
            precio_text = new TextBox();
            id_cita_text = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Guardar = new Button();
            label11 = new Label();
            hora_text = new TextBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // combo_Metodo
            // 
            combo_Metodo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Metodo.FormattingEnabled = true;
            combo_Metodo.Location = new Point(285, 426);
            combo_Metodo.Name = "combo_Metodo";
            combo_Metodo.Size = new Size(330, 28);
            combo_Metodo.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(66, 416);
            label10.Name = "label10";
            label10.Size = new Size(204, 52);
            label10.TabIndex = 38;
            label10.Text = "Metodo de pago:";
            // 
            // total_text
            // 
            total_text.Enabled = false;
            total_text.Location = new Point(498, 352);
            total_text.Name = "total_text";
            total_text.ReadOnly = true;
            total_text.Size = new Size(183, 27);
            total_text.TabIndex = 37;
            // 
            // sub_text
            // 
            sub_text.Enabled = false;
            sub_text.Location = new Point(205, 352);
            sub_text.Name = "sub_text";
            sub_text.ReadOnly = true;
            sub_text.Size = new Size(158, 27);
            sub_text.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(406, 342);
            label9.Name = "label9";
            label9.Size = new Size(86, 52);
            label9.TabIndex = 35;
            label9.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(66, 342);
            label8.Name = "label8";
            label8.Size = new Size(123, 52);
            label8.TabIndex = 34;
            label8.Text = "Subtotal:";
            // 
            // paciente_text
            // 
            paciente_text.Enabled = false;
            paciente_text.Location = new Point(701, 138);
            paciente_text.Name = "paciente_text";
            paciente_text.ReadOnly = true;
            paciente_text.Size = new Size(270, 27);
            paciente_text.TabIndex = 33;
            // 
            // medico_text
            // 
            medico_text.Enabled = false;
            medico_text.Location = new Point(197, 190);
            medico_text.Name = "medico_text";
            medico_text.ReadOnly = true;
            medico_text.Size = new Size(272, 27);
            medico_text.TabIndex = 32;
            // 
            // especialidad_text
            // 
            especialidad_text.Enabled = false;
            especialidad_text.Location = new Point(701, 190);
            especialidad_text.Name = "especialidad_text";
            especialidad_text.ReadOnly = true;
            especialidad_text.Size = new Size(270, 27);
            especialidad_text.TabIndex = 31;
            // 
            // id_turno_text
            // 
            id_turno_text.Enabled = false;
            id_turno_text.Location = new Point(197, 242);
            id_turno_text.Name = "id_turno_text";
            id_turno_text.ReadOnly = true;
            id_turno_text.Size = new Size(295, 27);
            id_turno_text.TabIndex = 30;
            // 
            // fecha_text
            // 
            fecha_text.Enabled = false;
            fecha_text.Location = new Point(197, 293);
            fecha_text.Name = "fecha_text";
            fecha_text.ReadOnly = true;
            fecha_text.Size = new Size(125, 27);
            fecha_text.TabIndex = 29;
            // 
            // precio_text
            // 
            precio_text.Enabled = false;
            precio_text.Location = new Point(701, 242);
            precio_text.Name = "precio_text";
            precio_text.ReadOnly = true;
            precio_text.Size = new Size(154, 27);
            precio_text.TabIndex = 28;
            // 
            // id_cita_text
            // 
            id_cita_text.Enabled = false;
            id_cita_text.Location = new Point(197, 138);
            id_cita_text.Name = "id_cita_text";
            id_cita_text.ReadOnly = true;
            id_cita_text.Size = new Size(125, 27);
            id_cita_text.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 128);
            label7.Name = "label7";
            label7.Size = new Size(110, 52);
            label7.TabIndex = 26;
            label7.Text = "ID Cita:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 283);
            label6.Name = "label6";
            label6.Size = new Size(94, 52);
            label6.TabIndex = 25;
            label6.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(567, 232);
            label5.Name = "label5";
            label5.Size = new Size(100, 52);
            label5.TabIndex = 24;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 232);
            label4.Name = "label4";
            label4.Size = new Size(96, 52);
            label4.TabIndex = 23;
            label4.Text = "Turno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(520, 180);
            label3.Name = "label3";
            label3.Size = new Size(170, 52);
            label3.TabIndex = 22;
            label3.Text = "Especialidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 180);
            label2.Name = "label2";
            label2.Size = new Size(111, 52);
            label2.TabIndex = 21;
            label2.Text = "Medico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(567, 128);
            label1.Name = "label1";
            label1.Size = new Size(123, 52);
            label1.TabIndex = 20;
            label1.Text = "Paciente:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(451, 514);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(149, 42);
            btn_Guardar.TabIndex = 40;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(385, 283);
            label11.Name = "label11";
            label11.Size = new Size(84, 52);
            label11.TabIndex = 41;
            label11.Text = "Hora:";
            // 
            // hora_text
            // 
            hora_text.Enabled = false;
            hora_text.Location = new Point(475, 293);
            hora_text.Name = "hora_text";
            hora_text.ReadOnly = true;
            hora_text.Size = new Size(125, 27);
            hora_text.TabIndex = 42;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 427);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Factura";
            // 
            // Form_Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1016, 618);
            Controls.Add(hora_text);
            Controls.Add(label11);
            Controls.Add(btn_Guardar);
            Controls.Add(combo_Metodo);
            Controls.Add(label10);
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
            Name = "Form_Factura";
            Text = "Form_Factura";
            Load += Form_Factura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Metodo;
        private Label label10;
        private TextBox total_text;
        private TextBox sub_text;
        private Label label9;
        private Label label8;
        private TextBox paciente_text;
        private TextBox medico_text;
        private TextBox especialidad_text;
        private TextBox id_turno_text;
        private TextBox fecha_text;
        private TextBox precio_text;
        private TextBox id_cita_text;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Guardar;
        private Label label11;
        private TextBox hora_text;
        private GroupBox groupBox1;
    }
}