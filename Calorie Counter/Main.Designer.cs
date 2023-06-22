namespace Calorie_Counter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buget = new System.Windows.Forms.Label();
            this.proteine = new System.Windows.Forms.Label();
            this.grasimi = new System.Windows.Forms.Label();
            this.carbohidrati = new System.Windows.Forms.Label();
            this.rbDejun = new System.Windows.Forms.RadioButton();
            this.rbGustari = new System.Windows.Forms.RadioButton();
            this.rbPranz = new System.Windows.Forms.RadioButton();
            this.rbCina = new System.Windows.Forms.RadioButton();
            this.btAdauga = new System.Windows.Forms.Button();
            this.adauga = new System.Windows.Forms.Label();
            this.CalRamase = new System.Windows.Forms.Label();
            this.btNextDay = new System.Windows.Forms.Button();
            this.lbCina = new System.Windows.Forms.Label();
            this.lbPranz = new System.Windows.Forms.Label();
            this.lbDejun = new System.Windows.Forms.Label();
            this.btProgres = new System.Windows.Forms.Button();
            this.lbGustari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buget
            // 
            this.buget.AutoSize = true;
            this.buget.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buget.Location = new System.Drawing.Point(25, 45);
            this.buget.Name = "buget";
            this.buget.Size = new System.Drawing.Size(417, 25);
            this.buget.TabIndex = 2;
            this.buget.Text = "Buget caloric: in functie de ce s-a ales";
            // 
            // proteine
            // 
            this.proteine.AutoSize = true;
            this.proteine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.proteine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteine.Location = new System.Drawing.Point(26, 172);
            this.proteine.Name = "proteine";
            this.proteine.Size = new System.Drawing.Size(105, 24);
            this.proteine.TabIndex = 4;
            this.proteine.Text = "Proteine: ...";
            // 
            // grasimi
            // 
            this.grasimi.AutoSize = true;
            this.grasimi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grasimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grasimi.Location = new System.Drawing.Point(26, 215);
            this.grasimi.Name = "grasimi";
            this.grasimi.Size = new System.Drawing.Size(98, 24);
            this.grasimi.TabIndex = 5;
            this.grasimi.Text = "Grasimi: ...";
            // 
            // carbohidrati
            // 
            this.carbohidrati.AutoSize = true;
            this.carbohidrati.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.carbohidrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbohidrati.Location = new System.Drawing.Point(26, 258);
            this.carbohidrati.Name = "carbohidrati";
            this.carbohidrati.Size = new System.Drawing.Size(136, 24);
            this.carbohidrati.TabIndex = 6;
            this.carbohidrati.Text = "Carbohidrati: ...";
            // 
            // rbDejun
            // 
            this.rbDejun.AutoSize = true;
            this.rbDejun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDejun.Location = new System.Drawing.Point(33, 364);
            this.rbDejun.Name = "rbDejun";
            this.rbDejun.Size = new System.Drawing.Size(135, 29);
            this.rbDejun.TabIndex = 10;
            this.rbDejun.TabStop = true;
            this.rbDejun.Text = "Mic Dejun";
            this.rbDejun.UseVisualStyleBackColor = true;
            // 
            // rbGustari
            // 
            this.rbGustari.AutoSize = true;
            this.rbGustari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGustari.Location = new System.Drawing.Point(420, 364);
            this.rbGustari.Name = "rbGustari";
            this.rbGustari.Size = new System.Drawing.Size(106, 29);
            this.rbGustari.TabIndex = 11;
            this.rbGustari.TabStop = true;
            this.rbGustari.Text = "Gustari";
            this.rbGustari.UseVisualStyleBackColor = true;
            // 
            // rbPranz
            // 
            this.rbPranz.AutoSize = true;
            this.rbPranz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPranz.Location = new System.Drawing.Point(198, 364);
            this.rbPranz.Name = "rbPranz";
            this.rbPranz.Size = new System.Drawing.Size(91, 29);
            this.rbPranz.TabIndex = 11;
            this.rbPranz.TabStop = true;
            this.rbPranz.Text = "Pranz";
            this.rbPranz.UseVisualStyleBackColor = true;
            // 
            // rbCina
            // 
            this.rbCina.AutoSize = true;
            this.rbCina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCina.Location = new System.Drawing.Point(311, 364);
            this.rbCina.Name = "rbCina";
            this.rbCina.Size = new System.Drawing.Size(78, 29);
            this.rbCina.TabIndex = 12;
            this.rbCina.TabStop = true;
            this.rbCina.Text = "Cina";
            this.rbCina.UseVisualStyleBackColor = true;
            // 
            // btAdauga
            // 
            this.btAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdauga.Location = new System.Drawing.Point(589, 376);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(179, 48);
            this.btAdauga.TabIndex = 13;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.UseVisualStyleBackColor = true;
            this.btAdauga.Click += new System.EventHandler(this.btAdauga_Click);
            // 
            // adauga
            // 
            this.adauga.AutoSize = true;
            this.adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga.Location = new System.Drawing.Point(40, 320);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(463, 25);
            this.adauga.TabIndex = 14;
            this.adauga.Text = "Selectati masa pe care vreti sa o adaugati:";
            // 
            // CalRamase
            // 
            this.CalRamase.AutoSize = true;
            this.CalRamase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalRamase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalRamase.Location = new System.Drawing.Point(26, 133);
            this.CalRamase.Name = "CalRamase";
            this.CalRamase.Size = new System.Drawing.Size(161, 24);
            this.CalRamase.TabIndex = 15;
            this.CalRamase.Text = "Calorii Ramase: ...";
            // 
            // btNextDay
            // 
            this.btNextDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btNextDay.Location = new System.Drawing.Point(589, 320);
            this.btNextDay.Name = "btNextDay";
            this.btNextDay.Size = new System.Drawing.Size(179, 50);
            this.btNextDay.TabIndex = 16;
            this.btNextDay.Text = "Urmatorea zi";
            this.btNextDay.UseVisualStyleBackColor = true;
            this.btNextDay.Click += new System.EventHandler(this.btNextDay_Click);
            // 
            // lbCina
            // 
            this.lbCina.AutoSize = true;
            this.lbCina.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCina.Location = new System.Drawing.Point(307, 215);
            this.lbCina.Name = "lbCina";
            this.lbCina.Size = new System.Drawing.Size(25, 24);
            this.lbCina.TabIndex = 18;
            this.lbCina.Text = "...";
            // 
            // lbPranz
            // 
            this.lbPranz.AutoSize = true;
            this.lbPranz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPranz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPranz.Location = new System.Drawing.Point(307, 172);
            this.lbPranz.Name = "lbPranz";
            this.lbPranz.Size = new System.Drawing.Size(25, 24);
            this.lbPranz.TabIndex = 19;
            this.lbPranz.Text = "...";
            // 
            // lbDejun
            // 
            this.lbDejun.AutoSize = true;
            this.lbDejun.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDejun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDejun.Location = new System.Drawing.Point(307, 133);
            this.lbDejun.Name = "lbDejun";
            this.lbDejun.Size = new System.Drawing.Size(25, 24);
            this.lbDejun.TabIndex = 20;
            this.lbDejun.Text = "...";
            // 
            // btProgres
            // 
            this.btProgres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btProgres.Location = new System.Drawing.Point(589, 264);
            this.btProgres.Name = "btProgres";
            this.btProgres.Size = new System.Drawing.Size(179, 50);
            this.btProgres.TabIndex = 21;
            this.btProgres.Text = "Vezi progresul";
            this.btProgres.UseVisualStyleBackColor = true;
            this.btProgres.Click += new System.EventHandler(this.btProgres_Click);
            // 
            // lbGustari
            // 
            this.lbGustari.AutoSize = true;
            this.lbGustari.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbGustari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGustari.Location = new System.Drawing.Point(307, 258);
            this.lbGustari.Name = "lbGustari";
            this.lbGustari.Size = new System.Drawing.Size(25, 24);
            this.lbGustari.TabIndex = 22;
            this.lbGustari.Text = "...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGustari);
            this.Controls.Add(this.btProgres);
            this.Controls.Add(this.lbDejun);
            this.Controls.Add(this.lbPranz);
            this.Controls.Add(this.lbCina);
            this.Controls.Add(this.btNextDay);
            this.Controls.Add(this.CalRamase);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.rbCina);
            this.Controls.Add(this.rbPranz);
            this.Controls.Add(this.rbGustari);
            this.Controls.Add(this.rbDejun);
            this.Controls.Add(this.carbohidrati);
            this.Controls.Add(this.grasimi);
            this.Controls.Add(this.proteine);
            this.Controls.Add(this.buget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label buget;
        private System.Windows.Forms.Label proteine;
        private System.Windows.Forms.Label grasimi;
        private System.Windows.Forms.Label carbohidrati;
        private System.Windows.Forms.Button btAdauga;
        private System.Windows.Forms.Label adauga;
        private System.Windows.Forms.Label CalRamase;
        private System.Windows.Forms.Button btNextDay;
        public System.Windows.Forms.RadioButton rbDejun;
        public System.Windows.Forms.RadioButton rbGustari;
        public System.Windows.Forms.RadioButton rbPranz;
        public System.Windows.Forms.RadioButton rbCina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProgres;
        public System.Windows.Forms.Label lbGustari;
        public System.Windows.Forms.Label lbCina;
        public System.Windows.Forms.Label lbPranz;
        public System.Windows.Forms.Label lbDejun;
    }
}