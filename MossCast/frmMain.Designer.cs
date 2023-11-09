﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MossCast
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmMain : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGenAll = new System.Windows.Forms.Button();
            this.btnKillVLC = new System.Windows.Forms.Button();
            this.btnMoveResize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAutocompleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditAutocompleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeVLCWindowSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenAppData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCombineNamesPronouns = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditStreamlinkConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResetStreamlinkPath = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.streamerGroupBox8 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox7 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox6 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox5 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox4 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox3 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox2 = new MossCast.StreamerGroupBox();
            this.streamerGroupBox1 = new MossCast.StreamerGroupBox();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenAll
            // 
            this.btnGenAll.Location = new System.Drawing.Point(526, 75);
            this.btnGenAll.Name = "btnGenAll";
            this.btnGenAll.Size = new System.Drawing.Size(101, 29);
            this.btnGenAll.TabIndex = 17;
            this.btnGenAll.Text = "Launch All";
            this.btnGenAll.UseVisualStyleBackColor = true;
            this.btnGenAll.Click += new System.EventHandler(this.btnGenAll_Click);
            // 
            // btnKillVLC
            // 
            this.btnKillVLC.Location = new System.Drawing.Point(526, 109);
            this.btnKillVLC.Name = "btnKillVLC";
            this.btnKillVLC.Size = new System.Drawing.Size(101, 29);
            this.btnKillVLC.TabIndex = 16;
            this.btnKillVLC.Text = "Close All";
            this.btnKillVLC.UseVisualStyleBackColor = true;
            this.btnKillVLC.Click += new System.EventHandler(this.vlcKill_Click);
            // 
            // btnMoveResize
            // 
            this.btnMoveResize.Location = new System.Drawing.Point(526, 40);
            this.btnMoveResize.Name = "btnMoveResize";
            this.btnMoveResize.Size = new System.Drawing.Size(101, 29);
            this.btnMoveResize.TabIndex = 15;
            this.btnMoveResize.Text = "Move and Resize";
            this.btnMoveResize.UseVisualStyleBackColor = true;
            this.btnMoveResize.Click += new System.EventHandler(this.moveResize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.StreamlinkToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(470, 24);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(470, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 18;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectAutocompleteFile,
            this.tsmiEditAutocompleteFile,
            this.tsmiChangeVLCWindowSize,
            this.tsmiOpenAppData,
            this.tsmiCombineNamesPronouns});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // tsmiSelectAutocompleteFile
            // 
            this.tsmiSelectAutocompleteFile.Name = "tsmiSelectAutocompleteFile";
            this.tsmiSelectAutocompleteFile.Size = new System.Drawing.Size(240, 22);
            this.tsmiSelectAutocompleteFile.Text = "Select Streamerlist File";
            this.tsmiSelectAutocompleteFile.Click += new System.EventHandler(this.selectAutocompleteFile_Click);
            // 
            // tsmiEditAutocompleteFile
            // 
            this.tsmiEditAutocompleteFile.Name = "tsmiEditAutocompleteFile";
            this.tsmiEditAutocompleteFile.Size = new System.Drawing.Size(240, 22);
            this.tsmiEditAutocompleteFile.Text = "Edit Streamerlist File";
            this.tsmiEditAutocompleteFile.Click += new System.EventHandler(this.tsmiEditAutocompleteFile_Click);
            // 
            // tsmiChangeVLCWindowSize
            // 
            this.tsmiChangeVLCWindowSize.Name = "tsmiChangeVLCWindowSize";
            this.tsmiChangeVLCWindowSize.Size = new System.Drawing.Size(240, 22);
            this.tsmiChangeVLCWindowSize.Text = "Change window size...";
            this.tsmiChangeVLCWindowSize.Click += new System.EventHandler(this.tsmiChangeVLCWindowSize_Click);
            // 
            // tsmiOpenAppData
            // 
            this.tsmiOpenAppData.Name = "tsmiOpenAppData";
            this.tsmiOpenAppData.Size = new System.Drawing.Size(240, 22);
            this.tsmiOpenAppData.Text = "Open AppData folder...";
            this.tsmiOpenAppData.Click += new System.EventHandler(this.tsmiOpenAppData_Click);
            // 
            // tsmiCombineNamesPronouns
            // 
            this.tsmiCombineNamesPronouns.CheckOnClick = true;
            this.tsmiCombineNamesPronouns.Name = "tsmiCombineNamesPronouns";
            this.tsmiCombineNamesPronouns.Size = new System.Drawing.Size(240, 22);
            this.tsmiCombineNamesPronouns.Text = "Combine Names and Pronouns";
            this.tsmiCombineNamesPronouns.Click += new System.EventHandler(this.tsmiFileConfigure_Click);
            // 
            // StreamlinkToolStripMenuItem
            // 
            this.StreamlinkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStreamlinkConfig,
            this.tsmiResetStreamlinkPath});
            this.StreamlinkToolStripMenuItem.Name = "StreamlinkToolStripMenuItem";
            this.StreamlinkToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.StreamlinkToolStripMenuItem.Text = "Streamlink";
            // 
            // tsmiEditStreamlinkConfig
            // 
            this.tsmiEditStreamlinkConfig.Name = "tsmiEditStreamlinkConfig";
            this.tsmiEditStreamlinkConfig.Size = new System.Drawing.Size(159, 22);
            this.tsmiEditStreamlinkConfig.Text = "Edit config file...";
            this.tsmiEditStreamlinkConfig.Click += new System.EventHandler(this.tsmiEditStreamlinkConfig_Click);
            // 
            // tsmiResetStreamlinkPath
            // 
            this.tsmiResetStreamlinkPath.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiResetStreamlinkPath.Name = "tsmiResetStreamlinkPath";
            this.tsmiResetStreamlinkPath.Size = new System.Drawing.Size(159, 22);
            this.tsmiResetStreamlinkPath.Text = "Reset path";
            this.tsmiResetStreamlinkPath.Click += new System.EventHandler(this.ResetStreamlinkPathToolStripMenuItem_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(14, 22);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(612, 8);
            this.ProgressBar1.TabIndex = 19;
            this.ProgressBar1.Visible = false;
            // 
            // statusLabel1
            // 
            this.statusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 609);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip1.Size = new System.Drawing.Size(639, 22);
            this.StatusStrip1.TabIndex = 21;
            // 
            // streamerGroupBox8
            // 
            this.streamerGroupBox8.Header = "Stream 8";
            this.streamerGroupBox8.Location = new System.Drawing.Point(269, 461);
            this.streamerGroupBox8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streamerGroupBox8.Name = "streamerGroupBox8";
            this.streamerGroupBox8.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox8.TabIndex = 29;
            // 
            // streamerGroupBox7
            // 
            this.streamerGroupBox7.Header = "Stream 7";
            this.streamerGroupBox7.Location = new System.Drawing.Point(12, 461);
            this.streamerGroupBox7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streamerGroupBox7.Name = "streamerGroupBox7";
            this.streamerGroupBox7.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox7.TabIndex = 28;
            // 
            // streamerGroupBox6
            // 
            this.streamerGroupBox6.Header = "Stream 6";
            this.streamerGroupBox6.Location = new System.Drawing.Point(269, 319);
            this.streamerGroupBox6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.streamerGroupBox6.Name = "streamerGroupBox6";
            this.streamerGroupBox6.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox6.TabIndex = 27;
            // 
            // streamerGroupBox5
            // 
            this.streamerGroupBox5.Header = "Stream 5";
            this.streamerGroupBox5.Location = new System.Drawing.Point(12, 319);
            this.streamerGroupBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.streamerGroupBox5.Name = "streamerGroupBox5";
            this.streamerGroupBox5.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox5.TabIndex = 26;
            // 
            // streamerGroupBox4
            // 
            this.streamerGroupBox4.Header = "Stream 4";
            this.streamerGroupBox4.Location = new System.Drawing.Point(269, 174);
            this.streamerGroupBox4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streamerGroupBox4.Name = "streamerGroupBox4";
            this.streamerGroupBox4.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox4.TabIndex = 25;
            // 
            // streamerGroupBox3
            // 
            this.streamerGroupBox3.Header = "Stream 3";
            this.streamerGroupBox3.Location = new System.Drawing.Point(12, 174);
            this.streamerGroupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.streamerGroupBox3.Name = "streamerGroupBox3";
            this.streamerGroupBox3.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox3.TabIndex = 24;
            // 
            // streamerGroupBox2
            // 
            this.streamerGroupBox2.Header = "Stream 2";
            this.streamerGroupBox2.Location = new System.Drawing.Point(269, 32);
            this.streamerGroupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.streamerGroupBox2.Name = "streamerGroupBox2";
            this.streamerGroupBox2.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox2.TabIndex = 23;
            // 
            // streamerGroupBox1
            // 
            this.streamerGroupBox1.Header = "Stream 1";
            this.streamerGroupBox1.Location = new System.Drawing.Point(12, 32);
            this.streamerGroupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.streamerGroupBox1.Name = "streamerGroupBox1";
            this.streamerGroupBox1.Size = new System.Drawing.Size(251, 142);
            this.streamerGroupBox1.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 631);
            this.Controls.Add(this.streamerGroupBox8);
            this.Controls.Add(this.streamerGroupBox7);
            this.Controls.Add(this.streamerGroupBox6);
            this.Controls.Add(this.streamerGroupBox5);
            this.Controls.Add(this.streamerGroupBox4);
            this.Controls.Add(this.streamerGroupBox3);
            this.Controls.Add(this.streamerGroupBox2);
            this.Controls.Add(this.streamerGroupBox1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGenAll);
            this.Controls.Add(this.btnKillVLC);
            this.Controls.Add(this.btnMoveResize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(655, 670);
            this.MinimumSize = new System.Drawing.Size(655, 670);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MossCast";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Button btnGenAll;
        private Button btnKillVLC;
        private Button btnMoveResize;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem tsmiSelectAutocompleteFile;
        internal ToolStripMenuItem tsmiEditAutocompleteFile;
        internal ToolStripMenuItem tsmiChangeVLCWindowSize;
        internal ToolStripMenuItem tsmiOpenAppData;
        internal ToolStripMenuItem StreamlinkToolStripMenuItem;
        internal ToolStripMenuItem tsmiEditStreamlinkConfig;
        internal ToolStripMenuItem tsmiResetStreamlinkPath;
        internal ToolStripMenuItem tsmiCombineNamesPronouns;
        internal ProgressBar ProgressBar1;
        private StreamerGroupBox streamerGroupBox1;
        private StreamerGroupBox streamerGroupBox2;
        internal ToolStripStatusLabel statusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal StatusStrip StatusStrip1;
        private StreamerGroupBox streamerGroupBox4;
        private StreamerGroupBox streamerGroupBox3;
        private StreamerGroupBox streamerGroupBox8;
        private StreamerGroupBox streamerGroupBox7;
        private StreamerGroupBox streamerGroupBox6;
        private StreamerGroupBox streamerGroupBox5;
    }
}