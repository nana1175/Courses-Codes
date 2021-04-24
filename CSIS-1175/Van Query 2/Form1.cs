using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Van_Query_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            var inputStr = InputTxtBx.Text.Trim().Replace(" ","").ToLower();
            
            //var uniqueStr = String.Join("", inputStr.Distinct());

            var resultDict = new Dictionary<char, int>();

            for(int i = 0; i < inputStr.Length; i++)
            {
                if (resultDict.ContainsKey(inputStr[i]))
                    resultDict[inputStr[i]]++;
                else
                    resultDict.Add(inputStr[i], 1);
            }

            string finalStr = "";

            foreach(KeyValuePair<char, int> kvp in resultDict)
            {
                finalStr += $"{kvp.Key} : {kvp.Value} \r\n";
            }

            ResultTxtBx.Text = finalStr;


        }
    }
}
