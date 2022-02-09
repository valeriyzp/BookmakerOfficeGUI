using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace BetSystem
{
    public interface IUserInterface
    {
        bool sign_in(string Login, string Password);
        bool sign_up(string Login, string Password);
        string get_money();
        string get_wins();
        string get_login();
        string[] get_match_coefficient(string MatchNumber);
        bool new_bet(string MatchNumber, string BetInfo, string MoneyToBet);
        List<string[]> get_matches();
        List<string[]> get_history();
        bool plus_one_coin();
    }

    public interface IAdminInterface
    {
        bool sign_in_admin(string Login, string Password);
        bool add_match(string Team1, string Team2, string Date, string Coefficients);
        List<string[]> get_matches();
        bool update_match(string MatchNumber, decimal FirstTeamGoals, decimal SecondTeamGoals);
    }

    public class SystemManagment : IUserInterface, IAdminInterface
    {
        string FileUsers = @"user.txt"; // @"C:\Users\Valeriy\Desktop\user.txt";
        string FileMatches = @"match.txt"; // @"C:\Users\Valeriy\Desktop\match.txt";
        string FileBet = @"bet.txt"; // @"C:\Users\Valeriy\Desktop\bet.txt";
        string FileUserBets = @"userbets.txt"; // @"C:\Users\Valeriy\Desktop\userbets.txt";

        public SystemManagment()
        {
            using (StreamWriter FileWrite = new StreamWriter(FileUsers, true)) ;
            using (StreamWriter FileWrite = new StreamWriter(FileMatches, true)) ;
            using (StreamWriter FileWrite = new StreamWriter(FileBet, true)) ;
            using (StreamWriter FileWrite = new StreamWriter(FileUserBets, true)) ;
        }

        string Name = "";

        public bool sign_in(string Login, string Password)
        {
            Name = Login;
            try
            {
                using (StreamReader FileRead = new StreamReader(FileUsers))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        string LoginFromFile = Line.Split(' ')[0];
                        string PasswordFromFile = Line.Split(' ')[1];
                        if (LoginFromFile == Login && Password == PasswordFromFile)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                using (StreamWriter FileWrite = new StreamWriter(FileUsers, true)) ;
            }
            return false;
        }

        private void write_str_to_file(string FileName, string Data)
        {
            using (StreamWriter FileWrite = new StreamWriter(FileName, true))
            {
                FileWrite.WriteLine(Data);
            }
        }

        public bool sign_up(string Login, string Password)
        {
            try
            {
                if(Login == "admin")
                {
                    return false;
                }
                using (StreamReader FileRead = new StreamReader(FileUsers))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        string LoginFromFile = Line.Split(' ')[0];
                        if (LoginFromFile == Login)
                        {
                            return false;
                        }
                    }
                }
            }
            catch(Exception)
            {
                using (StreamWriter FileWrite = new StreamWriter(FileUsers, true)) ;
            }
            write_str_to_file(FileUsers, Login + ' ' + Password + ' ' + "1000");
            return true;
        }

        public string get_money()
        {
            try
            {
                using (StreamReader FileRead = new StreamReader(FileUsers))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        string LoginFromFile = Line.Split(' ')[0];
                        if (LoginFromFile == Name)
                        {
                            return Line.Split(' ')[2];
                        }
                    }
                }
                return "0";
            }
            catch (Exception)
            {
                return "0";
            };
        }

        public string get_wins()
        {
            try
            {
                int Wins = 0;
                using (StreamReader FileRead = new StreamReader(FileUserBets))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        string LoginFromFile = Line.Split(' ')[1];
                        if (LoginFromFile == Name)
                        {
                            string Result = Line.Split(' ')[4];
                            if (Result == "WIN")
                            {
                                Wins++;
                            }
                        }
                    }
                }
                return Wins.ToString();
            }
            catch (Exception)
            {
                return "111";
            };
        }

        public string get_login()
        {
            return Name;
        }

        public string[] get_match_coefficient(string MatchNumber)
        {
            try
            {
                using (StreamReader FileRead = new StreamReader(FileBet))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        string Number = Line.Split(' ')[0];
                        string[] Bet = Line.Split(' ');
                        if (Number == MatchNumber)
                        {
                            string[] coefficient = new string[8];
                            for(int i = 0; i < 8; i++)
                            {
                                coefficient[i] = Bet[i + 1];
                            }
                            return coefficient;
                        }
                    }
                }
            }
            catch (Exception)
            {
                using (StreamWriter FileWrite = new StreamWriter(FileUsers, true)) ;
            }
            return null;
        }

        public bool sign_in_admin(string Login, string Password)
        {
            Name = Login;
            if (Login == "admin" && Password == "admin") return true;
            else return false;
        }

        public List<string[]> get_matches()
        {
            try
            {
                List<string[]> Matches = new List<string[]>();
                using (StreamReader FileRead = new StreamReader(FileMatches))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        if(Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[4] != "+")
                        {
                            string[] Match = new string[3];
                            Match[0] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                            Match[1] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                            Match[2] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2] + " - " + Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3];
                            Matches.Add(Match);
                        }
                    }
                }
                return Matches;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string get_resultSum(string MatchNumber, string BetInfo, string Sum)
        {
            string coefficient = find_coefficient(MatchNumber, BetInfo);
            string ResultSum = Convert.ToInt32((Convert.ToDecimal(Sum) * Convert.ToDecimal(coefficient))).ToString();
            return ResultSum;
        }

        public List<string[]> get_history()
        {
            try
            {
                List<string[]> History = new List<string[]>();
                using (StreamReader FileRead = new StreamReader(FileUserBets))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        if(Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1] == Name)
                        {
                            string coefficient = find_coefficient(Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0], Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2]);
                            string ResultSum = (Convert.ToDecimal(Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3]) * Convert.ToDecimal(coefficient)).ToString("0.00");
                            string[] Bet = new string[6];
                            Bet[0] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                            Bet[1] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2];
                            Bet[2] = find_coefficient(Bet[0], Bet[1]);
                            Bet[3] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3];
                            Bet[4] = get_resultSum(Bet[0], Bet[1], Bet[3]);
                            Bet[5] = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[4];
                            History.Add(Bet);
                        }
                    }
                }
                History.Reverse();
                return History;
            }
            catch (Exception)
            {
                using (StreamWriter FileWriter = new StreamWriter(FileUserBets)) ;
                List<string[]> History = new List<string[]>();
                return History;
            }
        }

        private string find_coefficient(string MatchNumber, string BetInfo)
        {
            try
            {
                using (StreamReader FileRead = new StreamReader(FileBet))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        if(Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0] == MatchNumber)
                        {
                            if (BetInfo == "W1") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                            else if (BetInfo == "D") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2];
                            else if (BetInfo == "W2") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3];
                            else if (BetInfo == "T0") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[4];
                            else if (BetInfo == "T1") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[5];
                            else if (BetInfo == "T2") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[6];
                            else if (BetInfo == "T3") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[7];
                            else if (BetInfo == "T4Plus") return Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[8];
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool new_bet(string MatchNumber, string BetInfo, string MoneyToBet)
        {
            try
            {
                bool IsBetConfirmed = false;
                using (StreamReader FileRead = new StreamReader(FileUsers))
                {
                    string[] Lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                    {
                        string LoginFromFile = Line.Split(' ')[0];
                        if (LoginFromFile == Name)
                        {
                            if (Convert.ToDecimal(MoneyToBet) > 0 && Convert.ToDecimal(Line.Split(' ')[2]) >= Convert.ToDecimal(MoneyToBet))
                            {
                                IsBetConfirmed = true;
                                write_str_to_file(FileUserBets, MatchNumber + ' ' + Name + ' ' + BetInfo + ' ' + MoneyToBet + " WAIT");
                                break;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                if (IsBetConfirmed)
                {
                    return update_user_money(Name, "-" + MoneyToBet);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool plus_one_coin()
        {
            return update_user_money(Name, "1");
        }

        private bool update_user_money(string UserName, string AddMoney)
        {
            try
            {
                string[] Users;
                using (StreamReader FileRead = new StreamReader(FileUsers))
                {
                    Users = FileRead.ReadToEnd().Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                }
                for (int i = 0; i < Users.Count(); i++)
                {
                    if(Users[i].Split(' ')[0] == UserName)
                    {
                        string NewSum = (Convert.ToDecimal(Users[i].Split(' ')[2]) + Convert.ToDecimal(AddMoney)).ToString();
                        Users[i] = Users[i].Split(' ')[0] + ' ' + Users[i].Split(' ')[1] + ' ' + NewSum;
                    }
                }
                using (StreamWriter FileWrite = new StreamWriter(FileUsers, false))
                {
                    foreach(string User in Users)
                    {
                        FileWrite.WriteLine(User);
                    }
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool add_match(string Team1, string Team2, string Date, string Coefficients)
        {
            string MatchNumber;
            try
            {
                using (StreamReader FileRead = new StreamReader(FileMatches))
                {
                    MatchNumber = (FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Count() + 1).ToString();
                }
                write_str_to_file(FileBet, MatchNumber + ' ' + Coefficients);
                write_str_to_file(FileMatches, MatchNumber + ' ' + Date + ' ' + Team1 + ' ' + Team2 + ' ' + "- 0 0");
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        public bool update_match(string MatchNumber, decimal FirstTeamGoals, decimal SecondTeamGoals)
        {
            try
            {

                string[] lines;
                using (StreamReader FileRead = new StreamReader(FileMatches))
                {
                    lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                }
                for (int i = 0; i < lines.Count(); i++)
                {
                    string[] Match = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Match[0] == MatchNumber && Match[4] == "-")
                    {
                        Match[4] = "+";
                        Match[5] = FirstTeamGoals.ToString();
                        Match[6] = SecondTeamGoals.ToString();
                        lines[i] = string.Join(" ", Match);
                        break;
                    }
                }
                using (StreamWriter FileWriter = new StreamWriter(FileMatches, false))
                {
                    foreach(string Match in lines)
                    {
                        FileWriter.WriteLine(Match);
                    }
                }
                using (StreamReader FileRead = new StreamReader(FileUserBets))
                {
                    lines = FileRead.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                }
                for(int i = 0; i < lines.Count(); i++)
                {
                    string[] Bet = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if(Bet[0] == MatchNumber)
                    {
                        bool isWin = false;
                        if(Bet[2] == "W1" && FirstTeamGoals > SecondTeamGoals)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "D" && FirstTeamGoals == SecondTeamGoals)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "W2" && FirstTeamGoals < SecondTeamGoals)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "T0" && FirstTeamGoals + SecondTeamGoals == 0)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "T1" && FirstTeamGoals + SecondTeamGoals == 1)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "T2" && FirstTeamGoals + SecondTeamGoals == 2)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "T3" && FirstTeamGoals + SecondTeamGoals == 3)
                        {
                            isWin = true;
                        }
                        if (Bet[2] == "T4Plus" && FirstTeamGoals + SecondTeamGoals > 3)
                        {
                            isWin = true;
                        }
                        if (isWin)
                        {
                            string coefficient = find_coefficient(MatchNumber, Bet[2]);
                            string ResultSum = (Convert.ToDecimal(Bet[3]) * Convert.ToDecimal(coefficient)).ToString("0.00");
                            update_user_money(Bet[1], get_resultSum(MatchNumber, Bet[2], Bet[3]));
                            Bet[4] = "WIN";
                        }
                        else
                        {
                            Bet[4] = "DEFEAT";
                        }
                        lines[i] = string.Join(" ", Bet);
                    }
                }
                using (StreamWriter FileWriter = new StreamWriter(FileUserBets, false))
                {
                    foreach (string UserBet in lines)
                    {
                        FileWriter.WriteLine(UserBet);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
