namespace MintPlayer.UpdateDialog
{
    partial class UpdateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDialog));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInstallUpdate = new System.Windows.Forms.Button();
            this.btnSearchAgain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReleaseNotes = new System.Windows.Forms.TextBox();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgbUpdate = new System.Windows.Forms.ProgressBar();
            this.lblProgressBytes = new System.Windows.Forms.Label();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInstallUpdate
            // 
            resources.ApplyResources(this.btnInstallUpdate, "btnInstallUpdate");
            this.btnInstallUpdate.Name = "btnInstallUpdate";
            this.btnInstallUpdate.UseVisualStyleBackColor = true;
            this.btnInstallUpdate.Click += new System.EventHandler(this.btnInstallUpdate_Click);
            // 
            // btnSearchAgain
            // 
            resources.ApplyResources(this.btnSearchAgain, "btnSearchAgain");
            this.btnSearchAgain.Name = "btnSearchAgain";
            this.btnSearchAgain.UseVisualStyleBackColor = true;
            this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNewVersion, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblCurrentVersion
            // 
            resources.ApplyResources(this.lblCurrentVersion, "lblCurrentVersion");
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblNewVersion
            // 
            resources.ApplyResources(this.lblNewVersion, "lblNewVersion");
            this.lblNewVersion.Name = "lblNewVersion";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtReleaseNotes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInformation, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtReleaseNotes
            // 
            resources.ApplyResources(this.txtReleaseNotes, "txtReleaseNotes");
            this.txtReleaseNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtReleaseNotes.Name = "txtReleaseNotes";
            this.txtReleaseNotes.ReadOnly = true;
            // 
            // txtInformation
            // 
            resources.ApplyResources(this.txtInformation, "txtInformation");
            this.txtInformation.BackColor = System.Drawing.SystemColors.Window;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // pgbUpdate
            // 
            resources.ApplyResources(this.pgbUpdate, "pgbUpdate");
            this.pgbUpdate.Name = "pgbUpdate";
            // 
            // lblProgressBytes
            // 
            resources.ApplyResources(this.lblProgressBytes, "lblProgressBytes");
            this.lblProgressBytes.Name = "lblProgressBytes";
            // 
            // lblProgressPercent
            // 
            resources.ApplyResources(this.lblProgressPercent, "lblProgressPercent");
            this.lblProgressPercent.Name = "lblProgressPercent";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.lblProgressBytes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblProgressPercent, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // UpdateDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.pgbUpdate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSearchAgain);
            this.Controls.Add(this.btnInstallUpdate);
            this.Controls.Add(this.btnClose);
            this.Name = "UpdateDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateDialog_FormClosed);
            this.Shown += new System.EventHandler(this.UpdateDialog_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInstallUpdate;
        private System.Windows.Forms.Button btnSearchAgain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtReleaseNotes;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pgbUpdate;
        private System.Windows.Forms.Label lblProgressBytes;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

