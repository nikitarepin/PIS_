namespace RoadMapApp.View
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxGoal = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonForm = new System.Windows.Forms.Button();
            this.textBoxInstructions = new System.Windows.Forms.TextBox();
            this.labelGoal = new System.Windows.Forms.Label();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxGoal
            // 
            this.comboBoxGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxGoal.FormattingEnabled = true;
            this.comboBoxGoal.Location = new System.Drawing.Point(13, 60);
            this.comboBoxGoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGoal.Name = "comboBoxGoal";
            this.comboBoxGoal.Size = new System.Drawing.Size(977, 33);
            this.comboBoxGoal.TabIndex = 0;
            this.comboBoxGoal.SelectedIndexChanged += new System.EventHandler(this.comboBoxGoal_SelectedIndexChanged);
            // 
            // dateTimePickerRegistrationDate
            // 
            this.dateTimePickerRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerRegistrationDate.Location = new System.Drawing.Point(13, 208);
            this.dateTimePickerRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerRegistrationDate.Name = "dateTimePickerRegistrationDate";
            this.dateTimePickerRegistrationDate.Size = new System.Drawing.Size(298, 30);
            this.dateTimePickerRegistrationDate.TabIndex = 1;
            this.dateTimePickerRegistrationDate.ValueChanged += new System.EventHandler(this.dateTimePickerRegistrationDate_ValueChanged);
            // 
            // buttonForm
            // 
            this.buttonForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonForm.Location = new System.Drawing.Point(13, 267);
            this.buttonForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonForm.Name = "buttonForm";
            this.buttonForm.Size = new System.Drawing.Size(208, 52);
            this.buttonForm.TabIndex = 2;
            this.buttonForm.Text = "Сформировать";
            this.buttonForm.UseVisualStyleBackColor = true;
            this.buttonForm.Click += new System.EventHandler(this.buttonForm_Click);
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxInstructions.Location = new System.Drawing.Point(13, 345);
            this.textBoxInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.Size = new System.Drawing.Size(977, 286);
            this.textBoxInstructions.TabIndex = 3;
            // 
            // labelGoal
            // 
            this.labelGoal.AutoSize = true;
            this.labelGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelGoal.Location = new System.Drawing.Point(13, 18);
            this.labelGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(191, 32);
            this.labelGoal.TabIndex = 4;
            this.labelGoal.Text = "Цель въезда:";
            this.labelGoal.Click += new System.EventHandler(this.labelGoal_Click);
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.AutoSize = true;
            this.labelRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRegistrationDate.Location = new System.Drawing.Point(8, 178);
            this.labelRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(253, 25);
            this.labelRegistrationDate.TabIndex = 5;
            this.labelRegistrationDate.Text = "Дата постановки на учет:";
            this.labelRegistrationDate.Click += new System.EventHandler(this.labelRegistrationDate_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(13, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(701, 33);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Вы участник государственной проргаммы переселения?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 649);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelRegistrationDate);
            this.Controls.Add(this.labelGoal);
            this.Controls.Add(this.textBoxInstructions);
            this.Controls.Add(this.buttonForm);
            this.Controls.Add(this.dateTimePickerRegistrationDate);
            this.Controls.Add(this.comboBoxGoal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Road Map App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxGoal;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistrationDate;
        private System.Windows.Forms.Button buttonForm;
        private System.Windows.Forms.TextBox textBoxInstructions;
        private System.Windows.Forms.Label labelGoal;
        private System.Windows.Forms.Label labelRegistrationDate;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}