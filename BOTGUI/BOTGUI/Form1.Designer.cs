namespace BOTGUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.GroupBox();
            this.grpQuiz = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnViewTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbActivityLog = new System.Windows.Forms.RichTextBox();
            this.grpQuiz.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(279, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CYBERSECURITY AWARENESS BOT";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.ForeColor = System.Drawing.Color.Black;
            this.txtUserInput.Location = new System.Drawing.Point(12, 327);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(563, 20);
            this.txtUserInput.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(12, 365);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 27);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(563, 294);
            this.rtbChat.TabIndex = 5;
            this.rtbChat.TabStop = false;
            this.rtbChat.Text = "Chat Assistant";
            // 
            // grpQuiz
            // 
            this.grpQuiz.Controls.Add(this.label4);
            this.grpQuiz.Location = new System.Drawing.Point(581, 327);
            this.grpQuiz.Name = "grpQuiz";
            this.grpQuiz.Size = new System.Drawing.Size(426, 117);
            this.grpQuiz.TabIndex = 7;
            this.grpQuiz.TabStop = false;
            this.grpQuiz.Text = "Cybersecurity Quiz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Question";
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.rtbActivityLog);
            this.grpLog.Location = new System.Drawing.Point(25, 452);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(982, 145);
            this.grpLog.TabIndex = 8;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Activity Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Title";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(9, 54);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(364, 20);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.btnDeleteTask);
            this.grpTasks.Controls.Add(this.btnCompleteTask);
            this.grpTasks.Controls.Add(this.btnViewTask);
            this.grpTasks.Controls.Add(this.btnAddTask);
            this.grpTasks.Controls.Add(this.dtpReminder);
            this.grpTasks.Controls.Add(this.label3);
            this.grpTasks.Controls.Add(this.textBox1);
            this.grpTasks.Controls.Add(this.label2);
            this.grpTasks.Controls.Add(this.txtTaskTitle);
            this.grpTasks.Controls.Add(this.label1);
            this.grpTasks.Location = new System.Drawing.Point(581, 27);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(426, 294);
            this.grpTasks.TabIndex = 6;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Task Assistant";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(141, 242);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 9;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(22, 243);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(86, 23);
            this.btnCompleteTask.TabIndex = 8;
            this.btnCompleteTask.Text = "Complete Task";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            // 
            // btnViewTask
            // 
            this.btnViewTask.Location = new System.Drawing.Point(141, 214);
            this.btnViewTask.Name = "btnViewTask";
            this.btnViewTask.Size = new System.Drawing.Size(75, 23);
            this.btnViewTask.TabIndex = 7;
            this.btnViewTask.Text = "View Tasks";
            this.btnViewTask.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(22, 214);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(86, 23);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(9, 177);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(200, 20);
            this.dtpReminder.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reminder Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // rtbActivityLog
            // 
            this.rtbActivityLog.Location = new System.Drawing.Point(11, 29);
            this.rtbActivityLog.Name = "rtbActivityLog";
            this.rtbActivityLog.ReadOnly = true;
            this.rtbActivityLog.Size = new System.Drawing.Size(351, 96);
            this.rtbActivityLog.TabIndex = 9;
            this.rtbActivityLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpQuiz);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpQuiz.ResumeLayout(false);
            this.grpQuiz.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpTasks.ResumeLayout(false);
            this.grpTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox rtbChat;
        private System.Windows.Forms.GroupBox grpQuiz;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnViewTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbActivityLog;
    }
}

