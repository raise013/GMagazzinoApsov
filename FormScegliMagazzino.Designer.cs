namespace GMagazzinoApsov
{
    partial class FormScegliMagazzino
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.checkBoxCreaMagazzino = new System.Windows.Forms.CheckBox();
            this.textBoxRighe = new System.Windows.Forms.TextBox();
            this.buttonScegliMagazzino = new System.Windows.Forms.Button();
            this.labelRighe = new System.Windows.Forms.Label();
            this.textBoxPercorsoImport = new System.Windows.Forms.TextBox();
            this.labelColonne = new System.Windows.Forms.Label();
            this.checkBoxScegliMagazzino = new System.Windows.Forms.CheckBox();
            this.textBoxColonne = new System.Windows.Forms.TextBox();
            this.buttonProsegui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelScegliMagazzino = new System.Windows.Forms.Panel();
            this.panelCreaMagazzino = new System.Windows.Forms.Panel();
            this.panelScegliMagazzino.SuspendLayout();
            this.panelCreaMagazzino.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(23, 25);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 20);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(82, 22);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(184, 27);
            this.textBoxNome.TabIndex = 7;
            // 
            // checkBoxCreaMagazzino
            // 
            this.checkBoxCreaMagazzino.AutoSize = true;
            this.checkBoxCreaMagazzino.Location = new System.Drawing.Point(24, 221);
            this.checkBoxCreaMagazzino.Name = "checkBoxCreaMagazzino";
            this.checkBoxCreaMagazzino.Size = new System.Drawing.Size(141, 24);
            this.checkBoxCreaMagazzino.TabIndex = 6;
            this.checkBoxCreaMagazzino.Text = "Crea magazzino:";
            this.checkBoxCreaMagazzino.UseVisualStyleBackColor = true;
            this.checkBoxCreaMagazzino.CheckedChanged += new System.EventHandler(this.checkBoxCreaMagazzino_CheckedChanged);
            // 
            // textBoxRighe
            // 
            this.textBoxRighe.Location = new System.Drawing.Point(82, 68);
            this.textBoxRighe.Name = "textBoxRighe";
            this.textBoxRighe.Size = new System.Drawing.Size(50, 27);
            this.textBoxRighe.TabIndex = 9;
            // 
            // buttonScegliMagazzino
            // 
            this.buttonScegliMagazzino.Location = new System.Drawing.Point(336, 18);
            this.buttonScegliMagazzino.Name = "buttonScegliMagazzino";
            this.buttonScegliMagazzino.Size = new System.Drawing.Size(40, 27);
            this.buttonScegliMagazzino.TabIndex = 2;
            this.buttonScegliMagazzino.Text = "...";
            this.buttonScegliMagazzino.UseVisualStyleBackColor = true;
            this.buttonScegliMagazzino.Click += new System.EventHandler(this.buttonScegliMagazzino_Click);
            // 
            // labelRighe
            // 
            this.labelRighe.AutoSize = true;
            this.labelRighe.Location = new System.Drawing.Point(26, 68);
            this.labelRighe.Name = "labelRighe";
            this.labelRighe.Size = new System.Drawing.Size(50, 20);
            this.labelRighe.TabIndex = 10;
            this.labelRighe.Text = "Righe:";
            // 
            // textBoxPercorsoImport
            // 
            this.textBoxPercorsoImport.Location = new System.Drawing.Point(12, 18);
            this.textBoxPercorsoImport.Name = "textBoxPercorsoImport";
            this.textBoxPercorsoImport.Size = new System.Drawing.Size(307, 27);
            this.textBoxPercorsoImport.TabIndex = 0;
            // 
            // labelColonne
            // 
            this.labelColonne.AutoSize = true;
            this.labelColonne.Location = new System.Drawing.Point(9, 105);
            this.labelColonne.Name = "labelColonne";
            this.labelColonne.Size = new System.Drawing.Size(67, 20);
            this.labelColonne.TabIndex = 11;
            this.labelColonne.Text = "Colonne:";
            // 
            // checkBoxScegliMagazzino
            // 
            this.checkBoxScegliMagazzino.AutoSize = true;
            this.checkBoxScegliMagazzino.Location = new System.Drawing.Point(24, 124);
            this.checkBoxScegliMagazzino.Name = "checkBoxScegliMagazzino";
            this.checkBoxScegliMagazzino.Size = new System.Drawing.Size(151, 24);
            this.checkBoxScegliMagazzino.TabIndex = 5;
            this.checkBoxScegliMagazzino.Text = "Scegli Magazzino:";
            this.checkBoxScegliMagazzino.UseVisualStyleBackColor = true;
            this.checkBoxScegliMagazzino.CheckedChanged += new System.EventHandler(this.checkBoxScegliMagazzino_CheckedChanged);
            // 
            // textBoxColonne
            // 
            this.textBoxColonne.Location = new System.Drawing.Point(82, 105);
            this.textBoxColonne.Name = "textBoxColonne";
            this.textBoxColonne.Size = new System.Drawing.Size(50, 27);
            this.textBoxColonne.TabIndex = 12;
            // 
            // buttonProsegui
            // 
            this.buttonProsegui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProsegui.Location = new System.Drawing.Point(284, 448);
            this.buttonProsegui.Name = "buttonProsegui";
            this.buttonProsegui.Size = new System.Drawing.Size(90, 29);
            this.buttonProsegui.TabIndex = 3;
            this.buttonProsegui.Text = "Prosegui";
            this.buttonProsegui.UseVisualStyleBackColor = true;
            this.buttonProsegui.Click += new System.EventHandler(this.buttonProsegui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Importa magazzino";
            // 
            // panelScegliMagazzino
            // 
            this.panelScegliMagazzino.Controls.Add(this.buttonScegliMagazzino);
            this.panelScegliMagazzino.Controls.Add(this.textBoxPercorsoImport);
            this.panelScegliMagazzino.Location = new System.Drawing.Point(193, 104);
            this.panelScegliMagazzino.Name = "panelScegliMagazzino";
            this.panelScegliMagazzino.Size = new System.Drawing.Size(394, 66);
            this.panelScegliMagazzino.TabIndex = 14;
            // 
            // panelCreaMagazzino
            // 
            this.panelCreaMagazzino.Controls.Add(this.labelNome);
            this.panelCreaMagazzino.Controls.Add(this.textBoxNome);
            this.panelCreaMagazzino.Controls.Add(this.textBoxColonne);
            this.panelCreaMagazzino.Controls.Add(this.labelRighe);
            this.panelCreaMagazzino.Controls.Add(this.labelColonne);
            this.panelCreaMagazzino.Controls.Add(this.textBoxRighe);
            this.panelCreaMagazzino.Location = new System.Drawing.Point(155, 251);
            this.panelCreaMagazzino.Name = "panelCreaMagazzino";
            this.panelCreaMagazzino.Size = new System.Drawing.Size(295, 157);
            this.panelCreaMagazzino.TabIndex = 15;
            // 
            // FormScegliMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 498);
            this.Controls.Add(this.buttonProsegui);
            this.Controls.Add(this.checkBoxScegliMagazzino);
            this.Controls.Add(this.panelCreaMagazzino);
            this.Controls.Add(this.panelScegliMagazzino);
            this.Controls.Add(this.checkBoxCreaMagazzino);
            this.Controls.Add(this.label2);
            this.Name = "FormScegliMagazzino";
            this.Text = "FormScegliMagazzino";
            this.panelScegliMagazzino.ResumeLayout(false);
            this.panelScegliMagazzino.PerformLayout();
            this.panelCreaMagazzino.ResumeLayout(false);
            this.panelCreaMagazzino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private CheckBox checkBoxCreaMagazzino;
        private TextBox textBoxRighe;
        private Button buttonScegliMagazzino;
        private Label labelRighe;
        private TextBox textBoxPercorsoImport;
        private Label labelColonne;
        private CheckBox checkBoxScegliMagazzino;
        private TextBox textBoxColonne;
        private Button buttonProsegui;
        private Label label2;
        private Panel panelScegliMagazzino;
        private Panel panelCreaMagazzino;
    }
}