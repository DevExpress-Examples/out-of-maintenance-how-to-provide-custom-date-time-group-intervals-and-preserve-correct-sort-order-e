using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void FillDataSource(DateTime beginDate, DateTime endDate)
        {
            DataTable dt = dataSet1.Tables["Data"];
            int i = 0;
            for (DateTime d = beginDate ; d <= endDate; d = d.AddDays(12))
            {
                dt.Rows.Add(new object[] { "Name " + i % 3, "Type " + i % 2, d, i });
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beforeDate = new DateTime(DateTime.Today.Year - 1, DateTime.Today.Month, 1).AddDays(-1);
            afterDate = new DateTime(DateTime.Today.Year + 1, DateTime.Today.Month, 1).AddMonths(1);
            beforeValue = String.Format("Before {0}", beforeDate.AddDays(1).ToString("MMMM yy"));
            afterValue = String.Format( "After {0}",afterDate.AddMonths(-1).ToString("MMMM yy"));

            FillDataSource(DateTime.Today.AddYears(-2), DateTime.Today.AddYears(2));
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
        }

        DateTime beforeDate;
        DateTime afterDate;
        string beforeValue;
        string afterValue;

        private void pivotGridControl1_CustomGroupInterval(object sender, DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs e)
        {
            if (ReferenceEquals(e.Field, fieldCustomMonth))
            {
                DateTime dt = Convert.ToDateTime(e.Value);
                if (dt.Date <= beforeDate)
                    e.GroupValue = beforeDate;
                else if (dt.Date >= afterDate)
                    e.GroupValue = afterDate;
                else
                    e.GroupValue = new DateTime(dt.Year, dt.Month, 1);                
            }
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {
            if (ReferenceEquals(e.Field, fieldCustomMonth))
            {
                DateTime dt = Convert.ToDateTime(e.Value);
                if (dt == beforeDate)                
                    e.DisplayText = beforeValue;
                
                else if (dt == afterDate)
                    e.DisplayText = afterValue;                
            }
        }

        private void pivotGridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            PivotGridHitInfo hitInfo = pivotGridControl1.CalcHitInfo(e.Location);
            if (hitInfo.HitTest == PivotGridHitTest.Value && hitInfo.ValueInfo != null)
                dataGridView1.DataSource = hitInfo.ValueInfo.CreateDrillDownDataSource();
        }


        

    }
}