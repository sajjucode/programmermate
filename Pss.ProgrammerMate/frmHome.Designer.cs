namespace Pss.ProgrammerMate
{
    partial class frmHome
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.solutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionsDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBSQLGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBTableFolderMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.AutoSize = false;
            this.msMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solutionsToolStripMenuItem,
            this.solutionsDBToolStripMenuItem,
            this.dBSQLGeneratorToolStripMenuItem,
            this.dBTableFolderMappingToolStripMenuItem,
            this.solutionProjectsToolStripMenuItem,
            this.businessEntityToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1044, 37);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // solutionsToolStripMenuItem
            // 
            this.solutionsToolStripMenuItem.Name = "solutionsToolStripMenuItem";
            this.solutionsToolStripMenuItem.Size = new System.Drawing.Size(75, 33);
            this.solutionsToolStripMenuItem.Text = "Solutions";
            this.solutionsToolStripMenuItem.Click += new System.EventHandler(this.solutionsToolStripMenuItem_Click);
            // 
            // solutionsDBToolStripMenuItem
            // 
            this.solutionsDBToolStripMenuItem.Name = "solutionsDBToolStripMenuItem";
            this.solutionsDBToolStripMenuItem.Size = new System.Drawing.Size(97, 33);
            this.solutionsDBToolStripMenuItem.Text = "Solutions DB";
            this.solutionsDBToolStripMenuItem.Click += new System.EventHandler(this.solutionsDBToolStripMenuItem_Click);
            // 
            // dBSQLGeneratorToolStripMenuItem
            // 
            this.dBSQLGeneratorToolStripMenuItem.Name = "dBSQLGeneratorToolStripMenuItem";
            this.dBSQLGeneratorToolStripMenuItem.Size = new System.Drawing.Size(131, 33);
            this.dBSQLGeneratorToolStripMenuItem.Text = "DB SQL Generator";
            this.dBSQLGeneratorToolStripMenuItem.Click += new System.EventHandler(this.dBSQLGeneratorToolStripMenuItem_Click);
            // 
            // solutionProjectsToolStripMenuItem
            // 
            this.solutionProjectsToolStripMenuItem.Name = "solutionProjectsToolStripMenuItem";
            this.solutionProjectsToolStripMenuItem.Size = new System.Drawing.Size(120, 33);
            this.solutionProjectsToolStripMenuItem.Text = "Solution Projects";
            this.solutionProjectsToolStripMenuItem.Click += new System.EventHandler(this.solutionProjectsToolStripMenuItem_Click);
            // 
            // dBTableFolderMappingToolStripMenuItem
            // 
            this.dBTableFolderMappingToolStripMenuItem.Name = "dBTableFolderMappingToolStripMenuItem";
            this.dBTableFolderMappingToolStripMenuItem.Size = new System.Drawing.Size(176, 33);
            this.dBTableFolderMappingToolStripMenuItem.Text = "DB Table Folder Mapping";
            this.dBTableFolderMappingToolStripMenuItem.Click += new System.EventHandler(this.dBTableFolderMappingToolStripMenuItem_Click);
            // 
            // businessEntityToolStripMenuItem
            // 
            this.businessEntityToolStripMenuItem.Name = "businessEntityToolStripMenuItem";
            this.businessEntityToolStripMenuItem.Size = new System.Drawing.Size(110, 33);
            this.businessEntityToolStripMenuItem.Text = "Business Entity";
            this.businessEntityToolStripMenuItem.Click += new System.EventHandler(this.businessEntityToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 488);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pss Programmer Mate 2015";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem solutionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionsDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBSQLGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBTableFolderMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessEntityToolStripMenuItem;
    }
}