namespace BT_projekt
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
            this.btnbelep = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.check2fal = new System.Windows.Forms.CheckBox();
            this.check2tru = new System.Windows.Forms.CheckBox();
            this.check3tru = new System.Windows.Forms.CheckBox();
            this.check3fal = new System.Windows.Forms.CheckBox();
            this.check1tru = new System.Windows.Forms.CheckBox();
            this.check1fal = new System.Windows.Forms.CheckBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnbelep
            // 
            this.btnbelep.Location = new System.Drawing.Point(560, 320);
            this.btnbelep.Name = "btnbelep";
            this.btnbelep.Size = new System.Drawing.Size(174, 80);
            this.btnbelep.TabIndex = 0;
            this.btnbelep.Text = "Belépés";
            this.btnbelep.UseVisualStyleBackColor = true;
            this.btnbelep.Click += new System.EventHandler(this.btnbelep_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(12, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(63, 26);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Név :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(12, 60);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(282, 26);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Személyi igazolvány szám :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.Location = new System.Drawing.Point(12, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(272, 26);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Vezet-e a nap folyamán?  :";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4.Location = new System.Drawing.Point(12, 140);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(296, 26);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Betöltötte már a 18. életévét :";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(433, 26);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(160, 20);
            this.txb1.TabIndex = 5;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5.Location = new System.Drawing.Point(12, 182);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(418, 26);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "Fog alkolholt fogyasztani a nap folyamán :";
            // 
            // check2fal
            // 
            this.check2fal.AutoSize = true;
            this.check2fal.Location = new System.Drawing.Point(519, 149);
            this.check2fal.Name = "check2fal";
            this.check2fal.Size = new System.Drawing.Size(46, 17);
            this.check2fal.TabIndex = 7;
            this.check2fal.Text = "nem";
            this.check2fal.UseVisualStyleBackColor = true;
            // 
            // check2tru
            // 
            this.check2tru.AutoSize = true;
            this.check2tru.Location = new System.Drawing.Point(433, 148);
            this.check2tru.Name = "check2tru";
            this.check2tru.Size = new System.Drawing.Size(46, 17);
            this.check2tru.TabIndex = 8;
            this.check2tru.Text = "igen";
            this.check2tru.UseVisualStyleBackColor = true;
            // 
            // check3tru
            // 
            this.check3tru.AutoSize = true;
            this.check3tru.Location = new System.Drawing.Point(433, 190);
            this.check3tru.Name = "check3tru";
            this.check3tru.Size = new System.Drawing.Size(46, 17);
            this.check3tru.TabIndex = 10;
            this.check3tru.Text = "igen";
            this.check3tru.UseVisualStyleBackColor = true;
            // 
            // check3fal
            // 
            this.check3fal.AutoSize = true;
            this.check3fal.Location = new System.Drawing.Point(519, 190);
            this.check3fal.Name = "check3fal";
            this.check3fal.Size = new System.Drawing.Size(46, 17);
            this.check3fal.TabIndex = 9;
            this.check3fal.Text = "nem";
            this.check3fal.UseVisualStyleBackColor = true;
            // 
            // check1tru
            // 
            this.check1tru.AutoSize = true;
            this.check1tru.Location = new System.Drawing.Point(433, 108);
            this.check1tru.Name = "check1tru";
            this.check1tru.Size = new System.Drawing.Size(46, 17);
            this.check1tru.TabIndex = 12;
            this.check1tru.Text = "igen";
            this.check1tru.UseVisualStyleBackColor = true;
            // 
            // check1fal
            // 
            this.check1fal.AutoSize = true;
            this.check1fal.Location = new System.Drawing.Point(519, 109);
            this.check1fal.Name = "check1fal";
            this.check1fal.Size = new System.Drawing.Size(46, 17);
            this.check1fal.TabIndex = 11;
            this.check1fal.Text = "nem";
            this.check1fal.UseVisualStyleBackColor = true;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(433, 66);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(160, 20);
            this.txb2.TabIndex = 13;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl6.Location = new System.Drawing.Point(12, 238);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(120, 26);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Stresszint :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.check1tru);
            this.Controls.Add(this.check1fal);
            this.Controls.Add(this.check3tru);
            this.Controls.Add(this.check3fal);
            this.Controls.Add(this.check2tru);
            this.Controls.Add(this.check2fal);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnbelep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbelep;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.CheckBox check2fal;
        private System.Windows.Forms.CheckBox check2tru;
        private System.Windows.Forms.CheckBox check3tru;
        private System.Windows.Forms.CheckBox check3fal;
        private System.Windows.Forms.CheckBox check1tru;
        private System.Windows.Forms.CheckBox check1fal;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

