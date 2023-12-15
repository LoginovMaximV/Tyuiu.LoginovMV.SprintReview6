using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.LoginovMV.SprintReview6.TaskReview.Lib
{
    public class DataService
    {
        public int GetProiz(int[,] matrix,int k, int l, int c)
        {
            int proiz = 1;
            if (k > l || k < 0 || l >= matrix.GetLength(0))
            {
                throw new ArgumentException("Invalid indices");
            }

            for (int i = k; i <= l; i++)
            {
                int element = matrix[i, c];

                // Если элемент четный
                if (element % 2 == 0)
                {
                    proiz *= element;
                }
            }

            return proiz;
        }
    }
}
