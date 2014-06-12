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
        private static readonly string PathSCDType1 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_1.txt";
        private static readonly string PathSCDType2 = Application.ExecutablePath + @"\..\..\..\SCD_Type\scd_type_2.txt";


        #region "Events"
        private void btSave_Click(object sender, EventArgs e)
        {

            if (cbSCDType.Text.ToLower() == "scd type 1")
            {

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

        private void SCDTypeDefinition_Load(object sender, EventArgs e)
        {


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSCDType_TextChanged(object sender, EventArgs e)
        {
            if (cbSCDType.Text.ToLower() == "scd type 1")
            {
                InputSCDType1();

            }
            if (cbSCDType.Text.ToLower() == "scd type 2")
            {
                InputSCDType2();
            }
        }
        #endregion

        #region "Methods"
       
        public IEnumerable<Table> Columns
        {
            get; set;
        }

        public IEnumerable<Table> PKColumns
        {
            get;
            set;
        }

        public SCDTypeDefinition()
        {
            InitializeComponent();
        }
            
        private void InputSCDType1()
        {
            string str = null;
            int i = 0;
            if (Columns != null)
                foreach (var it in Columns)
                {
                    str += it.ColumnName;
                    if (i + 1 < Columns.Count())
                    {
                        str += ';';
                    }
                    i = i + 1;
                    str += "\n";
                }
            rtb_InputSCDType.Text = str;
        }

        private void InputSCDType2()
        {
            string str = null;
            int i = 0;
            if (Columns != null)
                foreach (var it in PKColumns)
                {
                    str += it.ColumnName;
                    if (i + 1 < PKColumns.Count())
                    {
                        str += ';';
                    }
                    i = i + 1;
                    str += "\n";
                }
            rtb_InputSCDType.Text = str;
        }
               
        private bool SCDTypeValidation(){
            if (cbSCDType.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void WriteSCDType1() {

            if (!File.Exists(PathSCDType1))
            {
                File.Create(PathSCDType1);
            }
            if (File.Exists(PathSCDType1))
            {
                string content =InputProccesing(rtb_InputSCDType.Text);
                using (var sw = new StreamWriter(PathSCDType1))
                {
                    sw.Write(content);
                }

            }
        }

        private void WriteSCDType2()
        {
           if (!File.Exists(PathSCDType2))
            {
                File.Create(PathSCDType2);
            }
            if (File.Exists(PathSCDType2))
            {
                string content = InputProccesing(rtb_InputSCDType.Text);
                using (var sw = new StreamWriter(PathSCDType2))
                {
                    sw.Write(content);
                }

            }
        }
      
        private string InputProccesing(string inputStr)
        {
            inputStr = inputStr.Replace(Convert.ToChar(","), Convert.ToChar(";"));
            inputStr = inputStr.Replace("[", string.Empty);
            inputStr = inputStr.Replace("]", string.Empty);
            
            return inputStr;
        }

        private void ReadSCD_Types() {
           
            rtb_ReadSCDType.Text = "\n----------------SCD Type 1------------------\n";
          
            if (File.Exists(PathSCDType1))
            {

                rtb_ReadSCDType.Text += File.ReadAllText(PathSCDType1);
            }
            rtb_ReadSCDType.Text += "\n----------------SCD Type 2------------------\n";

            if (File.Exists(PathSCDType2))
            {
                rtb_ReadSCDType.Text += File.ReadAllText(PathSCDType2);
              
            }
        }
        #endregion
        
    }
}
