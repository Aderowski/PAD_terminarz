namespace Projekt_PAD_1
{
    partial class Rejestracja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rejestracja));
            this.Rpowhaslo = new AltoControls.AltoTextBox();
            this.Remail = new AltoControls.AltoTextBox();
            this.Rnazwisko = new AltoControls.AltoTextBox();
            this.Rimie = new AltoControls.AltoTextBox();
            this.Lpanel2 = new System.Windows.Forms.Panel();
            this.Lpanel1 = new System.Windows.Forms.Panel();
            this.btnRejestracja = new System.Windows.Forms.Button();
            this.btn_logowanie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rhaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Rpowhaslo
            // 
            this.Rpowhaslo.BackColor = System.Drawing.Color.Transparent;
            this.Rpowhaslo.Br = System.Drawing.Color.White;
            this.Rpowhaslo.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rpowhaslo.ForeColor = System.Drawing.Color.DimGray;
            this.Rpowhaslo.Location = new System.Drawing.Point(27, 251);
            this.Rpowhaslo.Name = "Rpowhaslo";
            this.Rpowhaslo.Size = new System.Drawing.Size(225, 42);
            this.Rpowhaslo.TabIndex = 3;
            this.Rpowhaslo.Text = "Powtórz swoje hasło:";
            this.Rpowhaslo.Click += new System.EventHandler(this.Rpowhaslo_Click);
            // 
            // Remail
            // 
            this.Remail.BackColor = System.Drawing.Color.Transparent;
            this.Remail.Br = System.Drawing.Color.White;
            this.Remail.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remail.ForeColor = System.Drawing.Color.DimGray;
            this.Remail.Location = new System.Drawing.Point(27, 203);
            this.Remail.Name = "Remail";
            this.Remail.Size = new System.Drawing.Size(225, 42);
            this.Remail.TabIndex = 4;
            this.Remail.Text = "Podaj swój E-mail";
            this.Remail.Click += new System.EventHandler(this.Remail_Click);
            // 
            // Rnazwisko
            // 
            this.Rnazwisko.BackColor = System.Drawing.Color.Transparent;
            this.Rnazwisko.Br = System.Drawing.Color.White;
            this.Rnazwisko.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rnazwisko.ForeColor = System.Drawing.Color.DimGray;
            this.Rnazwisko.Location = new System.Drawing.Point(44, 155);
            this.Rnazwisko.Name = "Rnazwisko";
            this.Rnazwisko.Size = new System.Drawing.Size(225, 42);
            this.Rnazwisko.TabIndex = 5;
            this.Rnazwisko.Text = "Wprowadź swoje nazwisko:";
            this.Rnazwisko.Click += new System.EventHandler(this.Rnazwisko_Click);
            // 
            // Rimie
            // 
            this.Rimie.BackColor = System.Drawing.Color.Transparent;
            this.Rimie.Br = System.Drawing.Color.White;
            this.Rimie.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rimie.ForeColor = System.Drawing.Color.DimGray;
            this.Rimie.Location = new System.Drawing.Point(44, 93);
            this.Rimie.Name = "Rimie";
            this.Rimie.Size = new System.Drawing.Size(225, 42);
            this.Rimie.TabIndex = 6;
            this.Rimie.Text = "Wprowadź swoje imię:";
            this.Rimie.Click += new System.EventHandler(this.Rimie_Click);
            // 
            // Lpanel2
            // 
            this.Lpanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Lpanel2.Location = new System.Drawing.Point(170, 54);
            this.Lpanel2.Name = "Lpanel2";
            this.Lpanel2.Size = new System.Drawing.Size(101, 5);
            this.Lpanel2.TabIndex = 21;
            // 
            // Lpanel1
            // 
            this.Lpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Lpanel1.Location = new System.Drawing.Point(27, 54);
            this.Lpanel1.Name = "Lpanel1";
            this.Lpanel1.Size = new System.Drawing.Size(101, 5);
            this.Lpanel1.TabIndex = 20;
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
            this.btnRejestracja.Location = new System.Drawing.Point(170, 21);
            this.btnRejestracja.Name = "btnRejestracja";
            this.btnRejestracja.Size = new System.Drawing.Size(101, 38);
            this.btnRejestracja.TabIndex = 19;
            this.btnRejestracja.Text = "Rejestracja";
            this.btnRejestracja.UseVisualStyleBackColor = false;
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
            this.btn_logowanie.Location = new System.Drawing.Point(27, 21);
            this.btn_logowanie.Name = "btn_logowanie";
            this.btn_logowanie.Size = new System.Drawing.Size(101, 38);
            this.btn_logowanie.TabIndex = 18;
            this.btn_logowanie.Text = "Logowanie";
            this.btn_logowanie.UseVisualStyleBackColor = false;
            this.btn_logowanie.Click += new System.EventHandler(this.btn_logowanie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hasło:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(16, 323);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 23;
            // 
            // Rhaslo
            // 
            this.Rhaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rhaslo.Location = new System.Drawing.Point(46, 323);
            this.Rhaslo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Rhaslo.Multiline = true;
            this.Rhaslo.Name = "Rhaslo";
            this.Rhaslo.PasswordChar = '*';
            this.Rhaslo.Size = new System.Drawing.Size(246, 30);
            this.Rhaslo.TabIndex = 22;
            this.Rhaslo.UseSystemPasswordChar = true;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Rhaslo);
            this.Controls.Add(this.Lpanel2);
            this.Controls.Add(this.Lpanel1);
            this.Controls.Add(this.btnRejestracja);
            this.Controls.Add(this.btn_logowanie);
            this.Controls.Add(this.Rimie);
            this.Controls.Add(this.Rnazwisko);
            this.Controls.Add(this.Remail);
            this.Controls.Add(this.Rpowhaslo);
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Rejestracja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AltoControls.AltoTextBox Rpowhaslo;
        private AltoControls.AltoTextBox Remail;
        private AltoControls.AltoTextBox Rnazwisko;
        private AltoControls.AltoTextBox Rimie;
        private System.Windows.Forms.Panel Lpanel2;
        private System.Windows.Forms.Panel Lpanel1;
        private System.Windows.Forms.Button btnRejestracja;
        private System.Windows.Forms.Button btn_logowanie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox Rhaslo;
    }
}