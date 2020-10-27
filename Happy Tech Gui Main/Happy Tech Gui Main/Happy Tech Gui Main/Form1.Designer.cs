namespace Happy_Tech_Gui_Main
{
    partial class Form
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
            this.SendFeedback = new System.Windows.Forms.Button();
            this.Templates = new System.Windows.Forms.ListBox();
            this.CheckboxforSucOrUnsucApplication = new System.Windows.Forms.CheckedListBox();
            this.EntrName = new System.Windows.Forms.TextBox();
            this.RecipientOfFeedback = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FeedbackTopic = new System.Windows.Forms.ListBox();
            this.ApplicantFeedback = new System.Windows.Forms.TextBox();
            this.ShortcutCheckbox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendFeedback
            // 
            this.SendFeedback.Location = new System.Drawing.Point(355, 379);
            this.SendFeedback.Name = "SendFeedback";
            this.SendFeedback.Size = new System.Drawing.Size(75, 23);
            this.SendFeedback.TabIndex = 0;
            this.SendFeedback.Text = "Send Email";
            this.SendFeedback.UseVisualStyleBackColor = true;
            this.SendFeedback.Click += new System.EventHandler(this.button1_Click);
            // 
            // Templates
            // 
            this.Templates.FormattingEnabled = true;
            this.Templates.Location = new System.Drawing.Point(66, 28);
            this.Templates.Name = "Templates";
            this.Templates.Size = new System.Drawing.Size(120, 95);
            this.Templates.TabIndex = 1;
            this.Templates.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CheckboxforSucOrUnsucApplication
            // 
            this.CheckboxforSucOrUnsucApplication.FormattingEnabled = true;
            this.CheckboxforSucOrUnsucApplication.Location = new System.Drawing.Point(66, 284);
            this.CheckboxforSucOrUnsucApplication.Name = "CheckboxforSucOrUnsucApplication";
            this.CheckboxforSucOrUnsucApplication.Size = new System.Drawing.Size(120, 94);
            this.CheckboxforSucOrUnsucApplication.TabIndex = 2;
            this.CheckboxforSucOrUnsucApplication.SelectedIndexChanged += new System.EventHandler(this.checBox1_SelectedIndexChanged);
            // 
            // EntrName
            // 
            this.EntrName.Location = new System.Drawing.Point(66, 129);
            this.EntrName.Name = "EntrName";
            this.EntrName.Size = new System.Drawing.Size(100, 20);
            this.EntrName.TabIndex = 3;
            this.EntrName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RecipientOfFeedback
            // 
            this.RecipientOfFeedback.Location = new System.Drawing.Point(66, 155);
            this.RecipientOfFeedback.Name = "RecipientOfFeedback";
            this.RecipientOfFeedback.Size = new System.Drawing.Size(100, 20);
            this.RecipientOfFeedback.TabIndex = 4;
            this.RecipientOfFeedback.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FeedbackTopic
            // 
            this.FeedbackTopic.FormattingEnabled = true;
            this.FeedbackTopic.Location = new System.Drawing.Point(66, 183);
            this.FeedbackTopic.Name = "FeedbackTopic";
            this.FeedbackTopic.Size = new System.Drawing.Size(120, 95);
            this.FeedbackTopic.TabIndex = 5;
            this.FeedbackTopic.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ApplicantFeedback
            // 
            this.ApplicantFeedback.Location = new System.Drawing.Point(236, 183);
            this.ApplicantFeedback.Name = "ApplicantFeedback";
            this.ApplicantFeedback.Size = new System.Drawing.Size(330, 20);
            this.ApplicantFeedback.TabIndex = 6;
            // 
            // ShortcutCheckbox
            // 
            this.ShortcutCheckbox.FormattingEnabled = true;
            this.ShortcutCheckbox.Location = new System.Drawing.Point(638, 81);
            this.ShortcutCheckbox.Name = "ShortcutCheckbox";
            this.ShortcutCheckbox.Size = new System.Drawing.Size(120, 94);
            this.ShortcutCheckbox.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Happy Tech";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShortcutCheckbox);
            this.Controls.Add(this.ApplicantFeedback);
            this.Controls.Add(this.FeedbackTopic);
            this.Controls.Add(this.RecipientOfFeedback);
            this.Controls.Add(this.EntrName);
            this.Controls.Add(this.CheckboxforSucOrUnsucApplication);
            this.Controls.Add(this.Templates);
            this.Controls.Add(this.SendFeedback);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendFeedback;
        private System.Windows.Forms.ListBox Templates;
        private System.Windows.Forms.CheckedListBox CheckboxforSucOrUnsucApplication;
        private System.Windows.Forms.TextBox EntrName;
        private System.Windows.Forms.TextBox RecipientOfFeedback;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox FeedbackTopic;
        private System.Windows.Forms.TextBox ApplicantFeedback;
        private System.Windows.Forms.CheckedListBox ShortcutCheckbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

