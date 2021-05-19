
namespace CarRentalApp
{
    partial class ManageRentalRecords
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
            this.button1 = new System.Windows.Forms.Button();
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 128);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Rental Records\r\n\r\n";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvRecordList
            // 
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(91, 123);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.Size = new System.Drawing.Size(527, 299);
            this.gvRecordList.TabIndex = 7;
            
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(91, 445);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(118, 38);
            this.btnAddRecord.TabIndex = 8;
            this.btnAddRecord.Text = "Add New Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(295, 445);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(115, 38);
            this.btnEditCar.TabIndex = 9;
            this.btnEditCar.Text = "Edit Record";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(511, 445);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(107, 38);
            this.btnDeleteCar.TabIndex = 10;
            this.btnDeleteCar.Text = "Delete Record";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.gvRecordList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ManageRentalRecords";
            this.Text = "ManageRentalRecords";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvRecordList;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}