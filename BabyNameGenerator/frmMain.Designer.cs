namespace BabyNameGenerator
{
    partial class frmMain
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeStatusSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewFirst = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnNewMiddle = new System.Windows.Forms.Button();
            this.btnRemoveMiddle = new System.Windows.Forms.Button();
            this.btnGoodName = new System.Windows.Forms.Button();
            this.btnBadName = new System.Windows.Forms.Button();
            this.seeNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiredNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(12, 42);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(159, 31);
            this.firstNameBox.TabIndex = 0;
            // 
            // middleNameBox
            // 
            this.middleNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.middleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameBox.Location = new System.Drawing.Point(177, 42);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.ReadOnly = true;
            this.middleNameBox.Size = new System.Drawing.Size(159, 31);
            this.middleNameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(342, 42);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.ReadOnly = true;
            this.lastNameBox.Size = new System.Drawing.Size(159, 31);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.Text = "Points";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNamesToolStripMenuItem,
            this.seeStatusSummaryToolStripMenuItem,
            this.seeNamesToolStripMenuItem,
            this.exportNamesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addNamesToolStripMenuItem
            // 
            this.addNamesToolStripMenuItem.Name = "addNamesToolStripMenuItem";
            this.addNamesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNamesToolStripMenuItem.Text = "Add Names";
            // 
            // seeStatusSummaryToolStripMenuItem
            // 
            this.seeStatusSummaryToolStripMenuItem.Name = "seeStatusSummaryToolStripMenuItem";
            this.seeStatusSummaryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.seeStatusSummaryToolStripMenuItem.Text = "See Status Summary";
            this.seeStatusSummaryToolStripMenuItem.Click += new System.EventHandler(this.seeStatusSummaryToolStripMenuItem_Click);
            // 
            // btnNewFirst
            // 
            this.btnNewFirst.Location = new System.Drawing.Point(12, 79);
            this.btnNewFirst.Name = "btnNewFirst";
            this.btnNewFirst.Size = new System.Drawing.Size(159, 34);
            this.btnNewFirst.TabIndex = 4;
            this.btnNewFirst.Text = "New";
            this.btnNewFirst.UseVisualStyleBackColor = true;
            this.btnNewFirst.Click += new System.EventHandler(this.btnNewFirst_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Location = new System.Drawing.Point(12, 119);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(159, 34);
            this.btnRemoveFirst.TabIndex = 5;
            this.btnRemoveFirst.Text = "Remove";
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnNewMiddle
            // 
            this.btnNewMiddle.Location = new System.Drawing.Point(177, 79);
            this.btnNewMiddle.Name = "btnNewMiddle";
            this.btnNewMiddle.Size = new System.Drawing.Size(159, 34);
            this.btnNewMiddle.TabIndex = 6;
            this.btnNewMiddle.Text = "New";
            this.btnNewMiddle.UseVisualStyleBackColor = true;
            this.btnNewMiddle.Click += new System.EventHandler(this.btnNewMiddle_Click);
            // 
            // btnRemoveMiddle
            // 
            this.btnRemoveMiddle.Location = new System.Drawing.Point(177, 119);
            this.btnRemoveMiddle.Name = "btnRemoveMiddle";
            this.btnRemoveMiddle.Size = new System.Drawing.Size(159, 34);
            this.btnRemoveMiddle.TabIndex = 7;
            this.btnRemoveMiddle.Text = "Remove";
            this.btnRemoveMiddle.UseVisualStyleBackColor = true;
            this.btnRemoveMiddle.Click += new System.EventHandler(this.btnRemoveMiddle_Click);
            // 
            // btnGoodName
            // 
            this.btnGoodName.Location = new System.Drawing.Point(342, 79);
            this.btnGoodName.Name = "btnGoodName";
            this.btnGoodName.Size = new System.Drawing.Size(159, 34);
            this.btnGoodName.TabIndex = 8;
            this.btnGoodName.Text = "Good Name";
            this.btnGoodName.UseVisualStyleBackColor = true;
            this.btnGoodName.Click += new System.EventHandler(this.btnGoodName_Click);
            // 
            // btnBadName
            // 
            this.btnBadName.Location = new System.Drawing.Point(342, 119);
            this.btnBadName.Name = "btnBadName";
            this.btnBadName.Size = new System.Drawing.Size(159, 34);
            this.btnBadName.TabIndex = 9;
            this.btnBadName.Text = "Bad Name";
            this.btnBadName.UseVisualStyleBackColor = true;
            this.btnBadName.Click += new System.EventHandler(this.btnBadName_Click);
            // 
            // seeNamesToolStripMenuItem
            // 
            this.seeNamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodNamesToolStripMenuItem,
            this.badNamesToolStripMenuItem,
            this.retiredNamesToolStripMenuItem});
            this.seeNamesToolStripMenuItem.Name = "seeNamesToolStripMenuItem";
            this.seeNamesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.seeNamesToolStripMenuItem.Text = "See Names";
            // 
            // goodNamesToolStripMenuItem
            // 
            this.goodNamesToolStripMenuItem.Name = "goodNamesToolStripMenuItem";
            this.goodNamesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.goodNamesToolStripMenuItem.Text = "Good Names";
            this.goodNamesToolStripMenuItem.Click += new System.EventHandler(this.goodNamesToolStripMenuItem_Click);
            // 
            // badNamesToolStripMenuItem
            // 
            this.badNamesToolStripMenuItem.Name = "badNamesToolStripMenuItem";
            this.badNamesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.badNamesToolStripMenuItem.Text = "Bad Names";
            // 
            // retiredNamesToolStripMenuItem
            // 
            this.retiredNamesToolStripMenuItem.Name = "retiredNamesToolStripMenuItem";
            this.retiredNamesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retiredNamesToolStripMenuItem.Text = "Retired Names";
            // 
            // exportNamesToolStripMenuItem
            // 
            this.exportNamesToolStripMenuItem.Name = "exportNamesToolStripMenuItem";
            this.exportNamesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportNamesToolStripMenuItem.Text = "Export Names";
            this.exportNamesToolStripMenuItem.Click += new System.EventHandler(this.exportNamesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 161);
            this.Controls.Add(this.btnBadName);
            this.Controls.Add(this.btnGoodName);
            this.Controls.Add(this.btnRemoveMiddle);
            this.Controls.Add(this.btnNewMiddle);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnNewFirst);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Name Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeStatusSummaryToolStripMenuItem;
        private System.Windows.Forms.Button btnNewFirst;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnNewMiddle;
        private System.Windows.Forms.Button btnRemoveMiddle;
        private System.Windows.Forms.Button btnGoodName;
        private System.Windows.Forms.Button btnBadName;
        private System.Windows.Forms.ToolStripMenuItem seeNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retiredNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportNamesToolStripMenuItem;
    }
}

