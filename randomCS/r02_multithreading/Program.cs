
using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;

class Program
{
    static Stopwatch s;
    static Form formChart;
    static Chart c1;
    static ChartArea ca1;
    static Series cs1, cs2, cs3, cs4;

    public static void Main(string[] args)
    {
        Console.Title = "array vs list";
        Console.SetWindowSize(50, 59);

        do
        {
            Console.Clear();

            //arrVSlist(10000000);

            arrVSlist_pixel();

        } while (Console.ReadKey().Key != ConsoleKey.T);
    }

    static void arrVSlist_pixel()
    {
        int ww = 500, hh = 500;

        Bitmap img = new Bitmap(ww, hh);
        Bitmap imgArray = new Bitmap(ww, hh);
        Bitmap imgList = new Bitmap(ww, hh);

        //List<double> arrW = new List<double>();
        //List<double> arrR = new List<double>();
        //List<double> listW = new List<double>();
        //List<double> listR = new List<double>();

        Color[] arr = new Color[img.Width * img.Height];
        List<Color> list = new List<Color>();

        Stopwatch S = new Stopwatch();

        // array write
        S.Reset(); S.Start();
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                int pos = (h * img.Width) + w;
                arr[pos] = img.GetPixel(w, h);
            }
        }
        var arr_W = mili(S.ElapsedTicks);
        
        // array read
        S.Reset(); S.Start();
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                int pos = (h * img.Width) + w;
                imgArray.SetPixel(w, h, arr[pos]);
            }
        }
        var arr_R = mili(S.ElapsedTicks);

        // list write
        S.Reset(); S.Start();
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                list.Add(img.GetPixel(w, h));
            }
        }
        var list_W = mili(S.ElapsedTicks);

        // list read
        S.Reset(); S.Start();
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                int pos = (h * img.Width) + w;
                imgList.SetPixel(w, h, list[pos]);
            }
        }
        var list_R = mili(S.ElapsedTicks);

        Console.WriteLine("arr  W = "+arr_W);
        Console.WriteLine("arr  R = "+arr_R);
        Console.WriteLine("list W = "+list_W);
        Console.WriteLine("list R = "+list_R);


        /*
        //array write
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                int pos = (h * img.Width) + w;
                s = Stopwatch.StartNew();
                arr[pos] = img.GetPixel(w, h);
                s.Stop();
                arrW.Add(mili(s.ElapsedTicks));
            }
        }

        // array read
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                int pos = (h * img.Width) + w;
                s = Stopwatch.StartNew();
                imgArray.SetPixel(w, h, arr[pos]);
                s.Stop();
                arrR.Add(mili(s.ElapsedTicks));
            }
        }

        // list write
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                s = Stopwatch.StartNew();
                list.Add(img.GetPixel(w, h));
                s.Stop();
                listW.Add(mili(s.ElapsedTicks));
            }
        }
        
        // list read
        for (int h = 0; h < img.Height; h++)
        {
            for (int w = 0; w < img.Width; w++)
            {
                int pos = (h * img.Width) + w;
                s = Stopwatch.StartNew();
                imgList.SetPixel(w, h, list[pos]);
                s.Stop();
                listR.Add(mili(s.ElapsedTicks));
            }
        }
        
        //Console.WriteLine();

        sform(arrW.ToArray(), arrR.ToArray(), listW.ToArray(), listR.ToArray());
        */
    }

    static void arrVSlist(int max)
    {
        //int max = 100000000;

        int[] arr = new int[max];
        List<int> list = new List<int>(max);

        int arrSum = 0;
        int listSum = 0;


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((i + 1) + "--------------------------");
            list.Clear();
            arrSum = 0;
            listSum = 0;

            for (int x = 0; x < max; x++)
            {
                arr[x] = x;
                list.Add(x);
            }

            // array write
            s = Stopwatch.StartNew();
            for (int x = 0; x < max; x++)
            {
                arr[x] = x;
            }
            s.Stop(); 
            Console.WriteLine("arr  w = " + mili(s.ElapsedTicks));

            // array read
            s = Stopwatch.StartNew();
            for (int x = 0; x < max; x++)
            {
                arrSum += arr[x];
            }
            s.Stop();
            Console.WriteLine("arr  r = " + mili(s.ElapsedTicks));

            // list write
            s = Stopwatch.StartNew();
            for (int x = 0; x < max; x++)
            {
                list[x] = x;
            }
            s.Stop();
            Console.WriteLine("list w = " + mili(s.ElapsedTicks));

            // list read
            s = Stopwatch.StartNew();
            for (int x = 0; x < max; x++)
            {
                listSum += list[x];
            }
            s.Stop();
            Console.WriteLine("list r = " + mili(s.ElapsedTicks));

            Console.WriteLine();

        }
    }

    static double mikro(long t)
    {
        double m = (double)1000000 / Stopwatch.Frequency;
        return m * t;
    }

    static double mili(long t)
    {
        double m = (double)1000 / Stopwatch.Frequency;
        return m * t;
    }

    static void sform(double[] A1, double[] A2, double[] A3, double[] A4)
    {
        formChart = new Form();
        formChart.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        formChart.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //formChart.ClientSize = new Size(284, 261);
        formChart.Size = Screen.PrimaryScreen.Bounds.Size;
        formChart.Name = "Form1";
        formChart.Text = "Tampil Chart";
        formChart.MinimizeBox = false;
        formChart.MaximizeBox = false;
        formChart.ResumeLayout(false);
        formChart.TopMost = true;
        formChart.KeyPreview = true;
        //formChart.Text = formChart.ClientSize.ToString();
        formChart.Load += (ss, ee) => { formChart.Location = new Point(0, 0); };
        formChart.KeyDown += (ss, ee) => { if (ee.KeyData == Keys.Escape) formChart.Close(); formChart.Dispose(); };

        c1 = new Chart();
        c1.Location = new Point(0, 0);
        c1.Size = formChart.ClientSize;
        ca1 = new ChartArea("chartArea1");
        c1.ChartAreas.Add(ca1);

        cs1 = new Series("series1");
        cs1.ChartType = SeriesChartType.Spline;
        cs1.Points.DataBindY(A1);
        c1.Series.Add(cs1);

        cs2 = new Series("series2");
        cs2.ChartType = SeriesChartType.Spline;
        cs2.Points.DataBindY(A2);
        c1.Series.Add(cs2);

        cs3 = new Series("series3");
        cs3.ChartType = SeriesChartType.Spline;
        cs3.Points.DataBindY(A3);
        c1.Series.Add(cs3);

        cs4 = new Series("series4");
        cs4.ChartType = SeriesChartType.Spline;
        cs4.Points.DataBindY(A4);
        c1.Series.Add(cs4);

        formChart.Controls.Add(c1);
        formChart.ShowDialog();
    }
}



