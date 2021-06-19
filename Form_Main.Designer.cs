using System;
using System.Windows.Forms;

namespace mycontracts
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstrip_add = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_search = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_add,
            this.toolStrip_edit,
            this.toolStrip_delete,
            this.toolStrip_search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
          
            // 
            // toolstrip_add
            // 
            this.toolstrip_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip_add.Name = "toolstrip_add";
            this.toolstrip_add.Size = new System.Drawing.Size(43, 24);
            this.toolstrip_add.Text = "添加";
            this.toolstrip_add.Click += new System.EventHandler(this.toolstrip_add_Click);
            // 
            // toolStrip_edit
            // 
            this.toolStrip_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_edit.Name = "toolStrip_edit";
            this.toolStrip_edit.Size = new System.Drawing.Size(43, 24);
            this.toolStrip_edit.Text = "编辑";
            this.toolStrip_edit.Click += new System.EventHandler(this.toolStrip_edit_Click);
            // 
            // toolStrip_delete
            // 
            this.toolStrip_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_delete.Name = "toolStrip_delete";
            this.toolStrip_delete.Size = new System.Drawing.Size(43, 24);
            this.toolStrip_delete.Text = "删除";
            this.toolStrip_delete.Click += new System.EventHandler(this.toolStrip_delete_Click);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.Size = new System.Drawing.Size(43, 24);
            this.toolStrip_search.Text = "查找";
            this.toolStrip_search.Click += new System.EventHandler(this.toolStrip_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 512);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.Text = "校外人员管理信息系统";
            
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void toolStrip_search_Click(object sender, EventArgs e)
        {
            Form_search formsearch = new Form_search();
            formsearch.ShowDialog();
        }

        private void toolStrip_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定要删除此访客的信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0]
                        .Value.ToString());
                    if (VisitorinfoBLL.DeleteVisitorInfo(selectrow))
                        MessageBox.Show("删除成功！");
                    else
                        MessageBox.Show("删除失败，请检查是否选中访客信息！");
                    initcontracts();
                }
            }
            else
                MessageBox.Show("请选中后再点击删除按钮");
        }

        private void toolStrip_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]
                    .Cells[0].Value.ToString());
                Form_edit formedit = new Form_edit();
                formedit.visitorId_edit = selectrow;
                formedit.ShowDialog();
                initcontracts();
            }
            else
                MessageBox.Show("请选中一行后再点击编辑按钮！");
        }

        private void toolstrip_add_Click(object sender, EventArgs e)
        {
            Form_add formadd = new Form_add();
            formadd.ShowDialog();
            initcontracts();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstrip_add;
        private System.Windows.Forms.ToolStripButton toolStrip_edit;
        private System.Windows.Forms.ToolStripButton toolStrip_delete;
        private System.Windows.Forms.ToolStripButton toolStrip_search;
        private DataGridView dataGridView1;
    }
}

