using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeverwinterGuildTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPickGuildExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = "CSV Files|*.csv";
            var rc = ofd.ShowDialog();
            if (rc == DialogResult.OK)
            {
                txtGuildFilePath.Text = ofd.FileName;
            }
        }

        private DateTime Today
        {
            get
            {
                DateTime now = DateTime.Now; // Avoid edge case of midnight rolling over while the next line runs
                DateTime today = new DateTime(now.Year, now.Month, now.Day);

                return today;
            }
        }

        private int KickableAccountAge
        {
            get
            {
                int deltaDays = (int)new TimeSpan(Today.Ticks - dtKickOlderThan.Value.Ticks).TotalDays;
                return deltaDays;
            }
        }

        private void btnGenKick_Click(object sender, EventArgs e)
        {
            ResetUI();

            try
            {
                StringBuilder cmds = new StringBuilder();

                var allCharacters = new ExportParser().ParseGuildExport(txtGuildFilePath.Text).ToList(); // Make a list as we need to iterate multiple times

                foreach (var gc in allCharacters
                    .GroupBy(c => c.Account, (key, c) => c.MaxBy(ch => -ch.AccountAge)) // Check the most recently active toon on the account. Use inverse of account age for effective "MinBy" ordering.
                    .Where(c => c.AccountAge > KickableAccountAge)
                    .OrderBy(c => c.LastActiveDate))
                {
                    foreach (var gcAcct in allCharacters.Where(c => c.Account == gc.Account).OrderBy(c => c.AccountAge))
                    {
                        if (chkShowInfo.Checked)
                        {
                            cmds.AppendLine($"{gcAcct.Name}{gcAcct.Account} active {gcAcct.LastActiveDate}");
                        }
                        else
                        {
                            cmds.AppendLine($"/guild_kick {gcAcct.Name}{gcAcct.Account}");
                        }
                    }
                }
                txtKickCommands.Text = cmds.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EnableGenButton
        {
            get
            {
                return File.Exists(txtGuildFilePath.Text) && KickableAccountAge > 0;
            }
        }
        private void txtGuildFilePath_TextChanged(object sender, EventArgs e)
        {
            ResetUI();
            btnGenKick.Enabled = EnableGenButton;
        }

        private void dtKickOlderThan_ValueChanged(object sender, EventArgs e)
        {
            ResetUI();
            
            int kaa = KickableAccountAge;

            if (kaa < 0)
            {
                dtKickOlderThan.Value = Today;
            }
            else
            {
                lblAccountAge.Text = kaa == 1 ? "1 day" : $"{kaa} days";
                btnGenKick.Enabled = EnableGenButton;
            }
        }

        private void ResetUI()
        {
            txtKickCommands.Text = "";
        }

        private DateTime Ago(int days)
        {
            return Today.AddDays(-days);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            dtKickOlderThan.Value = Ago(30);
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            dtKickOlderThan.Value = Ago(60);
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            dtKickOlderThan.Value = Ago(90);
        }
    }
}
