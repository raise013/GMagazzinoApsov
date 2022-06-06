namespace GMagazzinoApsov
{
    partial class FormProdotto
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
            this.labelPartita = new System.Windows.Forms.Label();
            this.textBoxPartita = new System.Windows.Forms.TextBox();
            this.textBoxLotto = new System.Windows.Forms.TextBox();
            this.labelLotto = new System.Windows.Forms.Label();
            this.buttonSalvaProdotto = new System.Windows.Forms.Button();
            this.comboVarieta = new System.Windows.Forms.ComboBox();
            this.labelVarieta = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboConcia = new System.Windows.Forms.ComboBox();
            this.labelConcia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPartita
            // 
            this.labelPartita.AutoSize = true;
            this.labelPartita.Location = new System.Drawing.Point(8, 185);
            this.labelPartita.Name = "labelPartita";
            this.labelPartita.Size = new System.Drawing.Size(51, 20);
            this.labelPartita.TabIndex = 1;
            this.labelPartita.Text = "Partita";
            // 
            // textBoxPartita
            // 
            this.textBoxPartita.Location = new System.Drawing.Point(89, 182);
            this.textBoxPartita.Name = "textBoxPartita";
            this.textBoxPartita.Size = new System.Drawing.Size(159, 27);
            this.textBoxPartita.TabIndex = 0;
            // 
            // textBoxLotto
            // 
            this.textBoxLotto.Location = new System.Drawing.Point(89, 231);
            this.textBoxLotto.Name = "textBoxLotto";
            this.textBoxLotto.Size = new System.Drawing.Size(159, 27);
            this.textBoxLotto.TabIndex = 2;
            // 
            // labelLotto
            // 
            this.labelLotto.AutoSize = true;
            this.labelLotto.Location = new System.Drawing.Point(8, 234);
            this.labelLotto.Name = "labelLotto";
            this.labelLotto.Size = new System.Drawing.Size(44, 20);
            this.labelLotto.TabIndex = 3;
            this.labelLotto.Text = "Lotto";
            // 
            // buttonSalvaProdotto
            // 
            this.buttonSalvaProdotto.Location = new System.Drawing.Point(306, 346);
            this.buttonSalvaProdotto.Name = "buttonSalvaProdotto";
            this.buttonSalvaProdotto.Size = new System.Drawing.Size(187, 29);
            this.buttonSalvaProdotto.TabIndex = 4;
            this.buttonSalvaProdotto.Text = "Salva";
            this.buttonSalvaProdotto.UseVisualStyleBackColor = true;
            this.buttonSalvaProdotto.Click += new System.EventHandler(this.buttonSalvaProdotto_Click);
            // 
            // comboVarieta
            // 
            this.comboVarieta.FormattingEnabled = true;
            this.comboVarieta.Location = new System.Drawing.Point(89, 42);
            this.comboVarieta.Name = "comboVarieta";
            this.comboVarieta.Size = new System.Drawing.Size(159, 28);
            this.comboVarieta.TabIndex = 5;
            // 
            // labelVarieta
            // 
            this.labelVarieta.AutoSize = true;
            this.labelVarieta.Location = new System.Drawing.Point(8, 45);
            this.labelVarieta.Name = "labelVarieta";
            this.labelVarieta.Size = new System.Drawing.Size(55, 20);
            this.labelVarieta.TabIndex = 6;
            this.labelVarieta.Text = "Varietà";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(8, 95);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(74, 20);
            this.labelCategoria.TabIndex = 7;
            this.labelCategoria.Text = "Categoria";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(88, 92);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(159, 28);
            this.comboCategoria.TabIndex = 8;
            // 
            // comboConcia
            // 
            this.comboConcia.FormattingEnabled = true;
            this.comboConcia.Location = new System.Drawing.Point(89, 134);
            this.comboConcia.Name = "comboConcia";
            this.comboConcia.Size = new System.Drawing.Size(159, 28);
            this.comboConcia.TabIndex = 9;
            // 
            // labelConcia
            // 
            this.labelConcia.AutoSize = true;
            this.labelConcia.Location = new System.Drawing.Point(9, 137);
            this.labelConcia.Name = "labelConcia";
            this.labelConcia.Size = new System.Drawing.Size(54, 20);
            this.labelConcia.TabIndex = 10;
            this.labelConcia.Text = "Concia";
            // 
            // FormInserisciProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.labelConcia);
            this.Controls.Add(this.comboConcia);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelVarieta);
            this.Controls.Add(this.comboVarieta);
            this.Controls.Add(this.buttonSalvaProdotto);
            this.Controls.Add(this.labelLotto);
            this.Controls.Add(this.textBoxLotto);
            this.Controls.Add(this.textBoxPartita);
            this.Controls.Add(this.labelPartita);
            this.Name = "FormInserisciProdotti";
            this.Text = "FormInserisciProdotti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPartita;
        private TextBox textBoxPartita;
        private TextBox textBoxLotto;
        private Label labelLotto;
        private Button buttonSalvaProdotto;
        private ComboBox comboVarieta;
        private Label labelVarieta;
        private Label labelCategoria;
        private ComboBox comboCategoria;
        private ComboBox comboConcia;
        private Label labelConcia;
    }
}