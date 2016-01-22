namespace BabyNameGenerator
{
    partial class frmStatus
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
            this.progbarNames = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValidNames = new System.Windows.Forms.TextBox();
            this.txtTriedNames = new System.Windows.Forms.TextBox();
            this.txtGoodNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progbarNames
            // 
            this.progbarNames.Location = new System.Drawing.Point(11, 28);
            this.progbarNames.Name = "progbarNames";
            this.progbarNames.Size = new System.Drawing.Size(283, 23);
            this.progbarNames.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progbarNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Generation Progress";
            // 
            // txtValidNames
            // 
            this.txtValidNames.BackColor = System.Drawing.SystemColors.Window;
            this.txtValidNames.Location = new System.Drawing.Point(147, 57);
            this.txtValidNames.Name = "txtValidNames";
            this.txtValidNames.ReadOnly = true;
            this.txtValidNames.Size = new System.Drawing.Size(147, 20);
            this.txtValidNames.TabIndex = 2;
            this.txtValidNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTriedNames
            // 
            this.txtTriedNames.BackColor = System.Drawing.SystemColors.Window;
            this.txtTriedNames.Location = new System.Drawing.Point(147, 84);
            this.txtTriedNames.Name = "txtTriedNames";
            this.txtTriedNames.ReadOnly = true;
            this.txtTriedNames.Size = new System.Drawing.Size(147, 20);
            this.txtTriedNames.TabIndex = 3;
            this.txtTriedNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGoodNames
            // 
            this.txtGoodNames.BackColor = System.Drawing.SystemColors.Window;
            this.txtGoodNames.Location = new System.Drawing.Point(147, 110);
            this.txtGoodNames.Name = "txtGoodNames";
            this.txtGoodNames.ReadOnly = true;
            this.txtGoodNames.Size = new System.Drawing.Size(147, 20);
            this.txtGoodNames.TabIndex = 4;
            this.txtGoodNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valid Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Names Tried";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Good Names";
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 145);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoodNames);
            this.Controls.Add(this.txtTriedNames);
            this.Controls.Add(this.txtValidNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progbarNames);
            this.Name = "frmStatus";
            this.Text = "frmStatus";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progbarNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValidNames;
        private System.Windows.Forms.TextBox txtTriedNames;
        private System.Windows.Forms.TextBox txtGoodNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}