namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPacient = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodosli u Ordinaciju";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPacient
            // 
            this.btnPacient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.btnPacient.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacient.Location = new System.Drawing.Point(36, 131);
            this.btnPacient.Name = "btnPacient";
            this.btnPacient.Size = new System.Drawing.Size(105, 44);
            this.btnPacient.TabIndex = 1;
            this.btnPacient.Text = "Pacijent";
            this.btnPacient.UseVisualStyleBackColor = false;
            this.btnPacient.Click += new System.EventHandler(this.btnPacient_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.btnDoktor.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDoktor.Location = new System.Drawing.Point(229, 131);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(105, 44);
            this.btnDoktor.TabIndex = 2;
            this.btnDoktor.Text = "Doktor";
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite kako zelite da nastavite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.abstract_color_paper_creative_colorful_pastel_paper_background_6529_282;
            this.ClientSize = new System.Drawing.Size(364, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnPacient);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ordinacija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPacient;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Label label2;
    }
}

