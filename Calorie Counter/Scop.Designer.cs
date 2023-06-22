namespace Calorie_Counter
{
    partial class Scop
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
            this.ideal = new System.Windows.Forms.Label();
            this.scopul = new System.Windows.Forms.Label();
            this.rbSlabire = new System.Windows.Forms.RadioButton();
            this.rbMasa = new System.Windows.Forms.RadioButton();
            this.rbMentinere = new System.Windows.Forms.RadioButton();
            this.btConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ideal
            // 
            this.ideal.AutoSize = true;
            this.ideal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideal.Location = new System.Drawing.Point(54, 85);
            this.ideal.Name = "ideal";
            this.ideal.Size = new System.Drawing.Size(332, 24);
            this.ideal.TabIndex = 0;
            this.ideal.Text = "Greutatea ideala pentru tine ar fi....";
            // 
            // scopul
            // 
            this.scopul.AutoSize = true;
            this.scopul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scopul.Location = new System.Drawing.Point(118, 109);
            this.scopul.Name = "scopul";
            this.scopul.Size = new System.Drawing.Size(185, 24);
            this.scopul.TabIndex = 1;
            this.scopul.Text = "Care e scopul tau?";
            // 
            // rbSlabire
            // 
            this.rbSlabire.AutoSize = true;
            this.rbSlabire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSlabire.Location = new System.Drawing.Point(58, 185);
            this.rbSlabire.Name = "rbSlabire";
            this.rbSlabire.Size = new System.Drawing.Size(202, 29);
            this.rbSlabire.TabIndex = 6;
            this.rbSlabire.TabStop = true;
            this.rbSlabire.Text = "Vreau sa slabesc!";
            this.rbSlabire.UseVisualStyleBackColor = true;
            // 
            // rbMasa
            // 
            this.rbMasa.AutoSize = true;
            this.rbMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasa.Location = new System.Drawing.Point(58, 299);
            this.rbMasa.Name = "rbMasa";
            this.rbMasa.Size = new System.Drawing.Size(327, 29);
            this.rbMasa.TabIndex = 7;
            this.rbMasa.TabStop = true;
            this.rbMasa.Text = "Vreau sa pun masa musculara!";
            this.rbMasa.UseVisualStyleBackColor = true;
            // 
            // rbMentinere
            // 
            this.rbMentinere.AutoSize = true;
            this.rbMentinere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMentinere.Location = new System.Drawing.Point(58, 242);
            this.rbMentinere.Name = "rbMentinere";
            this.rbMentinere.Size = new System.Drawing.Size(227, 29);
            this.rbMentinere.TabIndex = 8;
            this.rbMentinere.TabStop = true;
            this.rbMentinere.Text = "Vreau sa ma mentin!";
            this.rbMentinere.UseVisualStyleBackColor = true;
            // 
            // btConfirma
            // 
            this.btConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirma.Location = new System.Drawing.Point(12, 392);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(180, 46);
            this.btConfirma.TabIndex = 9;
            this.btConfirma.Text = "Confirma";
            this.btConfirma.UseVisualStyleBackColor = true;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // Scop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calorie_Counter.Properties.Resources.scop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.rbMentinere);
            this.Controls.Add(this.rbMasa);
            this.Controls.Add(this.rbSlabire);
            this.Controls.Add(this.scopul);
            this.Controls.Add(this.ideal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Scop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scop_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ideal;
        private System.Windows.Forms.Label scopul;
        private System.Windows.Forms.RadioButton rbSlabire;
        private System.Windows.Forms.RadioButton rbMasa;
        private System.Windows.Forms.RadioButton rbMentinere;
        private System.Windows.Forms.Button btConfirma;
    }
}