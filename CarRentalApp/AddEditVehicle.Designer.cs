
namespace CarRentalApp
{
    partial class AddEditVehicle
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VIN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbLicenseNum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(418, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
           // this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 64);
            this.lblTitle.TabIndex = 4;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(284, 51);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 13;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(284, 3);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(100, 20);
            this.tbMake.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // VIN
            // 
            this.VIN.AutoSize = true;
            this.VIN.Location = new System.Drawing.Point(3, 96);
            this.VIN.Name = "VIN";
            this.VIN.Size = new System.Drawing.Size(25, 13);
            this.VIN.TabIndex = 4;
            this.VIN.Text = "VIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "license Plate Number";
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(284, 99);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(100, 20);
            this.tbVIN.TabIndex = 10;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(284, 147);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 11;
            // 
            // tbLicenseNum
            // 
            this.tbLicenseNum.Location = new System.Drawing.Point(284, 195);
            this.tbLicenseNum.Name = "tbLicenseNum";
            this.tbLicenseNum.Size = new System.Drawing.Size(100, 20);
            this.tbLicenseNum.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseNum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbVIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.VIN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(281, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Visible = false;
            // 
            // lbId
            // 
            this.lbId.Location = new System.Drawing.Point(326, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(100, 20);
            this.lbId.TabIndex = 10;
            this.lbId.Visible = false;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 436);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbLicenseNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox lbId;
    }
}