namespace Tyuiu.MironenkoSE.Sprint6.Task1.V25
{
    partial class FormMain
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer_LVA = new System.Windows.Forms.TextBox();
            this.textBoxVarA_LVA = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxVarB_LVA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(446, 367);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(135, 71);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(338, 367);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(102, 71);
            this.buttonD.TabIndex = 1;
            this.buttonD.Text = "Справка";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAnswer_LVA);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 400);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxVarB_LVA);
            this.groupBox2.Controls.Add(this.textBoxVarA_LVA);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 333);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Условие";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных";
            // 
            // textBoxAnswer_LVA
            // 
            this.textBoxAnswer_LVA.Location = new System.Drawing.Point(17, 39);
            this.textBoxAnswer_LVA.Multiline = true;
            this.textBoxAnswer_LVA.Name = "textBoxAnswer_LVA";
            this.textBoxAnswer_LVA.Size = new System.Drawing.Size(168, 345);
            this.textBoxAnswer_LVA.TabIndex = 0;
            this.textBoxAnswer_LVA.Text = "1";
            this.textBoxAnswer_LVA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxVarA_LVA
            // 
            this.textBoxVarA_LVA.Location = new System.Drawing.Point(6, 83);
            this.textBoxVarA_LVA.Name = "textBoxVarA_LVA";
            this.textBoxVarA_LVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA_LVA.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(205, 35);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 10);
            this.textBox4.TabIndex = 2;
            // 
            // textBoxVarB_LVA
            // 
            this.textBoxVarB_LVA.Location = new System.Drawing.Point(186, 83);
            this.textBoxVarB_LVA.Name = "textBoxVarB_LVA";
            this.textBoxVarB_LVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarB_LVA.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(326, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonDone);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxVarA_LVA;
        private System.Windows.Forms.TextBox textBoxAnswer_LVA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxVarB_LVA;
        private System.Windows.Forms.TextBox textBox4;
    }
}

