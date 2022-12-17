namespace Tic_Tac_Toe
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
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ServerRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(118, 61);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(232, 23);
            this.IpAddress.TabIndex = 0;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(26, 42);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(182, 15);
            this.InstructionLabel.TabIndex = 1;
            this.InstructionLabel.Text = "Enter an IP Address to connect to";
            this.InstructionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(26, 60);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(26, 97);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(455, 217);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.Text = "";
            // 
            // ServerRadioButton
            // 
            this.ServerRadioButton.AutoSize = true;
            this.ServerRadioButton.Checked = true;
            this.ServerRadioButton.Location = new System.Drawing.Point(27, 12);
            this.ServerRadioButton.Name = "ServerRadioButton";
            this.ServerRadioButton.Size = new System.Drawing.Size(94, 19);
            this.ServerRadioButton.TabIndex = 4;
            this.ServerRadioButton.TabStop = true;
            this.ServerRadioButton.Text = "Create Server";
            this.ServerRadioButton.UseVisualStyleBackColor = true;
            this.ServerRadioButton.CheckedChanged += new System.EventHandler(this.ServerRadioButton_CheckedChanged);
            // 
            // ClientRadioButton
            // 
            this.ClientRadioButton.AutoSize = true;
            this.ClientRadioButton.Location = new System.Drawing.Point(127, 12);
            this.ClientRadioButton.Name = "ClientRadioButton";
            this.ClientRadioButton.Size = new System.Drawing.Size(93, 19);
            this.ClientRadioButton.TabIndex = 5;
            this.ClientRadioButton.Text = "Create Client";
            this.ClientRadioButton.UseVisualStyleBackColor = true;
            this.ClientRadioButton.CheckedChanged += new System.EventHandler(this.ClientRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.ClientRadioButton);
            this.Controls.Add(this.ServerRadioButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.IpAddress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IpAddress;
        private Label InstructionLabel;
        private Button ConnectButton;
        private RichTextBox OutputTextBox;
        private RadioButton ServerRadioButton;
        private RadioButton ClientRadioButton;
    }
}