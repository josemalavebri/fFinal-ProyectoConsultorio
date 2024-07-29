namespace ConsultorioPrivado.Vista.Cita_Form
{
    partial class Form_GestionCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionCita));
            cancelar_button = new Button();
            resetear_button = new Button();
            agregar_button = new Button();
            medicos = new Label();
            combo_Medicos = new ComboBox();
            GBx_Cita = new GroupBox();
            label1 = new Label();
            combo_Pacientes = new ComboBox();
            description = new Label();
            description_text = new TextBox();
            PBx_Close = new PictureBox();
            turnos_dgv = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txt_turnoFecha = new TextBox();
            txt_turnoHora = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            GBx_Cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBx_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnos_dgv).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cancelar_button
            // 
            cancelar_button.BackColor = Color.FromArgb(70, 133, 133);
            cancelar_button.FlatStyle = FlatStyle.Flat;
            cancelar_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            cancelar_button.ForeColor = SystemColors.ButtonHighlight;
            cancelar_button.Location = new Point(505, 194);
            cancelar_button.Margin = new Padding(3, 4, 3, 4);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(106, 51);
            cancelar_button.TabIndex = 31;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = false;
            cancelar_button.Click += cancelar_button_Click;
            // 
            // resetear_button
            // 
            resetear_button.BackColor = Color.FromArgb(70, 133, 133);
            resetear_button.FlatStyle = FlatStyle.Flat;
            resetear_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            resetear_button.ForeColor = SystemColors.ButtonHighlight;
            resetear_button.Location = new Point(505, 121);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(106, 51);
            resetear_button.TabIndex = 26;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = false;
            resetear_button.Click += resetear_button_Click;
            // 
            // agregar_button
            // 
            agregar_button.BackColor = Color.FromArgb(70, 133, 133);
            agregar_button.FlatAppearance.BorderSize = 0;
            agregar_button.FlatStyle = FlatStyle.Flat;
            agregar_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregar_button.ForeColor = SystemColors.ButtonHighlight;
            agregar_button.Location = new Point(474, 684);
            agregar_button.Margin = new Padding(3, 4, 3, 4);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(106, 51);
            agregar_button.TabIndex = 25;
            agregar_button.Text = "Aceptar";
            agregar_button.UseVisualStyleBackColor = false;
            agregar_button.Click += agregar_button_Click;
            // 
            // medicos
            // 
            medicos.AutoSize = true;
            medicos.Font = new Font("Century Gothic", 10.8F);
            medicos.Location = new Point(38, 87);
            medicos.Name = "medicos";
            medicos.Size = new Size(85, 21);
            medicos.TabIndex = 31;
            medicos.Text = "Medicos";
            // 
            // combo_Medicos
            // 
            combo_Medicos.BackColor = SystemColors.Window;
            combo_Medicos.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Medicos.FormattingEnabled = true;
            combo_Medicos.Location = new Point(141, 88);
            combo_Medicos.Margin = new Padding(3, 4, 3, 4);
            combo_Medicos.Name = "combo_Medicos";
            combo_Medicos.Size = new Size(251, 28);
            combo_Medicos.TabIndex = 32;
            combo_Medicos.SelectedIndexChanged += combo_Medicos_SelectedIndexChanged;
            // 
            // GBx_Cita
            // 
            GBx_Cita.BackColor = Color.FromArgb(156, 219, 166);
            GBx_Cita.Controls.Add(label1);
            GBx_Cita.Controls.Add(combo_Pacientes);
            GBx_Cita.Controls.Add(description);
            GBx_Cita.Controls.Add(combo_Medicos);
            GBx_Cita.Controls.Add(description_text);
            GBx_Cita.Controls.Add(medicos);
            GBx_Cita.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GBx_Cita.Location = new Point(65, 46);
            GBx_Cita.Name = "GBx_Cita";
            GBx_Cita.Size = new Size(417, 249);
            GBx_Cita.TabIndex = 33;
            GBx_Cita.TabStop = false;
            GBx_Cita.Text = "Detalles de la cita";
            GBx_Cita.Enter += GBx_Cita_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F);
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 37;
            label1.Text = "Paciente";
            // 
            // combo_Pacientes
            // 
            combo_Pacientes.BackColor = SystemColors.Window;
            combo_Pacientes.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Pacientes.ForeColor = SystemColors.Desktop;
            combo_Pacientes.FormattingEnabled = true;
            combo_Pacientes.Location = new Point(141, 32);
            combo_Pacientes.Margin = new Padding(3, 4, 3, 4);
            combo_Pacientes.Name = "combo_Pacientes";
            combo_Pacientes.Size = new Size(251, 28);
            combo_Pacientes.TabIndex = 30;
            // 
            // description
            // 
            description.AutoSize = true;
            description.BackColor = Color.FromArgb(156, 219, 166);
            description.Font = new Font("Century Gothic", 10.8F);
            description.Location = new Point(23, 164);
            description.Name = "description";
            description.Size = new Size(112, 21);
            description.TabIndex = 17;
            description.Text = "Descripcion";
            // 
            // description_text
            // 
            description_text.Location = new Point(141, 161);
            description_text.Margin = new Padding(3, 4, 3, 4);
            description_text.Multiline = true;
            description_text.Name = "description_text";
            description_text.Size = new Size(251, 64);
            description_text.TabIndex = 21;
            // 
            // PBx_Close
            // 
            PBx_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBx_Close.Image = (Image)resources.GetObject("PBx_Close.Image");
            PBx_Close.Location = new Point(629, 0);
            PBx_Close.Name = "PBx_Close";
            PBx_Close.Size = new Size(27, 28);
            PBx_Close.SizeMode = PictureBoxSizeMode.Zoom;
            PBx_Close.TabIndex = 32;
            PBx_Close.TabStop = false;
            PBx_Close.Click += PBx_Close_Click;
            // 
            // turnos_dgv
            // 
            turnos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            turnos_dgv.Location = new Point(65, 364);
            turnos_dgv.Margin = new Padding(3, 4, 3, 4);
            turnos_dgv.Name = "turnos_dgv";
            turnos_dgv.RowHeadersWidth = 51;
            turnos_dgv.Size = new Size(546, 304);
            turnos_dgv.TabIndex = 37;
            turnos_dgv.CellContentClick += turnos_dgv_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 325);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 38;
            label2.Text = "Turnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 693);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 39;
            label3.Text = "Turno";
            // 
            // txt_turnoFecha
            // 
            txt_turnoFecha.Location = new Point(137, 690);
            txt_turnoFecha.Margin = new Padding(3, 4, 3, 4);
            txt_turnoFecha.Name = "txt_turnoFecha";
            txt_turnoFecha.Size = new Size(101, 27);
            txt_turnoFecha.TabIndex = 40;
            // 
            // txt_turnoHora
            // 
            txt_turnoHora.Location = new Point(266, 692);
            txt_turnoHora.Margin = new Padding(3, 4, 3, 4);
            txt_turnoHora.Name = "txt_turnoHora";
            txt_turnoHora.Size = new Size(92, 27);
            txt_turnoHora.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 133, 133);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 27);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(519, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 80);
            panel2.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = View.Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form_GestionCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(657, 765);
            Controls.Add(panel2);
            Controls.Add(PBx_Close);
            Controls.Add(panel1);
            Controls.Add(txt_turnoHora);
            Controls.Add(txt_turnoFecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(turnos_dgv);
            Controls.Add(cancelar_button);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(GBx_Cita);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_GestionCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cita";
            Load += Agregar_Cita_Form_Load;
            GBx_Cita.ResumeLayout(false);
            GBx_Cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBx_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnos_dgv).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelar_button;
        private Button resetear_button;
        private Button agregar_button;
        private Label medicos;
        private ComboBox combo_Medicos;
        private GroupBox GBx_Cita;
        private Label description;
        private TextBox description_text;
        private ComboBox combo_Pacientes;
        private PictureBox PBx_Close;
        private Label label1;
        private DataGridView turnos_dgv;
        private Label label2;
        private Label label3;
        private TextBox txt_turnoFecha;
        private TextBox txt_turnoHora;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}