using SmileWei;
using SmileWei.EmbeddedApp;

namespace WeChartNotify
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSetWinodwIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Op = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_OCMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Answer = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetWinodwIn,
            this.ToolStripMenuItem_Set,
            this.ToolStripMenuItem_Op,
            this.toolStripMenuItem_OCMonitor,
            this.toolStripMenuItem_Answer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 114);
            // 
            // toolStripMenuItemSetWinodwIn
            // 
            this.toolStripMenuItemSetWinodwIn.Name = "toolStripMenuItemSetWinodwIn";
            this.toolStripMenuItemSetWinodwIn.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItemSetWinodwIn.Text = "嵌入窗口";
            this.toolStripMenuItemSetWinodwIn.Click += new System.EventHandler(this.ToolStripMenuItemSetWinodwIn_Click);
            // 
            // ToolStripMenuItem_Set
            // 
            this.ToolStripMenuItem_Set.Name = "ToolStripMenuItem_Set";
            this.ToolStripMenuItem_Set.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItem_Set.Text = "设置";
            this.ToolStripMenuItem_Set.Click += new System.EventHandler(this.ToolStripMenuItem_Set_Click);
            // 
            // ToolStripMenuItem_Op
            // 
            this.ToolStripMenuItem_Op.Name = "ToolStripMenuItem_Op";
            this.ToolStripMenuItem_Op.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItem_Op.Text = "设置透明";
            this.ToolStripMenuItem_Op.Click += new System.EventHandler(this.ToolStripMenuItem_Op_Click);
            // 
            // toolStripMenuItem_OCMonitor
            // 
            this.toolStripMenuItem_OCMonitor.Checked = true;
            this.toolStripMenuItem_OCMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_OCMonitor.Image = global::WeChartNotify.Properties.Resources._13412341;
            this.toolStripMenuItem_OCMonitor.Name = "toolStripMenuItem_OCMonitor";
            this.toolStripMenuItem_OCMonitor.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem_OCMonitor.Text = "当前是否在传送(开启/关闭)";
            this.toolStripMenuItem_OCMonitor.Click += new System.EventHandler(this.ToolStripMenuItem_OCMonitor_Click);
            // 
            // toolStripMenuItem_Answer
            // 
            this.toolStripMenuItem_Answer.Checked = true;
            this.toolStripMenuItem_Answer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem_Answer.Image = global::WeChartNotify.Properties.Resources._13412341;
            this.toolStripMenuItem_Answer.Name = "toolStripMenuItem_Answer";
            this.toolStripMenuItem_Answer.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem_Answer.Text = "开启/关闭人机对话";
            this.toolStripMenuItem_Answer.Click += new System.EventHandler(this.ToolStripMenuItem_Answer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Event);
            this.timer1.Enabled = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form2";
            this.Text = "Wechat-Hook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            this.Move += new System.EventHandler(this.Move_Event);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppContainer appBox = new AppContainer();
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Set;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Op;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetWinodwIn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_OCMonitor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Answer;
        private System.Windows.Forms.Timer timer1;
    }
}