namespace Projekt_PAD_1
{
    partial class Logowanie1
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lpokazhaslo = new System.Windows.Forms.CheckBox();
            this.Lhaslo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Llogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hasło:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Login:";
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
            this.button2.Location = new System.Drawing.Point(24, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Zaloguj się";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(13, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 18;
            // 
            // Lpokazhaslo
            // 
            this.Lpokazhaslo.AutoSize = true;
            this.Lpokazhaslo.Checked = true;
            this.Lpokazhaslo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lpokazhaslo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpokazhaslo.Location = new System.Drawing.Point(13, 232);
            this.Lpokazhaslo.Name = "Lpokazhaslo";
            this.Lpokazhaslo.Size = new System.Drawing.Size(103, 22);
            this.Lpokazhaslo.TabIndex = 16;
            this.Lpokazhaslo.Text = "Pokaż hasło";
            this.Lpokazhaslo.UseVisualStyleBackColor = true;
            // 
            // Lhaslo
            // 
            this.Lhaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lhaslo.Location = new System.Drawing.Point(43, 180);
            this.Lhaslo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Lhaslo.Multiline = true;
            this.Lhaslo.Name = "Lhaslo";
            this.Lhaslo.PasswordChar = '*';
            this.Lhaslo.Size = new System.Drawing.Size(246, 30);
            this.Lhaslo.TabIndex = 15;
            this.Lhaslo.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 17;
            // 
            // Llogin
            // 
            this.Llogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Llogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Llogin.Location = new System.Drawing.Point(43, 118);
            this.Llogin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Llogin.Multiline = true;
            this.Llogin.Name = "Llogin";
            this.Llogin.Size = new System.Drawing.Size(246, 30);
            this.Llogin.TabIndex = 14;
            // 
            // Logowanie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lpokazhaslo);
            this.Controls.Add(this.Lhaslo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Llogin);
            this.Name = "Logowanie1";
            this.Size = new System.Drawing.Size(304, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox Lpokazhaslo;
        public System.Windows.Forms.TextBox Lhaslo;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox Llogin;
    }
}
