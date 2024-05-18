namespace ProyectoFinal
{
    partial class VistaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMatricula = new TextBox();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(498, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(194, 45);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese la matricula a buscar";
            txtBuscar.Size = new Size(298, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 2;
            label1.Text = "Buscar Matricula:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(355, 37);
            label2.TabIndex = 3;
            label2.Text = "Agregar Nuevo Estudiante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 204);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 248);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 291);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "Matricula";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 201);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(88, 245);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(198, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(89, 288);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(197, 23);
            txtMatricula.TabIndex = 9;
            txtMatricula.TextChanged += txtMatricula_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(555, 228);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 55);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(29, 357);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(232, 62);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Estudiante";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtMatricula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Prueba";
            Text = "Form1";
            Load += Prueba_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMatricula;
        private Button btnLimpiar;
        private Button btnAgregar;
    }
}
