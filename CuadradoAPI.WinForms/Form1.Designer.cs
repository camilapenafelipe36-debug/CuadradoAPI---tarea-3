namespace CuadradoAPI.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNumero;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNumero = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCargar = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lblNumero = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            lblNumero.AutoSize = true;
            lblNumero.Location = new System.Drawing.Point(30, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(70, 15);
            lblNumero.Text = "Número:";

            txtNumero.Location = new System.Drawing.Point(100, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new System.Drawing.Size(150, 23);

            btnGuardar.Location = new System.Drawing.Point(270, 25);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 30);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;

            btnCargar.Location = new System.Drawing.Point(380, 25);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new System.Drawing.Size(100, 30);
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;

            dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Location = new System.Drawing.Point(30, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(550, 300);
            dataGridView1.TabIndex = 4;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            ClientSize = new System.Drawing.Size(620, 420);

            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(dataGridView1);

            Name = "Form1";
            Text = "Cliente Windows Forms - CuadradoAPI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
