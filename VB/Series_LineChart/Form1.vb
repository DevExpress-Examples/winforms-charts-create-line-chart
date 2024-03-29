Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports System.Drawing

' ...
Namespace Series_LineChart

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a new chart.
            Dim lineChart As ChartControl = New ChartControl()
            ' Create a line series.
            Dim series1 As Series = New Series("Series 1", ViewType.Line)
            ' Add points to it.
            series1.Points.Add(New SeriesPoint(1, 2))
            series1.Points.Add(New SeriesPoint(2, 12))
            series1.Points.Add(New SeriesPoint(3, 14))
            series1.Points.Add(New SeriesPoint(4, 17))
            ' Add the series to the chart.
            lineChart.Series.Add(series1)
            ' Set the numerical argument scale types for the series,
            ' as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical
            ' Access the view-type-specific options of the series.
            CType(series1.View, LineSeriesView).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            CType(series1.View, LineSeriesView).LineMarkerOptions.Size = 20
            CType(series1.View, LineSeriesView).LineMarkerOptions.Kind = MarkerKind.Triangle
            CType(series1.View, LineSeriesView).LineStyle.DashStyle = DashStyle.Dash
            ' Access the view-type-specific options of the series.
            CType(lineChart.Diagram, XYDiagram).AxisY.Interlaced = True
            CType(lineChart.Diagram, XYDiagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60)
            CType(lineChart.Diagram, XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
            CType(lineChart.Diagram, XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
            ' Hide the legend (if necessary).
            lineChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            ' Add a title to the chart (if necessary).
            lineChart.Titles.Add(New ChartTitle())
            lineChart.Titles(0).Text = "Line Chart"
            ' Add the chart to the form.
            lineChart.Dock = DockStyle.Fill
            Me.Controls.Add(lineChart)
        End Sub
    End Class
End Namespace
