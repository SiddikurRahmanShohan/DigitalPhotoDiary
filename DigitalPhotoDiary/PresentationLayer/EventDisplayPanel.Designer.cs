
namespace DigitalPhotoDiary.PresentationLayer
{
    partial class EventDisplayPanel
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
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.homeBackButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.modificationDateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.storyGroypBox = new System.Windows.Forms.GroupBox();
            this.storyLabel1 = new System.Windows.Forms.Label();
            this.storyGroupBox = new System.Windows.Forms.GroupBox();
            this.storyLabel2 = new System.Windows.Forms.Label();
            this.addPhotoButton1 = new System.Windows.Forms.Button();
            this.addPhotoButton2 = new System.Windows.Forms.Button();
            this.addStoryButton1 = new System.Windows.Forms.Button();
            this.addStoryButton2 = new System.Windows.Forms.Button();
            this.storyTextBox1 = new System.Windows.Forms.TextBox();
            this.storyTextBox2 = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.eventIdLabel = new System.Windows.Forms.Label();
            this.updatePhotoButton1 = new System.Windows.Forms.Button();
            this.updatePhotoButton2 = new System.Windows.Forms.Button();
            this.updateStoryButton1 = new System.Windows.Forms.Button();
            this.updateStoryButton2 = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathTextBox1 = new System.Windows.Forms.TextBox();
            this.pathTextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.storyGroypBox.SuspendLayout();
            this.storyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(70, 24);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(52, 17);
            this.eventNameLabel.TabIndex = 0;
            this.eventNameLabel.Text = "label1";
            // 
            // homeBackButton
            // 
            this.homeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBackButton.Location = new System.Drawing.Point(410, 453);
            this.homeBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeBackButton.Name = "homeBackButton";
            this.homeBackButton.Size = new System.Drawing.Size(52, 31);
            this.homeBackButton.TabIndex = 1;
            this.homeBackButton.Text = "Back";
            this.homeBackButton.UseVisualStyleBackColor = true;
            this.homeBackButton.Click += new System.EventHandler(this.homeBackButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(634, 9);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 17);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "label1";
            // 
            // modificationDateLabel
            // 
            this.modificationDateLabel.AutoSize = true;
            this.modificationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationDateLabel.Location = new System.Drawing.Point(634, 35);
            this.modificationDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modificationDateLabel.Name = "modificationDateLabel";
            this.modificationDateLabel.Size = new System.Drawing.Size(52, 17);
            this.modificationDateLabel.TabIndex = 3;
            this.modificationDateLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(96, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 210);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(495, 67);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 210);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // storyGroypBox
            // 
            this.storyGroypBox.Controls.Add(this.storyLabel1);
            this.storyGroypBox.Location = new System.Drawing.Point(119, 323);
            this.storyGroypBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyGroypBox.Name = "storyGroypBox";
            this.storyGroypBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyGroypBox.Size = new System.Drawing.Size(248, 41);
            this.storyGroypBox.TabIndex = 6;
            this.storyGroypBox.TabStop = false;
            this.storyGroypBox.Text = "Story:";
            this.storyGroypBox.Enter += new System.EventHandler(this.storyGroypBox_Enter);
            // 
            // storyLabel1
            // 
            this.storyLabel1.AutoSize = true;
            this.storyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel1.Location = new System.Drawing.Point(4, 15);
            this.storyLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.storyLabel1.Name = "storyLabel1";
            this.storyLabel1.Size = new System.Drawing.Size(133, 15);
            this.storyLabel1.TabIndex = 1;
            this.storyLabel1.Text = "Your Story Will Be Here";
            // 
            // storyGroupBox
            // 
            this.storyGroupBox.Controls.Add(this.storyLabel2);
            this.storyGroupBox.Location = new System.Drawing.Point(518, 323);
            this.storyGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyGroupBox.Name = "storyGroupBox";
            this.storyGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyGroupBox.Size = new System.Drawing.Size(239, 41);
            this.storyGroupBox.TabIndex = 7;
            this.storyGroupBox.TabStop = false;
            this.storyGroupBox.Text = "Story:";
            // 
            // storyLabel2
            // 
            this.storyLabel2.AutoSize = true;
            this.storyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel2.Location = new System.Drawing.Point(14, 16);
            this.storyLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.storyLabel2.Name = "storyLabel2";
            this.storyLabel2.Size = new System.Drawing.Size(136, 15);
            this.storyLabel2.TabIndex = 2;
            this.storyLabel2.Text = "Your Story Will Be Here.";
            // 
            // addPhotoButton1
            // 
            this.addPhotoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhotoButton1.Location = new System.Drawing.Point(20, 316);
            this.addPhotoButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPhotoButton1.Name = "addPhotoButton1";
            this.addPhotoButton1.Size = new System.Drawing.Size(82, 31);
            this.addPhotoButton1.TabIndex = 8;
            this.addPhotoButton1.Text = "AddPhoto";
            this.addPhotoButton1.UseVisualStyleBackColor = true;
            this.addPhotoButton1.Click += new System.EventHandler(this.addPhotoButton1_Click);
            // 
            // addPhotoButton2
            // 
            this.addPhotoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPhotoButton2.Location = new System.Drawing.Point(782, 309);
            this.addPhotoButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPhotoButton2.Name = "addPhotoButton2";
            this.addPhotoButton2.Size = new System.Drawing.Size(83, 31);
            this.addPhotoButton2.TabIndex = 9;
            this.addPhotoButton2.Text = "AddPhoto";
            this.addPhotoButton2.UseVisualStyleBackColor = true;
            this.addPhotoButton2.Click += new System.EventHandler(this.addPhotoButton2_Click);
            // 
            // addStoryButton1
            // 
            this.addStoryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStoryButton1.Location = new System.Drawing.Point(258, 412);
            this.addStoryButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStoryButton1.Name = "addStoryButton1";
            this.addStoryButton1.Size = new System.Drawing.Size(74, 31);
            this.addStoryButton1.TabIndex = 10;
            this.addStoryButton1.Text = "AddStory";
            this.addStoryButton1.UseVisualStyleBackColor = true;
            this.addStoryButton1.Click += new System.EventHandler(this.addStoryButton1_Click);
            // 
            // addStoryButton2
            // 
            this.addStoryButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStoryButton2.Location = new System.Drawing.Point(575, 412);
            this.addStoryButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStoryButton2.Name = "addStoryButton2";
            this.addStoryButton2.Size = new System.Drawing.Size(81, 31);
            this.addStoryButton2.TabIndex = 11;
            this.addStoryButton2.Text = "AddStory";
            this.addStoryButton2.UseVisualStyleBackColor = true;
            this.addStoryButton2.Click += new System.EventHandler(this.addStoryButton2_Click);
            // 
            // storyTextBox1
            // 
            this.storyTextBox1.Location = new System.Drawing.Point(119, 380);
            this.storyTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyTextBox1.Name = "storyTextBox1";
            this.storyTextBox1.Size = new System.Drawing.Size(248, 20);
            this.storyTextBox1.TabIndex = 12;
            // 
            // storyTextBox2
            // 
            this.storyTextBox2.Location = new System.Drawing.Point(518, 380);
            this.storyTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storyTextBox2.Name = "storyTextBox2";
            this.storyTextBox2.Size = new System.Drawing.Size(240, 20);
            this.storyTextBox2.TabIndex = 13;
            this.storyTextBox2.TextChanged += new System.EventHandler(this.storyTextBox2_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(370, 7);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(81, 17);
            this.userNameLabel.TabIndex = 14;
            this.userNameLabel.Text = "Username";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(461, 7);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(81, 17);
            this.userIdLabel.TabIndex = 15;
            this.userIdLabel.Text = "Username";
            // 
            // eventIdLabel
            // 
            this.eventIdLabel.AutoSize = true;
            this.eventIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIdLabel.Location = new System.Drawing.Point(195, 24);
            this.eventIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventIdLabel.Name = "eventIdLabel";
            this.eventIdLabel.Size = new System.Drawing.Size(52, 17);
            this.eventIdLabel.TabIndex = 16;
            this.eventIdLabel.Text = "label1";
            // 
            // updatePhotoButton1
            // 
            this.updatePhotoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhotoButton1.Location = new System.Drawing.Point(20, 351);
            this.updatePhotoButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatePhotoButton1.Name = "updatePhotoButton1";
            this.updatePhotoButton1.Size = new System.Drawing.Size(82, 31);
            this.updatePhotoButton1.TabIndex = 17;
            this.updatePhotoButton1.Text = "Update";
            this.updatePhotoButton1.UseVisualStyleBackColor = true;
            this.updatePhotoButton1.Click += new System.EventHandler(this.updatePhotoButton1_Click);
            // 
            // updatePhotoButton2
            // 
            this.updatePhotoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhotoButton2.Location = new System.Drawing.Point(782, 344);
            this.updatePhotoButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatePhotoButton2.Name = "updatePhotoButton2";
            this.updatePhotoButton2.Size = new System.Drawing.Size(83, 31);
            this.updatePhotoButton2.TabIndex = 18;
            this.updatePhotoButton2.Text = "Update";
            this.updatePhotoButton2.UseVisualStyleBackColor = true;
            this.updatePhotoButton2.Click += new System.EventHandler(this.updatePhotoButton2_Click);
            // 
            // updateStoryButton1
            // 
            this.updateStoryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStoryButton1.Location = new System.Drawing.Point(172, 412);
            this.updateStoryButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateStoryButton1.Name = "updateStoryButton1";
            this.updateStoryButton1.Size = new System.Drawing.Size(75, 31);
            this.updateStoryButton1.TabIndex = 19;
            this.updateStoryButton1.Text = "Update";
            this.updateStoryButton1.UseVisualStyleBackColor = true;
            // 
            // updateStoryButton2
            // 
            this.updateStoryButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStoryButton2.Location = new System.Drawing.Point(660, 412);
            this.updateStoryButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateStoryButton2.Name = "updateStoryButton2";
            this.updateStoryButton2.Size = new System.Drawing.Size(75, 31);
            this.updateStoryButton2.TabIndex = 20;
            this.updateStoryButton2.Text = "Update";
            this.updateStoryButton2.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(11, 273);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(81, 31);
            this.browseButton.TabIndex = 21;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseButton2
            // 
            this.browseButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton2.Location = new System.Drawing.Point(809, 264);
            this.browseButton2.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(81, 31);
            this.browseButton2.TabIndex = 22;
            this.browseButton2.Text = "Browse";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pathTextBox1
            // 
            this.pathTextBox1.Location = new System.Drawing.Point(126, 284);
            this.pathTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pathTextBox1.Name = "pathTextBox1";
            this.pathTextBox1.ReadOnly = true;
            this.pathTextBox1.Size = new System.Drawing.Size(248, 20);
            this.pathTextBox1.TabIndex = 23;
            // 
            // pathTextBox2
            // 
            this.pathTextBox2.Location = new System.Drawing.Point(509, 284);
            this.pathTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pathTextBox2.Name = "pathTextBox2";
            this.pathTextBox2.ReadOnly = true;
            this.pathTextBox2.Size = new System.Drawing.Size(248, 20);
            this.pathTextBox2.TabIndex = 24;
            // 
            // EventDisplayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 494);
            this.Controls.Add(this.pathTextBox2);
            this.Controls.Add(this.pathTextBox1);
            this.Controls.Add(this.browseButton2);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.updateStoryButton2);
            this.Controls.Add(this.updateStoryButton1);
            this.Controls.Add(this.updatePhotoButton2);
            this.Controls.Add(this.updatePhotoButton1);
            this.Controls.Add(this.eventIdLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.storyTextBox2);
            this.Controls.Add(this.storyTextBox1);
            this.Controls.Add(this.addStoryButton2);
            this.Controls.Add(this.addStoryButton1);
            this.Controls.Add(this.addPhotoButton2);
            this.Controls.Add(this.addPhotoButton1);
            this.Controls.Add(this.storyGroupBox);
            this.Controls.Add(this.storyGroypBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.modificationDateLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.homeBackButton);
            this.Controls.Add(this.eventNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventDisplayPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventDisplayPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventDisplayPanel_FormClosed);
            this.Load += new System.EventHandler(this.EventDisplayPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.storyGroypBox.ResumeLayout(false);
            this.storyGroypBox.PerformLayout();
            this.storyGroupBox.ResumeLayout(false);
            this.storyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Button homeBackButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label modificationDateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox storyGroypBox;
        private System.Windows.Forms.GroupBox storyGroupBox;
        private System.Windows.Forms.Button addPhotoButton1;
        private System.Windows.Forms.Button addPhotoButton2;
        private System.Windows.Forms.Button addStoryButton1;
        private System.Windows.Forms.Button addStoryButton2;
        private System.Windows.Forms.TextBox storyTextBox1;
        private System.Windows.Forms.TextBox storyTextBox2;
        private System.Windows.Forms.Label storyLabel1;
        private System.Windows.Forms.Label storyLabel2;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label eventIdLabel;
        private System.Windows.Forms.Button updatePhotoButton1;
        private System.Windows.Forms.Button updatePhotoButton2;
        private System.Windows.Forms.Button updateStoryButton1;
        private System.Windows.Forms.Button updateStoryButton2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button browseButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pathTextBox1;
        private System.Windows.Forms.TextBox pathTextBox2;
    }
}