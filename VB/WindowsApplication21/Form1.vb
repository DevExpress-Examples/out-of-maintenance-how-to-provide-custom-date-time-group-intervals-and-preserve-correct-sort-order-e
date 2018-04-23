Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication21
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub FillDataSource(ByVal beginDate As DateTime, ByVal endDate As DateTime)
			Dim dt As DataTable = dataSet1.Tables("Data")
			Dim i As Integer = 0
			Dim d As DateTime = beginDate
			Do While d <= endDate
				dt.Rows.Add(New Object() { "Name " & i Mod 3, "Type " & i Mod 2, d, i })
				i += 1
				d = d.AddDays(12)
			Loop
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			beforeDate = New DateTime(DateTime.Today.Year - 1, DateTime.Today.Month, 1).AddDays(-1)
			afterDate = New DateTime(DateTime.Today.Year + 1, DateTime.Today.Month, 1).AddMonths(1)
			beforeValue = String.Format("Before {0}", beforeDate.AddDays(1).ToString("MMMM yy"))
			afterValue = String.Format("After {0}",afterDate.AddMonths(-1).ToString("MMMM yy"))

			FillDataSource(DateTime.Today.AddYears(-2), DateTime.Today.AddYears(2))
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
		End Sub

		Private beforeDate As DateTime
		Private afterDate As DateTime
		Private beforeValue As String
		Private afterValue As String

		Private Sub pivotGridControl1_CustomGroupInterval(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs) Handles pivotGridControl1.CustomGroupInterval
			If ReferenceEquals(e.Field, fieldCustomMonth) Then
				Dim dt As DateTime = Convert.ToDateTime(e.Value)
				If dt.Date <= beforeDate Then
					e.GroupValue = beforeDate
				ElseIf dt.Date >= afterDate Then
					e.GroupValue = afterDate
				Else
					e.GroupValue = New DateTime(dt.Year, dt.Month, 1)
				End If
			End If
		End Sub

		Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles pivotGridControl1.FieldValueDisplayText
			If ReferenceEquals(e.Field, fieldCustomMonth) Then
				Dim dt As DateTime = Convert.ToDateTime(e.Value)
				If dt = beforeDate Then
					e.DisplayText = beforeValue

				ElseIf dt = afterDate Then
					e.DisplayText = afterValue
				End If
			End If
		End Sub

		Private Sub pivotGridControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pivotGridControl1.MouseClick
			Dim hitInfo As PivotGridHitInfo = pivotGridControl1.CalcHitInfo(e.Location)
			If hitInfo.HitTest = PivotGridHitTest.Value AndAlso hitInfo.ValueInfo IsNot Nothing Then
				dataGridView1.DataSource = hitInfo.ValueInfo.CreateDrillDownDataSource()
			End If
		End Sub




	End Class
End Namespace