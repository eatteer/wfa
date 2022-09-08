
namespace WFA.Forms
{
    partial class Questions
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answer1Button = new System.Windows.Forms.Button();
            this.answer2Button = new System.Windows.Forms.Button();
            this.answer3Button = new System.Windows.Forms.Button();
            this.answer4Button = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.fiftyButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(13, 13);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(49, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            // 
            // answer1Button
            // 
            this.answer1Button.Location = new System.Drawing.Point(16, 40);
            this.answer1Button.Name = "answer1Button";
            this.answer1Button.Size = new System.Drawing.Size(75, 23);
            this.answer1Button.TabIndex = 1;
            this.answer1Button.Text = "Answer 1";
            this.answer1Button.UseVisualStyleBackColor = true;
            // 
            // answer2Button
            // 
            this.answer2Button.Location = new System.Drawing.Point(98, 40);
            this.answer2Button.Name = "answer2Button";
            this.answer2Button.Size = new System.Drawing.Size(75, 23);
            this.answer2Button.TabIndex = 2;
            this.answer2Button.Text = "Answer2";
            this.answer2Button.UseVisualStyleBackColor = true;
            // 
            // answer3Button
            // 
            this.answer3Button.Location = new System.Drawing.Point(16, 70);
            this.answer3Button.Name = "answer3Button";
            this.answer3Button.Size = new System.Drawing.Size(75, 23);
            this.answer3Button.TabIndex = 3;
            this.answer3Button.Text = "Answer3";
            this.answer3Button.UseVisualStyleBackColor = true;
            // 
            // answer4Button
            // 
            this.answer4Button.Location = new System.Drawing.Point(98, 70);
            this.answer4Button.Name = "answer4Button";
            this.answer4Button.Size = new System.Drawing.Size(75, 23);
            this.answer4Button.TabIndex = 4;
            this.answer4Button.Text = "Answer4";
            this.answer4Button.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(16, 135);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // fiftyButton
            // 
            this.fiftyButton.Location = new System.Drawing.Point(98, 135);
            this.fiftyButton.Name = "fiftyButton";
            this.fiftyButton.Size = new System.Drawing.Size(75, 23);
            this.fiftyButton.TabIndex = 6;
            this.fiftyButton.Text = "50/50";
            this.fiftyButton.UseVisualStyleBackColor = true;
            this.fiftyButton.Click += new System.EventHandler(this.fiftyButton_Click);
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(180, 135);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 23);
            this.callButton.TabIndex = 7;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.fiftyButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.answer4Button);
            this.Controls.Add(this.answer3Button);
            this.Controls.Add(this.answer2Button);
            this.Controls.Add(this.answer1Button);
            this.Controls.Add(this.questionLabel);
            this.Name = "Questions";
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answer1Button;
        private System.Windows.Forms.Button answer2Button;
        private System.Windows.Forms.Button answer3Button;
        private System.Windows.Forms.Button answer4Button;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button fiftyButton;
        private System.Windows.Forms.Button callButton;
    }
}