using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Drawing;
// ...

namespace Series_LineChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl lineChart = new ChartControl();

            // Create a line series.
            Series series1 = new Series("Series 1", ViewType.Line);

            // Add points to it.
            series1.Points.Add(new SeriesPoint(1, 2));
            series1.Points.Add(new SeriesPoint(2, 12));
            series1.Points.Add(new SeriesPoint(3, 14));
            series1.Points.Add(new SeriesPoint(4, 17));

            // Add the series to the chart.
            lineChart.Series.Add(series1);

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Size = 20;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;

            // Access the view-type-specific options of the series.
            ((XYDiagram)lineChart.Diagram).AxisY.Interlaced = true;
            ((XYDiagram)lineChart.Diagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60);
            ((XYDiagram)lineChart.Diagram).AxisX.NumericScaleOptions.AutoGrid = false;
            ((XYDiagram)lineChart.Diagram).AxisX.NumericScaleOptions.GridSpacing = 1;

            // Hide the legend (if necessary).
            lineChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            lineChart.Titles.Add(new ChartTitle());
            lineChart.Titles[0].Text = "Line Chart";

            // Add the chart to the form.
            lineChart.Dock = DockStyle.Fill;
            this.Controls.Add(lineChart);
        }
    }
}