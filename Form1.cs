using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDemo
{
    public partial class Form1 : Form
    {

        Calculator calculator = new Calculator();
        List<String> memorie = new List<String>();
        double operand = 0;
        int count = 0;
        int countEgal = 0;
        public Form1()
        {
            InitializeComponent();
            rezultatMare.Text = "0";
            rezultatMic.ResetText();
            if (memorie.Count() == 0)
            {
                button_vizionare_memorie.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "0";
            } else
                rezultatMare.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "1";
            } else
                rezultatMare.Text += "1";

        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "2";
            }
            else
                rezultatMare.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "3";
            }
            else
                rezultatMare.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "4";
            }
            else
                rezultatMare.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "5";
            }
            else
                rezultatMare.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "6";
            }
            else
                rezultatMare.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "7";
            }
            else
                rezultatMare.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "8";
            }
            else
                rezultatMare.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text == "0")
            {
                rezultatMare.ResetText();
                rezultatMare.Text = "9";
            }
            else
                rezultatMare.Text += "9";
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            rezultatMare.Text += ".";
            if (rezultatMare.Text.Contains("."))
            {
                button_virgula.Enabled = false;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            rezultatMare.Text = "0";
            rezultatMic.ResetText();
            count = 0;
            countEgal = 0;
            button_adaugare_memorie.Enabled = true;
            button_adunare.Enabled = true;
            button_egal.Enabled = true;
            button_radical.Enabled = true;
            button_ridicare_putere.Enabled = true;
            button_scadere.Enabled = true;
            button_impartire.Enabled = true;
            button_inmultire.Enabled = true;
            button_schimba_semn.Enabled = true;
            button_unu_impartit.Enabled = true;
            button_virgula.Enabled = true;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            rezultatMare.Text = rezultatMare.Text
                .Remove(rezultatMare.Text.Length - 1);

            if( rezultatMare.Text.Equals(string.Empty))
            {
                rezultatMare.Text = "0";
            }

            if (rezultatMare.Text.Contains("Invalid") || rezultatMare.Text.Contains("divide"))
            {
                rezultatMare.Text = "0";
                button_adaugare_memorie.Enabled = true;
                button_adunare.Enabled = true;
                button_egal.Enabled = true;
                button_radical.Enabled = true;
                button_ridicare_putere.Enabled = true;
                button_scadere.Enabled = true;
                button_impartire.Enabled = true;
                button_inmultire.Enabled = true;
                button_schimba_semn.Enabled = true;
                button_unu_impartit.Enabled = true;
                button_virgula.Enabled = true;
            }

            if (!rezultatMare.Text.Contains("."))
            {
                button_virgula.Enabled = true;
            }
        }

        private void button_schimba_semn_Click(object sender, EventArgs e)
        {
            calculator.Rezultat = Convert.ToDouble(rezultatMare.Text);
            rezultatMare.Text = Convert.ToString(calculator.SchimbaSemn());
        }

        private void button_ridicare_putere_Click(object sender, EventArgs e)
        {
            calculator.Rezultat = Convert.ToDouble(rezultatMare.Text);
            rezultatMare.Text = Convert.ToString(calculator.RidicareLaPutere());
        }

        private void button_radical_Click(object sender, EventArgs e)
        {
            if (rezultatMare.Text.Contains("-"))
            {
                rezultatMare.Text = "Invalid input";
                button_adaugare_memorie.Enabled = false;
                button_adunare.Enabled = false;
                button_egal.Enabled = false;
                button_radical.Enabled = false;
                button_ridicare_putere.Enabled = false;
                button_scadere.Enabled = false;
                button_impartire.Enabled = false;
                button_inmultire.Enabled = false;
                button_schimba_semn.Enabled = false;
                button_unu_impartit.Enabled = false;
                button_virgula.Enabled = false;
            }
            else
            {
                calculator.Rezultat = Convert.ToDouble(rezultatMare.Text);
                rezultatMare.Text = Convert.ToString(calculator.Radical());
            }
        }


        private void button_unu_impartit_Click(object sender, EventArgs e)
        {
            if (!rezultatMare.Text.Equals("0"))
            {
                calculator.Rezultat = Convert.ToDouble(rezultatMare.Text);
                rezultatMare.Text = Convert.ToString(calculator.UnuImpartit());
            }
            else
            {
                rezultatMare.Text = "Cannot divide by zero!";
                button_adaugare_memorie.Enabled = false;
                button_adunare.Enabled = false;
                button_egal.Enabled = false;
                button_radical.Enabled = false;
                button_ridicare_putere.Enabled = false;
                button_scadere.Enabled = false;
                button_impartire.Enabled = false;
                button_inmultire.Enabled = false;
                button_schimba_semn.Enabled = false;
                button_unu_impartit.Enabled = false;
                button_virgula.Enabled = false;
            }
                
            
        }

        private void button_modul_Click(object sender, EventArgs e)
        {
            Console.WriteLine("%");
        }

        private void button_adaugare_memorie_Click(object sender, EventArgs e)
        {
            memorie.Add(rezultatMare.Text);
            button_vizionare_memorie.Enabled = true;
        }

        private void button_vizionare_memorie_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!(memorie.Count() == 0))
            {
                message = "Here are the numbers you have saved in memory:\n";
                for (int i = 0; i < memorie.Count(); i++)
                {
                    message += memorie[i] + ", ";
                }
            }
            else
            {
                message = "You did not add any number to the memory.\nPress `MEM` to add numbers!";
            }
                string title = "Memory";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
        }

        private void button_impartire_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                rezultatMic.Text = rezultatMare.Text + " /";
                rezultatMare.Text = "0";
                count += 1;
            }
            else
            {
                if(rezultatMare.Text == "0" || rezultatMare.Text.Count() < 1 || rezultatMare.Text.Contains("divide"))
                {
                    rezultatMare.Text = "Cannot divide by zero!";
                    button_adaugare_memorie.Enabled = false;
                    button_adunare.Enabled = false;
                    button_egal.Enabled = false;
                    button_radical.Enabled = false;
                    button_ridicare_putere.Enabled = false;
                    button_scadere.Enabled = false;
                    button_impartire.Enabled = false;
                    button_inmultire.Enabled = false;
                    button_schimba_semn.Enabled = false;
                    button_unu_impartit.Enabled = false;
                    button_virgula.Enabled = false;
                } else
                {
                    calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                    operand = Convert.ToDouble(rezultatMare.Text);
                    rezultatMic.Text = Convert.ToString(calculator.Imparte(operand)) + " /";
                    rezultatMare.Text = rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '));
                }
                
            }
            Console.WriteLine("/");
        }

        private void button_inmultire_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                rezultatMic.Text = rezultatMare.Text + " *";
                rezultatMare.Text = "0";
                count += 1;
            }
            else
            {
                rezultatMare.Text.Remove(0, 1);
                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                operand = Convert.ToDouble(rezultatMare.Text);
                rezultatMic.Text = Convert.ToString(calculator.Inmulteste(operand)) + " *";
                rezultatMare.Text = rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '));
            }
            Console.WriteLine("*");
        }

        private void button_scadere_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                rezultatMic.Text = rezultatMare.Text + " -";
                rezultatMare.Text = "0";
            }
            else
            {
                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                operand = Convert.ToDouble(rezultatMare.Text);
                rezultatMic.Text = Convert.ToString(calculator.Scade(operand)) + " -";
                rezultatMare.Text = rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '));
            }
            Console.WriteLine("-");
        }

        private void button_adunare_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                rezultatMic.Text = rezultatMare.Text + " +";
                rezultatMare.Text = "0";
                count += 1;
            
            } else
            {
                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                operand = Convert.ToDouble(rezultatMare.Text);
                rezultatMic.Text = Convert.ToString(calculator.Aduna(operand)) + " +";
                rezultatMare.Text = rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '));
            }
            Console.WriteLine("+");
        }

        private void button_egal_Click(object sender, EventArgs e)
        {
            if (!rezultatMic.Text.Equals(string.Empty))
            {
                string operation = rezultatMic.Text.Substring(rezultatMic.Text.IndexOf(' '), 2).Trim();

                switch (operation)
                {
                    case "+":
                        if (countEgal == 0)
                        {
                            if (!rezultatMic.Text.Contains("="))
                            {
                                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                                rezultatMic.Text += " " + rezultatMare.Text + " =";
                                rezultatMare.Text = Convert.ToString(calculator.Aduna(Convert.ToDouble(rezultatMare.Text)));
                            }
                            else
                                Console.WriteLine(rezultatMic.Text.Replace('=', '+'));
                        }
                        else
                        {
                            rezultatMic.Text = ReplaceFirst(rezultatMic.Text, rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                            , rezultatMare.Text);
                            calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                            Console.WriteLine(calculator.Rezultat);
                            rezultatMare.Text = Convert.ToString(calculator.Aduna(Convert.ToDouble
                                (rezultatMic.Text.Substring(rezultatMic.Text.IndexOf('+') + 1
                                , rezultatMic.Text.LastIndexOf(' ') - rezultatMic.Text.IndexOf('+')).Trim())));
                        }
                        countEgal++;
                        break;
                    case "-":
                        if (countEgal == 0)
                        {
                            if (!rezultatMic.Text.Contains("="))
                            {
                                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                            rezultatMic.Text += " " + rezultatMare.Text + " =";
                            rezultatMare.Text = Convert.ToString(calculator.Scade(Convert.ToDouble(rezultatMare.Text)));
                            }
                            else
                                rezultatMic.Text.Replace('=', '-');
                }
                        else
                        {
                            rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                            , rezultatMare.Text);
                            calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                            Console.WriteLine(calculator.Rezultat);
                            rezultatMare.Text = Convert.ToString(calculator.Scade(Convert.ToDouble
                                (rezultatMic.Text.Substring(rezultatMic.Text.IndexOf('-') + 1
                                , rezultatMic.Text.LastIndexOf(' ') - rezultatMic.Text.IndexOf('-')).Trim())));
                        }
                        countEgal++;
                        break;
                    case "*":
                        if (countEgal == 0)
                        {
                            if (!rezultatMic.Text.Contains("="))
                            {
                                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                                rezultatMic.Text += " " + rezultatMare.Text + " =";
                                rezultatMare.Text = Convert.ToString(calculator.Inmulteste(Convert.ToDouble(rezultatMare.Text)));
                            }
                            else
                                rezultatMic.Text.Replace('=', '*');
                            
                        }
                        else
                        {
                            rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                            , rezultatMare.Text);
                            calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                            Console.WriteLine(calculator.Rezultat);
                            rezultatMare.Text = Convert.ToString(calculator.Scade(Convert.ToDouble
                                (rezultatMic.Text.Substring(rezultatMic.Text.IndexOf('*') + 1
                                , rezultatMic.Text.LastIndexOf(' ') - rezultatMic.Text.IndexOf('*')).Trim())));
                        }
                        countEgal++;
                        break;
                    case "/":
                        if (countEgal == 0)
                        {
                            if (!rezultatMic.Text.Contains("="))
                            {
                                if (!rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim().Equals("0"))
                                {
                                    calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                                    rezultatMic.Text += " " + rezultatMare.Text + " =";
                                    rezultatMare.Text = Convert.ToString(calculator.Imparte(Convert.ToDouble(rezultatMare.Text)));
                                }
                                else
                                {
                                    rezultatMare.Text = "Cannot divide by 0";
                                }
                            }else
                                rezultatMic.Text.Replace('=', '/');

                        }
                        else
                        {
                  
                            if (!rezultatMic.Text.Substring(rezultatMic.Text.IndexOf('/') + 1
                                , rezultatMic.Text.LastIndexOf(' ') - rezultatMic.Text.IndexOf('/')).Trim().Equals("0"))
                            {
                                rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                                , rezultatMare.Text);
                                calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                                Console.WriteLine(calculator.Rezultat);
                                rezultatMare.Text = Convert.ToString(calculator.Scade(Convert.ToDouble
                                (rezultatMic.Text.Substring(rezultatMic.Text.IndexOf('/') + 1
                                , rezultatMic.Text.LastIndexOf(' ') - rezultatMic.Text.IndexOf('/')).Trim())));
                            }
                            else
                            {
                                rezultatMare.Text = "Cannot divide by 0";
                            }
                        }
                        countEgal++;
                        break;
                }
            }
            else
            {
                rezultatMic.Text = rezultatMare.Text + " =";
            }
        }

            private void info_Click(object sender, EventArgs e)
        {
            string message = "You have discovered an Easter Egg!\nThis calculator is created entirely by Claudiu Furtea!" +
                "\nhttps://github.com/clauf14\n© All rights reserved!";
            string title = "Easter Egg";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
        }

        private void button_adaugare_Leave_Focus(object sender, EventArgs e)
        {
            //count = 0;
        }

        private void button_scadere_Leave_Focus(object sender, EventArgs e)
        {
            //count = 0;
        }

        private void button_inmultire_Leave_Focus(object sender, EventArgs e)
        {
            //count = 0;
        }

        private void button_impartire_Leave_Focus(object sender, EventArgs e)
        {
            //count = 0;
        }

        private void button_egal_Leave_Focus(object sender, EventArgs e)
        {
            countEgal = 0;
        }

        private void button_adaugare_memorie_Leave_Focus(object sender, EventArgs e)
        {
            //countEgal = 0;
        }

        public static string ReplaceFirst(string str, string term, string replace)
        {
            int position = str.IndexOf(term);
            if (position < 0)
            {
                return str;
            }
            str = str.Substring(0, position) + replace + str.Substring(position + term.Length);
            return str;
        }

    }

}
