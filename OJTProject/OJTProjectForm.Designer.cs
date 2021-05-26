
namespace OJTProject
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
            this.tbCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(300, 212);
            this.tbCost.Multiline = true;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(200, 26);
            this.tbCost.TabIndex = 12;
            // 
            // OJTProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCost);
            this.Name = "OJTProjectForm";
            this.Text = "OJTProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCost;
    }
}