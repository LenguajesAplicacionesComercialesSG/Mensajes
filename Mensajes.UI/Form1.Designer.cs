namespace Mensajes.UI
{
    partial class Form1
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
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lbNombre = new Label();
            txtApellido = new TextBox();
            lbApellido = new Label();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 47);
            txtNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(86, 106);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(128, 41);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(363, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 47);
            txtApellido.TabIndex = 2;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(363, 106);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(128, 41);
            lbApellido.TabIndex = 3;
            lbApellido.Text = "Apellido";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(227, 274);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(188, 58);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(lbApellido);
            Controls.Add(txtApellido);
            Controls.Add(lbNombre);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lbNombre;
        private TextBox txtApellido;
        private Label lbApellido;
        private Button btnMostrar;
    }
}
