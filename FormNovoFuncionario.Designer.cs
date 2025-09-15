namespace EmpresaDigital
{
    partial class FormNovoFuncionario
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
            btnVoltar = new Button();
            lblNovoFuncionario = new Label();
            txbNomeFuncionario = new TextBox();
            label1 = new Label();
            cboCargos = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(8, 8);
            btnVoltar.Margin = new Padding(0);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(76, 24);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblNovoFuncionario
            // 
            lblNovoFuncionario.AutoSize = true;
            lblNovoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNovoFuncionario.Location = new Point(8, 40);
            lblNovoFuncionario.Margin = new Padding(0, 8, 0, 0);
            lblNovoFuncionario.Name = "lblNovoFuncionario";
            lblNovoFuncionario.Size = new Size(176, 21);
            lblNovoFuncionario.TabIndex = 1;
            lblNovoFuncionario.Text = "Nome do Funcionário";
            // 
            // txbNomeFuncionario
            // 
            txbNomeFuncionario.Location = new Point(8, 72);
            txbNomeFuncionario.MaxLength = 200;
            txbNomeFuncionario.Name = "txbNomeFuncionario";
            txbNomeFuncionario.Size = new Size(300, 23);
            txbNomeFuncionario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(8, 106);
            label1.Margin = new Padding(0, 8, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 3;
            label1.Text = "Cargo do funcionário";
            // 
            // cboCargos
            // 
            cboCargos.FormattingEnabled = true;
            cboCargos.Location = new Point(8, 135);
            cboCargos.Margin = new Padding(0);
            cboCargos.Name = "cboCargos";
            cboCargos.Size = new Size(300, 23);
            cboCargos.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(8, 166);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(76, 24);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormNovoFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(cboCargos);
            Controls.Add(label1);
            Controls.Add(txbNomeFuncionario);
            Controls.Add(lblNovoFuncionario);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNovoFuncionario";
            Text = "Novo Funcionário";
            Load += FormNovoFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label lblNovoFuncionario;
        private TextBox txbNomeFuncionario;
        private Label label1;
        private ComboBox cboCargos;
        private Button btnSalvar;
    }
}