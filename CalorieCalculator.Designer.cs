namespace Act8
{
    partial class CalorieCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalorieCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.numGramsFatLabel = new System.Windows.Forms.Label();
            this.numGramsCarbsLabel = new System.Windows.Forms.Label();
            this.numGramsFatTextBox = new System.Windows.Forms.TextBox();
            this.numGramsCarbsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.numCalsCarbsTextBox = new System.Windows.Forms.TextBox();
            this.numCalsFatTextBox = new System.Windows.Forms.TextBox();
            this.numCalsCarbsLabel = new System.Windows.Forms.Label();
            this.numCalsFatLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate the Number of Calories From Fat and Carbs";
            // 
            // numGramsFatLabel
            // 
            this.numGramsFatLabel.AutoSize = true;
            this.numGramsFatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGramsFatLabel.Location = new System.Drawing.Point(101, 126);
            this.numGramsFatLabel.Name = "numGramsFatLabel";
            this.numGramsFatLabel.Size = new System.Drawing.Size(187, 20);
            this.numGramsFatLabel.TabIndex = 1;
            this.numGramsFatLabel.Text = "Number of grams of fat:";
            // 
            // numGramsCarbsLabel
            // 
            this.numGramsCarbsLabel.AutoSize = true;
            this.numGramsCarbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGramsCarbsLabel.Location = new System.Drawing.Point(78, 180);
            this.numGramsCarbsLabel.Name = "numGramsCarbsLabel";
            this.numGramsCarbsLabel.Size = new System.Drawing.Size(210, 20);
            this.numGramsCarbsLabel.TabIndex = 2;
            this.numGramsCarbsLabel.Text = "Number of grams of carbs:";
            // 
            // numGramsFatTextBox
            // 
            this.numGramsFatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGramsFatTextBox.Location = new System.Drawing.Point(339, 126);
            this.numGramsFatTextBox.Name = "numGramsFatTextBox";
            this.numGramsFatTextBox.Size = new System.Drawing.Size(287, 27);
            this.numGramsFatTextBox.TabIndex = 3;
            this.numGramsFatTextBox.Text = "0";
            this.numGramsFatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numGramsCarbsTextBox
            // 
            this.numGramsCarbsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGramsCarbsTextBox.Location = new System.Drawing.Point(339, 177);
            this.numGramsCarbsTextBox.Name = "numGramsCarbsTextBox";
            this.numGramsCarbsTextBox.Size = new System.Drawing.Size(287, 27);
            this.numGramsCarbsTextBox.TabIndex = 4;
            this.numGramsCarbsTextBox.Text = "0";
            this.numGramsCarbsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(339, 236);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(287, 60);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // numCalsCarbsTextBox
            // 
            this.numCalsCarbsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalsCarbsTextBox.Location = new System.Drawing.Point(339, 377);
            this.numCalsCarbsTextBox.Name = "numCalsCarbsTextBox";
            this.numCalsCarbsTextBox.Size = new System.Drawing.Size(287, 27);
            this.numCalsCarbsTextBox.TabIndex = 9;
            this.numCalsCarbsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numCalsFatTextBox
            // 
            this.numCalsFatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalsFatTextBox.Location = new System.Drawing.Point(339, 326);
            this.numCalsFatTextBox.Name = "numCalsFatTextBox";
            this.numCalsFatTextBox.Size = new System.Drawing.Size(287, 27);
            this.numCalsFatTextBox.TabIndex = 8;
            this.numCalsFatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numCalsCarbsLabel
            // 
            this.numCalsCarbsLabel.AutoSize = true;
            this.numCalsCarbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalsCarbsLabel.Location = new System.Drawing.Point(46, 380);
            this.numCalsCarbsLabel.Name = "numCalsCarbsLabel";
            this.numCalsCarbsLabel.Size = new System.Drawing.Size(242, 20);
            this.numCalsCarbsLabel.TabIndex = 7;
            this.numCalsCarbsLabel.Text = "Number of calories from carbs:";
            // 
            // numCalsFatLabel
            // 
            this.numCalsFatLabel.AutoSize = true;
            this.numCalsFatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalsFatLabel.Location = new System.Drawing.Point(69, 329);
            this.numCalsFatLabel.Name = "numCalsFatLabel";
            this.numCalsFatLabel.Size = new System.Drawing.Size(219, 20);
            this.numCalsFatLabel.TabIndex = 6;
            this.numCalsFatLabel.Text = "Number of calories from fat:";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(516, 465);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(110, 45);
            this.doneButton.TabIndex = 10;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CalorieCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(710, 558);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.numCalsCarbsTextBox);
            this.Controls.Add(this.numCalsFatTextBox);
            this.Controls.Add(this.numCalsCarbsLabel);
            this.Controls.Add(this.numCalsFatLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numGramsCarbsTextBox);
            this.Controls.Add(this.numGramsFatTextBox);
            this.Controls.Add(this.numGramsCarbsLabel);
            this.Controls.Add(this.numGramsFatLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalorieCalculator";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numGramsFatLabel;
        private System.Windows.Forms.Label numGramsCarbsLabel;
        private System.Windows.Forms.TextBox numGramsFatTextBox;
        private System.Windows.Forms.TextBox numGramsCarbsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox numCalsCarbsTextBox;
        private System.Windows.Forms.TextBox numCalsFatTextBox;
        private System.Windows.Forms.Label numCalsCarbsLabel;
        private System.Windows.Forms.Label numCalsFatLabel;
        private System.Windows.Forms.Button doneButton;
    }
}