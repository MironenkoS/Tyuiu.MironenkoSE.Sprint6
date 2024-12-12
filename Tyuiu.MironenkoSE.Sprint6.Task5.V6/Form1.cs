using Tyuiu.MironenkoSE.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MironenkoSE.Sprint6.Task5.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\664\source\repos\Tyuiu.MironenkoSE.Sprint6\Sprint6Task6\InPutDataFileTask5V6.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewOutPut_KRV.ColumnCount = 2;
            dataGridViewOutPut_KRV.Columns[0].Width = 20;
            dataGridViewOutPut_KRV.Columns[1].Width = 50;

            this.chartDiagr_KRV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagr_KRV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagr_KRV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_KRV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagr_KRV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_KRV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonWiki_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Хасанов Ренат Владиславович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
        }
    }
}
