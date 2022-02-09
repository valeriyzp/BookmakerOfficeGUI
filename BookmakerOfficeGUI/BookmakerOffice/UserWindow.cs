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
    public partial class UserWindow : Form
    {
        IUserInterface User;
        string CurrentMatchNumber = "";
        string CurrentBet = "";
        public UserWindow(IUserInterface Father)
        {
            InitializeComponent();
            User = Father;
            l_Money.Text = User.get_money();
            l_Wins.Text = User.get_wins();
            l_UserName.Text = User.get_login();
            clear_interface();
            update_matches();
            update_history();
        }

        private void pb_Money_Click(object sender, EventArgs e)
        {
            User.plus_one_coin();
            l_Money.Text = User.get_money();
        }

        private void ll_SignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void clear_bets()
        {
            CurrentBet = "";
            b_W1.BackColor = Color.Gainsboro;
            b_D.BackColor = Color.Gainsboro;
            b_W2.BackColor = Color.Gainsboro;
            b_T0.BackColor = Color.Gainsboro;
            b_T1.BackColor = Color.Gainsboro;
            b_T2.BackColor = Color.Gainsboro;
            b_T3.BackColor = Color.Gainsboro;
            b_T4Plus.BackColor = Color.Gainsboro;
        }

        private void clear_interface()
        {
            l_FirstTeam.Text = "Team 1";
            l_SecondTeam.Text = "Team 2";
            b_W1.Text = "W1\r\n1,00";
            b_D.Text = "D\r\n1,00";
            b_W2.Text = "W2\r\n1,00";
            b_T0.Text = "T0\r\n1,00";
            b_T1.Text = "T1\r\n1,00";
            b_T2.Text = "T2\r\n1,00";
            b_T3.Text = "T3\r\n1,00";
            b_T4Plus.Text = "T4+\r\n1,00";
        }

        private void set_bet(string FirstTeam, string SecondTeam, string[] Сoefficient)
        {
            l_FirstTeam.Text = FirstTeam;
            l_SecondTeam.Text = SecondTeam;
            b_W1.Text = "W1\r\n" + Сoefficient[0];
            b_D.Text = "D\r\n" + Сoefficient[1];
            b_W2.Text = "W2\r\n" + Сoefficient[2];
            b_T0.Text = "T0\r\n" + Сoefficient[3];
            b_T1.Text = "T1\r\n" + Сoefficient[4];
            b_T2.Text = "T2\r\n" + Сoefficient[5];
            b_T3.Text = "T3\r\n" + Сoefficient[6];
            b_T4Plus.Text = "T4+\r\n" + Сoefficient[7];
        }

        private void update_matches()
        {
            clear_interface();
            clear_bets();
            List<string[]> matches = User.get_matches();
            foreach (string[] match in matches)
            {
                try
                {
                    dgv_Matches.Rows.Add(match);
                }
                catch(Exception)
                {
                    continue;
                }
            }
        }

        private void update_history()
        {
            dgv_History.Rows.Clear();
            List<string[]> History = User.get_history();
            foreach (string[] Line in History)
            {
                try
                {
                    dgv_History.Rows.Add(Line);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private void B_Bet_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_Sum.Value > Convert.ToDecimal(l_Money.Text)) throw new Exception();
                if (CurrentBet == "" || CurrentMatchNumber == "")
                {
                    MessageBox.Show("Select a match and place a bet!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (User.new_bet(CurrentMatchNumber, CurrentBet, nud_Sum.Value.ToString()))
                {
                    MessageBox.Show("Bet accepted", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                l_Money.Text = User.get_money();
                clear_bets();
                nud_Sum.Value = 1;
                update_history();
            }
            catch(Exception)
            {
                MessageBox.Show("Not enough money in the account", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_W1_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "W1";
            b_W1.BackColor = Color.GreenYellow;
        }

        private void B_D_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "D";
            b_D.BackColor = Color.GreenYellow;
        }

        private void B_W2_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "W2";
            b_W2.BackColor = Color.GreenYellow;
        }

        private void B_T0_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "T0";
            b_T0.BackColor = Color.GreenYellow;
        }

        private void B_T1_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "T1";
            b_T1.BackColor = Color.GreenYellow;
        }

        private void B_T2_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "T2";
            b_T2.BackColor = Color.GreenYellow;
        }

        private void B_T3_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "T3";
            b_T3.BackColor = Color.GreenYellow;
        }

        private void B_T4Plus_Click(object sender, EventArgs e)
        {
            clear_bets();
            CurrentBet = "T4Plus";
            b_T4Plus.BackColor = Color.GreenYellow;
        }

        private void Dgv_Matches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Matches.SelectedCells.Count == 0)
            {
                clear_bets();
                clear_interface();
            }
            else
            {
                DataGridViewRow row = dgv_Matches.Rows[dgv_Matches.SelectedCells[0].RowIndex];
                if (CurrentMatchNumber != row.Cells[0].Value.ToString())
                {
                    CurrentMatchNumber = row.Cells[0].Value.ToString();
                    CurrentBet = "";
                    clear_bets();
                    set_bet(row.Cells[2].Value.ToString().Split(' ')[0], row.Cells[2].Value.ToString().Split(' ')[2], User.get_match_coefficient(row.Cells[0].Value.ToString()));
                }
            }
        }
    }
}
