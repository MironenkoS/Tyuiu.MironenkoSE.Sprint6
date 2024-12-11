using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MironenkoSE.Sprint6.Task1.V25.Lib;
namespace Tyuiu.MironenkoSE.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_LVA.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_LVA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxAnswer_LVA.Text = "";
                textBoxAnswer_LVA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxAnswer_LVA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxAnswer_LVA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxAnswer_LVA.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }

                textBoxAnswer_LVA.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
