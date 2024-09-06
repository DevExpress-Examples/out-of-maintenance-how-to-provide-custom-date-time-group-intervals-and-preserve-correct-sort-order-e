Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication21

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FillDataSource(ByVal beginDate As Date, ByVal endDate As Date)
            Dim dt As DataTable = dataSet1.Tables("Data")
            Dim i As Integer = 0
            Dim d As Date = beginDate
            While d <= endDate
                dt.Rows.Add(New Object() {"Name " & i Mod 3, "Type " & i Mod 2, d, i})
                i += 1
                d = d.AddDays(12)
            End While
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            beforeDate = New DateTime(Date.Today.Year - 1, Date.Today.Month, 1).AddDays(-1)
            afterDate = New DateTime(Date.Today.Year + 1, Date.Today.Month, 1).AddMonths(1)
            beforeValue = String.Format("Before {0}", beforeDate.AddDays(1).ToString("MMMM yy"))
            afterValue = String.Format("After {0}", afterDate.AddMonths(-1).ToString("MMMM yy"))
            FillDataSource(Date.Today.AddYears(-2), Date.Today.AddYears(2))
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
        End Sub

        Private beforeDate As Date

        Private afterDate As Date

        Private beforeValue As String

        Private afterValue As String

        Private Sub pivotGridControl1_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs)
            If ReferenceEquals(e.Field, fieldCustomMonth) Then
                Dim dt As Date = Convert.ToDateTime(e.Value)
                If dt.Date <= beforeDate Then
                    e.GroupValue = beforeDate
                ElseIf dt.Date >= afterDate Then
                    e.GroupValue = afterDate
                Else
                    e.GroupValue = New DateTime(dt.Year, dt.Month, 1)
                End If
            End If
        End Sub

        Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If ReferenceEquals(e.Field, fieldCustomMonth) Then
                Dim dt As Date = Convert.ToDateTime(e.Value)
                If dt = beforeDate Then
                    e.DisplayText = beforeValue
                ElseIf dt = afterDate Then
                    e.DisplayText = afterValue
                End If
            End If
        End Sub

        Private Sub pivotGridControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo As PivotGridHitInfo = pivotGridControl1.CalcHitInfo(e.Location)
            If hitInfo.HitTest = PivotGridHitTest.Value AndAlso hitInfo.ValueInfo IsNot Nothing Then dataGridView1.DataSource = hitInfo.ValueInfo.CreateDrillDownDataSource()
        End Sub
    End Class
End Namespace
