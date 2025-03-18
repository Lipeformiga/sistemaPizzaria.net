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
            dtgPizza = new DataGridView();
            lblID = new Label();
            txtID = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPizza).BeginInit();
            SuspendLayout();
            // 
            // lblNomePizza
            // 
            lblNomePizza.AutoSize = true;
            lblNomePizza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomePizza.Location = new Point(51, 168);
            lblNomePizza.Name = "lblNomePizza";
            lblNomePizza.Size = new Size(116, 21);
            lblNomePizza.TabIndex = 0;
            lblNomePizza.Text = "Nome da pizza:";
            // 
            // lblPrecoPizza
            // 
            lblPrecoPizza.AutoSize = true;
            lblPrecoPizza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecoPizza.Location = new Point(51, 246);
            lblPrecoPizza.Name = "lblPrecoPizza";
            lblPrecoPizza.Size = new Size(112, 21);
            lblPrecoPizza.TabIndex = 1;
            lblPrecoPizza.Text = "Preço da pizza:";
            // 
            // txtNomePizza
            // 
            txtNomePizza.BackColor = SystemColors.Menu;
            txtNomePizza.ForeColor = Color.Gray;
            txtNomePizza.Location = new Point(51, 195);
            txtNomePizza.Name = "txtNomePizza";
            txtNomePizza.Size = new Size(263, 23);
            txtNomePizza.TabIndex = 2;
            // 
            // txtPrecoPizza
            // 
            txtPrecoPizza.BackColor = SystemColors.Menu;
            txtPrecoPizza.Location = new Point(51, 272);
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
            // dtgPizza
            // 
            dtgPizza.BackgroundColor = Color.DarkOliveGreen;
            dtgPizza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPizza.Location = new Point(335, 96);
            dtgPizza.Name = "dtgPizza";
            dtgPizza.Size = new Size(453, 342);
            dtgPizza.TabIndex = 5;
            dtgPizza.CellContentClick += dtgPizza_CellContentClick;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(51, 96);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 21);
            lblID.TabIndex = 6;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Menu;
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(51, 120);
            txtID.Name = "txtID";
            txtID.Size = new Size(263, 23);
            txtID.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(51, 386);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(239, 386);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmCadastroPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(dtgPizza);
            Controls.Add(lblTitle);
            Controls.Add(txtPrecoPizza);
            Controls.Add(txtNomePizza);
            Controls.Add(lblPrecoPizza);
            Controls.Add(lblNomePizza);
            Name = "FrmCadastroPizza";
            Text = "Form1";
            Load += FrmCadastroPizza_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePizza;
        private Label lblPrecoPizza;
        private TextBox txtNomePizza;
        private TextBox txtPrecoPizza;
        private Label lblTitle;
        private DataGridView dtgPizza;
        private Label lblID;
        private TextBox txtID;
        private Button btnSalvar;
        private Button btnExcluir;
    }
}
