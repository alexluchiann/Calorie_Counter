namespace Calorie_Counter
{
    partial class Login
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
            this.bunVenit = new System.Windows.Forms.Label();
            this.tbUtilizator = new System.Windows.Forms.TextBox();
            this.utilizator = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btIntoarcere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunVenit
            // 
            this.bunVenit.AutoSize = true;
            this.bunVenit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunVenit.Location = new System.Drawing.Point(313, 74);
            this.bunVenit.Name = "bunVenit";
            this.bunVenit.Size = new System.Drawing.Size(183, 31);
            this.bunVenit.TabIndex = 0;
            this.bunVenit.Text = "Bine ai venit!";
            // 
            // tbUtilizator
            // 
            this.tbUtilizator.Location = new System.Drawing.Point(356, 167);
            this.tbUtilizator.Name = "tbUtilizator";
            this.tbUtilizator.Size = new System.Drawing.Size(177, 20);
            this.tbUtilizator.TabIndex = 1;
//            this.tbUtilizator.TextChanged += new System.EventHandler(this.tbUtilizator_TextChanged);
            // 
            // utilizator
            // 
            this.utilizator.AutoSize = true;
            this.utilizator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.utilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizator.Location = new System.Drawing.Point(248, 161);
            this.utilizator.Name = "utilizator";
            this.utilizator.Size = new System.Drawing.Size(102, 25);
            this.utilizator.TabIndex = 2;
            this.utilizator.Text = "Utilizator:";
            // 
            // parola
            // 
            this.parola.AutoSize = true;
            this.parola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(270, 209);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(80, 25);
            this.parola.TabIndex = 4;
            this.parola.Text = "Parola:";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(356, 214);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(177, 20);
            this.tbParola.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(319, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Trimite";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.SystemColors.Control;
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(234, 337);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(334, 31);
            this.btnInregistrare.TabIndex = 6;
            this.btnInregistrare.Text = "Nu ai cont inca? Inregistreaza-te acum!";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btIntoarcere
            // 
            this.btIntoarcere.BackColor = System.Drawing.SystemColors.Control;
            this.btIntoarcere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIntoarcere.Location = new System.Drawing.Point(597, 389);
            this.btIntoarcere.Name = "btIntoarcere";
            this.btIntoarcere.Size = new System.Drawing.Size(191, 49);
            this.btIntoarcere.TabIndex = 7;
            this.btIntoarcere.Text = "Intoarcere";
            this.btIntoarcere.UseVisualStyleBackColor = false;
            this.btIntoarcere.Click += new System.EventHandler(this.btIntoarcere_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calorie_Counter.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btIntoarcere);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.utilizator);
            this.Controls.Add(this.tbUtilizator);
            this.Controls.Add(this.bunVenit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bunVenit;
        private System.Windows.Forms.Label utilizator;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btIntoarcere;
        public System.Windows.Forms.TextBox tbUtilizator;
        public System.Windows.Forms.TextBox tbParola;
    }
}