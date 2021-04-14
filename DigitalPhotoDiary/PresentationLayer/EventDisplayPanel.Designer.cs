
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
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(93, 50);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(59, 20);
            this.eventNameLabel.TabIndex = 0;
            this.eventNameLabel.Text = "label1";
            // 
            // homeBackButton
            // 
            this.homeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBackButton.Location = new System.Drawing.Point(461, 451);
            this.homeBackButton.Name = "homeBackButton";
            this.homeBackButton.Size = new System.Drawing.Size(70, 38);
            this.homeBackButton.TabIndex = 1;
            this.homeBackButton.Text = "Back";
            this.homeBackButton.UseVisualStyleBackColor = true;
            this.homeBackButton.Click += new System.EventHandler(this.homeBackButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(444, 50);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 20);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "label1";
            // 
            // modificationDateLabel
            // 
            this.modificationDateLabel.AutoSize = true;
            this.modificationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationDateLabel.Location = new System.Drawing.Point(431, 80);
            this.modificationDateLabel.Name = "modificationDateLabel";
            this.modificationDateLabel.Size = new System.Drawing.Size(59, 20);
            this.modificationDateLabel.TabIndex = 3;
            this.modificationDateLabel.Text = "label1";
            // 
            // EventDisplayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 516);
            this.Controls.Add(this.modificationDateLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.homeBackButton);
            this.Controls.Add(this.eventNameLabel);
            this.Name = "EventDisplayPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventDisplayPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventDisplayPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Button homeBackButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label modificationDateLabel;
    }
}