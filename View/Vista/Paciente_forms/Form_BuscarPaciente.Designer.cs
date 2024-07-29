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
            ((System.ComponentModel.ISupportInitialize)dgv_paciente).BeginInit();
            SuspendLayout();
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(353, 17);
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
            btn_guardar.Location = new Point(409, 404);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(197, 63);
            btn_guardar.TabIndex = 28;
            btn_guardar.Text = "Seleccionar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(222, 19);
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
            cedula_text.Location = new Point(73, 25);
            cedula_text.Margin = new Padding(3, 4, 3, 4);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(114, 27);
            cedula_text.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 28);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 25;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 84);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 24;
            label1.Text = "Pacientes Agregados:";
            // 
            // dgv_paciente
            // 
            dgv_paciente.AllowUserToAddRows = false;
            dgv_paciente.AllowUserToDeleteRows = false;
            dgv_paciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_paciente.Location = new Point(14, 128);
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
            label2.Location = new Point(18, 432);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 30;
            label2.Text = "Paciente Seleccionado";
            // 
            // txt_pacienteSelec
            // 
            txt_pacienteSelec.Location = new Point(185, 421);
            txt_pacienteSelec.Margin = new Padding(3, 4, 3, 4);
            txt_pacienteSelec.Name = "txt_pacienteSelec";
            txt_pacienteSelec.Size = new Size(146, 27);
            txt_pacienteSelec.TabIndex = 31;
            // 
            // Form_BuscarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 599);
            Controls.Add(txt_pacienteSelec);
            Controls.Add(label2);
            Controls.Add(resetear_button);
            Controls.Add(btn_guardar);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dgv_paciente);
            Name = "Form_BuscarPaciente";
            Text = "Pacientes";
            Load += Form_BuscarPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_paciente).EndInit();
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
    }
}