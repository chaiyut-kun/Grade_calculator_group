namespace Grade_calculator
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
            this.text_id_student = new System.Windows.Forms.TextBox();
            this.student_id_label = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.text_point = new System.Windows.Forms.TextBox();
            this.point_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.text_id_student_max = new System.Windows.Forms.TextBox();
            this.text_id_student_min = new System.Windows.Forms.TextBox();
            this.text_name_max = new System.Windows.Forms.TextBox();
            this.text_name_min = new System.Windows.Forms.TextBox();
            this.text_point_max = new System.Windows.Forms.TextBox();
            this.text_point_min = new System.Windows.Forms.TextBox();
            this.text_avg_point = new System.Windows.Forms.TextBox();
            this.avg_point_label = new System.Windows.Forms.Label();
            this.max_point_label = new System.Windows.Forms.Label();
            this.min_point_label = new System.Windows.Forms.Label();
            this.student_id_label2 = new System.Windows.Forms.Label();
            this.name_label2 = new System.Windows.Forms.Label();
            this.point_label2 = new System.Windows.Forms.Label();
            this.group_enter_data_box = new System.Windows.Forms.GroupBox();
            this.group_result_box = new System.Windows.Forms.GroupBox();
            this.group_enter_data_box.SuspendLayout();
            this.group_result_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_id_student
            // 
            this.text_id_student.Location = new System.Drawing.Point(168, 35);
            this.text_id_student.Name = "text_id_student";
            this.text_id_student.Size = new System.Drawing.Size(100, 27);
            this.text_id_student.TabIndex = 1;
            // 
            // student_id_label
            // 
            this.student_id_label.AutoSize = true;
            this.student_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label.Location = new System.Drawing.Point(68, 37);
            this.student_id_label.Name = "student_id_label";
            this.student_id_label.Size = new System.Drawing.Size(94, 20);
            this.student_id_label.TabIndex = 2;
            this.student_id_label.Text = "รหัสนักศึกษา";
            this.student_id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(168, 80);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 27);
            this.text_name.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(68, 82);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(91, 20);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "ชื่อ-นามสกุล";
            // 
            // text_point
            // 
            this.text_point.Location = new System.Drawing.Point(168, 131);
            this.text_point.Name = "text_point";
            this.text_point.Size = new System.Drawing.Size(100, 27);
            this.text_point.TabIndex = 5;
            // 
            // point_label
            // 
            this.point_label.AutoSize = true;
            this.point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label.Location = new System.Drawing.Point(68, 133);
            this.point_label.Name = "point_label";
            this.point_label.Size = new System.Drawing.Size(58, 20);
            this.point_label.TabIndex = 6;
            this.point_label.Text = "คะแนน";
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(178, 177);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(79, 32);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = " บักทึก";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // text_id_student_max
            // 
            this.text_id_student_max.Location = new System.Drawing.Point(134, 94);
            this.text_id_student_max.Name = "text_id_student_max";
            this.text_id_student_max.Size = new System.Drawing.Size(100, 27);
            this.text_id_student_max.TabIndex = 8;
            // 
            // text_id_student_min
            // 
            this.text_id_student_min.Location = new System.Drawing.Point(134, 143);
            this.text_id_student_min.Name = "text_id_student_min";
            this.text_id_student_min.Size = new System.Drawing.Size(100, 27);
            this.text_id_student_min.TabIndex = 9;
            // 
            // text_name_max
            // 
            this.text_name_max.Location = new System.Drawing.Point(266, 94);
            this.text_name_max.Name = "text_name_max";
            this.text_name_max.Size = new System.Drawing.Size(100, 27);
            this.text_name_max.TabIndex = 9;
            // 
            // text_name_min
            // 
            this.text_name_min.Location = new System.Drawing.Point(266, 145);
            this.text_name_min.Name = "text_name_min";
            this.text_name_min.Size = new System.Drawing.Size(100, 27);
            this.text_name_min.TabIndex = 10;
            // 
            // text_point_max
            // 
            this.text_point_max.Location = new System.Drawing.Point(398, 94);
            this.text_point_max.Name = "text_point_max";
            this.text_point_max.Size = new System.Drawing.Size(100, 27);
            this.text_point_max.TabIndex = 11;
            // 
            // text_point_min
            // 
            this.text_point_min.Location = new System.Drawing.Point(398, 145);
            this.text_point_min.Name = "text_point_min";
            this.text_point_min.Size = new System.Drawing.Size(100, 27);
            this.text_point_min.TabIndex = 12;
            // 
            // text_avg_point
            // 
            this.text_avg_point.Location = new System.Drawing.Point(398, 199);
            this.text_avg_point.Name = "text_avg_point";
            this.text_avg_point.Size = new System.Drawing.Size(100, 27);
            this.text_avg_point.TabIndex = 13;
            // 
            // avg_point_label
            // 
            this.avg_point_label.AutoSize = true;
            this.avg_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_point_label.Location = new System.Drawing.Point(273, 201);
            this.avg_point_label.Name = "avg_point_label";
            this.avg_point_label.Size = new System.Drawing.Size(93, 20);
            this.avg_point_label.TabIndex = 14;
            this.avg_point_label.Text = "คะแนนเฉลี่ย";
            // 
            // max_point_label
            // 
            this.max_point_label.AutoSize = true;
            this.max_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_point_label.Location = new System.Drawing.Point(16, 96);
            this.max_point_label.Name = "max_point_label";
            this.max_point_label.Size = new System.Drawing.Size(94, 20);
            this.max_point_label.TabIndex = 15;
            this.max_point_label.Text = "คะแนนสูงสุด";
            // 
            // min_point_label
            // 
            this.min_point_label.AutoSize = true;
            this.min_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_point_label.Location = new System.Drawing.Point(16, 147);
            this.min_point_label.Name = "min_point_label";
            this.min_point_label.Size = new System.Drawing.Size(95, 20);
            this.min_point_label.TabIndex = 16;
            this.min_point_label.Text = "คะแนนต่ำสุด";
            // 
            // student_id_label2
            // 
            this.student_id_label2.AutoSize = true;
            this.student_id_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label2.Location = new System.Drawing.Point(130, 47);
            this.student_id_label2.Name = "student_id_label2";
            this.student_id_label2.Size = new System.Drawing.Size(94, 20);
            this.student_id_label2.TabIndex = 17;
            this.student_id_label2.Text = "รหัสนักศึกษา";
            // 
            // name_label2
            // 
            this.name_label2.AutoSize = true;
            this.name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label2.Location = new System.Drawing.Point(273, 47);
            this.name_label2.Name = "name_label2";
            this.name_label2.Size = new System.Drawing.Size(91, 20);
            this.name_label2.TabIndex = 18;
            this.name_label2.Text = "ชื่อ-นามสกุล";
            // 
            // point_label2
            // 
            this.point_label2.AutoSize = true;
            this.point_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label2.Location = new System.Drawing.Point(404, 47);
            this.point_label2.Name = "point_label2";
            this.point_label2.Size = new System.Drawing.Size(58, 20);
            this.point_label2.TabIndex = 19;
            this.point_label2.Text = "คะแนน";
            // 
            // group_enter_data_box
            // 
            this.group_enter_data_box.Controls.Add(this.student_id_label);
            this.group_enter_data_box.Controls.Add(this.text_id_student);
            this.group_enter_data_box.Controls.Add(this.text_name);
            this.group_enter_data_box.Controls.Add(this.name_label);
            this.group_enter_data_box.Controls.Add(this.text_point);
            this.group_enter_data_box.Controls.Add(this.point_label);
            this.group_enter_data_box.Controls.Add(this.Save_button);
            this.group_enter_data_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_enter_data_box.Location = new System.Drawing.Point(57, 82);
            this.group_enter_data_box.Name = "group_enter_data_box";
            this.group_enter_data_box.Size = new System.Drawing.Size(335, 254);
            this.group_enter_data_box.TabIndex = 20;
            this.group_enter_data_box.TabStop = false;
            this.group_enter_data_box.Text = "กรอกข้อมูล";
            // 
            // group_result_box
            // 
            this.group_result_box.Controls.Add(this.text_name_min);
            this.group_result_box.Controls.Add(this.text_id_student_max);
            this.group_result_box.Controls.Add(this.point_label2);
            this.group_result_box.Controls.Add(this.text_id_student_min);
            this.group_result_box.Controls.Add(this.name_label2);
            this.group_result_box.Controls.Add(this.text_name_max);
            this.group_result_box.Controls.Add(this.student_id_label2);
            this.group_result_box.Controls.Add(this.text_point_max);
            this.group_result_box.Controls.Add(this.min_point_label);
            this.group_result_box.Controls.Add(this.text_point_min);
            this.group_result_box.Controls.Add(this.max_point_label);
            this.group_result_box.Controls.Add(this.text_avg_point);
            this.group_result_box.Controls.Add(this.avg_point_label);
            this.group_result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_result_box.Location = new System.Drawing.Point(445, 82);
            this.group_result_box.Name = "group_result_box";
            this.group_result_box.Size = new System.Drawing.Size(578, 254);
            this.group_result_box.TabIndex = 21;
            this.group_result_box.TabStop = false;
            this.group_result_box.Text = "ผลลัพธ์";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 396);
            this.Controls.Add(this.group_result_box);
            this.Controls.Add(this.group_enter_data_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_enter_data_box.ResumeLayout(false);
            this.group_enter_data_box.PerformLayout();
            this.group_result_box.ResumeLayout(false);
            this.group_result_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_id_student;
        private System.Windows.Forms.Label student_id_label;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox text_point;
        private System.Windows.Forms.Label point_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox text_id_student_max;
        private System.Windows.Forms.TextBox text_id_student_min;
        private System.Windows.Forms.TextBox text_name_max;
        private System.Windows.Forms.TextBox text_name_min;
        private System.Windows.Forms.TextBox text_point_max;
        private System.Windows.Forms.TextBox text_point_min;
        private System.Windows.Forms.TextBox text_avg_point;
        private System.Windows.Forms.Label avg_point_label;
        private System.Windows.Forms.Label max_point_label;
        private System.Windows.Forms.Label min_point_label;
        private System.Windows.Forms.Label student_id_label2;
        private System.Windows.Forms.Label name_label2;
        private System.Windows.Forms.Label point_label2;
        private System.Windows.Forms.GroupBox group_enter_data_box;
        private System.Windows.Forms.GroupBox group_result_box;
    }
}

