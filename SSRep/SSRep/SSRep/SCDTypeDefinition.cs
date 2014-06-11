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

namespace SSRep
{
    public partial class SCDTypeDefinition : Form
    {
        private static readonly string _path_scdType1 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_1.txt";
        private static readonly string _path_scdType2 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_2.txt";
   
        public SCDTypeDefinition()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
         
            if (cbSCDType.Text.ToLower() == "scd type 1") { 

                //create scd type 1 file
                WriteSCDType1();
               
            }
            if (cbSCDType.Text.ToLower() == "scd type 2")
            {
                //create scd type 2 file
                WriteSCDType2();
               
            }
            //read scd types
            ReadSCD_Types();
            rtb_InputSCDType.Text = string.Empty;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SCDTypeValidation(){
            if (cbSCDType.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void WriteSCDType1() {

            if (!File.Exists(_path_scdType1))
            {
                File.Create(_path_scdType1);
            }
            if (File.Exists(_path_scdType1))
            {
                string content =InputProccesing(rtb_InputSCDType.Text);
                using (var sw = new StreamWriter(_path_scdType1))
                {
                    sw.Write(content);
                }

            }
        }

        private void WriteSCDType2()
        {
           if (!File.Exists(_path_scdType2))
            {
                File.Create(_path_scdType2);
            }
            if (File.Exists(_path_scdType2))
            {
                string content = InputProccesing(rtb_InputSCDType.Text);
                using (var sw = new StreamWriter(_path_scdType2))
                {
                    sw.Write(content);
                }

            }
        }
        /// <summary>
        /// To do some thing on this function
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        private string InputProccesing(string inputStr) {

            //to do some thing
            return inputStr;
        }

        private void ReadSCD_Types() {
           
            rtb_ReadSCDType.Text = "\n----------------SCD Type 1------------------\n";
          
            if (File.Exists(_path_scdType1))
            {

                rtb_ReadSCDType.Text += File.ReadAllText(_path_scdType1);
            }
            rtb_ReadSCDType.Text += "\n----------------SCD Type 2------------------\n";

            if (File.Exists(_path_scdType2))
            {
                rtb_ReadSCDType.Text += File.ReadAllText(_path_scdType2);
              
            }
        }

   
    }
}
