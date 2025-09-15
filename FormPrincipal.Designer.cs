namespace EmpresaDigital
{
    partial class FormPrincipal
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
            btnVerCargos = new Button();
            dgvVisualizador = new DataGridView();
            btnNovoCargo = new Button();
            btnVerFuncionario = new Button();
            btnNovoFuncionario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVisualizador).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(8, 5);
            lblTitulo.Margin = new Padding(2, 0, 7, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(336, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gerenciador de Funcionários";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVerCargos
            // 
            btnVerCargos.BackColor = SystemColors.ButtonHighlight;
            btnVerCargos.Location = new Point(8, 29);
            btnVerCargos.Margin = new Padding(2);
            btnVerCargos.Name = "btnVerCargos";
            btnVerCargos.Size = new Size(118, 24);
            btnVerCargos.TabIndex = 1;
            btnVerCargos.Text = "Visualizar Cargos";
            btnVerCargos.UseVisualStyleBackColor = false;
            btnVerCargos.Click += btnVerCargos_Click;
            // 
            // dgvVisualizador
            // 
            dgvVisualizador.AllowUserToAddRows = false;
            dgvVisualizador.AllowUserToDeleteRows = false;
            dgvVisualizador.AllowUserToResizeColumns = false;
            dgvVisualizador.AllowUserToResizeRows = false;
            dgvVisualizador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisualizador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisualizador.Location = new Point(8, 57);
            dgvVisualizador.Margin = new Padding(2);
            dgvVisualizador.MultiSelect = false;
            dgvVisualizador.Name = "dgvVisualizador";
            dgvVisualizador.ReadOnly = true;
            dgvVisualizador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVisualizador.RowHeadersVisible = false;
            dgvVisualizador.RowHeadersWidth = 62;
            dgvVisualizador.Size = new Size(543, 206);
            dgvVisualizador.TabIndex = 2;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Location = new Point(130, 29);
            btnNovoCargo.Margin = new Padding(2);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(115, 24);
            btnNovoCargo.TabIndex = 3;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // btnVerFuncionario
            // 
            btnVerFuncionario.Location = new Point(249, 29);
            btnVerFuncionario.Margin = new Padding(2);
            btnVerFuncionario.Name = "btnVerFuncionario";
            btnVerFuncionario.Size = new Size(136, 24);
            btnVerFuncionario.TabIndex = 4;
            btnVerFuncionario.Text = "Visualizar Funcionários";
            btnVerFuncionario.UseVisualStyleBackColor = true;
            btnVerFuncionario.Click += btnVerFuncionario_Click;
            // 
            // btnNovoFuncionario
            // 
            btnNovoFuncionario.Location = new Point(389, 29);
            btnNovoFuncionario.Margin = new Padding(2);
            btnNovoFuncionario.Name = "btnNovoFuncionario";
            btnNovoFuncionario.Size = new Size(136, 24);
            btnNovoFuncionario.TabIndex = 5;
            btnNovoFuncionario.Text = "Novo Funcionário";
            btnNovoFuncionario.UseVisualStyleBackColor = true;
            btnNovoFuncionario.Click += btnNovoFuncionario_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnNovoFuncionario);
            Controls.Add(btnVerFuncionario);
            Controls.Add(btnNovoCargo);
            Controls.Add(dgvVisualizador);
            Controls.Add(btnVerCargos);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa Digital";
            ((System.ComponentModel.ISupportInitialize)dgvVisualizador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVerCargos;
        private DataGridView dgvVisualizador;
        private Button btnNovoCargo;
        private Button btnVerFuncionario;
        private Button btnNovoFuncionario;
    }
}
