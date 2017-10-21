using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            double currLvl = 0;
            double tarLvl = 0;
            double currExp = 0;
            double expSmaple = 0;
            string errMsg = "";

            try
            {
                currLvl = double.Parse(txtCurrLvl.Text);
                tarLvl = double.Parse(txtTargetLvl.Text);
                currExp = double.Parse(txtTotalExp.Text);
                expSmaple = double.Parse(txtExpSample.Text);
            }
            catch (Exception ex)
            {
                errMsg = "Please enter valid information in the textboxes." + Environment.NewLine;

            }
            double totalExp = 0;
            double neededExp = 0;
            double days = 0;
            double hours = 0;
            double minutes = 0;
            double seconds = 0;
            double totalHours = 0;

            double arrExp = 0;
            double arrExpCurr = 0;
            int[] expInfo = {0, 15, 34, 57, 92, 135, 372, 560, 840, 1242, 1716, 2360, 3216, 4200, 5460, 7050, 8840,
        11040, 13716, 16680, 20216, 24402, 28980, 34320, 40512, 47216, 54900, 63666, 73080, 83720, 95700, 108480,
        122760, 138666, 155540, 174216, 194832, 216600, 240500, 266682, 294216, 324240, 356916, 391160, 428280, 468450,
        510420, 555680, 604416, 655200, 709716, 748608, 789631, 832902, 878545, 926689, 977471, 1031036, 1087536,
        1147032, 1209994, 1276301, 1346242, 1420016, 1497832, 1579913, 1666492, 1757815, 1854143, 1955750, 2062925,
        2175973, 2295216, 2420993, 2553663, 2693603, 2841212, 2996910, 3161140, 3334370, 3517093, 3709829, 3913127,
        4127566, 4353756, 4592341, 4844001, 5109452, 5389449, 5684790, 5996316, 6324914, 6671519, 7037118, 7422752,
        7829518, 8258575, 8711144, 9188514, 9692044, 10223168, 10783397, 11374327, 11997640, 12655110, 13348610,
        14080113, 14851703, 15665576, 16524049, 17429566, 18384706, 19392187, 20454878, 21575805, 22758159, 24005306,
        25320796, 26708375, 28171993, 29715818, 31344244, 33061908, 34873700, 36784778, 38800583, 40926854, 43169645,
        45535341, 48030677, 50662758, 53439077, 56367538, 59456479, 62714694, 66151459, 69776558, 73600313, 77633610,
        81887931, 86375389, 91108760, 96101520, 101367883, 106992842, 112782213, 118962678, 125481832, 132358236,
        139611467, 147262175, 155332142, 163844343, 172823012, 182293713, 192283408, 202820538, 213935103, 225658746,
        238024845, 251068606, 264827165, 279339639, 294647508, 310794191, 327825712, 345790561, 364739883, 384727628,
        405810702, 428049128, 451506220, 476248760, 502347192, 529875818, 558913012, 589541445, 621848316, 655925603,
        691870326, 729784819, 769777027, 811960808, 856456260, 903390063, 952895838, 1005114529, 1060194805,
        1118293480, 1179575962, 1244216724, 1312399800, 1384319309, 1460180007, 1540197871, 1624600714, 1713628833,
        1807535693, 1906558648, 2011069705, 2121276324 };

            if(expSmaple < 20) {
                errMsg += "Please enter a valid epm sample!";
            }
            if (errMsg == "") {
                if (tarLvl < 201 && tarLvl > currLvl)
                {                    
                
                for (int i = 0; i < tarLvl; i++)
                {              
                        arrExp += expInfo[i];
                
                }
                for (int i = 0; i < currLvl; i++)
                {
                        arrExpCurr += expInfo[i];

                }

                totalExp = arrExp;
                neededExp = totalExp - (arrExpCurr + currExp);            
                totalHours = (neededExp / (expSmaple * 60));
                if (totalHours > 24)
                {
                    
                    
                    var timeSpan = TimeSpan.FromHours(totalHours);                       
                    days = timeSpan.Days;    
                    hours = timeSpan.Hours;
                    minutes = timeSpan.Minutes;
                    seconds = timeSpan.Seconds;               
                    txtOutput.Text += "Total time: "+ days + " day(s) " + hours + " hour(s) " + minutes + " minute(s) " +  seconds + " second(s) " +Environment.NewLine;
                }
                else
                {
                    var timeSpan = TimeSpan.FromHours(totalHours);
                    hours = timeSpan.Hours;
                    minutes = timeSpan.Minutes;
                    seconds = timeSpan.Seconds;
                    txtOutput.Text += "Total time: " + hours + " hour(s) " + minutes + " minute(s) " + seconds + " second(s) " + Environment.NewLine;
                } 
                txtOutput.Text += "Total exp from level: " + currLvl + " to " + tarLvl +": "+ String.Format("{0:n0}", neededExp) + Environment.NewLine;
                txtOutput.Text += "Exp per hour: " + String.Format("{0:n0}",(expSmaple * 60)) + Environment.NewLine;
                }
            }
            else
            {
                txtOutput.Text = "Something went wrong!. Please re-enter information" + Environment.NewLine;
                txtOutput.Text = errMsg;
                    
            }
            
        }
    }
}
