using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosModernCalculator
{
    public partial class Form1 : Form
    {
        float num1, ans;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        public void disable()   //Create One method to disable Calculator
        {
            // Follow are Disable when call we disable () function
            TxtBoxCalNum.Enabled = false;
            TxtBoxCalNum.Text = "";
            BtnOFF.Show();
            BtnON.Show();
            BtnZero.Enabled = false;
            BtnOne.Enabled = false;
            BtnTwo.Enabled = false;
            BtnThree.Enabled = false;
            BtnFour.Enabled = false;
            BtnFive.Enabled = false;
            BtnSix.Enabled = false;
            BtnSeven.Enabled = false;
            BtnEigth.Enabled = false;
            BtnNine.Enabled = false;
            
            BtnDivision.Enabled = false;
            BtnMultiplication.Enabled = false;
            BtnMinus.Enabled = false;
            BtnAddition.Enabled = false;
            BtnDecimal.Enabled = false;
            BtnPercentage.Enabled = false;
            BtnTotal.Enabled = false;

            BtnCE.Enabled = false;
            BtnClear.Enabled = false;
            BtnBackSpace.Enabled = false;
        }

        public void enable()   //Create One method to disable Calculator
        {
            // Follow are enablede when call we enable () function
            TxtBoxCalNum.Enabled = true;
            BtnOFF.Show();
            BtnON.Show();
            BtnZero.Enabled = true;
            BtnOne.Enabled = true;
            BtnTwo.Enabled = true;
            BtnThree.Enabled = true;
            BtnFour.Enabled = true;
            BtnFive.Enabled = true;
            BtnSix.Enabled = true;
            BtnSeven.Enabled = true;
            BtnEigth.Enabled = true;
            BtnNine.Enabled = true;

            BtnDivision.Enabled = true;
            BtnMultiplication.Enabled = true;
            BtnMinus.Enabled = true;
            BtnAddition.Enabled = true;
            BtnDecimal.Enabled = true;
            BtnPercentage.Enabled = true;
            BtnTotal.Enabled = true;

            BtnCE.Enabled = true;
            BtnClear.Enabled = true;
            BtnBackSpace.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TxtBoxCalNum.Text = "0";
        }

        private void TxtBoxCalNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnON_Click(object sender, EventArgs e)
        {
            enable();     //Call enable function() to turn on calculator
        }

        private void BtnOFF_Click(object sender, EventArgs e)
        {
            disable();   // Call Disable function() to turn off calculator
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            //Display Seven (7) in TextBox when press 7 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 7;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnEigth_Click(object sender, EventArgs e)
        {
            //Display Eigth (8) in TextBox when press 8 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 8;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            //Display Ninex (9) in TextBox when press 9 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 9;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }
      
        private void BtnFour_Click(object sender, EventArgs e)
        {
            //Display Four (4) in TextBox when press 4 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 4;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            //Display Five (5) in TextBox when press 5 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 5;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            //Display Six (6) in TextBox when press 6 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 6;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxCalNum.Clear();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            //Display One (1) in TextBox when press 1 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 1;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            //Display Two (2) in TextBox when press 2 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 2;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            //Display Three (3) in TextBox when press 3 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 3;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            //Display Zero (0)  in TextBox when press 0 button with Forest Green color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + 0;
            TxtBoxCalNum.ForeColor = Color.ForestGreen;
         }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if ((string.Compare(TxtBoxCalNum .Text, " ") < 0))
            {
                TxtBoxCalNum.Text = TxtBoxCalNum.Text.Substring(0, TxtBoxCalNum.TextLength - 1 + 1);
            }
            else
            {
                TxtBoxCalNum.Text = TxtBoxCalNum.Text.Substring(0, TxtBoxCalNum.TextLength - 1);
            }
        }

        //  int lenght = TxtBoxCalNum.Text - 1;
        //  string text = TxtBoxCalNum.Text;
        //  TxtBoxCalNum.clear();
        //     for (int i = 0; int < lenght; i++)
        //    TxtBoxCalNum.Text = TxtBoxCalNum.Text + text[int];

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            //Display dot(.) in TextBox when press dot(.) button with Red color
            TxtBoxCalNum.Text = TxtBoxCalNum.Text + ".";
            TxtBoxCalNum.ForeColor = Color.Red;
         }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            computing();  // call computing () function to perform arithmetic operation
            label1.Text = "";   // clear the text on the label
        }

        public void computing()
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(TxtBoxCalNum.Text);   // It performs Addition
                    TxtBoxCalNum.Text = ans.ToString();     // Converted Float into String
                    break;

                case 2:
                    ans = num1 - float.Parse(TxtBoxCalNum.Text);   // It performs Substraction
                    TxtBoxCalNum.Text = ans.ToString();     // Converted Float into String
                    break;

                case 3:
                    ans = num1 * float.Parse(TxtBoxCalNum.Text);   // It performs Multiplication
                    TxtBoxCalNum.Text = ans.ToString();     // Converted Float into String
                    break;

                case 4:
                    ans = num1 / float.Parse(TxtBoxCalNum.Text);   // It performs Division
                    TxtBoxCalNum.Text = ans.ToString();     // Converted Float into String
                    break;

                case 5:
                    ans = num1 + float.Parse(TxtBoxCalNum.Text)*100;   // It performs Percentage
                    TxtBoxCalNum.Text = ans.ToString();     // Converted Float into String
                    break;
            }
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TxtBoxCalNum.Text);
            TxtBoxCalNum.Clear();
            TxtBoxCalNum.Focus();     //Focus on thextbox after Clearing TextBox
            count = 1;     //count store case
            label1.Text = num1.ToString() + "+";   //Display text on label
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TxtBoxCalNum.Text);
            TxtBoxCalNum.Clear();
            TxtBoxCalNum.Focus();     //Focus on thextbox after Clearing TextBox
            count = 2;     //count store case
            label1.Text = num1.ToString() + "-";   //Display text on label
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TxtBoxCalNum.Text);
            TxtBoxCalNum.Clear();
            TxtBoxCalNum.Focus();     //Focus on thextbox after Clearing TextBox
            count = 3;     //count store case
            label1.Text = num1.ToString() + "x";   //Display text on label
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TxtBoxCalNum.Text);
            TxtBoxCalNum.Clear();
            TxtBoxCalNum.Focus();     //Focus on thextbox after Clearing TextBox
            count = 4;     //count store Switch case value
            label1.Text = num1.ToString() + "÷";   //Display text on label
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(TxtBoxCalNum.Text);
            TxtBoxCalNum.Clear();
            TxtBoxCalNum.Focus();     //Focus on thextbox after Clearing TextBox
            count = 5;     //count store case
            label1.Text = num1.ToString() + "%";   //Display text on label
        }
        
        private void BtnCE_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && TxtBoxCalNum.Text.Length > 0)
            {
                num1 = 0; TxtBoxCalNum.Clear();
            }
            else if (num1 > 0 && TxtBoxCalNum.TextLength > 0)
            {
                TxtBoxCalNum.Clear();
            }
        }
    }
}



