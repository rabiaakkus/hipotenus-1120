namespace hipotenüs_1120
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
            this.lblKenar1 = new System.Windows.Forms.Label();
            this.lblKenar2 = new System.Windows.Forms.Label();
            this.lblHipotenus = new System.Windows.Forms.Label();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKenar1
            // 
            this.lblKenar1.AutoSize = true;
            this.lblKenar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar1.Location = new System.Drawing.Point(12, 35);
            this.lblKenar1.Name = "lblKenar1";
            this.lblKenar1.Size = new System.Drawing.Size(93, 25);
            this.lblKenar1.TabIndex = 0;
            this.lblKenar1.Text = "Kenar1 :";
            // 
            // lblKenar2
            // 
            this.lblKenar2.AutoSize = true;
            this.lblKenar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar2.Location = new System.Drawing.Point(12, 75);
            this.lblKenar2.Name = "lblKenar2";
            this.lblKenar2.Size = new System.Drawing.Size(93, 25);
            this.lblKenar2.TabIndex = 1;
            this.lblKenar2.Text = "Kenar2 :";
            // 
            // lblHipotenus
            // 
            this.lblHipotenus.AutoSize = true;
            this.lblHipotenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHipotenus.Location = new System.Drawing.Point(12, 174);
            this.lblHipotenus.Name = "lblHipotenus";
            this.lblHipotenus.Size = new System.Drawing.Size(85, 25);
            this.lblHipotenus.TabIndex = 2;
            this.lblHipotenus.Text = "Sonuc :";
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(111, 41);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(127, 20);
            this.txtKenar1.TabIndex = 3;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(111, 80);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(127, 20);
            this.txtKenar2.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(124, 115);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(127, 50);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(410, 289);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKenar2);
            this.Controls.Add(this.txtKenar1);
            this.Controls.Add(this.lblHipotenus);
            this.Controls.Add(this.lblKenar2);
            this.Controls.Add(this.lblKenar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKenar1;
        private System.Windows.Forms.Label lblKenar2;
        private System.Windows.Forms.Label lblHipotenus;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Button btnHesapla;
    }
}

