namespace ToDoListApp
{
    partial class DetailForm
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
            this.tasknameLabel = new System.Windows.Forms.Label();
            this.Important_Label = new System.Windows.Forms.Label();
            this.Urgency_combobox = new System.Windows.Forms.ComboBox();
            this.Urgency_Label = new System.Windows.Forms.Label();
            this.Priority_combobox = new System.Windows.Forms.ComboBox();
            this.DeadLine_Label = new System.Windows.Forms.Label();
            this.Deadline_timepicker = new System.Windows.Forms.DateTimePicker();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.edit_buttom = new System.Windows.Forms.Button();
            this.delet_buttom = new System.Windows.Forms.Button();
            this.Task_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tasknameLabel
            // 
            this.tasknameLabel.AutoSize = true;
            this.tasknameLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tasknameLabel.Location = new System.Drawing.Point(13, 25);
            this.tasknameLabel.Name = "tasknameLabel";
            this.tasknameLabel.Size = new System.Drawing.Size(106, 24);
            this.tasknameLabel.TabIndex = 0;
            this.tasknameLabel.Text = "待辦事項";
            this.tasknameLabel.UseMnemonic = false;
            this.tasknameLabel.Click += new System.EventHandler(this.tasknameLabel_Click);
            // 
            // Important_Label
            // 
            this.Important_Label.AutoSize = true;
            this.Important_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Important_Label.Location = new System.Drawing.Point(37, 74);
            this.Important_Label.Name = "Important_Label";
            this.Important_Label.Size = new System.Drawing.Size(82, 24);
            this.Important_Label.TabIndex = 2;
            this.Important_Label.Text = "重要度";
            // 
            // Urgency_combobox
            // 
            this.Urgency_combobox.FormattingEnabled = true;
            this.Urgency_combobox.Items.AddRange(new object[] {
            "重要",
            "普通",
            "不重要"});
            this.Urgency_combobox.Location = new System.Drawing.Point(125, 80);
            this.Urgency_combobox.Name = "Urgency_combobox";
            this.Urgency_combobox.Size = new System.Drawing.Size(121, 20);
            this.Urgency_combobox.TabIndex = 6;
            // 
            // Urgency_Label
            // 
            this.Urgency_Label.AutoSize = true;
            this.Urgency_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Urgency_Label.Location = new System.Drawing.Point(37, 123);
            this.Urgency_Label.Name = "Urgency_Label";
            this.Urgency_Label.Size = new System.Drawing.Size(82, 24);
            this.Urgency_Label.TabIndex = 8;
            this.Urgency_Label.Text = "緊急度";
            // 
            // Priority_combobox
            // 
            this.Priority_combobox.FormattingEnabled = true;
            this.Priority_combobox.Items.AddRange(new object[] {
            "緊急",
            "普通",
            "不緊急"});
            this.Priority_combobox.Location = new System.Drawing.Point(125, 127);
            this.Priority_combobox.Name = "Priority_combobox";
            this.Priority_combobox.Size = new System.Drawing.Size(121, 20);
            this.Priority_combobox.TabIndex = 9;
            // 
            // DeadLine_Label
            // 
            this.DeadLine_Label.AutoSize = true;
            this.DeadLine_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeadLine_Label.Location = new System.Drawing.Point(37, 165);
            this.DeadLine_Label.Name = "DeadLine_Label";
            this.DeadLine_Label.Size = new System.Drawing.Size(82, 24);
            this.DeadLine_Label.TabIndex = 10;
            this.DeadLine_Label.Text = "截止日";
            // 
            // Deadline_timepicker
            // 
            this.Deadline_timepicker.Location = new System.Drawing.Point(125, 167);
            this.Deadline_timepicker.Name = "Deadline_timepicker";
            this.Deadline_timepicker.Size = new System.Drawing.Size(121, 22);
            this.Deadline_timepicker.TabIndex = 11;
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Description_Label.Location = new System.Drawing.Point(12, 204);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(106, 24);
            this.Description_Label.TabIndex = 12;
            this.Description_Label.Text = "工作說明";
            this.Description_Label.Click += new System.EventHandler(this.Description_Label_Click);
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(23, 231);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(223, 168);
            this.Description_textBox.TabIndex = 13;
            // 
            // edit_buttom
            // 
            this.edit_buttom.Location = new System.Drawing.Point(23, 415);
            this.edit_buttom.Name = "edit_buttom";
            this.edit_buttom.Size = new System.Drawing.Size(75, 23);
            this.edit_buttom.TabIndex = 14;
            this.edit_buttom.Text = "編輯";
            this.edit_buttom.UseVisualStyleBackColor = true;
            this.edit_buttom.Click += new System.EventHandler(this.edit_buttom_Click);
            // 
            // delet_buttom
            // 
            this.delet_buttom.Location = new System.Drawing.Point(171, 415);
            this.delet_buttom.Name = "delet_buttom";
            this.delet_buttom.Size = new System.Drawing.Size(75, 23);
            this.delet_buttom.TabIndex = 15;
            this.delet_buttom.Text = "刪除";
            this.delet_buttom.UseVisualStyleBackColor = true;
            this.delet_buttom.Click += new System.EventHandler(this.delet_buttom_Click);
            // 
            // Task_textbox
            // 
            this.Task_textbox.Location = new System.Drawing.Point(125, 27);
            this.Task_textbox.Name = "Task_textbox";
            this.Task_textbox.Size = new System.Drawing.Size(121, 22);
            this.Task_textbox.TabIndex = 16;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.Task_textbox);
            this.Controls.Add(this.delet_buttom);
            this.Controls.Add(this.edit_buttom);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Description_Label);
            this.Controls.Add(this.Deadline_timepicker);
            this.Controls.Add(this.DeadLine_Label);
            this.Controls.Add(this.Priority_combobox);
            this.Controls.Add(this.Urgency_Label);
            this.Controls.Add(this.Urgency_combobox);
            this.Controls.Add(this.Important_Label);
            this.Controls.Add(this.tasknameLabel);
            this.Name = "DetailForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tasknameLabel;
        private System.Windows.Forms.Label Important_Label;
        private System.Windows.Forms.ComboBox Urgency_combobox;
        private System.Windows.Forms.Label Urgency_Label;
        private System.Windows.Forms.ComboBox Priority_combobox;
        private System.Windows.Forms.Label DeadLine_Label;
        private System.Windows.Forms.DateTimePicker Deadline_timepicker;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Button edit_buttom;
        private System.Windows.Forms.Button delet_buttom;
        private System.Windows.Forms.TextBox Task_textbox;
    }
}