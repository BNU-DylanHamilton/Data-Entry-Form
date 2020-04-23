namespace Data_Entry_Form
{
    partial class dataEntryForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.messageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.upperCaseButton = new System.Windows.Forms.Button();
            this.lowerCaseButton = new System.Windows.Forms.Button();
            this.townLabel = new System.Windows.Forms.Label();
            this.changeMessageButton = new System.Windows.Forms.Button();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Yellow;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(50, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(432, 47);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "User Details Data Entry";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(50, 80);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(136, 27);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(50, 120);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(117, 27);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Yellow;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(200, 216);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(2, 29);
            this.messageLabel.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(200, 85);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(157, 34);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.Location = new System.Drawing.Point(200, 125);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(157, 34);
            this.surnameTextBox.TabIndex = 5;
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(50, 351);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(117, 53);
            this.messageButton.TabIndex = 6;
            this.messageButton.Text = "&Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.showMessage);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 351);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 53);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearMessage);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(434, 356);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(95, 43);
            this.quitButton.TabIndex = 8;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // upperCaseButton
            // 
            this.upperCaseButton.Location = new System.Drawing.Point(50, 216);
            this.upperCaseButton.Name = "upperCaseButton";
            this.upperCaseButton.Size = new System.Drawing.Size(111, 41);
            this.upperCaseButton.TabIndex = 9;
            this.upperCaseButton.Text = "&Upper Case";
            this.upperCaseButton.UseVisualStyleBackColor = true;
            this.upperCaseButton.Click += new System.EventHandler(this.upperCaseMessage);
            // 
            // lowerCaseButton
            // 
            this.lowerCaseButton.Location = new System.Drawing.Point(50, 272);
            this.lowerCaseButton.Name = "lowerCaseButton";
            this.lowerCaseButton.Size = new System.Drawing.Size(111, 41);
            this.lowerCaseButton.TabIndex = 10;
            this.lowerCaseButton.Text = "&Lower Case";
            this.lowerCaseButton.UseVisualStyleBackColor = true;
            this.lowerCaseButton.Click += new System.EventHandler(this.lowerCaseMessage);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townLabel.Location = new System.Drawing.Point(87, 166);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(74, 27);
            this.townLabel.TabIndex = 11;
            this.townLabel.Text = "Town:";
            // 
            // changeMessageButton
            // 
            this.changeMessageButton.Location = new System.Drawing.Point(459, 98);
            this.changeMessageButton.Name = "changeMessageButton";
            this.changeMessageButton.Size = new System.Drawing.Size(122, 48);
            this.changeMessageButton.TabIndex = 12;
            this.changeMessageButton.Text = "C&hange Message";
            this.changeMessageButton.UseVisualStyleBackColor = true;
            this.changeMessageButton.Click += new System.EventHandler(this.changeMessage);
            // 
            // townTextBox
            // 
            this.townTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.townTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.townTextBox.Location = new System.Drawing.Point(200, 166);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(157, 34);
            this.townTextBox.TabIndex = 13;
            // 
            // dataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 431);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(this.changeMessageButton);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.lowerCaseButton);
            this.Controls.Add(this.upperCaseButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dataEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button upperCaseButton;
        private System.Windows.Forms.Button lowerCaseButton;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.Button changeMessageButton;
        private System.Windows.Forms.TextBox townTextBox;
    }
}

