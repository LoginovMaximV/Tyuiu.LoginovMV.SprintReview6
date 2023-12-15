using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.SprintReview6.TaskReview.Lib;

namespace Tyuiu.LoginovMV.SprintReview6.TaskReview
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_LMV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_LMV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_LMV.ColumnCount = 38;
            dataGridViewInPut_LMV.RowCount = 38;
            panelLeft_LMV.Width = this.Width / 2;

            for (int i = 0; i < 38; i++)
            {
                dataGridViewInPut_LMV.Columns[i].Width = 25;
            }

        }

        private void buttonAbout_LMV_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        

        private void buttonOpenFile_LMV_Click(object sender, EventArgs e)
        { 
            
        }

        private void textBoxN_LMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN_LMV.Text);
            int m = Convert.ToInt32(textBoxM_LMV.Text);
            int c = Convert.ToInt32(textBoxС_LMV.Text);
            int n1 = Convert.ToInt32(textBoxStart_LMV.Text);
            int n2 = Convert.ToInt32(textBoxStop_LMV.Text);
            int k = Convert.ToInt32(textBoxK_LMV.Text);
            int l = Convert.ToInt32(textBoxL_LMV.Text);
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = rnd.Next(n1, n2+1);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j - 1] * matrix[i, j - 1];
                    }
                }
            }

            dataGridViewInPut_LMV.RowCount = n;
            dataGridViewInPut_LMV.ColumnCount = m;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <m; j++)
                {
                    dataGridViewInPut_LMV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            try
            {
                textBoxRes_LMV.Text = Convert.ToString(ds.GetProiz(matrix, k, l, c));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
