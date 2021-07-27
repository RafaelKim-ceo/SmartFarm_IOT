using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCirculatorSet_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SetStartTime = setData1.Text;
            string SetEndTime = setData2.Text;

            string[] ParsingStartData = SetStartTime.Split(':');
            string[] ParsingEndData = SetEndTime.Split(':');

            Form1.Circulate_StartHour = Convert.ToInt32(ParsingStartData[0]);
            Form1.Circulate_StartMin = Convert.ToInt32(ParsingStartData[1]);

            Form1.Circulate_EndHour = Convert.ToInt32(ParsingEndData[0]);
            Form1.Circulate_EndMin = Convert.ToInt32(ParsingEndData[1]);
        }
    }
}
