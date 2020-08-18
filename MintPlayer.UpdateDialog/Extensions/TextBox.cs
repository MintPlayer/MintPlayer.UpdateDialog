using System;

namespace MintPlayer.UpdateDialog.Extensions
{
    public static class TextBox
    {
        public static void AppendLine(this System.Windows.Forms.TextBox textBox, string line)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = line;
            }
            else
            {
                textBox.AppendText(Environment.NewLine + line);
            }
        }
    }
}
