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
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).BeginInit();
            SuspendLayout();
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(309, 13);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(93, 31);
            resetear_button.TabIndex = 29;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // nuevo_button
            // 
            nuevo_button.Location = new Point(2, 56);
            nuevo_button.Name = "nuevo_button";
            nuevo_button.Size = new Size(172, 47);
            nuevo_button.TabIndex = 28;
            nuevo_button.Text = "Nuevo";
            nuevo_button.UseVisualStyleBackColor = true;
            nuevo_button.Click += nuevo_button_Click;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(194, 14);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(96, 29);
            buscar_button.TabIndex = 27;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            buscar_button.Click += buscar_button_Click;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(64, 19);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(100, 23);
            cedula_text.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 21);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 25;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 118);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 24;
            label1.Text = "Pacientes Agregados:";
            // 
            // paciente_dgv
            // 
            paciente_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paciente_dgv.Location = new Point(4, 151);
            paciente_dgv.Name = "paciente_dgv";
            paciente_dgv.RowHeadersWidth = 51;
            paciente_dgv.Size = new Size(843, 191);
            paciente_dgv.TabIndex = 23;
            paciente_dgv.CellClick += paciente_dgv_CellClick;
            // 
            // Paciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 400);
            Controls.Add(resetear_button);
            Controls.Add(nuevo_button);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(paciente_dgv);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Paciente_form";
            Text = "Pacientes";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).EndInit();
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
    }
}