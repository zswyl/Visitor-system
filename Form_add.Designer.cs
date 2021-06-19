namespace mycontracts
{
    partial class Form_add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_visitCase = new System.Windows.Forms.TextBox();
            this.dt_visitTime = new System.Windows.Forms.DateTimePicker();
            this.dt_leaveTime = new System.Windows.Forms.DateTimePicker();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.rb_woman = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加访客信息";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "访客姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "访客性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "手机号码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "来访日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "来访原因";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "离开日期";
         
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(146, 77);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(246, 21);
            this.txt_name.TabIndex = 10;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(145, 195);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(247, 21);
            this.txt_phone.TabIndex = 11;
        
            // 
            // txt_visitCase
            // 
            this.txt_visitCase.Location = new System.Drawing.Point(148, 313);
            this.txt_visitCase.Name = "txt_visitCase";
            this.txt_visitCase.Size = new System.Drawing.Size(244, 21);
            this.txt_visitCase.TabIndex = 14;
            // 
            // dt_visitTime
            // 
            this.dt_visitTime.CustomFormat = "yyyy/MM/dd HH:MM";
            this.dt_visitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_visitTime.Location = new System.Drawing.Point(148, 261);
            this.dt_visitTime.Name = "dt_visitTime";
            this.dt_visitTime.Size = new System.Drawing.Size(247, 21);
            this.dt_visitTime.TabIndex = 22;
            // 
            // dt_leaveTime
            // 
            this.dt_leaveTime.CustomFormat = "yyyy/MM/dd HH:MM";
            this.dt_leaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_leaveTime.Location = new System.Drawing.Point(148, 372);
            this.dt_leaveTime.Name = "dt_leaveTime";
            this.dt_leaveTime.Size = new System.Drawing.Size(247, 21);
            this.dt_leaveTime.TabIndex = 23;
          
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Location = new System.Drawing.Point(181, 138);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(35, 16);
            this.rb_man.TabIndex = 20;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "男";
            this.rb_man.UseVisualStyleBackColor = true;
            // 
            // rb_woman
            // 
            this.rb_woman.AutoSize = true;
            this.rb_woman.Location = new System.Drawing.Point(309, 136);
            this.rb_woman.Name = "rb_woman";
            this.rb_woman.Size = new System.Drawing.Size(35, 16);
            this.rb_woman.TabIndex = 21;
            this.rb_woman.TabStop = true;
            this.rb_woman.Text = "女";
            this.rb_woman.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(464, 63);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 43);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(464, 121);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(78, 43);
            this.bt_close.TabIndex = 19;
            this.bt_close.Text = "关闭";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(588, 417);
            this.Controls.Add(this.dt_visitTime);
            this.Controls.Add(this.rb_woman);
            this.Controls.Add(this.rb_man);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_visitCase);
            this.Controls.Add(this.dt_leaveTime);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加访客信息";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_visitCase;
        private System.Windows.Forms.DateTimePicker dt_visitTime;
        private System.Windows.Forms.DateTimePicker dt_leaveTime;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.RadioButton rb_woman;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button bt_close;
    }
}