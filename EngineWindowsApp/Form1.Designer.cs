namespace EngineWindowsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_addData = new System.Windows.Forms.ToolStripButton();
            this.btn_table = new System.Windows.Forms.ToolStripButton();
            this.btn_addAttribute = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_addField = new System.Windows.Forms.ToolStripButton();
            this.btn_calField = new System.Windows.Forms.ToolStripButton();
            this.btn_traversal = new System.Windows.Forms.ToolStripButton();
            this.btn_addXYdata = new System.Windows.Forms.ToolStripButton();
            this.btn_deleteField = new System.Windows.Forms.ToolStripButton();
            this.btn_modifyAttribute = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.btn_DeleteFeature = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文档ToolStripMenuItem,
            this.保存文档ToolStripMenuItem,
            this.数据添加ToolStripMenuItem,
            this.退出软件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文档ToolStripMenuItem
            // 
            this.打开文档ToolStripMenuItem.Name = "打开文档ToolStripMenuItem";
            this.打开文档ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开文档ToolStripMenuItem.Text = "打开文档";
            // 
            // 保存文档ToolStripMenuItem
            // 
            this.保存文档ToolStripMenuItem.Name = "保存文档ToolStripMenuItem";
            this.保存文档ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存文档ToolStripMenuItem.Text = "保存文档";
            // 
            // 数据添加ToolStripMenuItem
            // 
            this.数据添加ToolStripMenuItem.Name = "数据添加ToolStripMenuItem";
            this.数据添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.数据添加ToolStripMenuItem.Text = "数据添加";
            // 
            // 退出软件ToolStripMenuItem
            // 
            this.退出软件ToolStripMenuItem.Name = "退出软件ToolStripMenuItem";
            this.退出软件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出软件ToolStripMenuItem.Text = "退出软件";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_addData,
            this.btn_table,
            this.btn_addAttribute,
            this.btn_DeleteFeature});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_addData
            // 
            this.btn_addData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_addData.Image = ((System.Drawing.Image)(resources.GetObject("btn_addData.Image")));
            this.btn_addData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(60, 22);
            this.btn_addData.Text = "添加数据";
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // btn_table
            // 
            this.btn_table.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_table.Image = ((System.Drawing.Image)(resources.GetObject("btn_table.Image")));
            this.btn_table.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_table.Name = "btn_table";
            this.btn_table.Size = new System.Drawing.Size(72, 22);
            this.btn_table.Text = "预览属性表";
            this.btn_table.Click += new System.EventHandler(this.btn_table_Click);
            // 
            // btn_addAttribute
            // 
            this.btn_addAttribute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_addAttribute.Image = ((System.Drawing.Image)(resources.GetObject("btn_addAttribute.Image")));
            this.btn_addAttribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addAttribute.Name = "btn_addAttribute";
            this.btn_addAttribute.Size = new System.Drawing.Size(101, 22);
            this.btn_addAttribute.Text = "Excel连接属性表";
            this.btn_addAttribute.Click += new System.EventHandler(this.btn_addAttribute_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_addField,
            this.btn_calField,
            this.btn_traversal,
            this.btn_addXYdata,
            this.btn_deleteField,
            this.btn_modifyAttribute});
            this.toolStrip2.Location = new System.Drawing.Point(0, 50);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_addField
            // 
            this.btn_addField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_addField.Image = ((System.Drawing.Image)(resources.GetObject("btn_addField.Image")));
            this.btn_addField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addField.Name = "btn_addField";
            this.btn_addField.Size = new System.Drawing.Size(60, 22);
            this.btn_addField.Text = "添加字段";
            this.btn_addField.Click += new System.EventHandler(this.btn_addField_Click);
            // 
            // btn_calField
            // 
            this.btn_calField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_calField.Image = ((System.Drawing.Image)(resources.GetObject("btn_calField.Image")));
            this.btn_calField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_calField.Name = "btn_calField";
            this.btn_calField.Size = new System.Drawing.Size(60, 22);
            this.btn_calField.Text = "字段计算";
            this.btn_calField.Click += new System.EventHandler(this.btn_calField_Click);
            // 
            // btn_traversal
            // 
            this.btn_traversal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_traversal.Image = ((System.Drawing.Image)(resources.GetObject("btn_traversal.Image")));
            this.btn_traversal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_traversal.Name = "btn_traversal";
            this.btn_traversal.Size = new System.Drawing.Size(60, 22);
            this.btn_traversal.Text = "遍历字段";
            this.btn_traversal.Click += new System.EventHandler(this.btn_traversal_Click);
            // 
            // btn_addXYdata
            // 
            this.btn_addXYdata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_addXYdata.Image = ((System.Drawing.Image)(resources.GetObject("btn_addXYdata.Image")));
            this.btn_addXYdata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addXYdata.Name = "btn_addXYdata";
            this.btn_addXYdata.Size = new System.Drawing.Size(101, 22);
            this.btn_addXYdata.Text = "Excel生产点要素";
            this.btn_addXYdata.Click += new System.EventHandler(this.btn_addXYdata_Click);
            // 
            // btn_deleteField
            // 
            this.btn_deleteField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_deleteField.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteField.Image")));
            this.btn_deleteField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_deleteField.Name = "btn_deleteField";
            this.btn_deleteField.Size = new System.Drawing.Size(84, 22);
            this.btn_deleteField.Text = "批量删除字段";
            this.btn_deleteField.Click += new System.EventHandler(this.btn_deleteField_Click);
            // 
            // btn_modifyAttribute
            // 
            this.btn_modifyAttribute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_modifyAttribute.Image = ((System.Drawing.Image)(resources.GetObject("btn_modifyAttribute.Image")));
            this.btn_modifyAttribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modifyAttribute.Name = "btn_modifyAttribute";
            this.btn_modifyAttribute.Size = new System.Drawing.Size(60, 22);
            this.btn_modifyAttribute.Text = "修正字段";
            this.btn_modifyAttribute.Click += new System.EventHandler(this.btn_modifyAttribute_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "read";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 502);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 4;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(254, 502);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(770, 502);
            this.axMapControl1.TabIndex = 0;
            // 
            // btn_DeleteFeature
            // 
            this.btn_DeleteFeature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_DeleteFeature.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteFeature.Image")));
            this.btn_DeleteFeature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteFeature.Name = "btn_DeleteFeature";
            this.btn_DeleteFeature.Size = new System.Drawing.Size(101, 22);
            this.btn_DeleteFeature.Text = "批量删除feature";
            this.btn_DeleteFeature.Click += new System.EventHandler(this.btn_DeleteFeature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ArcGIS功能汇总";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.ToolStripButton btn_addData;
        private System.Windows.Forms.ToolStripButton btn_addField;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btn_calField;
        private System.Windows.Forms.ToolStripButton btn_traversal;
        private System.Windows.Forms.ToolStripButton btn_table;
        private System.Windows.Forms.ToolStripButton btn_addXYdata;
        private System.Windows.Forms.ToolStripButton btn_addAttribute;
        private System.Windows.Forms.ToolStripButton btn_deleteField;
        private System.Windows.Forms.ToolStripButton btn_modifyAttribute;
        private System.Windows.Forms.ToolStripButton btn_DeleteFeature;
        //测试Commit 20191018 23：09

    }
}

