namespace WinNameGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generateButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.NameListLabel = new System.Windows.Forms.Label();
            this.backUpButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateButton.Location = new System.Drawing.Point(157, 126);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(77, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(34, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(200, 37);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameListBox
            // 
            this.nameListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(34, 157);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(104, 160);
            this.nameListBox.TabIndex = 2;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(157, 184);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add to List";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Location = new System.Drawing.Point(157, 265);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save to File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(34, 328);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(200, 48);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameListLabel
            // 
            this.NameListLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameListLabel.AutoSize = true;
            this.NameListLabel.Location = new System.Drawing.Point(36, 131);
            this.NameListLabel.Name = "NameListLabel";
            this.NameListLabel.Size = new System.Drawing.Size(74, 13);
            this.NameListLabel.TabIndex = 6;
            this.NameListLabel.Text = "Saved Names";
            this.NameListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backUpButton
            // 
            this.backUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backUpButton.Location = new System.Drawing.Point(157, 155);
            this.backUpButton.Name = "backUpButton";
            this.backUpButton.Size = new System.Drawing.Size(77, 23);
            this.backUpButton.TabIndex = 7;
            this.backUpButton.Text = "<<<<";
            this.backUpButton.UseVisualStyleBackColor = true;
            this.backUpButton.Click += new System.EventHandler(this.backUpButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearListButton.Location = new System.Drawing.Point(157, 294);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(77, 23);
            this.clearListButton.TabIndex = 8;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 385);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.backUpButton);
            this.Controls.Add(this.NameListLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.generateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label NameListLabel;
        private System.Windows.Forms.Button backUpButton;
        private System.Windows.Forms.Button clearListButton;
    }
}

