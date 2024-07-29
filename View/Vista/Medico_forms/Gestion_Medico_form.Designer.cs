namespace ConsultorioPrivado.Vista
{
    partial class Gestion_Medico_form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nombre_text = new TextBox();
            apellido_text = new TextBox();
            cedula_text = new TextBox();
            correoText = new TextBox();
            agregar_button = new Button();
            resetear_button = new Button();
            telefono_text = new TextBox();
            telefono_label = new Label();
            especialidad = new Label();
            especialidad_combo = new ComboBox();
            cancelar_button = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F);
            label1.Location = new Point(147, 61);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F);
            label2.Location = new Point(147, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F);
            label3.Location = new Point(147, 226);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F);
            label4.Location = new Point(147, 281);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // nombre_text
            // 
            nombre_text.Font = new Font("Century Gothic", 10.8F);
            nombre_text.Location = new Point(267, 61);
            nombre_text.Margin = new Padding(3, 4, 3, 4);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(114, 30);
            nombre_text.TabIndex = 4;
            // 
            // apellido_text
            // 
            apellido_text.Font = new Font("Century Gothic", 10.8F);
            apellido_text.Location = new Point(267, 113);
            apellido_text.Margin = new Padding(3, 4, 3, 4);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(114, 30);
            apellido_text.TabIndex = 5;
            // 
            // cedula_text
            // 
            cedula_text.Font = new Font("Century Gothic", 10.8F);
            cedula_text.Location = new Point(267, 226);
            cedula_text.Margin = new Padding(3, 4, 3, 4);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(114, 30);
            cedula_text.TabIndex = 6;
            // 
            // correoText
            // 
            correoText.Font = new Font("Century Gothic", 10.8F);
            correoText.Location = new Point(267, 281);
            correoText.Margin = new Padding(3, 4, 3, 4);
            correoText.Name = "correoText";
            correoText.Size = new Size(114, 30);
            correoText.TabIndex = 7;
            // 
            // agregar_button
            // 
            agregar_button.BackColor = Color.FromArgb(70, 133, 133);
            agregar_button.FlatStyle = FlatStyle.Flat;
            agregar_button.Font = new Font("Century Gothic", 10.8F);
            agregar_button.ForeColor = SystemColors.ButtonHighlight;
            agregar_button.Location = new Point(159, 406);
            agregar_button.Margin = new Padding(3, 4, 3, 4);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(109, 42);
            agregar_button.TabIndex = 8;
            agregar_button.Text = "Aceptar";
            agregar_button.UseVisualStyleBackColor = false;
            agregar_button.Click += agregar_button_Click;
            // 
            // resetear_button
            // 
            resetear_button.BackColor = Color.FromArgb(70, 133, 133);
            resetear_button.FlatStyle = FlatStyle.Flat;
            resetear_button.Font = new Font("Century Gothic", 10.8F);
            resetear_button.ForeColor = SystemColors.ButtonHighlight;
            resetear_button.Location = new Point(310, 406);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(109, 42);
            resetear_button.TabIndex = 9;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = false;
            resetear_button.Click += resetear_button_Click;
            // 
            // telefono_text
            // 
            telefono_text.Font = new Font("Century Gothic", 10.8F);
            telefono_text.Location = new Point(267, 337);
            telefono_text.Margin = new Padding(3, 4, 3, 4);
            telefono_text.Name = "telefono_text";
            telefono_text.Size = new Size(114, 30);
            telefono_text.TabIndex = 11;
            // 
            // telefono_label
            // 
            telefono_label.AutoSize = true;
            telefono_label.Font = new Font("Century Gothic", 10.8F);
            telefono_label.Location = new Point(147, 337);
            telefono_label.Name = "telefono_label";
            telefono_label.Size = new Size(86, 21);
            telefono_label.TabIndex = 10;
            telefono_label.Text = "Telefono";
            // 
            // especialidad
            // 
            especialidad.AutoSize = true;
            especialidad.Font = new Font("Century Gothic", 10.8F);
            especialidad.Location = new Point(141, 171);
            especialidad.Name = "especialidad";
            especialidad.Size = new Size(120, 21);
            especialidad.TabIndex = 12;
            especialidad.Text = "Especialidad";
            // 
            // especialidad_combo
            // 
            especialidad_combo.Font = new Font("Century Gothic", 10.8F);
            especialidad_combo.FormattingEnabled = true;
            especialidad_combo.Items.AddRange(new object[] { "Cardiologia", "Dermatologia", "Pediatria" });
            especialidad_combo.Location = new Point(267, 168);
            especialidad_combo.Margin = new Padding(3, 4, 3, 4);
            especialidad_combo.Name = "especialidad_combo";
            especialidad_combo.Size = new Size(141, 29);
            especialidad_combo.TabIndex = 13;
            // 
            // cancelar_button
            // 
            cancelar_button.BackColor = Color.FromArgb(70, 133, 133);
            cancelar_button.FlatStyle = FlatStyle.Flat;
            cancelar_button.Font = new Font("Century Gothic", 10.8F);
            cancelar_button.ForeColor = SystemColors.ButtonHighlight;
            cancelar_button.Location = new Point(236, 465);
            cancelar_button.Margin = new Padding(3, 4, 3, 4);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(109, 42);
            cancelar_button.TabIndex = 14;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = false;
            cancelar_button.Click += cancelar_button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 133, 133);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(30, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 96);
            panel2.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = View.Properties.Resources.Dispensario_Icon;
            pictureBox1.Location = new Point(11, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 133, 133);
            panel1.Location = new Point(-9, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 23);
            panel1.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 133, 133);
            panel3.Location = new Point(0, 563);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 23);
            panel3.TabIndex = 35;
            // 
            // Gestion_Medico_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 249, 196);
            ClientSize = new Size(515, 585);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cancelar_button);
            Controls.Add(especialidad_combo);
            Controls.Add(especialidad);
            Controls.Add(telefono_text);
            Controls.Add(telefono_label);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(correoText);
            Controls.Add(cedula_text);
            Controls.Add(apellido_text);
            Controls.Add(nombre_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Gestion_Medico_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Medico";
            Load += add_Medico_form_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombre_text;
        private TextBox apellido_text;
        private TextBox cedula_text;
        private TextBox correoText;
        private Button agregar_button;
        private Button resetear_button;
        private TextBox telefono_text;
        private Label telefono_label;
        private Label especialidad;
        private ComboBox especialidad_combo;
        private Button cancelar_button;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
    }
}