namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOut3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOut2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOut3
            // 
            this.txtOut3.Location = new System.Drawing.Point(253, 153);
            this.txtOut3.Name = "txtOut3";
            this.txtOut3.Size = new System.Drawing.Size(140, 112);
            this.txtOut3.TabIndex = 13;
            this.txtOut3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "В очереди:";
            // 
            // txtOut2
            // 
            this.txtOut2.Location = new System.Drawing.Point(253, 47);
            this.txtOut2.Name = "txtOut2";
            this.txtOut2.Size = new System.Drawing.Size(140, 99);
            this.txtOut2.TabIndex = 11;
            this.txtOut2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Взять";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(21, 50);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(207, 96);
            this.txtInfo.TabIndex = 9;
            this.txtInfo.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(21, 153);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(207, 96);
            this.txtOut.TabIndex = 8;
            this.txtOut.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Перезаполнить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 298);
            this.Controls.Add(this.txtOut3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtOut3;
        private Label label1;
        private RichTextBox txtOut2;
        private Button button2;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button button1;
    }
}