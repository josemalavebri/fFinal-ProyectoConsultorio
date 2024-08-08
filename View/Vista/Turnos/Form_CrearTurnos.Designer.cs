namespace View.Vista.Turnos
{
    partial class Form_CrearTurnos
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
            cmb_jornada = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            date_fecha = new DateTimePicker();
            txt_hora = new TextBox();
            txt_minuto = new TextBox();
            label4 = new Label();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            btn_resetear = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            cmb_medico = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmb_jornada
            // 
            cmb_jornada.Font = new Font("Century Gothic", 10.8F);
            cmb_jornada.FormattingEnabled = true;
            cmb_jornada.Items.AddRange(new object[] { "Matutina", "Vespertina" });
            cmb_jornada.Location = new Point(117, 127);
            cmb_jornada.Name = "cmb_jornada";
            cmb_jornada.Size = new Size(159, 27);
            cmb_jornada.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F);
            label1.Location = new Point(41, 130);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Jornada:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F);
            label2.Location = new Point(41, 176);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F);
            label3.Location = new Point(41, 222);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha:";
            // 
            // date_fecha
            // 
            date_fecha.Font = new Font("Century Gothic", 10.8F);
            date_fecha.Location = new Point(106, 222);
            date_fecha.Name = "date_fecha";
            date_fecha.Size = new Size(295, 25);
            date_fecha.TabIndex = 4;
            date_fecha.Value = new DateTime(2024, 8, 6, 0, 0, 0, 0);
            // 
            // txt_hora
            // 
            txt_hora.Font = new Font("Century Gothic", 10.8F);
            txt_hora.Location = new Point(95, 171);
            txt_hora.Name = "txt_hora";
            txt_hora.Size = new Size(69, 25);
            txt_hora.TabIndex = 5;
            // 
            // txt_minuto
            // 
            txt_minuto.Font = new Font("Century Gothic", 10.8F);
            txt_minuto.Location = new Point(282, 173);
            txt_minuto.Name = "txt_minuto";
            txt_minuto.Size = new Size(67, 25);
            txt_minuto.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F);
            label4.Location = new Point(212, 176);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "Minuto:";
            // 
            // btn_guardar
            // 
            btn_guardar.Font = new Font("Century Gothic", 10.8F);
            btn_guardar.Location = new Point(41, 265);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(144, 53);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Century Gothic", 10.8F);
            btn_cancelar.Location = new Point(257, 265);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(144, 53);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_resetear
            // 
            btn_resetear.Font = new Font("Century Gothic", 10.8F);
            btn_resetear.Location = new Point(150, 336);
            btn_resetear.Name = "btn_resetear";
            btn_resetear.Size = new Size(144, 53);
            btn_resetear.TabIndex = 10;
            btn_resetear.Text = "Resetear";
            btn_resetear.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(26, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(67, 72);
            panel2.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(9, 15);
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
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 17);
            panel1.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 133, 133);
            panel3.Location = new Point(1, 453);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 19);
            panel3.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F);
            label5.Location = new Point(41, 89);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 40;
            label5.Text = "Medico";
            // 
            // cmb_medico
            // 
            cmb_medico.Font = new Font("Century Gothic", 10.8F);
            cmb_medico.FormattingEnabled = true;
            cmb_medico.Location = new Point(117, 82);
            cmb_medico.Name = "cmb_medico";
            cmb_medico.Size = new Size(159, 27);
            cmb_medico.TabIndex = 41;
            // 
            // Form_CrearTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 472);
            Controls.Add(cmb_medico);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btn_resetear);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar);
            Controls.Add(label4);
            Controls.Add(txt_minuto);
            Controls.Add(txt_hora);
            Controls.Add(date_fecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_jornada);
            Name = "Form_CrearTurnos";
            Text = "Form_CrearTurnos";
            Load += Form_CrearTurnos_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_jornada;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker date_fecha;
        private TextBox txt_hora;
        private TextBox txt_minuto;
        private Label label4;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Button btn_resetear;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private ComboBox cmb_medico;
    }
}