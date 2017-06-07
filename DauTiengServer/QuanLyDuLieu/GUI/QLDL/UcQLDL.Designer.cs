﻿namespace QuanLyDuLieu.GUI
{
    partial class UcQLDL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.lvThongTin = new System.Windows.Forms.ListView();
            this.chAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUpdateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayoutMain
            // 
            this.tbLayoutMain.ColumnCount = 1;
            this.tbLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutMain.Controls.Add(this.label1, 0, 0);
            this.tbLayoutMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tbLayoutMain.Controls.Add(this.splitContainer1, 0, 2);
            this.tbLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutMain.Name = "tbLayoutMain";
            this.tbLayoutMain.RowCount = 4;
            this.tbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayoutMain.Size = new System.Drawing.Size(800, 600);
            this.tbLayoutMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỮ LIỆU";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 553);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 83);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewFolder);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvThongTin);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(794, 464);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.Location = new System.Drawing.Point(0, 0);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.Size = new System.Drawing.Size(200, 464);
            this.treeViewFolder.TabIndex = 0;
            this.treeViewFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFolder_BeforeExpand);
            this.treeViewFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFolder_AfterSelect);
            // 
            // lvThongTin
            // 
            this.lvThongTin.CheckBoxes = true;
            this.lvThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAll,
            this.chPath,
            this.chName,
            this.chType,
            this.chUpdateDate});
            this.lvThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThongTin.FullRowSelect = true;
            this.lvThongTin.GridLines = true;
            this.lvThongTin.Location = new System.Drawing.Point(0, 0);
            this.lvThongTin.MultiSelect = false;
            this.lvThongTin.Name = "lvThongTin";
            this.lvThongTin.Size = new System.Drawing.Size(590, 464);
            this.lvThongTin.TabIndex = 0;
            this.lvThongTin.UseCompatibleStateImageBehavior = false;
            this.lvThongTin.View = System.Windows.Forms.View.Details;
            this.lvThongTin.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvThongTin_ColumnClick);
            this.lvThongTin.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvThongTin_ColumnWidthChanging);
            this.lvThongTin.SelectedIndexChanged += new System.EventHandler(this.lvThongTin_SelectedIndexChanged);
            this.lvThongTin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvThongTin_MouseDoubleClick);
            // 
            // chAll
            // 
            this.chAll.Text = "All";
            this.chAll.Width = 30;
            // 
            // chPath
            // 
            this.chPath.Text = "";
            this.chPath.Width = 0;
            // 
            // chName
            // 
            this.chName.Text = "Tên dữ liệu";
            this.chName.Width = 373;
            // 
            // chType
            // 
            this.chType.Text = "Loại";
            this.chType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chUpdateDate
            // 
            this.chUpdateDate.Text = "Ngày cập nhật";
            this.chUpdateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chUpdateDate.Width = 100;
            // 
            // UcQLDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLayoutMain);
            this.Name = "UcQLDL";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UcQLDL_Load);
            this.tbLayoutMain.ResumeLayout(false);
            this.tbLayoutMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLayoutMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.ListView lvThongTin;
        private System.Windows.Forms.ColumnHeader chAll;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chUpdateDate;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chPath;
    }
}
