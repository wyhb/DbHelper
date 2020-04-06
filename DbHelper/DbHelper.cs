using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbHelper
{
    public partial class DbHelper : Form
    {
        private DataTable dt;
        private string query = @"select
  concat(
    T1.SCHEMA_NAME
    , '.'
    , T1.TABLE_NAME
    , '.'
    , T1.COLUMN_NAME
  ) as SCHEMA_TBL_COL
  , concat(
    cast(T2.TABLE_COMMENT AS NVARCHAR(MAX))
    , '.'
    , cast(T1.COLUMN_COMMENT AS NVARCHAR(MAX))
  ) as TBL_COMMENT_COL_COMMENT
  , T1.TABLE_NAME as TBL_NAME
  , T2.TABLE_COMMENT as TBL_COMMENT
  , T1.COLUMN_NAME as COL_NAME
  , T1.COLUMN_COMMENT as COL_COMMENT
  , T1.COLUMN_ID
  , T1.TYPE
  , T1.LENGTH
  , T1.PRECISION
  , T1.SCALE
  , T1.NULLABLE
from
  (
    select
      S.NAME AS SCHEMA_NAME
      , S.SCHEMA_ID AS SCHEMA_ID
      , T.NAME AS TABLE_NAME
      , T.SCHEMA_ID AS TSCHEMA_ID
      , C.NAME AS COLUMN_NAME
      , E.MAJOR_ID AS MAJOR_ID
      , E.MINOR_ID AS MINOR_ID
      , E.VALUE AS COLUMN_COMMENT
      , C.COLUMN_ID as COLUMN_ID
      , TYPE_NAME(C.SYSTEM_TYPE_ID) as TYPE
      , C.MAX_LENGTH as LENGTH
      , C.PRECISION as PRECISION
      , C.SCALE as SCALE
      , IIF(C.IS_NULLABLE = 1, 'TRUE', 'FALSE') as NULLABLE
      , C.is_identity as is_identity
      , C.default_object_id as default_object_id
      --, I.OBJECT_ID
      --, C.OBJECT_ID
      --, IC.OBJECT_ID
      --, I.INDEX_ID
      --, IC.INDEX_ID
    from
      SYS.SCHEMAS S
      --, SYS.INDEXES I
      --, SYS.INDEX_COLUMNS IC
      , SYS.TABLES T
      , SYS.COLUMNS C
      , SYS.EXTENDED_PROPERTIES E
    where
      S.SCHEMA_ID = T.SCHEMA_ID
      and T.OBJECT_ID = C.OBJECT_ID
      and C.OBJECT_ID = E.MAJOR_ID
      and C.COLUMN_ID = E.MINOR_ID
      --and I.OBJECT_ID = C.OBJECT_ID
      --and IC.COLUMN_ID = C.COLUMN_ID
  ) as T1
  , (
    select
      S.NAME AS SCHEMA_NAME
      , S.SCHEMA_ID AS SCHEMA_ID
      , T.NAME AS TABLE_NAME
      , T.SCHEMA_ID AS TSCHEMA_ID
      , E.MAJOR_ID AS MAJOR_ID
      , E.MINOR_ID AS MINOR_ID
      , E.VALUE AS TABLE_COMMENT
    from
      SYS.SCHEMAS S
      , SYS.TABLES T
      , SYS.EXTENDED_PROPERTIES E
    where
      S.SCHEMA_ID = T.SCHEMA_ID
      and T.OBJECT_ID = E.MAJOR_ID
      and E.MINOR_ID = 0
  ) AS T2
where
  T1.MAJOR_ID = T2.MAJOR_ID
order by
  T1.MAJOR_ID
  , T1.MINOR_ID;
";
        public DbHelper()
        {
            InitializeComponent();
        }

        private void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //dt = new DataTable();
            //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            //{
            //    var cmd = new SqlCommand(query, con);
            //    con.Open();

            //    using (var da = new SqlDataAdapter(cmd))
            //    {
            //        da.Fill(dt);
            //        da.Dispose();
            //    }

            //     con.Close();
            //}

            var dtLst = new List<DataTable>();
            var dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Marks");

            var row = dt.NewRow();
            row["Name"] = "aa";
            row["Marks"] = "bb";
            dt.Rows.Add(row);
            dtLst.Add(dt);

            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Marks");

            row = dt.NewRow();
            row["Name"] = "aa";
            row["Marks"] = "bb";
            dt.Rows.Add(row);
            dtLst.Add(dt);

            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Marks");

            row = dt.NewRow();
            row["Name"] = "aa";
            row["Marks"] = "bb";
            dt.Rows.Add(row);
            dtLst.Add(dt);

            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Marks");

            row = dt.NewRow();
            row["Name"] = "aa";
            row["Marks"] = "bb";
            dt.Rows.Add(row);
            dtLst.Add(dt);
            tab.TabPages.Clear();
            for (int idx =0; idx < 4; idx++)
            {
                tab.TabPages.Add(idx.ToString());
                tab.TabPages[idx].Controls.Add(new DataGridView()
                {
                    Name = "dataGridView_" + idx.ToString(),
                    Dock = DockStyle.Fill,
                    DataSource = dtLst[idx]
                }); 
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("DB確認");
                for (var idx=0; idx < tab.TabPages.Count; idx++)
                {
                    var dt = (DataTable)tab.TabPages[idx].Controls.Cast<DataGridView>().ToList().FirstOrDefault().DataSource;
                    if (idx >= 1)
                    {
                        ws.Cell(ws.LastRowUsed().RowNumber() + 2, 1).Value = tab.TabPages[idx].Text;
                        ws.Cell(ws.LastRowUsed().RowNumber() + 1, 1).InsertTable(dt);
                    }
                    else
                    {
                        ws.Cell(1, 1).Value = tab.TabPages[idx].Text;
                        ws.Cell(2, 1).InsertTable(dt);
                    }
                }
                ws.Columns().AdjustToContents();
                wb.SaveAs("c:\\temp\\AddingDataTableAsWorksheet.xlsx");
                wb.Dispose();
            }
        }
    }
}