/**
using System;
using System.Diagnostics;
class xx
{
    static void Main(string[] args)
    {
        double sec = (double)1 / Stopwatch.Frequency;
        double mili = (double)1000 / Stopwatch.Frequency; ;
        double mikro = (double)1000000 / Stopwatch.Frequency; ;
        double nano = (double)1000000000 / Stopwatch.Frequency;
        do
        {
            Console.Clear();
            Stopwatch s = Stopwatch.StartNew();
            Console.WriteLine("aaaa");
            s.Stop();
            Console.WriteLine(s.Elapsed);
            Console.WriteLine(s.ElapsedTicks);
            Console.WriteLine((double)s.ElapsedTicks * sec);
            Console.WriteLine(s.ElapsedTicks * mili);
            Console.WriteLine(s.ElapsedTicks * mikro);
            Console.WriteLine(s.ElapsedTicks * nano);

            



        } while (Console.ReadKey(true).Key != ConsoleKey.T);
    }
}
*/
/**
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.InteropServices;
public class App
{
    public static void Main()
    {
        Console.Title = "multithreading test";
        Console.SetWindowSize(50, 59);
        Console.SetBufferSize(Console.BufferWidth, 1024);
        do
        {
            Console.Clear();
            CollectSamples();
        } while (Console.ReadKey().KeyChar != 't');
    }
    public static void CollectSamples()
    {
        const String categoryName = "ElapsedTimeSampleCategory";
        const String counterName = "ElapsedTimeSample";
        // If the category does not exist, create the category and exit.
        // Performance counters should not be created and immediately used.
        // There is a latency time to enable the counters, they should be created
        // prior to executing the application that uses the counters.
        // Execute this sample a second time to use the category.
        if (!PerformanceCounterCategory.Exists(categoryName))
        {
            CounterCreationDataCollection CCDC = new CounterCreationDataCollection();
            // Add the counter.
            CounterCreationData ETimeData = new CounterCreationData();
            ETimeData.CounterType = PerformanceCounterType.ElapsedTime;
            ETimeData.CounterName = counterName;
            CCDC.Add(ETimeData);
            // Create the category.
            PerformanceCounterCategory.Create(categoryName,
            "Demonstrates ElapsedTime performance counter usage.",
            PerformanceCounterCategoryType.SingleInstance, CCDC);
            // Return, rerun the application to make use of the new counters.
            return;
        }
        else
        {
            Console.WriteLine("Category exists ‐ {0}", categoryName);
        }
        // Create the performance counter.
        PerformanceCounter PC = new PerformanceCounter(categoryName,
        counterName,
        false);
        // Initialize the counter.
        PC.RawValue = Stopwatch.GetTimestamp();
        DateTime Start = DateTime.Now;
        // Loop for the samples.
        for (int j = 0; j < 100; j++)
        {
            // Output the values.
            if ((j % 10) == 9)
            {
                //Console.WriteLine("\nNextValue() = " + PC.NextValue().ToString());
                //Console.WriteLine("Actual elapsed time = " + DateTime.Now.Subtract(Start));
                OutputSample(PC.NextSample());
            }
            // Reset the counter on every 20th iteration.
            if (j % 20 == 0)
            {
                PC.RawValue = Stopwatch.GetTimestamp();
                Start = DateTime.Now;
            }
            //System.Threading.Thread.Sleep(10);
        }
        Console.WriteLine("\nElapsed time = " + DateTime.Now.Subtract(Start));
    }
    private static void OutputSample(CounterSample s)
    {
        //Console.WriteLine("\r\n+++++++++++");
        //Console.WriteLine("Sample values ‐ \r\n");
        //Console.WriteLine(" BaseValue = " + s.BaseValue);
        //Console.WriteLine(" CounterFrequency = " + s.CounterFrequency);
        Console.WriteLine(" CounterTimeStamp = " + s.CounterTimeStamp);
        //Console.WriteLine(" CounterType = " + s.CounterType);
        Console.WriteLine(" RawValue         = " + s.RawValue);
        //Console.WriteLine(" SystemFrequency = " + s.SystemFrequency);
        Console.WriteLine(" TimeStamp        = " + s.TimeStamp);
        Console.WriteLine(TimeSpan.FromTicks(s.CounterTimeStamp));
        //Console.WriteLine(" TimeStamp100nSec = " + s.TimeStamp100nSec);
        Console.WriteLine("--------------------------------------------\n");
    }
}

*/
/**
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace r02_multithreading
{
    class Program
    {
        static Bitmap img = new Bitmap(1000, 1000);
        static void Main(string[] args)
        {
            Console.Title = "multithreading test";
            Console.SetWindowSize(50, 59);
            do
            {
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("\nloop ke - " + (i + 1));
                    t2();
                    t1();
                }
            } while (Console.ReadKey().KeyChar != 't');
        }

        static void t1()
        {
            //var a = System.Diagnostics.Stopwatch.StartNew();
            //a.Stop();
            //Console.WriteLine("t1 = " + a.ElapsedTicks.ToString());
        }

        static void t2()
        {
            //var a = System.Diagnostics.Stopwatch.StartNew();
            //if (img == null) { }
            //else { }//Console.Write("if statement "); }
            //a.Stop();
            //Console.WriteLine("t2 = " + a.ElapsedTicks.ToString());
        }
    }
}
*/