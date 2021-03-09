namespace DefibrillatorWpf
{
    partial class frmFo
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
            this.btnKilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.tbXkoord = new System.Windows.Forms.TextBox();
            this.tbYkoord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdatlekeres = new System.Windows.Forms.Button();
            this.btnUjadatok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(266, 426);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 23);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X koordináta:";
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.Location = new System.Drawing.Point(44, 125);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(279, 264);
            this.lbAdatok.TabIndex = 2;
            // 
            // tbXkoord
            // 
            this.tbXkoord.Location = new System.Drawing.Point(175, 12);
            this.tbXkoord.Name = "tbXkoord";
            this.tbXkoord.Size = new System.Drawing.Size(100, 20);
            this.tbXkoord.TabIndex = 3;
            // 
            // tbYkoord
            // 
            this.tbYkoord.Location = new System.Drawing.Point(175, 47);
            this.tbYkoord.Name = "tbYkoord";
            this.tbYkoord.Size = new System.Drawing.Size(100, 20);
            this.tbYkoord.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y koordináta:";
            // 
            // btnAdatlekeres
            // 
            this.btnAdatlekeres.Location = new System.Drawing.Point(113, 85);
            this.btnAdatlekeres.Name = "btnAdatlekeres";
            this.btnAdatlekeres.Size = new System.Drawing.Size(139, 23);
            this.btnAdatlekeres.TabIndex = 6;
            this.btnAdatlekeres.Text = "Adatok lekérése";
            this.btnAdatlekeres.UseVisualStyleBackColor = true;
            this.btnAdatlekeres.Click += new System.EventHandler(this.btnAdatlekeres_Click);
            // 
            // btnUjadatok
            // 
            this.btnUjadatok.Location = new System.Drawing.Point(44, 426);
            this.btnUjadatok.Name = "btnUjadatok";
            this.btnUjadatok.Size = new System.Drawing.Size(102, 23);
            this.btnUjadatok.TabIndex = 7;
            this.btnUjadatok.Text = "Új adat megadása";
            this.btnUjadatok.UseVisualStyleBackColor = true;
            this.btnUjadatok.Click += new System.EventHandler(this.btnUjadatok_Click);
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnUjadatok);
            this.Controls.Add(this.btnAdatlekeres);
            this.Controls.Add(this.tbYkoord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbXkoord);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKilepes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.TextBox tbXkoord;
        private System.Windows.Forms.TextBox tbYkoord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdatlekeres;
        private System.Windows.Forms.Button btnUjadatok;
    }
}

