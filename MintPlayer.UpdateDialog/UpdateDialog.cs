using System;
using System.ComponentModel;
using System.Deployment.Application;
using System.Windows.Forms;
using MintPlayer.UpdateDialog.Extensions;

namespace MintPlayer.UpdateDialog
{
    public partial class UpdateDialog : Form
    {
        public UpdateDialog()
        {
            try
            {
                InitializeComponent();
                deployment = ApplicationDeployment.CurrentDeployment;
            }
            catch (Exception)
            {
                // During development, there is no deployment
            }
        }

        private readonly ApplicationDeployment deployment;
        private string previousGroup;
        private DeploymentProgressState? previousState = null;

        private void UpdateDialog_Shown(object sender, EventArgs e)
        {
            if (deployment != null)
            {
                deployment.CheckForUpdateProgressChanged += Deployment_CheckForUpdateProgressChanged;
                deployment.CheckForUpdateCompleted += Deployment_CheckForUpdateCompleted;
                deployment.UpdateProgressChanged += Deployment_UpdateProgressChanged;
                deployment.UpdateCompleted += Deployment_UpdateCompleted;

                lblCurrentVersion.Text = deployment.CurrentVersion.ToString();
                CheckForUpdatesAsync();
            }
        }

        private void UpdateDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (deployment != null)
            {
                deployment.CheckForUpdateProgressChanged -= Deployment_CheckForUpdateProgressChanged;
                deployment.CheckForUpdateCompleted -= Deployment_CheckForUpdateCompleted;
                deployment.UpdateProgressChanged -= Deployment_UpdateProgressChanged;
                deployment.UpdateCompleted -= Deployment_UpdateCompleted;
            }
        }

        private void btnSearchAgain_Click(object sender, EventArgs e)
        {
            CheckForUpdatesAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ModifierKeys == Keys.None) && (keyData == Keys.Escape))
            {
                Close();
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void btnInstallUpdate_Click(object sender, EventArgs e)
        {
            btnInstallUpdate.Enabled = btnSearchAgain.Enabled = false;
            lblStatus.Text = Properties.Resources.Updating;
            deployment.UpdateAsync();
        }

        private void CheckForUpdatesAsync()
        {
            if (deployment != null)
            {
                btnInstallUpdate.Enabled = btnSearchAgain.Enabled = false;
                lblStatus.Text = Properties.Resources.CheckingForUpdates;

                deployment.CheckForUpdateAsync();
            }
        }

        private void Deployment_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            pgbUpdate.Value = e.ProgressPercentage;
            lblProgressBytes.Text = string.Format(Properties.Resources.AFromBBytes, e.BytesCompleted, e.BytesTotal);
            lblProgressPercent.Text = e.ProgressPercentage + "%";

            if (e.State != previousState)
            {
                previousState = e.State;
                txtInformation.AppendLine($"{Properties.Resources.CheckingForUpdates}: {e.State}");
            }
            if(e.Group != previousGroup)
            {
                previousGroup = e.Group;
                txtInformation.AppendLine(string.Format(Properties.Resources.CheckingForUpdatesDownloading, e.Group));
            }
        }

        private void Deployment_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {
            previousState = null;
            btnSearchAgain.Enabled = true;
            if (e.UpdateAvailable)
            {
                lblStatus.Text = Properties.Resources.UpdateAvailable;
                lblNewVersion.Text = e.AvailableVersion.ToString();
                btnInstallUpdate.Enabled = true;
            }
            else
            {
                lblStatus.Text = Properties.Resources.UpToDate;
            }
        }

        private void Deployment_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            pgbUpdate.Value = e.ProgressPercentage;
            lblProgressBytes.Text = string.Format(Properties.Resources.AFromBBytes, e.BytesCompleted, e.BytesTotal);
            lblProgressPercent.Text = e.ProgressPercentage + "%";

            if (e.State != previousState)
            {
                previousState = e.State;
                txtInformation.AppendLine($"{Properties.Resources.CheckingForUpdates}: {e.State}");
            }
            if (e.Group != previousGroup)
            {
                previousGroup = e.Group;
                txtInformation.AppendLine(string.Format(Properties.Resources.CheckingForUpdatesDownloading, e.Group));
            }
        }

        private void Deployment_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Action action = () =>
            {
                previousState = null;
                if (e.Cancelled)
                {
                    lblStatus.Text = Properties.Resources.UpdateInterrupted;
                    txtInformation.AppendLine(Properties.Resources.UpdateInterrupted);
                }
                else if (e.Error != null)
                {
                    lblStatus.Text = Properties.Resources.ErrorOccured;
                    txtInformation.AppendLine($"{Properties.Resources.ErrorOccured}: {e.Error.Message}");
                }
                else
                {
                    lblStatus.Text = Properties.Resources.UpdateComplete;
                    if (MessageBox.Show(Properties.Resources.UpdateCompleteRestart, Properties.Resources.Restart, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BeginInvoke((Action) delegate { Application.Restart(); });
                    }
                }
            };

            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
