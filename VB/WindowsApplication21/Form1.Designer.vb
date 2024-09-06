Namespace WindowsApplication21

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.fieldName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldType1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCustomMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
            Me.dataTable1.TableName = "Data"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Name"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Type"
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Date"
            Me.dataColumn3.DataType = GetType(System.DateTime)
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "Value"
            Me.dataColumn4.DataType = GetType(Decimal)
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataMember = Nothing
            Me.pivotGridControl1.DataSource = Me.dataBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName1, Me.fieldType1, Me.fieldCustomMonth, Me.fieldValue1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(537, 371)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pivotGridControl1_MouseClick)
            AddHandler Me.pivotGridControl1.FieldValueDisplayText, New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(AddressOf Me.pivotGridControl1_FieldValueDisplayText)
            AddHandler Me.pivotGridControl1.CustomGroupInterval, New DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventHandler(AddressOf Me.pivotGridControl1_CustomGroupInterval)
            ' 
            ' dataBindingSource
            ' 
            Me.dataBindingSource.DataMember = "Data"
            Me.dataBindingSource.DataSource = Me.dataSet1
            ' 
            ' fieldName1
            ' 
            Me.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldName1.AreaIndex = 1
            Me.fieldName1.Caption = "Name"
            Me.fieldName1.FieldName = "Name"
            Me.fieldName1.Name = "fieldName1"
            ' 
            ' fieldType1
            ' 
            Me.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldType1.AreaIndex = 0
            Me.fieldType1.Caption = "Type"
            Me.fieldType1.FieldName = "Type"
            Me.fieldType1.Name = "fieldType1"
            ' 
            ' fieldCustomMonth
            ' 
            Me.fieldCustomMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCustomMonth.AreaIndex = 0
            Me.fieldCustomMonth.Caption = "Date"
            Me.fieldCustomMonth.FieldName = "Date"
            Me.fieldCustomMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
            Me.fieldCustomMonth.Name = "fieldCustomMonth"
            Me.fieldCustomMonth.UnboundFieldName = "fieldDate1"
            Me.fieldCustomMonth.ValueFormat.FormatString = "MMMM yy"
            Me.fieldCustomMonth.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            ' 
            ' fieldValue1
            ' 
            Me.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue1.AreaIndex = 0
            Me.fieldValue1.Caption = "Value"
            Me.fieldValue1.FieldName = "Value"
            Me.fieldValue1.Name = "fieldValue1"
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dataGridView1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(966, 371)
            Me.splitContainerControl1.SplitterPosition = 537
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' dataGridView1
            ' 
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.Size = New System.Drawing.Size(423, 371)
            Me.dataGridView1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(966, 371)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private dataColumn4 As System.Data.DataColumn

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private dataBindingSource As System.Windows.Forms.BindingSource

        Private fieldName1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldType1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCustomMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private dataGridView1 As System.Windows.Forms.DataGridView
    End Class
End Namespace
