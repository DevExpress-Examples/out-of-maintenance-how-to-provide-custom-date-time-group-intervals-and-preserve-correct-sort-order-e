namespace WindowsApplication21
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Data";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Type";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Date";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Value";
            this.dataColumn4.DataType = typeof(decimal);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataMember = null;
            this.pivotGridControl1.DataSource = this.dataBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldName1,
            this.fieldType1,
            this.fieldCustomMonth,
            this.fieldValue1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(537, 371);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pivotGridControl1_MouseClick);
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.CustomGroupInterval += new DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventHandler(this.pivotGridControl1_CustomGroupInterval);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.dataSet1;
            // 
            // fieldName1
            // 
            this.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldName1.AreaIndex = 1;
            this.fieldName1.Caption = "Name";
            this.fieldName1.FieldName = "Name";
            this.fieldName1.Name = "fieldName1";
            // 
            // fieldType1
            // 
            this.fieldType1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldType1.AreaIndex = 0;
            this.fieldType1.Caption = "Type";
            this.fieldType1.FieldName = "Type";
            this.fieldType1.Name = "fieldType1";
            // 
            // fieldCustomMonth
            // 
            this.fieldCustomMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustomMonth.AreaIndex = 0;
            this.fieldCustomMonth.Caption = "Date";
            this.fieldCustomMonth.FieldName = "Date";
            this.fieldCustomMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom;
            this.fieldCustomMonth.Name = "fieldCustomMonth";
            this.fieldCustomMonth.UnboundFieldName = "fieldDate1";
            this.fieldCustomMonth.ValueFormat.FormatString = "MMMM yy";
            this.fieldCustomMonth.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldValue1
            // 
            this.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValue1.AreaIndex = 0;
            this.fieldValue1.Caption = "Value";
            this.fieldValue1.FieldName = "Value";
            this.fieldValue1.Name = "fieldValue1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(966, 371);
            this.splitContainerControl1.SplitterPosition = 537;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 371);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

