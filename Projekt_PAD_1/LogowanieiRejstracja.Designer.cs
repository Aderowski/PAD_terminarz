namespace Projekt_PAD_1
{
    partial class LogowanieiRejstracja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lpanel2 = new System.Windows.Forms.Panel();
            this.Lpanel1 = new System.Windows.Forms.Panel();
            this.btnRejestracja = new System.Windows.Forms.Button();
            this.btnLogowanie = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 394);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lpanel2);
            this.panel2.Controls.Add(this.Lpanel1);
            this.panel2.Controls.Add(this.btnRejestracja);
            this.panel2.Controls.Add(this.btnLogowanie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 70);
            this.panel2.TabIndex = 1;
            // 
            // Lpanel2
            // 
            this.Lpanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Lpanel2.Location = new System.Drawing.Point(173, 49);
            this.Lpanel2.Name = "Lpanel2";
            this.Lpanel2.Size = new System.Drawing.Size(101, 5);
            this.Lpanel2.TabIndex = 25;
            // 
            // Lpanel1
            // 
            this.Lpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Lpanel1.Location = new System.Drawing.Point(30, 49);
            this.Lpanel1.Name = "Lpanel1";
            this.Lpanel1.Size = new System.Drawing.Size(101, 5);
            this.Lpanel1.TabIndex = 24;
            this.Lpanel1.Visible = false;
            // 
            // btnRejestracja
            // 
            this.btnRejestracja.BackColor = System.Drawing.Color.Transparent;
            this.btnRejestracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRejestracja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRejestracja.FlatAppearance.BorderSize = 0;
            this.btnRejestracja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRejestracja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejestracja.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejestracja.Location = new System.Drawing.Point(173, 16);
            this.btnRejestracja.Name = "btnRejestracja";
            this.btnRejestracja.Size = new System.Drawing.Size(101, 38);
            this.btnRejestracja.TabIndex = 23;
            this.btnRejestracja.Text = "Rejestracja";
            this.btnRejestracja.UseVisualStyleBackColor = false;
            this.btnRejestracja.Click += new System.EventHandler(this.btnRejestracja_Click);
            // 
            // btnLogowanie
            // 
            this.btnLogowanie.BackColor = System.Drawing.Color.Transparent;
            this.btnLogowanie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogowanie.FlatAppearance.BorderSize = 0;
            this.btnLogowanie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogowanie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogowanie.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogowanie.Location = new System.Drawing.Point(30, 16);
            this.btnLogowanie.Name = "btnLogowanie";
            this.btnLogowanie.Size = new System.Drawing.Size(101, 38);
            this.btnLogowanie.TabIndex = 22;
            this.btnLogowanie.Text = "Logowanie";
            this.btnLogowanie.UseVisualStyleBackColor = false;
            this.btnLogowanie.Click += new System.EventHandler(this.btnLogowanie_Click);
            // 
            // LogowanieiRejstracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LogowanieiRejstracja";
            this.Text = "LogowanieiRejstracja";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Lpanel2;
        private System.Windows.Forms.Panel Lpanel1;
        private System.Windows.Forms.Button btnRejestracja;
        private System.Windows.Forms.Button btnLogowanie;
    }
}