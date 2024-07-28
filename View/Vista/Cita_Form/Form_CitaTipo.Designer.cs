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
            SuspendLayout();
            // 
            // btn_pacienteRecurrente
            // 
            btn_pacienteRecurrente.Location = new Point(37, 157);
            btn_pacienteRecurrente.Name = "btn_pacienteRecurrente";
            btn_pacienteRecurrente.Size = new Size(137, 57);
            btn_pacienteRecurrente.TabIndex = 1;
            btn_pacienteRecurrente.Text = "Paciente Recurrente";
            btn_pacienteRecurrente.UseVisualStyleBackColor = true;
            btn_pacienteRecurrente.Click += btn_pacienteRecurrente_Click;
            // 
            // btn_pacienteNuevo
            // 
            btn_pacienteNuevo.Location = new Point(37, 60);
            btn_pacienteNuevo.Name = "btn_pacienteNuevo";
            btn_pacienteNuevo.Size = new Size(137, 60);
            btn_pacienteNuevo.TabIndex = 0;
            btn_pacienteNuevo.Text = "Paciente Nuevo";
            btn_pacienteNuevo.UseVisualStyleBackColor = true;
            btn_pacienteNuevo.Click += btn_pacienteNuevo_Click;
            // 
            // Form_CitaTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 299);
            Controls.Add(btn_pacienteRecurrente);
            Controls.Add(btn_pacienteNuevo);
            Name = "Form_CitaTipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cita";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_pacienteRecurrente;
        private Button btn_pacienteNuevo;
    }
}