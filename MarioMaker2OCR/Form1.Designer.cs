﻿namespace MarioMaker2OCR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLevelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocrTextBox = new System.Windows.Forms.TextBox();
            this.ocrLabel = new System.Windows.Forms.Label();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.propertiesButton = new System.Windows.Forms.Button();
            this.resolutionsCombobox = new System.Windows.Forms.ComboBox();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderTextbox = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processStatusIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.percentMatchLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.processingLevelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLevelFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearLevelFileToolStripMenuItem
            // 
            this.clearLevelFileToolStripMenuItem.Name = "clearLevelFileToolStripMenuItem";
            this.clearLevelFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearLevelFileToolStripMenuItem.Text = "Clear Level File";
            this.clearLevelFileToolStripMenuItem.Click += new System.EventHandler(this.clearLevelFileToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ocrTextBox
            // 
            this.ocrTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocrTextBox.Location = new System.Drawing.Point(10, 187);
            this.ocrTextBox.Name = "ocrTextBox";
            this.ocrTextBox.ReadOnly = true;
            this.ocrTextBox.Size = new System.Drawing.Size(393, 29);
            this.ocrTextBox.TabIndex = 5;
            // 
            // ocrLabel
            // 
            this.ocrLabel.AutoSize = true;
            this.ocrLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocrLabel.Location = new System.Drawing.Point(17, 165);
            this.ocrLabel.Name = "ocrLabel";
            this.ocrLabel.Size = new System.Drawing.Size(38, 20);
            this.ocrLabel.TabIndex = 10;
            this.ocrLabel.Text = "OCR";
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceLabel.Location = new System.Drawing.Point(32, 34);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(54, 20);
            this.deviceLabel.TabIndex = 11;
            this.deviceLabel.Text = "Device";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(90, 36);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(241, 21);
            this.deviceComboBox.TabIndex = 12;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(113, 241);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(212, 241);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 14;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // propertiesButton
            // 
            this.propertiesButton.Location = new System.Drawing.Point(335, 35);
            this.propertiesButton.Name = "propertiesButton";
            this.propertiesButton.Size = new System.Drawing.Size(67, 23);
            this.propertiesButton.TabIndex = 15;
            this.propertiesButton.Text = "Properties";
            this.propertiesButton.UseVisualStyleBackColor = true;
            this.propertiesButton.Click += new System.EventHandler(this.propertiesButton_Click);
            // 
            // resolutionsCombobox
            // 
            this.resolutionsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsCombobox.FormattingEnabled = true;
            this.resolutionsCombobox.Location = new System.Drawing.Point(90, 65);
            this.resolutionsCombobox.Name = "resolutionsCombobox";
            this.resolutionsCombobox.Size = new System.Drawing.Size(85, 21);
            this.resolutionsCombobox.TabIndex = 16;
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderLabel.Location = new System.Drawing.Point(27, 96);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(55, 40);
            this.outputFolderLabel.TabIndex = 17;
            this.outputFolderLabel.Text = "Output\r\n Folder";
            // 
            // outputFolderTextbox
            // 
            this.outputFolderTextbox.Enabled = false;
            this.outputFolderTextbox.Location = new System.Drawing.Point(89, 100);
            this.outputFolderTextbox.Multiline = true;
            this.outputFolderTextbox.Name = "outputFolderTextbox";
            this.outputFolderTextbox.Size = new System.Drawing.Size(242, 51);
            this.outputFolderTextbox.TabIndex = 18;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(335, 100);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(67, 23);
            this.selectFolderButton.TabIndex = 19;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processStatusIcon,
            this.percentMatchLabel,
            this.processingLevelLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(415, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // processStatusIcon
            // 
            this.processStatusIcon.AutoToolTip = true;
            this.processStatusIcon.BackColor = System.Drawing.Color.Red;
            this.processStatusIcon.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.processStatusIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.processStatusIcon.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            this.processStatusIcon.Name = "processStatusIcon";
            this.processStatusIcon.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.processStatusIcon.Size = new System.Drawing.Size(17, 20);
            this.processStatusIcon.ToolTipText = "Process status";
            // 
            // percentMatchLabel
            // 
            this.percentMatchLabel.AutoToolTip = true;
            this.percentMatchLabel.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            this.percentMatchLabel.Name = "percentMatchLabel";
            this.percentMatchLabel.Size = new System.Drawing.Size(0, 20);
            this.percentMatchLabel.ToolTipText = "Percentage current video frame matches a Mario Maker 2 level screen";
            // 
            // processingLevelLabel
            // 
            this.processingLevelLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.processingLevelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processingLevelLabel.Margin = new System.Windows.Forms.Padding(-7, 3, 0, 2);
            this.processingLevelLabel.Name = "processingLevelLabel";
            this.processingLevelLabel.Size = new System.Drawing.Size(151, 20);
            this.processingLevelLabel.Text = "  - Processing Level...";
            this.processingLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processingLevelLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.processingLevelLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Resolution";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tool Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.outputFolderTextbox);
            this.Controls.Add(this.outputFolderLabel);
            this.Controls.Add(this.resolutionsCombobox);
            this.Controls.Add(this.propertiesButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.ocrLabel);
            this.Controls.Add(this.ocrTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mario Maker 2 OCR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox ocrTextBox;
        private System.Windows.Forms.Label ocrLabel;
        private System.Windows.Forms.ToolStripMenuItem clearLevelFileToolStripMenuItem;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button propertiesButton;
        private System.Windows.Forms.ComboBox resolutionsCombobox;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.TextBox outputFolderTextbox;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel percentMatchLabel;
        private System.Windows.Forms.ToolStripStatusLabel processStatusIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel processingLevelLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

