namespace Sistema_de_control_de_acceso
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lstCola = new ListBox();
            btnRegistrar = new Button();
            btnAtender = new Button();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(229, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(379, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema control de acceso";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(64, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(172, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 38);
            txtNombre.TabIndex = 2;
            // 
            // lstCola
            // 
            lstCola.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCola.FormattingEnabled = true;
            lstCola.Location = new Point(12, 254);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(776, 172);
            lstCola.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.Menu;
            btnRegistrar.Location = new Point(112, 195);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 53);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnAtender
            // 
            btnAtender.BackColor = SystemColors.HotTrack;
            btnAtender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtender.ForeColor = SystemColors.Menu;
            btnAtender.Location = new Point(564, 195);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(122, 53);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Click += btnAtender_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(12, 500);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(776, 200);
            lstHistorial.TabIndex = 6;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.Location = new Point(338, 446);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(119, 38);
            lblHistorial.TabIndex = 7;
            lblHistorial.Text = "Historial";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 722);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(btnAtender);
            Controls.Add(btnRegistrar);
            Controls.Add(lstCola);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private ListBox lstCola;
        private Button btnRegistrar;
        private Button btnAtender;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}
