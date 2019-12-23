namespace EngineWindowsApp
{
    partial class FormExcel2Pt
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
            this.FeatureBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcelBox = new System.Windows.Forms.ComboBox();
            this.btn_createPt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_browserExcel = new System.Windows.Forms.Button();
            this.btn_browserFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeatureBox
            // 
            this.FeatureBox.FormattingEnabled = true;
            this.FeatureBox.Location = new System.Drawing.Point(136, 142);
            this.FeatureBox.Name = "FeatureBox";
            this.FeatureBox.Size = new System.Drawing.Size(142, 20);
            this.FeatureBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "矢量数据路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择EXCEL数据：";
            // 
            // ExcelBox
            // 
            this.ExcelBox.FormattingEnabled = true;
            this.ExcelBox.Location = new System.Drawing.Point(136, 76);
            this.ExcelBox.Name = "ExcelBox";
            this.ExcelBox.Size = new System.Drawing.Size(142, 20);
            this.ExcelBox.TabIndex = 3;
            // 
            // btn_createPt
            // 
            this.btn_createPt.Location = new System.Drawing.Point(54, 230);
            this.btn_createPt.Name = "btn_createPt";
            this.btn_createPt.Size = new System.Drawing.Size(75, 23);
            this.btn_createPt.TabIndex = 5;
            this.btn_createPt.Text = "确定";
            this.btn_createPt.UseVisualStyleBackColor = true;
            this.btn_createPt.Click += new System.EventHandler(this.btn_createPt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_browserExcel
            // 
            this.btn_browserExcel.Location = new System.Drawing.Point(284, 74);
            this.btn_browserExcel.Name = "btn_browserExcel";
            this.btn_browserExcel.Size = new System.Drawing.Size(40, 22);
            this.btn_browserExcel.TabIndex = 7;
            this.btn_browserExcel.Text = "...";
            this.btn_browserExcel.UseVisualStyleBackColor = true;
            this.btn_browserExcel.Click += new System.EventHandler(this.btn_browserExcel_Click);
            // 
            // btn_browserFeature
            // 
            this.btn_browserFeature.Location = new System.Drawing.Point(284, 140);
            this.btn_browserFeature.Name = "btn_browserFeature";
            this.btn_browserFeature.Size = new System.Drawing.Size(40, 23);
            this.btn_browserFeature.TabIndex = 8;
            this.btn_browserFeature.Text = "...";
            this.btn_browserFeature.UseVisualStyleBackColor = true;
            this.btn_browserFeature.Click += new System.EventHandler(this.btn_browserFeature_Click);
            // 
            // FormExcel2Pt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 299);
            this.Controls.Add(this.btn_browserFeature);
            this.Controls.Add(this.btn_browserExcel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_createPt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExcelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FeatureBox);
            this.Name = "FormExcel2Pt";
            this.Text = "生成点数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FeatureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ExcelBox;
        private System.Windows.Forms.Button btn_createPt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_browserExcel;
        private System.Windows.Forms.Button btn_browserFeature;
    }
}