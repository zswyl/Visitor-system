namespace mycontracts
{
    partial class Form_search
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
            this.txt_searchtxt = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searchtxt
            // 
            this.txt_searchtxt.Location = new System.Drawing.Point(421, 46);
            this.txt_searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_searchtxt.Name = "txt_searchtxt";
            this.txt_searchtxt.Size = new System.Drawing.Size(159, 25);
            this.txt_searchtxt.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(676, 28);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 59);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(824, 28);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(93, 59);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "关闭";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "访客编号",
            "访客姓名"});
            this.cb_search.Location = new System.Drawing.Point(168, 46);
            this.cb_search.Margin = new System.Windows.Forms.Padding(4);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(191, 23);
            this.cb_search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "查找项目";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 364);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchtxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询访客信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchtxt;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}