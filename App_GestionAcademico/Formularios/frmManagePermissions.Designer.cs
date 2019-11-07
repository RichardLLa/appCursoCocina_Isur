namespace App_AcademicManagement
{
    partial class frmManagePermissions
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
            this.pageControls = new MetroFramework.Controls.MetroListView();
            this.pagePersmissionsRoles = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // pageControls
            // 
            this.pageControls.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pageControls.FullRowSelect = true;
            this.pageControls.Location = new System.Drawing.Point(36, 95);
            this.pageControls.Name = "pageControls";
            this.pageControls.OwnerDraw = true;
            this.pageControls.Size = new System.Drawing.Size(244, 263);
            this.pageControls.TabIndex = 0;
            this.pageControls.UseCompatibleStateImageBehavior = false;
            this.pageControls.UseSelectable = true;
            // 
            // pagePersmissionsRoles
            // 
            this.pagePersmissionsRoles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pagePersmissionsRoles.FullRowSelect = true;
            this.pagePersmissionsRoles.Location = new System.Drawing.Point(398, 95);
            this.pagePersmissionsRoles.Name = "pagePersmissionsRoles";
            this.pagePersmissionsRoles.OwnerDraw = true;
            this.pagePersmissionsRoles.Size = new System.Drawing.Size(244, 263);
            this.pagePersmissionsRoles.TabIndex = 1;
            this.pagePersmissionsRoles.UseCompatibleStateImageBehavior = false;
            this.pagePersmissionsRoles.UseSelectable = true;
            // 
            // frmManagePermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 456);
            this.Controls.Add(this.pagePersmissionsRoles);
            this.Controls.Add(this.pageControls);
            this.Name = "frmManagePermissions";
            this.Text = "frmManagePermissions";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView pageControls;
        private MetroFramework.Controls.MetroListView pagePersmissionsRoles;
    }
}