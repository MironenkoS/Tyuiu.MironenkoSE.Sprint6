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
        string path = @"D:\Programs\VisualStudio\Projects\repos\2024\Tyuiu.SosninFM.Sprint6\Sprint6Task6\InPutDataFileTask6V19.txt";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_SVA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_SVA.ColumnCount = 2;
            dataGridViewOutPut_SVA.Columns[0].Width = 20;
            dataGridViewOutPut_SVA.Columns[1].Width = 50;

            this.chartDiag_SVA.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chartDiag_SVA.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartDiag_SVA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_SVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SVA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        private void buttonHelp_SVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 5 âûïîëíèë ñòóäåíò ãðóïïû ÀÑÎèÓá 24-1 Ñîñíèí Ôåäîð Ìèõàéëîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_SAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}