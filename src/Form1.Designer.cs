namespace Math_Speed_Test
{
    partial class SpeedTest
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeRemaining = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.operand1 = new System.Windows.Forms.Label();
            this.operationLabel = new System.Windows.Forms.Label();
            this.operand2 = new System.Windows.Forms.Label();
            this.equals = new System.Windows.Forms.Label();
            this.answerField = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.completedLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.answerField)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeRemaining
            // 
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.Location = new System.Drawing.Point(343, 34);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(0, 13);
            this.timeRemaining.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Remaining: ";
            // 
            // operand1
            // 
            this.operand1.AutoSize = true;
            this.operand1.Location = new System.Drawing.Point(105, 102);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(13, 13);
            this.operand1.TabIndex = 2;
            this.operand1.Text = "?";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(124, 102);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(13, 13);
            this.operationLabel.TabIndex = 3;
            this.operationLabel.Text = "⋄";
            // 
            // operand2
            // 
            this.operand2.AutoSize = true;
            this.operand2.Location = new System.Drawing.Point(143, 102);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(13, 13);
            this.operand2.TabIndex = 4;
            this.operand2.Text = "?";
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(162, 102);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(13, 13);
            this.equals.TabIndex = 5;
            this.equals.Text = "=";
            // 
            // answerField
            // 
            this.answerField.Location = new System.Drawing.Point(181, 100);
            this.answerField.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(120, 20);
            this.answerField.TabIndex = 7;
            this.answerField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_Down);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(12, 150);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(81, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start the Test";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Completed: ";
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.Location = new System.Drawing.Point(94, 33);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(13, 13);
            this.completedLabel.TabIndex = 10;
            this.completedLabel.Text = "0";
            // 
            // NextButton
            // 
            this.NextButton.AutoSize = true;
            this.NextButton.Location = new System.Drawing.Point(332, 150);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 23);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next Question";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SpeedTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 202);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.completedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.operand2);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.operand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeRemaining);
            this.Name = "SpeedTest";
            this.Text = "Math Speed Test";
            ((System.ComponentModel.ISupportInitialize)(this.answerField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label operand1;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Label operand2;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.NumericUpDown answerField;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Button NextButton;
    }
}

