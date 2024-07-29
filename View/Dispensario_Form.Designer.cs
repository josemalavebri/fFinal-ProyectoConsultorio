namespace ConsultorioPrivado.Vista.Dispensario
{
    partial class Dispensario_Form
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
            Panel_Vertical = new Panel();
            Ptx_Menu = new PictureBox();
            btn_turnos = new FontAwesome.Sharp.IconButton();
            Bnt_Citas = new FontAwesome.Sharp.IconButton();
            btn_Inicio = new FontAwesome.Sharp.IconButton();
            Btn_Medicos = new FontAwesome.Sharp.IconButton();
            Btn_Pacientes = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Panel_Principal = new Panel();
            btn_Factura = new FontAwesome.Sharp.IconButton();
            Panel_Vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ptx_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Panel_Vertical
            // 
            Panel_Vertical.BackColor = Color.FromArgb(0, 122, 204);
            Panel_Vertical.Controls.Add(btn_Factura);
            Panel_Vertical.Controls.Add(Ptx_Menu);
            Panel_Vertical.Controls.Add(btn_turnos);
            Panel_Vertical.Controls.Add(Bnt_Citas);
            Panel_Vertical.Controls.Add(btn_Inicio);
            Panel_Vertical.Controls.Add(Btn_Medicos);
            Panel_Vertical.Controls.Add(Btn_Pacientes);
            Panel_Vertical.Controls.Add(label1);
            Panel_Vertical.Controls.Add(pictureBox2);
            Panel_Vertical.Dock = DockStyle.Left;
            Panel_Vertical.Location = new Point(0, 0);
            Panel_Vertical.Name = "Panel_Vertical";
            Panel_Vertical.Size = new Size(248, 665);
            Panel_Vertical.TabIndex = 0;
            // 
            // Ptx_Menu
            // 
            Ptx_Menu.Image = View.Properties.Resources.Menu_Icon;
            Ptx_Menu.Location = new Point(9, 0);
            Ptx_Menu.Name = "Ptx_Menu";
            Ptx_Menu.Size = new Size(51, 31);
            Ptx_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            Ptx_Menu.TabIndex = 0;
            Ptx_Menu.TabStop = false;
            Ptx_Menu.Click += Ptx_Menu_Click;
            // 
            // btn_turnos
            // 
            btn_turnos.BackColor = Color.FromArgb(0, 185, 240);
            btn_turnos.FlatAppearance.BorderColor = Color.White;
            btn_turnos.FlatAppearance.BorderSize = 0;
            btn_turnos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_turnos.ForeColor = SystemColors.ButtonHighlight;
            btn_turnos.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btn_turnos.IconColor = Color.White;
            btn_turnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_turnos.IconSize = 40;
            btn_turnos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_turnos.Location = new Point(12, 444);
            btn_turnos.Name = "btn_turnos";
            btn_turnos.Size = new Size(225, 81);
            btn_turnos.TabIndex = 52;
            btn_turnos.Text = "Turnos";
            btn_turnos.UseVisualStyleBackColor = false;
            btn_turnos.Click += btn_turnos_Click;
            // 
            // Bnt_Citas
            // 
            Bnt_Citas.BackColor = Color.FromArgb(0, 185, 240);
            Bnt_Citas.FlatAppearance.BorderColor = Color.White;
            Bnt_Citas.FlatAppearance.BorderSize = 0;
            Bnt_Citas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bnt_Citas.ForeColor = SystemColors.ButtonHighlight;
            Bnt_Citas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            Bnt_Citas.IconColor = Color.White;
            Bnt_Citas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Bnt_Citas.IconSize = 40;
            Bnt_Citas.ImageAlign = ContentAlignment.MiddleLeft;
            Bnt_Citas.Location = new Point(12, 357);
            Bnt_Citas.Name = "Bnt_Citas";
            Bnt_Citas.Size = new Size(223, 81);
            Bnt_Citas.TabIndex = 51;
            Bnt_Citas.Text = "Citas";
            Bnt_Citas.UseVisualStyleBackColor = false;
            Bnt_Citas.Click += Bnt_Citas_Click;
            // 
            // btn_Inicio
            // 
            btn_Inicio.BackColor = Color.FromArgb(0, 185, 240);
            btn_Inicio.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            btn_Inicio.FlatAppearance.BorderSize = 0;
            btn_Inicio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inicio.ForeColor = SystemColors.ButtonHighlight;
            btn_Inicio.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btn_Inicio.IconColor = Color.White;
            btn_Inicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Inicio.IconSize = 40;
            btn_Inicio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Inicio.Location = new Point(12, 96);
            btn_Inicio.Name = "btn_Inicio";
            btn_Inicio.Size = new Size(222, 81);
            btn_Inicio.TabIndex = 44;
            btn_Inicio.Text = "Inicio";
            btn_Inicio.UseVisualStyleBackColor = false;
            btn_Inicio.Click += btn_Inicio_Click;
            // 
            // Btn_Medicos
            // 
            Btn_Medicos.BackColor = Color.FromArgb(0, 185, 240);
            Btn_Medicos.FlatAppearance.BorderColor = Color.White;
            Btn_Medicos.FlatAppearance.BorderSize = 0;
            Btn_Medicos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Medicos.ForeColor = SystemColors.ButtonHighlight;
            Btn_Medicos.IconChar = FontAwesome.Sharp.IconChar.Medrt;
            Btn_Medicos.IconColor = Color.White;
            Btn_Medicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Medicos.IconSize = 40;
            Btn_Medicos.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Medicos.Location = new Point(12, 270);
            Btn_Medicos.Name = "Btn_Medicos";
            Btn_Medicos.Size = new Size(222, 81);
            Btn_Medicos.TabIndex = 48;
            Btn_Medicos.Text = "Medicos";
            Btn_Medicos.UseVisualStyleBackColor = false;
            Btn_Medicos.Click += Btn_Medicos_Click;
            // 
            // Btn_Pacientes
            // 
            Btn_Pacientes.BackColor = Color.FromArgb(0, 185, 240);
            Btn_Pacientes.FlatAppearance.BorderSize = 0;
            Btn_Pacientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Pacientes.ForeColor = SystemColors.ButtonHighlight;
            Btn_Pacientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            Btn_Pacientes.IconColor = Color.White;
            Btn_Pacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Pacientes.IconSize = 40;
            Btn_Pacientes.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Pacientes.Location = new Point(12, 183);
            Btn_Pacientes.Name = "Btn_Pacientes";
            Btn_Pacientes.Size = new Size(222, 81);
            Btn_Pacientes.TabIndex = 50;
            Btn_Pacientes.Text = "Pacientes";
            Btn_Pacientes.UseVisualStyleBackColor = false;
            Btn_Pacientes.Click += Btn_Pacientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 46);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 47;
            label1.Text = "Dispensario medico";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = View.Properties.Resources.Dispensario_Icon;
            pictureBox2.Location = new Point(9, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // Panel_Principal
            // 
            Panel_Principal.AccessibleRole = AccessibleRole.None;
            Panel_Principal.BackColor = SystemColors.ButtonHighlight;
            Panel_Principal.Dock = DockStyle.Fill;
            Panel_Principal.Location = new Point(248, 0);
            Panel_Principal.Name = "Panel_Principal";
            Panel_Principal.Size = new Size(1034, 665);
            Panel_Principal.TabIndex = 0;
            // 
            // btn_Factura
            // 
            btn_Factura.BackColor = Color.FromArgb(0, 185, 240);
            btn_Factura.FlatAppearance.BorderColor = Color.White;
            btn_Factura.FlatAppearance.BorderSize = 0;
            btn_Factura.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Factura.ForeColor = SystemColors.ButtonHighlight;
            btn_Factura.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btn_Factura.IconColor = Color.White;
            btn_Factura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Factura.IconSize = 40;
            btn_Factura.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Factura.Location = new Point(12, 531);
            btn_Factura.Name = "btn_Factura";
            btn_Factura.Size = new Size(225, 81);
            btn_Factura.TabIndex = 53;
            btn_Factura.Text = "Factura";
            btn_Factura.UseVisualStyleBackColor = false;
            btn_Factura.Click += btn_Factura_Click;
            // 
            // Dispensario_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 665);
            Controls.Add(Panel_Principal);
            Controls.Add(Panel_Vertical);
            IsMdiContainer = true;
            Name = "Dispensario_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dispensario";
            Load += Dispensario_Form_Load;
            Panel_Vertical.ResumeLayout(false);
            Panel_Vertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Ptx_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Vertical;
        private Panel Panel_Principal;
        private PictureBox Ptx_Menu;
        private Label label1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btn_Inicio;
        private FontAwesome.Sharp.IconButton Btn_Pacientes;
        private FontAwesome.Sharp.IconButton Btn_Medicos;
        private FontAwesome.Sharp.IconButton Bnt_Citas;

        public Panel PanelPrincipal_Form()
        {
            return Panel_Principal;
        }

        private FontAwesome.Sharp.IconButton btn_turnos;
        private FontAwesome.Sharp.IconButton btn_Factura;
    }
}