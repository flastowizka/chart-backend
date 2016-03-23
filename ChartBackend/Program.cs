using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] yValues = { 65.62, 75.54, 60.45, 55.73, 70.42 };
            string[] xValues = { "France", "Canada", "UK", "USA", "Italy" };

            Chart chart1 = new Chart();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            DataPoint dataPoint1 = new DataPoint(0, 39);
            DataPoint dataPoint2 = new DataPoint(0, 18);
            DataPoint dataPoint3 = new DataPoint(0, 15);
            DataPoint dataPoint4 = new DataPoint(0, 12);
            DataPoint dataPoint5 = new DataPoint(0, 8);
            DataPoint dataPoint6 = new DataPoint(0, 4.5);
            DataPoint dataPoint7 = new DataPoint(0, 3.2000000476837158);
            DataPoint dataPoint8 = new DataPoint(0, 2);
            DataPoint dataPoint9 = new DataPoint(0, 1);
            Title title1 = new Title();

            chart1.BackColor = Color.FromArgb(211, 223, 240);
            chart1.BackGradientStyle = GradientStyle.TopBottom;
            chart1.BorderlineColor = Color.FromArgb(26, 59, 105);
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 900;
            chartArea1.Area3DStyle.Rotation = 162;
            chartArea1.Area3DStyle.WallWidth = 25;
            chartArea1.AxisX.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            chartArea1.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            chartArea1.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = Color.Transparent;
            chartArea1.BorderColor = Color.FromArgb(64, 64, 64, 64);
            chartArea1.Name = "Area1";
            chartArea1.ShadowColor = Color.Transparent;
            chart1.ChartAreas.Add(chartArea1);
            chart1.IsSoftShadows = false;
            legend1.BackColor = Color.Transparent;
            legend1.Font = new Font("Trebuchet MS", 8F, FontStyle.Bold);
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(16, 61);
            chart1.Name = "chart1";
            series1.BorderColor = Color.FromArgb(64, 64, 64, 64);
            series1.ChartArea = "Area1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Color = Color.FromArgb(180, 65, 140, 240);
            series1.CustomProperties = "DoughnutRadius=25, PieDrawingStyle=SoftEdge, CollectedLabel=Other, MinimumRelative" +
                "PieSize=20";
            series1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold);
            series1.Label = "#PERCENT{P1}";
            series1.Legend = "Default";
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.Name = "Series1";
            dataPoint1.CustomProperties = "OriginalPointIndex=0";
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.LegendText = "RUS";
            dataPoint2.CustomProperties = "OriginalPointIndex=1";
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.LegendText = "CAN";
            dataPoint3.CustomProperties = "OriginalPointIndex=2";
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.LegendText = "USA";
            dataPoint4.CustomProperties = "OriginalPointIndex=3";
            dataPoint4.LegendText = "PRC";
            dataPoint5.CustomProperties = "OriginalPointIndex=5";
            dataPoint5.LegendText = "DEN";
            dataPoint6.LegendText = "AUS";
            dataPoint7.CustomProperties = "OriginalPointIndex=4";
            dataPoint7.LegendText = "IND";
            dataPoint8.LegendText = "ARG";
            dataPoint9.LegendText = "FRA";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.XValueType = ChartValueType.Double;
            series1.YValueType = ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Size = new Size(412, 296);
            chart1.TabIndex = 1;


            //chart1.Series["Default"].Points.DataBindXY(xValues, yValues);

            chart1.Legends[0].Enabled = true;
            //chart1.Series[0]["PieLabelStyle"] = "Inside";
            chart1.Series[0]["CollectedToolTip"] = "Other";
            


            // save from the chart object itself
            chart1.SaveImage(@"C:\Temp\HiddenChart.png", ChartImageFormat.Png);

            //// save to a bitmap
            //Bitmap bmp = new Bitmap(2100, 1500);
            //chart1.DrawToBitmap(bmp, new Rectangle(0, 0, 2100, 1500));
            //bmp.Save(@"C:\Temp\HiddenChart2.png");
        }
    }
}
