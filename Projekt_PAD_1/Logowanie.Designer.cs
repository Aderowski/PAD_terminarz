namespace Projekt_PAD_1
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.label1 = new System.Windows.Forms.Label();
            this.Llogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lpokazhaslo = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lhaslo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logowanie = new System.Windows.Forms.Button();
            this.btn_rejestracja = new System.Windows.Forms.Button();
            this.Lpanel1 = new System.Windows.Forms.Panel();
            this.Lpanel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaloguj się do konta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Llogin
            // 
            this.Llogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Llogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Llogin.Location = new System.Drawing.Point(47, 182);
            this.Llogin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Llogin.Multiline = true;
            this.Llogin.Name = "Llogin";
            this.Llogin.Size = new System.Drawing.Size(246, 30);
            this.Llogin.TabIndex = 4;
            this.Llogin.TextChanged += new System.EventHandler(this.Llogin_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(17, 182);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 8;
            // 
            // Lpokazhaslo
            // 
            this.Lpokazhaslo.AutoSize = true;
            this.Lpokazhaslo.Checked = true;
            this.Lpokazhaslo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lpokazhaslo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpokazhaslo.Location = new System.Drawing.Point(17, 296);
            this.Lpokazhaslo.Name = "Lpokazhaslo";
            this.Lpokazhaslo.Size = new System.Drawing.Size(103, 22);
            this.Lpokazhaslo.TabIndex = 6;
            this.Lpokazhaslo.Text = "Pokaż hasło";
            this.Lpokazhaslo.UseVisualStyleBackColor = true;
            this.Lpokazhaslo.CheckedChanged += new System.EventHandler(this.Lpokazhaslo_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(17, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 10;
            // 
            // Lhaslo
            // 
            this.Lhaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lhaslo.Location = new System.Drawing.Point(47, 244);
            this.Lhaslo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Lhaslo.Multiline = true;
            this.Lhaslo.Name = "Lhaslo";
            this.Lhaslo.PasswordChar = '*';
            this.Lhaslo.Size = new System.Drawing.Size(246, 30);
            this.Lhaslo.TabIndex = 5;
            this.Lhaslo.UseSystemPasswordChar = true;
            this.Lhaslo.TextChanged += new System.EventHandler(this.Lhaslo_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Zaloguj się";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasło:";
            // 
            // btn_logowanie
            // 
            this.btn_logowanie.BackColor = System.Drawing.Color.Transparent;
            this.btn_logowanie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logowanie.FlatAppearance.BorderSize = 0;
            this.btn_logowanie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_logowanie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_logowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logowanie.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logowanie.Location = new System.Drawing.Point(28, 24);
            this.btn_logowanie.Name = "btn_logowanie";
            this.btn_logowanie.Size = new System.Drawing.Size(101, 38);
            this.btn_logowanie.TabIndex = 14;
            this.btn_logowanie.Text = "Logowanie";
            this.btn_logowanie.UseVisualStyleBackColor = false;
            this.btn_logowanie.Click += new System.EventHandler(this.btn_logowanie_Click);
            // 
            // btn_rejestracja
            // 
            this.btn_rejestracja.BackColor = System.Drawing.Color.Transparent;
            this.btn_rejestracja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rejestracja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_rejestracja.FlatAppearance.BorderSize = 0;
            this.btn_rejestracja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rejestracja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rejestracja.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rejestracja.Location = new System.Drawing.Point(171, 24);
            this.btn_rejestracja.Name = "btn_rejestracja";
            this.btn_rejestracja.Size = new System.Drawing.Size(101, 38);
            this.btn_rejestracja.TabIndex = 15;
            this.btn_rejestracja.Text = "Rejestracja";
            this.btn_rejestracja.UseVisualStyleBackColor = false;
            this.btn_rejestracja.Click += new System.EventHandler(this.btnRejestracja_Click);
            // 
            // Lpanel1
            // 
            this.Lpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Lpanel1.Location = new System.Drawing.Point(28, 57);
            this.Lpanel1.Name = "Lpanel1";
            this.Lpanel1.Size = new System.Drawing.Size(101, 5);
            this.Lpanel1.TabIndex = 16;
            // 
            // Lpanel2
            // 
            this.Lpanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Lpanel2.Location = new System.Drawing.Point(171, 57);
            this.Lpanel2.Name = "Lpanel2";
            this.Lpanel2.Size = new System.Drawing.Size(101, 5);
            this.Lpanel2.TabIndex = 17;
            this.Lpanel2.Visible = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.Lpanel2);
            this.Controls.Add(this.Lpanel1);
            this.Controls.Add(this.btn_rejestracja);
            this.Controls.Add(this.btn_logowanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lpokazhaslo);
            this.Controls.Add(this.Lhaslo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Llogin);
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Lpokazhaslo;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox Llogin;
        public System.Windows.Forms.TextBox Lhaslo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_logowanie;
        private System.Windows.Forms.Button btn_rejestracja;
        private System.Windows.Forms.Panel Lpanel1;
        private System.Windows.Forms.Panel Lpanel2;
    }
}

