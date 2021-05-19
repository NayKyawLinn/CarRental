
namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(52, 87);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(96, 38);
            this.btnrefresh.TabIndex = 11;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Location = new System.Drawing.Point(296, 326);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(196, 38);
            this.btnDeactivateUser.TabIndex = 10;
            this.btnDeactivateUser.Text = "Deactivate/Activate User ";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(163, 326);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(115, 38);
            this.btnResetPassword.TabIndex = 9;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(52, 326);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(96, 38);
            this.btnNewUser.TabIndex = 8;
            this.btnNewUser.Text = "Add New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Users";
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(52, 145);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(440, 153);
            this.gvUserList.TabIndex = 6;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserList;
    }
}