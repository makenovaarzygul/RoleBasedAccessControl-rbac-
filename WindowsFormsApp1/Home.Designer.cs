
namespace WindowsFormsApp1
{
    partial class frm_Home
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
            this.btn_Attendance = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.Location = new System.Drawing.Point(90, 93);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Size = new System.Drawing.Size(110, 75);
            this.btn_Attendance.TabIndex = 0;
            this.btn_Attendance.Text = "Посещаемость";
            this.btn_Attendance.UseVisualStyleBackColor = true;
            // 
            // btn_Student
            // 
            this.btn_Student.Location = new System.Drawing.Point(278, 93);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(110, 75);
            this.btn_Student.TabIndex = 1;
            this.btn_Student.Text = "Студент";
            this.btn_Student.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(455, 93);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(110, 75);
            this.btn_Report.TabIndex = 2;
            this.btn_Report.Text = "Отчет";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Payment
            // 
            this.btn_Payment.Location = new System.Drawing.Point(90, 209);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(110, 75);
            this.btn_Payment.TabIndex = 3;
            this.btn_Payment.Text = "Оплата";
            this.btn_Payment.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(278, 209);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 75);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Добавить Юзера/Админа";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(455, 209);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(110, 75);
            this.btn_Settings.TabIndex = 5;
            this.btn_Settings.Text = "Настройки";
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(718, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(70, 46);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Выйти";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Location = new System.Drawing.Point(263, 27);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(137, 17);
            this.lbl_loguser.TabIndex = 7;
            this.lbl_loguser.Text = "Добро пожаловать:";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Student);
            this.Controls.Add(this.btn_Attendance);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Attendance;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
    }
}