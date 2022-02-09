using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetSystem;

namespace BookmakerOffice
{
    public partial class AdminWindow : Form
    {
        IAdminInterface Admin;
        string CurrentMatchNumber = "";

        public AdminWindow(IAdminInterface Father)
        {
            InitializeComponent();
            Admin = Father;
            update_matches();
        }

        private void L_SignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        public void update_matches()
        {
            clear_interface_update_match();
            dgv_Matches.Rows.Clear();
            List<string[]> matches = Admin.get_matches();
            foreach (string[] match in matches)
            {
                try
                {
                    dgv_Matches.Rows.Add(match);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        void set_teams_to_update(string Team1, string Team2)
        {
            clear_interface_update_match();
            l_FirstTeam.Text = Team1;
            l_SecondTeam.Text = Team2;
        }

        private void clear_interface_update_match()
        {
            l_FirstTeam.Text = "Team 1";
            l_SecondTeam.Text = "Team 2";
            nud_FirstTeamGoals.Value = 0;
            nud_SecondTeamGoals.Value = 0;
            CurrentMatchNumber = "";
        }

        private void clear_interface_new_match()
        {
            tb_Team1.Text = "";
            tb_Team2.Text = "";
            dtp_Date.Value = DateTime.Now;
            nud_W1.Value = 1;
            nud_D.Value = 1;
            nud_W2.Value = 1;
            nud_T0.Value = 1;
            nud_T1.Value = 1;
            nud_T2.Value = 1;
            nud_T3.Value = 1;
            nud_T4Plus.Value = 1;
        }

        private void B_AddMatch_Click(object sender, EventArgs e)
        {
            if(tb_Team1.Text != "" && tb_Team2.Text != "")
            {
                if(nud_W1.Value > 1 && nud_D.Value > 1 && nud_W2.Value > 1)
                {
                    string Coefficient = nud_W1.Value.ToString() + ' ' + nud_D.Value.ToString() + ' ' + nud_W2.Value.ToString() + ' ';

                    if (nud_T0.Value > 1 && nud_T1.Value > 1 && nud_T2.Value > 1 && nud_T3.Value > 1 && nud_T4Plus.Value > 1)
                    {
                        Coefficient += nud_T0.Value.ToString() + ' ' + nud_T1.Value.ToString() + ' ' + nud_T2.Value.ToString() + ' ';
                        Coefficient += nud_T3.Value.ToString() + ' ' + nud_T4Plus.Value.ToString();
                        if (!Admin.add_match(tb_Team1.Text, tb_Team2.Text, dtp_Date.Value.ToShortDateString(), Coefficient))
                        {
                            MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            clear_interface_new_match();
                            MessageBox.Show("Add match accepted", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            update_matches();
                        }
                        return;
                    }
                }
            }
            MessageBox.Show("All fields are required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Dgv_Matches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Matches.SelectedCells.Count == 0)
            {
                clear_interface_update_match();
            }
            else
            {
                DataGridViewRow row = dgv_Matches.Rows[dgv_Matches.SelectedCells[0].RowIndex];
                if (CurrentMatchNumber != row.Cells[0].Value.ToString())
                {
                    set_teams_to_update(row.Cells[2].Value.ToString().Split(' ')[0], row.Cells[2].Value.ToString().Split(' ')[2]);
                    CurrentMatchNumber = row.Cells[0].Value.ToString();
                }
            }
        }

        private void B_Accept_Click(object sender, EventArgs e)
        {
            if(CurrentMatchNumber != "")
            {
                if(Admin.update_match(CurrentMatchNumber, nud_FirstTeamGoals.Value, nud_SecondTeamGoals.Value))
                {
                    update_matches();
                    MessageBox.Show("Update match accepted", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Choose the match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
