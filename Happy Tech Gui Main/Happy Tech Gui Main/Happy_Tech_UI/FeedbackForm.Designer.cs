namespace Happy_Tech_UI
{
    partial class FeedbackForm
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
            this.RecipientOfFeedback = new System.Windows.Forms.TextBox();
            this.Interviewer = new System.Windows.Forms.TextBox();
            this.SendFeedback = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FeedbackText = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FeedbackTopic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.suggestedText = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecipientOfFeedback
            // 
            this.RecipientOfFeedback.Location = new System.Drawing.Point(43, 132);
            this.RecipientOfFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.RecipientOfFeedback.Name = "RecipientOfFeedback";
            this.RecipientOfFeedback.Size = new System.Drawing.Size(159, 22);
            this.RecipientOfFeedback.TabIndex = 17;
            this.RecipientOfFeedback.Text = "FeedbackRecipient";
            // 
            // Interviewer
            // 
            this.Interviewer.Location = new System.Drawing.Point(43, 102);
            this.Interviewer.Margin = new System.Windows.Forms.Padding(4);
            this.Interviewer.Name = "Interviewer";
            this.Interviewer.Size = new System.Drawing.Size(159, 22);
            this.Interviewer.TabIndex = 16;
            this.Interviewer.Text = "Interviewer";
            this.Interviewer.TextChanged += new System.EventHandler(this.EntrName_TextChanged);
            // 
            // SendFeedback
            // 
            this.SendFeedback.Location = new System.Drawing.Point(437, 474);
            this.SendFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.SendFeedback.Name = "SendFeedback";
            this.SendFeedback.Size = new System.Drawing.Size(100, 28);
            this.SendFeedback.TabIndex = 14;
            this.SendFeedback.Text = "Send Email";
            this.SendFeedback.UseVisualStyleBackColor = true;
            this.SendFeedback.Click += new System.EventHandler(this.SendFeedback_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "HappyTech";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FeedbackText
            // 
            this.FeedbackText.Location = new System.Drawing.Point(261, 152);
            this.FeedbackText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeedbackText.Multiline = true;
            this.FeedbackText.Name = "FeedbackText";
            this.FeedbackText.Size = new System.Drawing.Size(475, 273);
            this.FeedbackText.TabIndex = 22;
            this.FeedbackText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(43, 404);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 21);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Unsuccessful Application";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(43, 377);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Successful Application";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FeedbackTopic
            // 
            this.FeedbackTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeedbackTopic.FormattingEnabled = true;
            this.FeedbackTopic.Items.AddRange(new object[] {
            "Successful CV",
            "Unsuccessful CV",
            "Tell us more about yourself",
            "Successful Technical Examination",
            "Unsuccessful Technical Examination",
            "Interview Invitation",
            "Right fit for the applied role",
            "The applied role did not match your skills"});
            this.FeedbackTopic.Location = new System.Drawing.Point(261, 123);
            this.FeedbackTopic.Name = "FeedbackTopic";
            this.FeedbackTopic.Size = new System.Drawing.Size(475, 24);
            this.FeedbackTopic.TabIndex = 24;
            this.FeedbackTopic.SelectedIndexChanged += new System.EventHandler(this.FeedbackTopic_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Feedback Topic:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // suggestedText
            // 
            this.suggestedText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suggestedText.FormattingEnabled = true;
            this.suggestedText.Location = new System.Drawing.Point(745, 207);
            this.suggestedText.Name = "suggestedText";
            this.suggestedText.Size = new System.Drawing.Size(219, 24);
            this.suggestedText.TabIndex = 26;
            this.suggestedText.SelectedIndexChanged += new System.EventHandler(this.suggestedText_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Insert Suggested Text:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(43, 239);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 89);
            this.checkedListBox1.TabIndex = 28;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Staff Template Selection";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suggestedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FeedbackTopic);
            this.Controls.Add(this.RecipientOfFeedback);
            this.Controls.Add(this.Interviewer);
            this.Controls.Add(this.SendFeedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FeedbackText);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecipientOfFeedback;
        private System.Windows.Forms.TextBox Interviewer;
        private System.Windows.Forms.Button SendFeedback;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FeedbackText;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox FeedbackTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox suggestedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
    }
}

