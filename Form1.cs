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
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            rezultatMare.Text = rezultatMare.Text
                .Remove(rezultatMare.Text.Length - 1);

            if(rezultatMare.Text.Contains("divide"))
            {
                rezultatMare.Text = "0";
            }

            if(rezultatMare.Text.Equals(string.Empty))
            {
                rezultatMare.Text = "0";
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
            calculator.Rezultat = Convert.ToDouble(rezultatMare.Text);
            rezultatMare.Text = Convert.ToString(calculator.Radical());
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
            }
                
            
        }

        private void button_modul_Click(object sender, EventArgs e)
        {
            Console.WriteLine("%");
        }

        private void button_adaugare_memorie_Click(object sender, EventArgs e)
        {
            memorie.Add(rezultatMare.Text);
            Console.WriteLine(rezultatMare.Text + " added to memory!");
            countEgal = 1;
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
                message = "You did not add any number to the memory.\nPress `MEM` to add numbers!";
            string title = "Memory";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
        }

        private void button_impartire_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                rezultatMic.Text = rezultatMare.Text + " /";
                rezultatMare.ResetText();
                count += 1;
            }
            else
            {
                if(rezultatMare.Text == "0" || rezultatMare.Text.Count() < 1 || rezultatMare.Text.Contains("divide"))
                {
                    rezultatMare.Text = "Cannot divide by zero!";
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
                rezultatMare.ResetText();
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
                rezultatMare.ResetText();
                count += 1;
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
                rezultatMare.ResetText();
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
            string operation = rezultatMic.Text.Substring(rezultatMic.Text.IndexOf(' '), 2).Trim();

            switch (operation)
            {
                case "+":
                    if (countEgal == 0)
                    {
                        calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                        rezultatMic.Text += " " + rezultatMare.Text + "=";
                        rezultatMare.Text = Convert.ToString(calculator.Aduna(Convert.ToDouble(rezultatMare.Text)));
                    }
                    else
                    {
                        rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                        , rezultatMare.Text);
                        calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                        Console.WriteLine(calculator.Rezultat);
                        rezultatMare.Text = Convert.ToString(calculator.Aduna(Convert.ToDouble
                            (rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim())));
                    }
                    countEgal++;
                    break;
                case "-":
                    if (countEgal == 0)
                    {
                        calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                        rezultatMic.Text += " " + rezultatMare.Text + "=";
                        rezultatMare.Text = Convert.ToString(calculator.Scade(Convert.ToDouble(rezultatMare.Text)));
                    }
                    else
                    {
                        rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                        , rezultatMare.Text);
                        calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                        Console.WriteLine(calculator.Rezultat);
                        rezultatMare.Text = Convert.ToString(calculator.Scade(Convert.ToDouble
                            (rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim())));
                    }
                    countEgal++;
                    break;
                case "*":
                    if (countEgal == 0)
                    {
                        calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                        rezultatMic.Text += " " + rezultatMare.Text + "=";
                        rezultatMare.Text = Convert.ToString(calculator.Inmulteste(Convert.ToDouble(rezultatMare.Text)));
                    }
                    else
                    {
                        rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                        , rezultatMare.Text);
                        calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                        Console.WriteLine(calculator.Rezultat);
                        rezultatMare.Text = Convert.ToString(calculator.Inmulteste(Convert.ToDouble
                            (rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim())));
                    }
                    countEgal++;
                    break;
                case "/":
                    if (countEgal == 0)
                    {
                        
                        if (!rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim().Equals("0"))
                        {
                            calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                            rezultatMic.Text += " " + rezultatMare.Text + "=";
                            rezultatMare.Text = Convert.ToString(calculator.Imparte(Convert.ToDouble(rezultatMare.Text)));
                        }
                        else
                        {
                            rezultatMare.Text = "Cannot divide by 0";
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine(rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim());
                        if (!rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim().Equals("0")){
                            rezultatMic.Text = rezultatMic.Text.Replace(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' '))
                            , rezultatMare.Text);
                            calculator.Rezultat = Convert.ToDouble(rezultatMic.Text.Substring(0, rezultatMic.Text.IndexOf(' ')));
                            Console.WriteLine(calculator.Rezultat);
                            rezultatMare.Text = Convert.ToString(calculator.Imparte(Convert.ToDouble
                                (rezultatMic.Text.Substring(rezultatMic.Text.LastIndexOf(' '), 2).Trim())));
                        } else
                        {
                            rezultatMare.Text = "Cannot divide by 0";
                        }
                    }
                    countEgal++;
                    break;
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
           //rezultatMare.ResetText();
        }

        private void button_scadere_Leave_Focus(object sender, EventArgs e)
        {
           //rezultatMare.ResetText();
        }

        private void button_inmultire_Leave_Focus(object sender, EventArgs e)
        {
             //rezultatMare.ResetText();
        }

        private void button_impartire_Leave_Focus(object sender, EventArgs e)
        {
           //rezultatMare.ResetText();
        }

        private void button_egal_Leave_Focus(object sender, EventArgs e)
        {
            countEgal = 0;
        }

        private void button_adaugare_memorie_Leave_Focus(object sender, EventArgs e)
        {
            countEgal = 0;
        }
    }
}
