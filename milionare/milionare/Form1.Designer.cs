namespace milionare
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
            this.button_answer1 = new System.Windows.Forms.Button();
            this.button_answer2 = new System.Windows.Forms.Button();
            this.button_answer3 = new System.Windows.Forms.Button();
            this.button_answer4 = new System.Windows.Forms.Button();
            this.label_question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_answer1
            // 
            this.button_answer1.Location = new System.Drawing.Point(30, 210);
            this.button_answer1.Name = "button_answer1";
            this.button_answer1.Size = new System.Drawing.Size(252, 70);
            this.button_answer1.TabIndex = 0;
            this.button_answer1.UseVisualStyleBackColor = true;
            // 
            // button_answer2
            // 
            this.button_answer2.Location = new System.Drawing.Point(30, 308);
            this.button_answer2.Name = "button_answer2";
            this.button_answer2.Size = new System.Drawing.Size(252, 69);
            this.button_answer2.TabIndex = 1;
            this.button_answer2.UseVisualStyleBackColor = true;
            // 
            // button_answer3
            // 
            this.button_answer3.Location = new System.Drawing.Point(314, 210);
            this.button_answer3.Name = "button_answer3";
            this.button_answer3.Size = new System.Drawing.Size(251, 70);
            this.button_answer3.TabIndex = 2;
            this.button_answer3.UseVisualStyleBackColor = true;
            // 
            // button_answer4
            // 
            this.button_answer4.Location = new System.Drawing.Point(314, 308);
            this.button_answer4.Name = "button_answer4";
            this.button_answer4.Size = new System.Drawing.Size(251, 69);
            this.button_answer4.TabIndex = 3;
            this.button_answer4.UseVisualStyleBackColor = true;
            // 
            // label_question
            // 
            this.label_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_question.Location = new System.Drawing.Point(51, 65);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(460, 82);
            this.label_question.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 446);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.button_answer4);
            this.Controls.Add(this.button_answer3);
            this.Controls.Add(this.button_answer2);
            this.Controls.Add(this.button_answer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onload);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_answer1;
        private System.Windows.Forms.Button button_answer2;
        private System.Windows.Forms.Button button_answer3;
        private System.Windows.Forms.Button button_answer4;
        private System.Windows.Forms.Label label_question;
    }
}

