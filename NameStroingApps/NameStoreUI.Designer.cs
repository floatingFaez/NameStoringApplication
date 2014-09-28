namespace NameStroingApps
{
    partial class NameStoringForm
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
            this.addNameGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.countingResultLabel = new System.Windows.Forms.Label();
            this.addCountLabel = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showNameListBox = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.addNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNameGroupBox
            // 
            this.addNameGroupBox.Controls.Add(this.addButton);
            this.addNameGroupBox.Controls.Add(this.addNameTextBox);
            this.addNameGroupBox.Controls.Add(this.countingResultLabel);
            this.addNameGroupBox.Controls.Add(this.addCountLabel);
            this.addNameGroupBox.Location = new System.Drawing.Point(12, 72);
            this.addNameGroupBox.Name = "addNameGroupBox";
            this.addNameGroupBox.Size = new System.Drawing.Size(387, 104);
            this.addNameGroupBox.TabIndex = 2;
            this.addNameGroupBox.TabStop = false;
            this.addNameGroupBox.Text = "Add Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(293, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(31, 39);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.addNameTextBox.TabIndex = 1;
            // 
            // countingResultLabel
            // 
            this.countingResultLabel.AutoSize = true;
            this.countingResultLabel.Location = new System.Drawing.Point(107, 71);
            this.countingResultLabel.Name = "countingResultLabel";
            this.countingResultLabel.Size = new System.Drawing.Size(0, 13);
            this.countingResultLabel.TabIndex = 0;
            // 
            // addCountLabel
            // 
            this.addCountLabel.AutoSize = true;
            this.addCountLabel.Location = new System.Drawing.Point(28, 71);
            this.addCountLabel.Name = "addCountLabel";
            this.addCountLabel.Size = new System.Drawing.Size(63, 13);
            this.addCountLabel.TabIndex = 0;
            this.addCountLabel.Text = "Add Count :";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(305, 202);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 32);
            this.showAllButton.TabIndex = 3;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // showNameListBox
            // 
            this.showNameListBox.FormattingEnabled = true;
            this.showNameListBox.Location = new System.Drawing.Point(43, 202);
            this.showNameListBox.Name = "showNameListBox";
            this.showNameListBox.Size = new System.Drawing.Size(243, 186);
            this.showNameListBox.TabIndex = 2;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(305, 250);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 34);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(40, 32);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(35, 13);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "Count";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(305, 29);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(102, 29);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(184, 20);
            this.countTextBox.TabIndex = 1;
            // 
            // NameStoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 400);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.showNameListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.addNameGroupBox);
            this.Name = "NameStoringForm";
            this.Text = "Name Storing Application";
            this.Load += new System.EventHandler(this.NameStoringForm_Load);
            this.addNameGroupBox.ResumeLayout(false);
            this.addNameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addNameGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label countingResultLabel;
        private System.Windows.Forms.Label addCountLabel;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox showNameListBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox countTextBox;
    }
}

