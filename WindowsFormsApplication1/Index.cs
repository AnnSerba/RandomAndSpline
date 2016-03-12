using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SplineNS;
using RandomExtensionNS;

namespace WindowsFormsApplication1
{
    public partial class Index : Form
    {
        Random random = new Random();
        SortedList<double, double> Grid;
        public Index()
        {
            
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = (i + 0.5) + "";
                dataGridView1.Rows[i].Cells[1].Value = "5";
            }
            //Заполнение(100, 0, 100);
        }
        public void FillIn(int n, double limityMin, double limityMax)
        {

            for (int k = 0; k < checkedListBox.Items.Count; k++)
            {
                if (checkedListBox.GetItemChecked(k) == true)
                {
                    Charting plot = new Charting();
                    plot.Visible = true;
                    if (checkedListBox.Items[k] == "Betta")
                    {
                        plot.Text="Betta распределение";
                    }
                    if (checkedListBox.Items[k] == "Нормальное(Гаусса)")
                    {
                        plot.Text="Нормальное(Гаусса) распределение";
                    }
                    if (checkedListBox.Items[k] == "Равновероятное")
                    {
                        plot.Text = "Равновероятное распределение";
                    }
                    Grid = new SortedList<double, double>();
                    plot.chart1.Series[0].Points.Clear();
                    plot.chart1.Series[1].Points.Clear();
                    plot.chart1.Series[2].Points.Clear();


                    for (int i = 0; i < n; i++)
                    {
                        double y = 0;
                        if (checkedListBox.Items[k].ToString() == "Betta")
                        {
                            y = random.NextBetta(limityMin, limityMax);
                        }
                        if (checkedListBox.Items[k].ToString() == "Нормальное(Гаусса)")
                        {
                            y = (limityMax - limityMin)*(random.NextGaussian() / 6 + 0.5)+1;
                        }
                        if (checkedListBox.Items[k].ToString() == "Равновероятное")
                        {
                            y = (limityMax - limityMin) * random.NextDouble()+1;
                        }
                        Grid.Add(i, y);
                        plot.chart1.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(i, y));
                        plot.chart1.Series[1].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(i, y));
                        plot.dataGridView1.Rows.Add(i + "", y + "");
                    }
                    Spline splayn = new Spline(Grid);
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        try
                        {
                            double resDouble = 0;
                            int resInt = 0;
                            if (double.TryParse(dataGridView1.Rows[i].Cells[0].Value.ToString(), out resDouble) == true && int.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out resInt))
                            {
                                plot.chart1.Series[2].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(resDouble, Math.Round(splayn.InterpolationPoint(resDouble, n), resInt)));
                                plot.dataGridView2.Rows.Add(resDouble + "", Math.Round(splayn.InterpolationPoint(resDouble, n), resInt) + "");
                            }
                            else
                            {
                                throw new Exception("Что то не так с " + i + "-м значением ");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }
        }
        private void buttonВычислить_Click(object sender, EventArgs e)
        {
            try
            {
                FillIn(int.Parse(textBoxN.Text), double.Parse(textBoxMin.Text), double.Parse(textBoxMax.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}

