namespace ReceiveMail
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
            this.txtBodyR = new System.Windows.Forms.TextBox();
            this.txtFromR = new System.Windows.Forms.TextBox();
            this.txtSubjectR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBodyR
            // 
            this.txtBodyR.Location = new System.Drawing.Point(53, 200);
            this.txtBodyR.Multiline = true;
            this.txtBodyR.Name = "txtBodyR";
            this.txtBodyR.Size = new System.Drawing.Size(493, 148);
            this.txtBodyR.TabIndex = 0;
            // 
            // txtFromR
            // 
            this.txtFromR.Location = new System.Drawing.Point(53, 42);
            this.txtFromR.Name = "txtFromR";
            this.txtFromR.Size = new System.Drawing.Size(338, 22);
            this.txtFromR.TabIndex = 1;
            // 
            // txtSubjectR
            // 
            this.txtSubjectR.Location = new System.Drawing.Point(53, 110);
            this.txtSubjectR.Name = "txtSubjectR";
            this.txtSubjectR.Size = new System.Drawing.Size(493, 22);
            this.txtSubjectR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectR);
            this.Controls.Add(this.txtFromR);
            this.Controls.Add(this.txtBodyR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBodyR;
        private System.Windows.Forms.TextBox txtFromR;
        private System.Windows.Forms.TextBox txtSubjectR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

