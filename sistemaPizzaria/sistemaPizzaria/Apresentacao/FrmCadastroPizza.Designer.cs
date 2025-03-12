namespace sistemaPizzaria
{
    partial class FrmCadastroPizza
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
            lblNomePizza = new Label();
            lblPrecoPizza = new Label();
            txtNomePizza = new TextBox();
            txtPrecoPizza = new TextBox();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNomePizza
            // 
            lblNomePizza.AutoSize = true;
            lblNomePizza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomePizza.Location = new Point(51, 96);
            lblNomePizza.Name = "lblNomePizza";
            lblNomePizza.Size = new Size(116, 21);
            lblNomePizza.TabIndex = 0;
            lblNomePizza.Text = "Nome da pizza:";
            // 
            // lblPrecoPizza
            // 
            lblPrecoPizza.AutoSize = true;
            lblPrecoPizza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecoPizza.Location = new Point(51, 174);
            lblPrecoPizza.Name = "lblPrecoPizza";
            lblPrecoPizza.Size = new Size(112, 21);
            lblPrecoPizza.TabIndex = 1;
            lblPrecoPizza.Text = "Preço da pizza:";
            // 
            // txtNomePizza
            // 
            txtNomePizza.BackColor = SystemColors.Menu;
            txtNomePizza.ForeColor = Color.Gray;
            txtNomePizza.Location = new Point(51, 123);
            txtNomePizza.Name = "txtNomePizza";
            txtNomePizza.Size = new Size(263, 23);
            txtNomePizza.TabIndex = 2;
            // 
            // txtPrecoPizza
            // 
            txtPrecoPizza.BackColor = SystemColors.Menu;
            txtPrecoPizza.Location = new Point(51, 200);
            txtPrecoPizza.Name = "txtPrecoPizza";
            txtPrecoPizza.Size = new Size(263, 23);
            txtPrecoPizza.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(289, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 30);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "CADASTRO DE PIZZA";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkOliveGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 342);
            dataGridView1.TabIndex = 5;
            // 
            // FrmCadastroPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(txtPrecoPizza);
            Controls.Add(txtNomePizza);
            Controls.Add(lblPrecoPizza);
            Controls.Add(lblNomePizza);
            Name = "FrmCadastroPizza";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePizza;
        private Label lblPrecoPizza;
        private TextBox txtNomePizza;
        private TextBox txtPrecoPizza;
        private Label lblTitle;
        private DataGridView dataGridView1;
    }
}
