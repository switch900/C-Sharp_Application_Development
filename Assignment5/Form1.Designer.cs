namespace COMP2614Assign05
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
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCheckDate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(9, 13);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "&Year:";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(85, 13);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "&Month:";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(161, 13);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(29, 13);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "&Day:";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Location = new System.Drawing.Point(12, 29);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(70, 20);
            this.textBoxYear.TabIndex = 0;
            this.textBoxYear.Click += new System.EventHandler(this.textBoxYear_Enter);
            this.textBoxYear.Enter += new System.EventHandler(this.textBoxYear_Enter);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonth.Location = new System.Drawing.Point(88, 29);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(70, 20);
            this.textBoxMonth.TabIndex = 4;
            this.textBoxMonth.Click += new System.EventHandler(this.textBoxMonth_Enter);
            this.textBoxMonth.Enter += new System.EventHandler(this.textBoxMonth_Enter);
            // 
            // textBoxDay
            // 
            this.textBoxDay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDay.Location = new System.Drawing.Point(164, 29);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(70, 20);
            this.textBoxDay.TabIndex = 6;
            this.textBoxDay.Click += new System.EventHandler(this.textBoxDay_Enter);
            this.textBoxDay.Enter += new System.EventHandler(this.textBoxDay_Enter);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(8, 79);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(81, 24);
            this.labelResult.TabIndex = 7;
            this.labelResult.Tag = "";
            this.labelResult.Text = "<Valid>";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.labelResult, "Enter the Dragon\r\n");
            // 
            // buttonCheckDate
            // 
            this.buttonCheckDate.Location = new System.Drawing.Point(152, 81);
            this.buttonCheckDate.Name = "buttonCheckDate";
            this.buttonCheckDate.Size = new System.Drawing.Size(82, 25);
            this.buttonCheckDate.TabIndex = 7;
            this.buttonCheckDate.Text = "&Check Date";
            this.buttonCheckDate.UseVisualStyleBackColor = true;
            this.buttonCheckDate.Click += new System.EventHandler(this.buttonCheckDate_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCheckDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(251, 126);
            this.Controls.Add(this.buttonCheckDate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Validator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.textBoxYear_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheckDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

