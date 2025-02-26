namespace WindowsFormsApp1
{
    partial class frmAstibin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExelent = new System.Windows.Forms.RadioButton();
            this.rbGood = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbVeryGood = new System.Windows.Forms.RadioButton();
            this.chbAddComment = new System.Windows.Forms.CheckBox();
            this.txtAddComment = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "استبيان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "تقديرك في  سي شارب";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbVeryGood);
            this.groupBox1.Controls.Add(this.rbGood);
            this.groupBox1.Controls.Add(this.rbExelent);
            this.groupBox1.Location = new System.Drawing.Point(49, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 54);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbExelent
            // 
            this.rbExelent.AutoSize = true;
            this.rbExelent.Location = new System.Drawing.Point(427, 20);
            this.rbExelent.Name = "rbExelent";
            this.rbExelent.Size = new System.Drawing.Size(65, 28);
            this.rbExelent.TabIndex = 0;
            this.rbExelent.TabStop = true;
            this.rbExelent.Text = "ممتاز";
            this.rbExelent.UseVisualStyleBackColor = true;
            this.rbExelent.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbGood
            // 
            this.rbGood.AutoSize = true;
            this.rbGood.Location = new System.Drawing.Point(174, 18);
            this.rbGood.Name = "rbGood";
            this.rbGood.Size = new System.Drawing.Size(52, 28);
            this.rbGood.TabIndex = 0;
            this.rbGood.TabStop = true;
            this.rbGood.Text = "جيد";
            this.rbGood.UseVisualStyleBackColor = true;
            this.rbGood.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(46, 18);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(68, 28);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "مقبول";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbVeryGood
            // 
            this.rbVeryGood.AutoSize = true;
            this.rbVeryGood.Location = new System.Drawing.Point(286, 18);
            this.rbVeryGood.Name = "rbVeryGood";
            this.rbVeryGood.Size = new System.Drawing.Size(81, 28);
            this.rbVeryGood.TabIndex = 0;
            this.rbVeryGood.TabStop = true;
            this.rbVeryGood.Text = "جيد جدا";
            this.rbVeryGood.UseVisualStyleBackColor = true;
            this.rbVeryGood.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // chbAddComment
            // 
            this.chbAddComment.AutoSize = true;
            this.chbAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAddComment.Location = new System.Drawing.Point(633, 151);
            this.chbAddComment.Name = "chbAddComment";
            this.chbAddComment.Size = new System.Drawing.Size(125, 29);
            this.chbAddComment.TabIndex = 7;
            this.chbAddComment.Text = "أضافة تعليق";
            this.chbAddComment.UseVisualStyleBackColor = true;
            this.chbAddComment.CheckedChanged += new System.EventHandler(this.chbAddComment_CheckedChanged);
            // 
            // txtAddComment
            // 
            this.txtAddComment.Location = new System.Drawing.Point(201, 141);
            this.txtAddComment.Multiline = true;
            this.txtAddComment.Name = "txtAddComment";
            this.txtAddComment.Size = new System.Drawing.Size(366, 86);
            this.txtAddComment.TabIndex = 8;
            this.txtAddComment.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(317, 283);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(116, 39);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "ارسال ";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "المشتريات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAstibin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtAddComment);
            this.Controls.Add(this.chbAddComment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAstibin";
            this.Text = "frmAstibin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExelent;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbGood;
        private System.Windows.Forms.RadioButton rbVeryGood;
        private System.Windows.Forms.CheckBox chbAddComment;
        private System.Windows.Forms.TextBox txtAddComment;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button1;
    }
}