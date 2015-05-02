using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace StringManipulatingApp
{
    public partial class Form1 : Form
    {
        //delegate for the method change to capital
        public delegate string StringChange(string input);
        public StringChange stringChange;
        //delegate for the second method dash to underscore
        //public delegate string 
        public Form1()
        {
            InitializeComponent();
        }
        public void Change(StringChange changeVariable)
        {
            stringChange = new StringChange(changeVariable);
            richTextBoxOut.Text = stringChange(richTextBoxIn.Text);
        }
        public string ChangeToCapital(string input)
        {
            //char[] arr1 = str.ToCharArray(); or: string s = new string (arr1);
            char[] arr1 = input.ToCharArray();
            int l = arr1.Length;
            string[] auxArr1 = new string[l];
            for (int i = 0; i < arr1.Length; i++)
			{
                auxArr1[i] = arr1[i].ToString().ToUpper();
			}
            string capitalArr = string.Join("",auxArr1);
            return capitalArr;
        }
        //public string RemoveVowels(string input)
        //{
        //    char[] arr1 = input.ToCharArray();
        //    int l = arr1.Length;
        //    string[] auxArr1 = new string[l];
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (arr1[i] == 'a'|| arr1[i] == 'e' || arr1[i] =='o'||arr1[i] =='u'||arr1[i] == 'i'||arr1[i] =='y')
        //        {
        //            auxArr1[i] = "";
        //        }
        //        else
        //        {
        //            auxArr1[i] = arr1[i].ToString();
        //        }
        //    }
        //    string stringArr = string.Join("", auxArr1);
        //    return stringArr;
        //}

        /*
         * this is a linq query that selects all the characters from a string where the character is 
         * not contained in the vowels string (that is the Where part) - the ToArray() is putting all 
         * these characters in an array and is necessary since one of the string constructor overloads 
         * takes a character array as input (but doesn't work with an enumeration)
         */
        public string RemoveVowels(string input)
        {
            string vowels = "AaEeIiOoUuYy";
            input = new string(input.Where(c => !vowels.Contains(c)).ToArray());
            return input;
        }

        /*
         * Method to uppercase first letters
         */

        public string UppercaseWords(string input)
        {
            char[] arr1 = input.ToCharArray();
            //it the array is longer than 1
            if (arr1.Length >= 1)
            {
                //if the first letter is lower case
                if (char.IsLower(arr1[0]))
                {
                    //transform the first letter from lower to uppercase 
                    arr1[0] = char.ToUpper(arr1[0]);
                }
            }
            //Scan the letters, checking for spaces between the words
            //if there is space check if the next letter is lower case and change it to upper case.
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i - 1] == ' ')
                //if (arr1[i] == ' ')
                {
                    if (char.IsLower(arr1[i]))
                    {
                        arr1[i] = char.ToUpper(arr1[i]);
                    }
                }
            }
            return new string(arr1);
        }
        public string ChangeSpaceToUnderscore(string input)
        {
            return input.Replace('-', '_');
        }

        private void btnToCapitals_Click(object sender, EventArgs e)
        {
            Change(ChangeToCapital);
        }
        private void btnDashToUnderscore_Click(object sender, EventArgs e)
        {
            Change(ChangeSpaceToUnderscore);
        }

        private void btnRemoveVowels_Click(object sender, EventArgs e)
        {
            Change(RemoveVowels);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change(UppercaseWords);
        }
    }
}
