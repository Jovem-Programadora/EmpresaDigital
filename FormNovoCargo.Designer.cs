namespace EmpresaDigital
{
    partial class FormNovoCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoCargo));
            btnVoltar = new Button();
            label1 = new Label();
            txbCargo = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 1;
            label1.Text = "Digite o novo cargo:";
            // 
            // txbCargo
            // 
            txbCargo.Font = new Font("Segoe UI", 12F);
            txbCargo.Location = new Point(12, 120);
            txbCargo.Margin = new Padding(8);
            txbCargo.Name = "txbCargo";
            txbCargo.Size = new Size(249, 39);
            txbCargo.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 170);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormNovoCargo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txbCargo);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNovoCargo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNovoCargo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private TextBox txbCargo;
        private Button btnSalvar;
    }
}