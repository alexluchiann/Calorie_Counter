namespace Calorie_Counter
{
    partial class Adauga
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ingrediente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gramaj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btTerminat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Morcov",
            "Rosii",
            "Broccoli",
            "Spanac",
            "Salata verde",
            "Ceapa",
            "Ardei gras",
            "Conopida",
            "Dovlecel",
            "Vinete",
            "Varza",
            "Fasole verde",
            "Sparanghel",
            "Ardei iute",
            "Gulie",
            "?elina",
            "Sfecla ro?ie",
            "Leurda",
            "Dovleac",
            "Linte",
            "Cartofii albi",
            "Orez",
            "Ciuperci",
            "Naut",
            "Cartofi ro?ii",
            "Portocale",
            "Mere",
            "Banane",
            "Kiwi",
            "Pere",
            "Cire?e",
            "Pepene verde",
            "Prune",
            "Ananas",
            "Piersici",
            "Mango",
            "Afine",
            "Zmeura",
            "Mure",
            "Capsuni",
            "Lamâi",
            "Alune",
            "Avocado",
            "Caise",
            "Clementine",
            "Coacaze",
            "Mandarine",
            "Masline",
            "Mure",
            "Cocos",
            "Nectarine",
            "Porumb",
            "Struguri",
            "Dude",
            "Gutuie",
            "Pui",
            "Vita",
            "Porc",
            "Curcan",
            "Ra?a",
            "Gâsca",
            "Pe?te",
            "Somon",
            "Tocatura de vita",
            "Cârna?i",
            "Brânza de vaci",
            "Ca?caval",
            "Mozzarella",
            "Parmezan",
            "Brie",
            "Roquefort",
            "Gouda",
            "Feta",
            "Brânza de oaie",
            "Ca?",
            "Brânza de casa",
            "Pâine",
            "Faina",
            "Lapte",
            "Oua",
            "Pâine",
            "Brânza",
            "?elina",
            "Morcovi",
            "Cartofi",
            "Castrave?i",
            "Rosii",
            "Ceapa",
            "Usturoi",
            "Patrunjel",
            "Lamâie",
            "Miere",
            "Cârna?i",
            "Somon",
            "Morcov",
            "Rosii",
            "Morcov",
            "Rosii",
            "Broccoli",
            "Spanac",
            "Salata verde",
            "Ceapa",
            "Ardei gras",
            "Conopida",
            "Dovlecel",
            "Vinete",
            "Varza"});
            this.comboBox1.Location = new System.Drawing.Point(43, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // ingrediente
            // 
            this.ingrediente.AutoSize = true;
            this.ingrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrediente.Location = new System.Drawing.Point(40, 76);
            this.ingrediente.Name = "ingrediente";
            this.ingrediente.Size = new System.Drawing.Size(274, 25);
            this.ingrediente.TabIndex = 1;
            this.ingrediente.Text = "Introduceti ingredientele:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 2;
            // 
            // gramaj
            // 
            this.gramaj.AutoSize = true;
            this.gramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramaj.Location = new System.Drawing.Point(418, 76);
            this.gramaj.Name = "gramaj";
            this.gramaj.Size = new System.Drawing.Size(94, 25);
            this.gramaj.TabIndex = 3;
            this.gramaj.Text = "Gramaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista ingrediente:";
            // 
            // btConfirma
            // 
            this.btConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirma.Location = new System.Drawing.Point(586, 377);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(202, 61);
            this.btConfirma.TabIndex = 8;
            this.btConfirma.Text = "Confirma";
            this.btConfirma.UseVisualStyleBackColor = true;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // btTerminat
            // 
            this.btTerminat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTerminat.Location = new System.Drawing.Point(586, 310);
            this.btTerminat.Name = "btTerminat";
            this.btTerminat.Size = new System.Drawing.Size(202, 61);
            this.btTerminat.TabIndex = 9;
            this.btTerminat.Text = "Am terminat";
            this.btTerminat.UseVisualStyleBackColor = true;
            this.btTerminat.Click += new System.EventHandler(this.btTerminat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 134);
            this.listBox1.TabIndex = 10;
            // 
            // Adauga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calorie_Counter.Properties.Resources.adauga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btTerminat);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gramaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ingrediente);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Adauga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Adauga_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ingrediente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label gramaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btTerminat;
        private System.Windows.Forms.ListBox listBox1;
    }
}