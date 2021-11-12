using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_Low_Game
{
    
    public partial class frmHighLow : Form
    {

        public frmHighLow()
        {
            InitializeComponent();
        }

        private void frmHighLow_Load(object sender, EventArgs e)
        {
            
                        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnGuess.Enabled = true;
            txtGuess.Enabled = true;

            Random rnRandomNumber = new Random();
            intRandomNumber = rnRandomNumber.Next(0, 1000);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

        }

        private bool isNumberInt(string strInput)
        {
            try
            {
                int intvalue = int.Parse(strInput);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
