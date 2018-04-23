Namespace ChartPivotInteractionApproaches
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.simpleDataSet1 = New ChartPivotInteractionApproaches.SimpleDataSet()
            Me.fieldrow1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldrow2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldrow3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fielddata1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fielddata2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fielddata3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.actualDataTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.selectionOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.chartDataVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.chartDataSourceTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.pivotGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.pivotSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.label1 = New System.Windows.Forms.Label()
            Me.cbArgument = New System.Windows.Forms.ComboBox()
            Me.cbValue = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.simpleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.menuStrip1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.chartControl1.DataSource = Me.pivotGridControl1
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.MaxHorizontalPercentage = 30
            Me.chartControl1.Location = New System.Drawing.Point(12, 360)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Chameleon"
            Me.chartControl1.SeriesDataMember = "Series"
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Label = sideBySideBarSeriesLabel1
            series1.Name = "Series 1"
            sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series2.Label = sideBySideBarSeriesLabel2
            series2.Name = "Series 2"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
            sideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            sideBySideBarSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl1.Size = New System.Drawing.Size(628, 234)
            Me.chartControl1.TabIndex = 0
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataMember = "table"
            Me.pivotGridControl1.DataSource = Me.simpleDataSet1
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldrow1, Me.fieldrow2, Me.fieldrow3, Me.fielddata1, Me.fielddata2, Me.fielddata3})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 27)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.pivotGridControl1.Size = New System.Drawing.Size(628, 300)
            Me.pivotGridControl1.TabIndex = 1
            ' 
            ' simpleDataSet1
            ' 
            Me.simpleDataSet1.DataSetName = "NewDataSet"
            ' 
            ' fieldrow1
            ' 
            Me.fieldrow1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldrow1.AreaIndex = 0
            Me.fieldrow1.Caption = "row1"
            Me.fieldrow1.FieldName = "row1"
            Me.fieldrow1.Name = "fieldrow1"
            ' 
            ' fieldrow2
            ' 
            Me.fieldrow2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldrow2.AreaIndex = 1
            Me.fieldrow2.Caption = "row2"
            Me.fieldrow2.FieldName = "row2"
            Me.fieldrow2.Name = "fieldrow2"
            ' 
            ' fieldrow3
            ' 
            Me.fieldrow3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldrow3.AreaIndex = 2
            Me.fieldrow3.Caption = "row3"
            Me.fieldrow3.FieldName = "row3"
            Me.fieldrow3.Name = "fieldrow3"
            ' 
            ' fielddata1
            ' 
            Me.fielddata1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fielddata1.AreaIndex = 0
            Me.fielddata1.Caption = "data1"
            Me.fielddata1.FieldName = "data1"
            Me.fielddata1.Name = "fielddata1"
            ' 
            ' fielddata2
            ' 
            Me.fielddata2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fielddata2.AreaIndex = 1
            Me.fielddata2.Caption = "data2"
            Me.fielddata2.FieldName = "data2"
            Me.fielddata2.Name = "fielddata2"
            ' 
            ' fielddata3
            ' 
            Me.fielddata3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fielddata3.AreaIndex = 2
            Me.fielddata3.Caption = "data3"
            Me.fielddata3.FieldName = "data3"
            Me.fielddata3.Name = "fielddata3"
            ' 
            ' menuStrip1
            ' 
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.viewToolStripMenuItem, Me.optionsToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Size = New System.Drawing.Size(917, 24)
            Me.menuStrip1.TabIndex = 2
            Me.menuStrip1.Text = "menuStrip1"
            ' 
            ' fileToolStripMenuItem
            ' 
            Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.exitToolStripMenuItem})
            Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
            Me.fileToolStripMenuItem.Text = "&File"
            ' 
            ' exitToolStripMenuItem
            ' 
            Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            Me.exitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
            Me.exitToolStripMenuItem.Text = "&Exit"
            ' 
            ' viewToolStripMenuItem
            ' 
            Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.actualDataTableToolStripMenuItem})
            Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
            Me.viewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
            Me.viewToolStripMenuItem.Text = "&View"
            ' 
            ' actualDataTableToolStripMenuItem
            ' 
            Me.actualDataTableToolStripMenuItem.Name = "actualDataTableToolStripMenuItem"
            Me.actualDataTableToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
            Me.actualDataTableToolStripMenuItem.Text = "Actual DataTable"
            ' 
            ' optionsToolStripMenuItem
            ' 
            Me.optionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.selectionOnlyToolStripMenuItem, Me.chartDataVerticalToolStripMenuItem, Me.chartDataSourceTypeToolStripMenuItem})
            Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
            Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
            Me.optionsToolStripMenuItem.Text = "&Options"
            ' 
            ' selectionOnlyToolStripMenuItem
            ' 
            Me.selectionOnlyToolStripMenuItem.CheckOnClick = True
            Me.selectionOnlyToolStripMenuItem.Name = "selectionOnlyToolStripMenuItem"
            Me.selectionOnlyToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.selectionOnlyToolStripMenuItem.Text = "SelectionOnly"
            ' 
            ' chartDataVerticalToolStripMenuItem
            ' 
            Me.chartDataVerticalToolStripMenuItem.CheckOnClick = True
            Me.chartDataVerticalToolStripMenuItem.Name = "chartDataVerticalToolStripMenuItem"
            Me.chartDataVerticalToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.chartDataVerticalToolStripMenuItem.Text = "RetrieveDataByColumns"
            ' 
            ' chartDataSourceTypeToolStripMenuItem
            ' 
            Me.chartDataSourceTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.pivotGridToolStripMenuItem, Me.pivotSummaryToolStripMenuItem})
            Me.chartDataSourceTypeToolStripMenuItem.Name = "chartDataSourceTypeToolStripMenuItem"
            Me.chartDataSourceTypeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
            Me.chartDataSourceTypeToolStripMenuItem.Text = "ChartDataSourceType"
            ' 
            ' pivotGridToolStripMenuItem
            ' 
            Me.pivotGridToolStripMenuItem.Name = "pivotGridToolStripMenuItem"
            Me.pivotGridToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.pivotGridToolStripMenuItem.Text = "PivotGrid"
            ' 
            ' pivotSummaryToolStripMenuItem
            ' 
            Me.pivotSummaryToolStripMenuItem.Name = "pivotSummaryToolStripMenuItem"
            Me.pivotSummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.pivotSummaryToolStripMenuItem.Text = "PivotSummary"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(38, 337)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(52, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Argument"
            ' 
            ' cbArgument
            ' 
            Me.cbArgument.Enabled = False
            Me.cbArgument.FormattingEnabled = True
            Me.cbArgument.Location = New System.Drawing.Point(96, 334)
            Me.cbArgument.Name = "cbArgument"
            Me.cbArgument.Size = New System.Drawing.Size(121, 21)
            Me.cbArgument.TabIndex = 4
            ' 
            ' cbValue
            ' 
            Me.cbValue.Enabled = False
            Me.cbValue.FormattingEnabled = True
            Me.cbValue.Location = New System.Drawing.Point(314, 334)
            Me.cbValue.Name = "cbValue"
            Me.cbValue.Size = New System.Drawing.Size(121, 21)
            Me.cbValue.TabIndex = 6
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(274, 337)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(34, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Value"
            ' 
            ' filterControl1
            ' 
            Me.filterControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.filterControl1.Location = New System.Drawing.Point(646, 27)
            Me.filterControl1.Name = "filterControl1"
            Me.filterControl1.Size = New System.Drawing.Size(259, 100)
            Me.filterControl1.TabIndex = 7
            Me.filterControl1.Text = "filterControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(917, 606)
            Me.Controls.Add(Me.filterControl1)
            Me.Controls.Add(Me.cbValue)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.cbArgument)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.menuStrip1)
            Me.MainMenuStrip = Me.menuStrip1
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.simpleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private simpleDataSet1 As SimpleDataSet
        Private fieldrow1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldrow2 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldrow3 As DevExpress.XtraPivotGrid.PivotGridField
        Private fielddata1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fielddata2 As DevExpress.XtraPivotGrid.PivotGridField
        Private fielddata3 As DevExpress.XtraPivotGrid.PivotGridField
        Private menuStrip1 As System.Windows.Forms.MenuStrip
        Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents chartDataVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private chartDataSourceTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents pivotGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents pivotSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents selectionOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private viewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents actualDataTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private label1 As System.Windows.Forms.Label
        Private WithEvents cbArgument As System.Windows.Forms.ComboBox
        Private WithEvents cbValue As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents filterControl1 As DevExpress.XtraEditors.FilterControl
    End Class
End Namespace

