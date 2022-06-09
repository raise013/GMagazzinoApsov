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
            this.textBoxPercorsoImport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonScegliMagazzino = new System.Windows.Forms.Button();
            this.buttonProsegui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPercorsoImport
            // 
            this.textBoxPercorsoImport.Location = new System.Drawing.Point(137, 89);
            this.textBoxPercorsoImport.Name = "textBoxPercorsoImport";
            this.textBoxPercorsoImport.Size = new System.Drawing.Size(307, 27);
            this.textBoxPercorsoImport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegli magazzino";
            // 
            // buttonScegliMagazzino
            // 
            this.buttonScegliMagazzino.Location = new System.Drawing.Point(450, 89);
            this.buttonScegliMagazzino.Name = "buttonScegliMagazzino";
            this.buttonScegliMagazzino.Size = new System.Drawing.Size(40, 27);
            this.buttonScegliMagazzino.TabIndex = 2;
            this.buttonScegliMagazzino.Text = "...";
            this.buttonScegliMagazzino.UseVisualStyleBackColor = true;
            this.buttonScegliMagazzino.Click += new System.EventHandler(this.buttonScegliMagazzino_Click);
            // 
            // buttonProsegui
            // 
            this.buttonProsegui.Location = new System.Drawing.Point(350, 305);
            this.buttonProsegui.Name = "buttonProsegui";
            this.buttonProsegui.Size = new System.Drawing.Size(94, 29);
            this.buttonProsegui.TabIndex = 3;
            this.buttonProsegui.Text = "Prosegui";
            this.buttonProsegui.UseVisualStyleBackColor = true;
            this.buttonProsegui.Click += new System.EventHandler(this.buttonProsegui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Importa magazzino";
            // 
            // FormScegliMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonProsegui);
            this.Controls.Add(this.buttonScegliMagazzino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPercorsoImport);
            this.Name = "FormScegliMagazzino";
            this.Text = "FormScegliMagazzino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPercorsoImport;
        private Label label1;
        private Button buttonScegliMagazzino;
        private Button buttonProsegui;
        private Label label2;
    }
}