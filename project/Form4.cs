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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.PUMP_SET_STATE = true;

            string SetStartTime = setData1.Text;
            string SetEndTime = setData2.Text;

            string[] ParsingStartData = SetStartTime.Split(':');
            string[] ParsingEndData = SetEndTime.Split(':');

            Form1.PUMP_StartHour = Convert.ToInt32(ParsingStartData[0]);
            Form1.PUMP_StartMin = Convert.ToInt32(ParsingStartData[1]);

            Form1.PUMP_EndHour = Convert.ToInt32(ParsingEndData[0]);
            Form1.PUMP_EndMin = Convert.ToInt32(ParsingEndData[1]);
        }
    }
}
