namespace ConsultorioPrivado.Vista
{
    partial class Medico_form
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
            buscar_button = new Button();
            cedula_text = new TextBox();
            label4 = new Label();
            label1 = new Label();
            medicos_dgv = new DataGridView();
            nuevo_button = new Button();
            resetear_button = new Button();
            ((System.ComponentModel.ISupportInitialize)medicos_dgv).BeginInit();
            SuspendLayout();
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(233, 9);
            buscar_button.Margin = new Padding(3, 4, 3, 4);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(110, 39);
            buscar_button.TabIndex = 17;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            buscar_button.Click += buscar_button_Click;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(94, 15);
            cedula_text.Margin = new Padding(3, 4, 3, 4);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(114, 27);
            cedula_text.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 25);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 15;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 151);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 12;
            label1.Text = "Medicos Agregados:";
            // 
            // medicos_dgv
            // 
            medicos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicos_dgv.Location = new Point(14, 195);
            medicos_dgv.Margin = new Padding(3, 4, 3, 4);
            medicos_dgv.Name = "medicos_dgv";
            medicos_dgv.RowHeadersWidth = 51;
            medicos_dgv.Size = new Size(973, 300);
            medicos_dgv.TabIndex = 11;
            medicos_dgv.CellClick += medicos_dgv_CellClick;
            // 
            // nuevo_button
            // 
            nuevo_button.Location = new Point(11, 69);
            nuevo_button.Margin = new Padding(3, 4, 3, 4);
            nuevo_button.Name = "nuevo_button";
            nuevo_button.Size = new Size(197, 63);
            nuevo_button.TabIndex = 20;
            nuevo_button.Text = "Nuevo";
            nuevo_button.UseVisualStyleBackColor = true;
            nuevo_button.Click += nuevo_button_Click_1;
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(371, 7);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(106, 41);
            resetear_button.TabIndex = 22;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click_1;
            // 
            // Medico_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 508);
            Controls.Add(resetear_button);
            Controls.Add(nuevo_button);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(medicos_dgv);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Medico_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medico";
            Load += Medico_form_Load;
            ((System.ComponentModel.ISupportInitialize)medicos_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buscar_button;
        private TextBox cedula_text;
        private Label label4;
        private Label label1;
        private DataGridView medicos_dgv;
        private Button nuevo_button;
        private Button resetear_button;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}