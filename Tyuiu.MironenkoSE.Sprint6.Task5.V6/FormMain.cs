using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MironenkoSE.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MironenkoSE.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\664\source\repos\Tyuiu.MironenkoSE.Sprint6\Sprint6Task6\InPutDataFileTask5V6.txt";
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
