using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.SprintReview6.TaskReview.Lib;

namespace Tyuiu.LoginovMV.SprintReview6.TaskReview.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int k = 0;
            int l = 2;
            int c = 1;
            int res = ds.GetProiz(matrix, k, l, c);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
