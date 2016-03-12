using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplineNS;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestSpline
{
    [TestClass]
    public class UnitTestSpline
    {
        Random Random { get; set; }
        Spline Splayn { get; set; }
        double[] NewX { get; set; }
        double[] NewY { get; set; }
        SortedList<double, double> Grid;
        int N { get; set; }
        [TestInitialize]
        public void Init()
        {
            N = 100;
            Random = new Random(10000);
            NewX = new double[N];
            NewY = new double[N];
            Grid = new SortedList<double, double>();
            for (int i = 0; i < N; i++)
            {
                Grid.Add(i, Random.NextDouble());
                NewX[i] = i+0.5;
            }
            Splayn = new Spline(Grid);
        }
        [TestMethod]
        public void TestmetodSplineRepeat100()
        {
            TestMetodSpline(100);
        }
        [TestMethod]
        public void TestmetodSplineRepeat1000()
        {
            TestMetodSpline(1000);
        }
        [TestMethod]
        public void TestmetodSplineRepeat10000()
        {
            TestMetodSpline(10000);
        }
        public void TestMetodSpline(int M)
        {
            for (int i = 0; i < M; i++)
            {
                for(int j=0;j< N; j++)
                {
                    NewY[j] = Splayn.InterpolationPoint(NewX[j],N);
                }
            }
        }
    }
}
