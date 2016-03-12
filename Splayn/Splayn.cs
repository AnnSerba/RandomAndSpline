using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplineNS
{
    public class SplineTuple
    {
        public double a, b, c, d, x;
        public SplineTuple(double x, double a,double c)
        {
            this.x = x;
            this.a = a;
            this.c = c;
        }
    }
    public class Spline
    {
        public SplineTuple[] splines; 
        public Spline(SortedList<double,double> grid)
        {
            // Инициализация массива сплайнов
            splines = new SplineTuple[grid.Count];
            double[] c = MethodSweep(grid);
            for (int i = 0; i < grid.Count; i++)
            {
                splines[i] = new SplineTuple(grid.Keys[i], grid.Values[i],c[i]);
            }
            splines.Initialize();
            // По известным коэффициентам c[i] находим значения b[i] и d[i]
            for (int i = grid.Count - 1; i > 0; --i)
            {
                double h_i = grid.Keys[i] - grid.Keys[i - 1];
                splines[i].d = (splines[i].c - splines[i - 1].c) / h_i;
                splines[i].b = h_i * (2.0 * splines[i].c + splines[i - 1].c) / 6.0 + (grid.Values[i] - grid.Values[i - 1]) / h_i;
            }
        }
        public double[] MethodSweep(SortedList<double, double> grid)
        {
            double[] c = new double[grid.Count];
            c[0] =c[grid.Count - 1] = 0.0;
            // Решение СЛАУ относительно коэффициентов сплайнов c[i] методом прогонки для трехдиагональных матриц
            // Вычисление прогоночных коэффициентов - прямой ход метода прогонки
            double[] alpha = new double[grid.Count - 1];
            double[] beta = new double[grid.Count - 1];
            alpha[0] = beta[0] = 0.0;
            for (int i = 1; i < grid.Count - 1; ++i)
            {
                double h_i = grid.Keys[i] - grid.Keys[i - 1], h_i1 = grid.Keys[i + 1] - grid.Keys[i];
                double A = h_i;
                double C = 2.0 * (h_i + h_i1);
                double B = h_i1;
                double F = 6.0 * ((grid.Values[i + 1] - grid.Values[i]) / h_i1 - (grid.Values[i] - grid.Values[i - 1]) / h_i);
                double z = (A * alpha[i - 1] + C);
                alpha[i] = -B / z;
                beta[i] = (F - A * beta[i - 1]) / z;
            }
            // Нахождение решения - обратный ход метода прогонки
            for (int i = grid.Count - 2; i > 0; --i)
                c[i] = alpha[i] * c[i + 1] + beta[i];
            return c;
        }
        // Вычисление значения интерполированной функции в произвольной точке
        public double InterpolationPoint(double x, int n)
        {
            SplineTuple s;
            if (x <= splines[0].x) // Если x меньше точки сетки x[0] - пользуемся первым эл-тов массива
                s = splines[1];
            else if (x >= splines[n - 1].x) // Если x больше точки сетки x[n - 1] - пользуемся последним эл-том массива
                s = splines[n - 1];
            else // Иначе x лежит между граничными точками сетки - производим бинарный поиск нужного эл-та массива
            {
                int i = 0, j = n - 1;
                while (i + 1 < j)
                {
                    int k = i + (j - i) / 2;
                    if (x <= splines[k].x)
                        j = k;
                    else
                        i = k;
                }
                s = splines[j];
            }
            double dx = (x - s.x);
            // Вычисляем значение сплайна в заданной точке по схеме Горнера (в принципе, "умный" компилятор применил бы схему Горнера сам, но ведь не все так умны, как кажутся)
            return s.a + (s.b + (s.c / 2.0 + s.d * dx / 6.0) * dx) * dx;
        }
    }
}
