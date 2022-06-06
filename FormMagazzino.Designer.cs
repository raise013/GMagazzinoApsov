namespace GMagazzinoApsov
{
    partial class FormMagazzino
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
            this.buttonInserisciProdotti = new System.Windows.Forms.Button();
            this.grigliaMagazzino = new System.Windows.Forms.DataGridView();
            this.panelGrigliaMagazzino = new System.Windows.Forms.Panel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaMagazzino)).BeginInit();
            this.panelGrigliaMagazzino.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInserisciProdotti
            // 
            this.buttonInserisciProdotti.Location = new System.Drawing.Point(0, 0);
            this.buttonInserisciProdotti.Name = "buttonInserisciProdotti";
            this.buttonInserisciProdotti.Size = new System.Drawing.Size(172, 29);
            this.buttonInserisciProdotti.TabIndex = 1;
            this.buttonInserisciProdotti.Text = "Inserisci prodotto";
            this.buttonInserisciProdotti.UseVisualStyleBackColor = true;
            this.buttonInserisciProdotti.Click += new System.EventHandler(this.buttonInserisciProdotti_Click);
            // 
            // grigliaMagazzino
            // 
            this.grigliaMagazzino.AllowUserToAddRows = false;
            this.grigliaMagazzino.AllowUserToDeleteRows = false;
            this.grigliaMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaMagazzino.Location = new System.Drawing.Point(0, 0);
            this.grigliaMagazzino.Name = "grigliaMagazzino";
            this.grigliaMagazzino.ReadOnly = true;
            this.grigliaMagazzino.RowHeadersWidth = 51;
            this.grigliaMagazzino.RowTemplate.Height = 29;
            this.grigliaMagazzino.Size = new System.Drawing.Size(956, 608);
            this.grigliaMagazzino.TabIndex = 2;
            // 
            // panelGrigliaMagazzino
            // 
            this.panelGrigliaMagazzino.Controls.Add(this.grigliaMagazzino);
            this.panelGrigliaMagazzino.Location = new System.Drawing.Point(1, 0);
            this.panelGrigliaMagazzino.Name = "panelGrigliaMagazzino";
            this.panelGrigliaMagazzino.Size = new System.Drawing.Size(959, 616);
            this.panelGrigliaMagazzino.TabIndex = 3;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.buttonInserisciProdotti);
            this.panelToolbar.Location = new System.Drawing.Point(1, 614);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(959, 32);
            this.panelToolbar.TabIndex = 4;
            // 
            // FormMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 648);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelGrigliaMagazzino);
            this.Name = "FormMagazzino";
            this.Text = "FormMagazzino";
            ((System.ComponentModel.ISupportInitialize)(this.grigliaMagazzino)).EndInit();
            this.panelGrigliaMagazzino.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonInserisciProdotti;
        private DataGridView grigliaMagazzino;
        private Panel panelGrigliaMagazzino;
        private Panel panelToolbar;
    }
}