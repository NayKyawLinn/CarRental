
namespace OJTProjectFrom
{
    partial class OJTProjectForm
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStartWatching = new System.Windows.Forms.Button();
            this.gvOJTProjectList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvOJTProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(498, 400);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(107, 38);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(271, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 38);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStartWatching
            // 
            this.btnStartWatching.Location = new System.Drawing.Point(78, 400);
            this.btnStartWatching.Name = "btnStartWatching";
            this.btnStartWatching.Size = new System.Drawing.Size(118, 38);
            this.btnStartWatching.TabIndex = 13;
            this.btnStartWatching.Text = "Start Watching";
            this.btnStartWatching.UseVisualStyleBackColor = true;
            this.btnStartWatching.TextChanged += new System.EventHandler(this.btnStartWatching_TextChanged);
            this.btnStartWatching.Click += new System.EventHandler(this.btnStartWatching_Click);
            // 
            // gvOJTProjectList
            // 
            this.gvOJTProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOJTProjectList.Location = new System.Drawing.Point(78, 69);
            this.gvOJTProjectList.Name = "gvOJTProjectList";
            this.gvOJTProjectList.Size = new System.Drawing.Size(527, 299);
            this.gvOJTProjectList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "OJT Project Form";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Path = "D:\\CarRentalProject\\Testing";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // OJTProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStartWatching);
            this.Controls.Add(this.gvOJTProjectList);
            this.Controls.Add(this.label1);
            this.Name = "OJTProjectForm";
            this.Text = "OJTProjectForm";
            this.Load += new System.EventHandler(this.OJTProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOJTProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStartWatching;
        private System.Windows.Forms.DataGridView gvOJTProjectList;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}