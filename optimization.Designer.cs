namespace solution
{
    partial class form_optimization
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
            this.text_function = new System.Windows.Forms.TextBox();
            this.label_function = new System.Windows.Forms.Label();
            this.group_powell = new System.Windows.Forms.GroupBox();
            this.text_powell_output = new System.Windows.Forms.TextBox();
            this.label_powell_output = new System.Windows.Forms.Label();
            this.text_powell_time = new System.Windows.Forms.TextBox();
            this.label_powell_time = new System.Windows.Forms.Label();
            this.button_calculate_powell = new System.Windows.Forms.Button();
            this.label_d2_x1 = new System.Windows.Forms.Label();
            this.text_d2_x1 = new System.Windows.Forms.TextBox();
            this.label_d2_x0 = new System.Windows.Forms.Label();
            this.label_d1_x1 = new System.Windows.Forms.Label();
            this.label_d1_x0 = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_x0 = new System.Windows.Forms.Label();
            this.text_d2_x0 = new System.Windows.Forms.TextBox();
            this.text_d1_x1 = new System.Windows.Forms.TextBox();
            this.text_d1_x0 = new System.Windows.Forms.TextBox();
            this.text_e = new System.Windows.Forms.TextBox();
            this.text_x1 = new System.Windows.Forms.TextBox();
            this.text_x0 = new System.Windows.Forms.TextBox();
            this.group_koshi = new System.Windows.Forms.GroupBox();
            this.text_koshi_output = new System.Windows.Forms.TextBox();
            this.label_koshi_output = new System.Windows.Forms.Label();
            this.text_koshi_time = new System.Windows.Forms.TextBox();
            this.label_koshi_time = new System.Windows.Forms.Label();
            this.button_calculate_koshi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.group_powell.SuspendLayout();
            this.group_koshi.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_function
            // 
            this.text_function.Location = new System.Drawing.Point(6, 28);
            this.text_function.Name = "text_function";
            this.text_function.ReadOnly = true;
            this.text_function.Size = new System.Drawing.Size(410, 20);
            this.text_function.TabIndex = 43;
            this.text_function.Text = "2 * x1^2 + x1 * x2 + x2^2";
            this.text_function.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_function
            // 
            this.label_function.Location = new System.Drawing.Point(6, 5);
            this.label_function.Name = "label_function";
            this.label_function.Size = new System.Drawing.Size(410, 20);
            this.label_function.TabIndex = 42;
            this.label_function.Text = "оптимиз. функция:";
            this.label_function.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_powell
            // 
            this.group_powell.Controls.Add(this.text_powell_output);
            this.group_powell.Controls.Add(this.label_powell_output);
            this.group_powell.Controls.Add(this.text_powell_time);
            this.group_powell.Controls.Add(this.label_powell_time);
            this.group_powell.Controls.Add(this.button_calculate_powell);
            this.group_powell.Controls.Add(this.label_d2_x1);
            this.group_powell.Controls.Add(this.text_d2_x1);
            this.group_powell.Controls.Add(this.label_d2_x0);
            this.group_powell.Controls.Add(this.label_d1_x1);
            this.group_powell.Controls.Add(this.label_d1_x0);
            this.group_powell.Controls.Add(this.label_e);
            this.group_powell.Controls.Add(this.label_x1);
            this.group_powell.Controls.Add(this.label_x0);
            this.group_powell.Controls.Add(this.text_d2_x0);
            this.group_powell.Controls.Add(this.text_d1_x1);
            this.group_powell.Controls.Add(this.text_d1_x0);
            this.group_powell.Controls.Add(this.text_e);
            this.group_powell.Controls.Add(this.text_x1);
            this.group_powell.Controls.Add(this.text_x0);
            this.group_powell.Location = new System.Drawing.Point(6, 54);
            this.group_powell.Name = "group_powell";
            this.group_powell.Size = new System.Drawing.Size(202, 329);
            this.group_powell.TabIndex = 44;
            this.group_powell.TabStop = false;
            this.group_powell.Text = "сопряж. направл.";
            // 
            // text_powell_output
            // 
            this.text_powell_output.Location = new System.Drawing.Point(13, 299);
            this.text_powell_output.Name = "text_powell_output";
            this.text_powell_output.ReadOnly = true;
            this.text_powell_output.Size = new System.Drawing.Size(180, 20);
            this.text_powell_output.TabIndex = 61;
            this.text_powell_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_powell_output
            // 
            this.label_powell_output.Location = new System.Drawing.Point(13, 276);
            this.label_powell_output.Name = "label_powell_output";
            this.label_powell_output.Size = new System.Drawing.Size(180, 20);
            this.label_powell_output.TabIndex = 60;
            this.label_powell_output.Text = "результат работы";
            this.label_powell_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_powell_time
            // 
            this.text_powell_time.Location = new System.Drawing.Point(13, 253);
            this.text_powell_time.Name = "text_powell_time";
            this.text_powell_time.ReadOnly = true;
            this.text_powell_time.Size = new System.Drawing.Size(180, 20);
            this.text_powell_time.TabIndex = 59;
            this.text_powell_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_powell_time
            // 
            this.label_powell_time.Location = new System.Drawing.Point(13, 230);
            this.label_powell_time.Name = "label_powell_time";
            this.label_powell_time.Size = new System.Drawing.Size(180, 20);
            this.label_powell_time.TabIndex = 58;
            this.label_powell_time.Text = "время подсчета";
            this.label_powell_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calculate_powell
            // 
            this.button_calculate_powell.Location = new System.Drawing.Point(13, 198);
            this.button_calculate_powell.Name = "button_calculate_powell";
            this.button_calculate_powell.Size = new System.Drawing.Size(180, 29);
            this.button_calculate_powell.TabIndex = 57;
            this.button_calculate_powell.Text = "вычислить";
            this.button_calculate_powell.UseVisualStyleBackColor = true;
            this.button_calculate_powell.Click += new System.EventHandler(this.button_calculate_powell_Click);
            // 
            // label_d2_x1
            // 
            this.label_d2_x1.Location = new System.Drawing.Point(10, 172);
            this.label_d2_x1.Name = "label_d2_x1";
            this.label_d2_x1.Size = new System.Drawing.Size(129, 20);
            this.label_d2_x1.TabIndex = 55;
            this.label_d2_x1.Text = "направление d2 (x2)";
            this.label_d2_x1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_d2_x1
            // 
            this.text_d2_x1.Location = new System.Drawing.Point(145, 172);
            this.text_d2_x1.Name = "text_d2_x1";
            this.text_d2_x1.Size = new System.Drawing.Size(48, 20);
            this.text_d2_x1.TabIndex = 49;
            this.text_d2_x1.Text = "1";
            // 
            // label_d2_x0
            // 
            this.label_d2_x0.Location = new System.Drawing.Point(10, 146);
            this.label_d2_x0.Name = "label_d2_x0";
            this.label_d2_x0.Size = new System.Drawing.Size(129, 20);
            this.label_d2_x0.TabIndex = 54;
            this.label_d2_x0.Text = "направление d2 (x1)";
            this.label_d2_x0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_d1_x1
            // 
            this.label_d1_x1.Location = new System.Drawing.Point(10, 120);
            this.label_d1_x1.Name = "label_d1_x1";
            this.label_d1_x1.Size = new System.Drawing.Size(129, 20);
            this.label_d1_x1.TabIndex = 53;
            this.label_d1_x1.Text = "направление d1 (x2)";
            this.label_d1_x1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_d1_x0
            // 
            this.label_d1_x0.Location = new System.Drawing.Point(10, 94);
            this.label_d1_x0.Name = "label_d1_x0";
            this.label_d1_x0.Size = new System.Drawing.Size(129, 20);
            this.label_d1_x0.TabIndex = 52;
            this.label_d1_x0.Text = "направление d1 (x1)";
            this.label_d1_x0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_e
            // 
            this.label_e.Location = new System.Drawing.Point(10, 68);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(129, 20);
            this.label_e.TabIndex = 51;
            this.label_e.Text = "интервал неопр. e";
            this.label_e.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_x1
            // 
            this.label_x1.Location = new System.Drawing.Point(10, 42);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(129, 20);
            this.label_x1.TabIndex = 50;
            this.label_x1.Text = "начальная точка (x2)";
            this.label_x1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_x0
            // 
            this.label_x0.Location = new System.Drawing.Point(10, 16);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(129, 20);
            this.label_x0.TabIndex = 48;
            this.label_x0.Text = "начальная точка (x1)";
            this.label_x0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_d2_x0
            // 
            this.text_d2_x0.Location = new System.Drawing.Point(145, 146);
            this.text_d2_x0.Name = "text_d2_x0";
            this.text_d2_x0.Size = new System.Drawing.Size(48, 20);
            this.text_d2_x0.TabIndex = 47;
            this.text_d2_x0.Text = "0";
            // 
            // text_d1_x1
            // 
            this.text_d1_x1.Location = new System.Drawing.Point(145, 120);
            this.text_d1_x1.Name = "text_d1_x1";
            this.text_d1_x1.Size = new System.Drawing.Size(48, 20);
            this.text_d1_x1.TabIndex = 46;
            this.text_d1_x1.Text = "0";
            // 
            // text_d1_x0
            // 
            this.text_d1_x0.Location = new System.Drawing.Point(145, 94);
            this.text_d1_x0.Name = "text_d1_x0";
            this.text_d1_x0.Size = new System.Drawing.Size(48, 20);
            this.text_d1_x0.TabIndex = 45;
            this.text_d1_x0.Text = "1";
            // 
            // text_e
            // 
            this.text_e.Location = new System.Drawing.Point(145, 68);
            this.text_e.Name = "text_e";
            this.text_e.Size = new System.Drawing.Size(48, 20);
            this.text_e.TabIndex = 44;
            this.text_e.Text = "0.1";
            // 
            // text_x1
            // 
            this.text_x1.Location = new System.Drawing.Point(145, 42);
            this.text_x1.Name = "text_x1";
            this.text_x1.Size = new System.Drawing.Size(48, 20);
            this.text_x1.TabIndex = 43;
            this.text_x1.Text = "9";
            // 
            // text_x0
            // 
            this.text_x0.Location = new System.Drawing.Point(145, 16);
            this.text_x0.Name = "text_x0";
            this.text_x0.Size = new System.Drawing.Size(48, 20);
            this.text_x0.TabIndex = 42;
            this.text_x0.Text = "8";
            // 
            // group_koshi
            // 
            this.group_koshi.Controls.Add(this.text_koshi_output);
            this.group_koshi.Controls.Add(this.label_koshi_output);
            this.group_koshi.Controls.Add(this.text_koshi_time);
            this.group_koshi.Controls.Add(this.label_koshi_time);
            this.group_koshi.Controls.Add(this.button_calculate_koshi);
            this.group_koshi.Controls.Add(this.label3);
            this.group_koshi.Controls.Add(this.textBox3);
            this.group_koshi.Controls.Add(this.label4);
            this.group_koshi.Controls.Add(this.label5);
            this.group_koshi.Controls.Add(this.label6);
            this.group_koshi.Controls.Add(this.label7);
            this.group_koshi.Controls.Add(this.label8);
            this.group_koshi.Controls.Add(this.label9);
            this.group_koshi.Controls.Add(this.textBox4);
            this.group_koshi.Controls.Add(this.textBox5);
            this.group_koshi.Controls.Add(this.textBox6);
            this.group_koshi.Controls.Add(this.textBox7);
            this.group_koshi.Controls.Add(this.textBox8);
            this.group_koshi.Controls.Add(this.textBox9);
            this.group_koshi.Location = new System.Drawing.Point(214, 54);
            this.group_koshi.Name = "group_koshi";
            this.group_koshi.Size = new System.Drawing.Size(202, 329);
            this.group_koshi.TabIndex = 62;
            this.group_koshi.TabStop = false;
            this.group_koshi.Text = "Коши";
            // 
            // text_koshi_output
            // 
            this.text_koshi_output.Location = new System.Drawing.Point(13, 299);
            this.text_koshi_output.Name = "text_koshi_output";
            this.text_koshi_output.ReadOnly = true;
            this.text_koshi_output.Size = new System.Drawing.Size(180, 20);
            this.text_koshi_output.TabIndex = 61;
            this.text_koshi_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_koshi_output
            // 
            this.label_koshi_output.Location = new System.Drawing.Point(13, 276);
            this.label_koshi_output.Name = "label_koshi_output";
            this.label_koshi_output.Size = new System.Drawing.Size(180, 20);
            this.label_koshi_output.TabIndex = 60;
            this.label_koshi_output.Text = "результат работы";
            this.label_koshi_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_koshi_time
            // 
            this.text_koshi_time.Location = new System.Drawing.Point(13, 253);
            this.text_koshi_time.Name = "text_koshi_time";
            this.text_koshi_time.ReadOnly = true;
            this.text_koshi_time.Size = new System.Drawing.Size(180, 20);
            this.text_koshi_time.TabIndex = 59;
            this.text_koshi_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_koshi_time
            // 
            this.label_koshi_time.Location = new System.Drawing.Point(13, 230);
            this.label_koshi_time.Name = "label_koshi_time";
            this.label_koshi_time.Size = new System.Drawing.Size(180, 20);
            this.label_koshi_time.TabIndex = 58;
            this.label_koshi_time.Text = "время подсчета";
            this.label_koshi_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calculate_koshi
            // 
            this.button_calculate_koshi.Location = new System.Drawing.Point(13, 198);
            this.button_calculate_koshi.Name = "button_calculate_koshi";
            this.button_calculate_koshi.Size = new System.Drawing.Size(180, 29);
            this.button_calculate_koshi.TabIndex = 57;
            this.button_calculate_koshi.Text = "вычислить";
            this.button_calculate_koshi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "направление d2 (x2)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 49;
            this.textBox3.Text = "1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "направление d2 (x1)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "направление d1 (x2)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "направление d1 (x1)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "интервал неопр. e";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "начальная точка (x2)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "начальная точка (x1)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 20);
            this.textBox4.TabIndex = 47;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(145, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 20);
            this.textBox5.TabIndex = 46;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 94);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(48, 20);
            this.textBox6.TabIndex = 45;
            this.textBox6.Text = "1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(145, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(48, 20);
            this.textBox7.TabIndex = 44;
            this.textBox7.Text = "0.1";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(145, 42);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(48, 20);
            this.textBox8.TabIndex = 43;
            this.textBox8.Text = "9";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(145, 16);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(48, 20);
            this.textBox9.TabIndex = 42;
            this.textBox9.Text = "8";
            // 
            // form_optimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 389);
            this.Controls.Add(this.group_koshi);
            this.Controls.Add(this.group_powell);
            this.Controls.Add(this.text_function);
            this.Controls.Add(this.label_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_optimization";
            this.Text = "optimization";
            this.group_powell.ResumeLayout(false);
            this.group_powell.PerformLayout();
            this.group_koshi.ResumeLayout(false);
            this.group_koshi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_function;
        private System.Windows.Forms.Label label_function;
        private System.Windows.Forms.GroupBox group_powell;
        private System.Windows.Forms.TextBox text_powell_output;
        private System.Windows.Forms.Label label_powell_output;
        private System.Windows.Forms.TextBox text_powell_time;
        private System.Windows.Forms.Label label_powell_time;
        private System.Windows.Forms.Button button_calculate_powell;
        private System.Windows.Forms.Label label_d2_x1;
        private System.Windows.Forms.TextBox text_d2_x1;
        private System.Windows.Forms.Label label_d2_x0;
        private System.Windows.Forms.Label label_d1_x1;
        private System.Windows.Forms.Label label_d1_x0;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.TextBox text_d2_x0;
        private System.Windows.Forms.TextBox text_d1_x1;
        private System.Windows.Forms.TextBox text_d1_x0;
        private System.Windows.Forms.TextBox text_e;
        private System.Windows.Forms.TextBox text_x1;
        private System.Windows.Forms.TextBox text_x0;
        private System.Windows.Forms.GroupBox group_koshi;
        private System.Windows.Forms.TextBox text_koshi_output;
        private System.Windows.Forms.Label label_koshi_output;
        private System.Windows.Forms.TextBox text_koshi_time;
        private System.Windows.Forms.Label label_koshi_time;
        private System.Windows.Forms.Button button_calculate_koshi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}

