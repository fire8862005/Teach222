﻿namespace NewTeacher.Controls
{
    partial class StudentScreen
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picScreen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labName = new System.Windows.Forms.Label();
            this.labCallShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picScreen
            // 
            this.picScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScreen.Location = new System.Drawing.Point(0, 0);
            this.picScreen.Margin = new System.Windows.Forms.Padding(0);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(304, 179);
            this.picScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScreen.TabIndex = 0;
            this.picScreen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 41);
            this.panel1.TabIndex = 1;
            // 
            // labName
            // 
            this.labName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.ForeColor = System.Drawing.Color.Green;
            this.labName.Location = new System.Drawing.Point(0, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(304, 41);
            this.labName.TabIndex = 0;
            this.labName.Text = "label1";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labCallShow
            // 
            this.labCallShow.AutoSize = true;
            this.labCallShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCallShow.ForeColor = System.Drawing.Color.MediumBlue;
            this.labCallShow.Location = new System.Drawing.Point(65, 82);
            this.labCallShow.Name = "labCallShow";
            this.labCallShow.Size = new System.Drawing.Size(154, 21);
            this.labCallShow.TabIndex = 2;
            this.labCallShow.Text = "已呼叫该学生演示";
            this.labCallShow.Visible = false;
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labCallShow);
            this.Controls.Add(this.picScreen);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "StudentScreen";
            this.Size = new System.Drawing.Size(304, 220);
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCallShow;
    }
}
