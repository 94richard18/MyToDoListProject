namespace ToDoListApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.task_dataGridView = new System.Windows.Forms.DataGridView();
            this.Important_Label = new System.Windows.Forms.Label();
            this.ToDo_label = new System.Windows.Forms.Label();
            this.Task_textbox = new System.Windows.Forms.TextBox();
            this.Urgency_combobox = new System.Windows.Forms.ComboBox();
            this.Priority_combobox = new System.Windows.Forms.ComboBox();
            this.Urgency_Label = new System.Windows.Forms.Label();
            this.DeadLine_Label = new System.Windows.Forms.Label();
            this.Deadline_timepicker = new System.Windows.Forms.DateTimePicker();
            this.Description_Label = new System.Windows.Forms.Label();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.task_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // task_dataGridView
            // 
            this.task_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.task_dataGridView.Location = new System.Drawing.Point(266, 12);
            this.task_dataGridView.Name = "task_dataGridView";
            this.task_dataGridView.RowTemplate.Height = 24;
            this.task_dataGridView.Size = new System.Drawing.Size(522, 506);
            this.task_dataGridView.TabIndex = 0;
            // 
            // Important_Label
            // 
            this.Important_Label.AutoSize = true;
            this.Important_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Important_Label.Location = new System.Drawing.Point(12, 68);
            this.Important_Label.Name = "Important_Label";
            this.Important_Label.Size = new System.Drawing.Size(82, 24);
            this.Important_Label.TabIndex = 1;
            this.Important_Label.Text = "重要度";
            // 
            // ToDo_label
            // 
            this.ToDo_label.AutoSize = true;
            this.ToDo_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToDo_label.Location = new System.Drawing.Point(12, 21);
            this.ToDo_label.Name = "ToDo_label";
            this.ToDo_label.Size = new System.Drawing.Size(106, 24);
            this.ToDo_label.TabIndex = 2;
            this.ToDo_label.Text = "代辦事項";
            // 
            // Task_textbox
            // 
            this.Task_textbox.Location = new System.Drawing.Point(124, 21);
            this.Task_textbox.Name = "Task_textbox";
            this.Task_textbox.Size = new System.Drawing.Size(121, 22);
            this.Task_textbox.TabIndex = 3;
            // 
            // Urgency_combobox
            // 
            this.Urgency_combobox.FormattingEnabled = true;
            this.Urgency_combobox.Items.AddRange(new object[] {
            "重要",
            "普通",
            "不重要"});
            this.Urgency_combobox.Location = new System.Drawing.Point(124, 68);
            this.Urgency_combobox.Name = "Urgency_combobox";
            this.Urgency_combobox.Size = new System.Drawing.Size(121, 20);
            this.Urgency_combobox.TabIndex = 5;
            // 
            // Priority_combobox
            // 
            this.Priority_combobox.FormattingEnabled = true;
            this.Priority_combobox.Items.AddRange(new object[] {
            "緊急",
            "普通",
            "不緊急"});
            this.Priority_combobox.Location = new System.Drawing.Point(124, 126);
            this.Priority_combobox.Name = "Priority_combobox";
            this.Priority_combobox.Size = new System.Drawing.Size(121, 20);
            this.Priority_combobox.TabIndex = 6;
            // 
            // Urgency_Label
            // 
            this.Urgency_Label.AutoSize = true;
            this.Urgency_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Urgency_Label.Location = new System.Drawing.Point(12, 120);
            this.Urgency_Label.Name = "Urgency_Label";
            this.Urgency_Label.Size = new System.Drawing.Size(82, 24);
            this.Urgency_Label.TabIndex = 7;
            this.Urgency_Label.Text = "緊急度";
            // 
            // DeadLine_Label
            // 
            this.DeadLine_Label.AutoSize = true;
            this.DeadLine_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeadLine_Label.Location = new System.Drawing.Point(12, 171);
            this.DeadLine_Label.Name = "DeadLine_Label";
            this.DeadLine_Label.Size = new System.Drawing.Size(82, 24);
            this.DeadLine_Label.TabIndex = 8;
            this.DeadLine_Label.Text = "截止日";
            // 
            // Deadline_timepicker
            // 
            this.Deadline_timepicker.Location = new System.Drawing.Point(124, 173);
            this.Deadline_timepicker.Name = "Deadline_timepicker";
            this.Deadline_timepicker.Size = new System.Drawing.Size(121, 22);
            this.Deadline_timepicker.TabIndex = 9;
            // 
            // Description_Label
            // 
            this.Description_Label.AutoSize = true;
            this.Description_Label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Description_Label.Location = new System.Drawing.Point(12, 227);
            this.Description_Label.Name = "Description_Label";
            this.Description_Label.Size = new System.Drawing.Size(106, 24);
            this.Description_Label.TabIndex = 10;
            this.Description_Label.Text = "工作說明";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(16, 264);
            this.Description_textBox.Multiline = true;
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(223, 168);
            this.Description_textBox.TabIndex = 11;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(22, 477);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 12;
            this.Add_button.Text = "新增";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 530);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Description_Label);
            this.Controls.Add(this.Deadline_timepicker);
            this.Controls.Add(this.DeadLine_Label);
            this.Controls.Add(this.Urgency_Label);
            this.Controls.Add(this.Priority_combobox);
            this.Controls.Add(this.Urgency_combobox);
            this.Controls.Add(this.Task_textbox);
            this.Controls.Add(this.ToDo_label);
            this.Controls.Add(this.Important_Label);
            this.Controls.Add(this.task_dataGridView);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView task_dataGridView;
        private System.Windows.Forms.Label Important_Label;
        private System.Windows.Forms.Label ToDo_label;
        private System.Windows.Forms.TextBox Task_textbox;
        private System.Windows.Forms.ComboBox Urgency_combobox;
        private System.Windows.Forms.ComboBox Priority_combobox;
        private System.Windows.Forms.Label Urgency_Label;
        private System.Windows.Forms.Label DeadLine_Label;
        private System.Windows.Forms.DateTimePicker Deadline_timepicker;
        private System.Windows.Forms.Label Description_Label;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.Button Add_button;
    }
}

