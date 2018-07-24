using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up some data
            //var xvals = new[]
            //    {
            //        new DateTime(2012,1,2), 
            //        new DateTime(2012,2,2), 
            //        new DateTime(2012,3,3), 
            //        new DateTime(2012,4,4)
            //    };
            var xvals = new[] { "ja","feb","mar","apr"};
            var yvals = new[] { 1, 3, 7, 12 };

            // create the chart
            var chart = new Chart();
            chart.Size = new Size(600, 250);

            var chartArea = new ChartArea();
            chartArea.AxisX.LabelStyle.Format = "dd/MMM\nhh:mm";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            chart.ChartAreas.Add(chartArea);

            var series = new Series();
            series.Name = "Series1";
            series.ChartType = SeriesChartType.FastLine;
            series.XValueType = ChartValueType.String;
            chart.Series.Add(series);

            // bind the datapoints
            chart.Series["Series1"].Points.DataBindXY(xvals, yvals);

            //// copy the series and manipulate the copy
            //chart.DataManipulator.CopySeriesValues("Series1", "Series2");
            //chart.DataManipulator.FinancialFormula(
            //    FinancialFormula.WeightedMovingAverage,
            //    "Series2"
            //);
            //chart.Series["Series2"].ChartType = SeriesChartType.FastLine;

            // draw!
            chart.Invalidate();

            // write out a file
            chart.SaveImage("chart.png", ChartImageFormat.Png);

            Console.WriteLine("ini cuman program penyimpan chart");
            Console.WriteLine("cek direktori untuk melihat gambar chart");
            Console.ReadKey();
        }
    }
}
