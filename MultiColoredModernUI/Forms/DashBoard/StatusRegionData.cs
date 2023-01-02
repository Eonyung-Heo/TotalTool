
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.DashBoard
{
    public partial class StatusRegionData : Form
    {
        MssqlDashBoard sql = new MssqlDashBoard();
        string[] strHeaders = { "지역", "시내버스", "공항버스", "시외버스", "고속버스", "지하철", "열차/KTX", "항공" };
        int regoinIndex = 0;

        public StatusRegionData()
        {
            InitializeComponent();
            RegionDataView(0);
            DisableButton();
            btnDataAll.FillColor = Color.LightSalmon;
            btnDataAll.ForeColor = Color.White;

        }



        private void DataGridView_Paint(object sender, PaintEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;



            if (regoinIndex == 0)
            {
                DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

                DataGridViewColumnVisible(0);

                // GV / Event / Colum Count(배열 순서) / 병합할 Width 수 / 병합할 처음 위치
                DataGridViewColumnMerge(gv, e, 0, 1, 0);
                DataGridViewColumnMerge(gv, e, 1, 3, 4);
                DataGridViewColumnMerge(gv, e, 2, 2, 7);
                DataGridViewColumnMerge(gv, e, 3, 2, 9);
                DataGridViewColumnMerge(gv, e, 4, 2, 11);
                DataGridViewColumnMerge(gv, e, 5, 2, 13);
                DataGridViewColumnMerge(gv, e, 6, 2, 15);
                DataGridViewColumnMerge(gv, e, 7, 2, 17);

                
            }
            else
            {
                DataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

                DataGridViewColumnVisible(1);

                DataGridViewColumnMerge(gv, e, 0, 1, 0);
                DataGridViewColumnMerge(gv, e, 1, 3, 4);
                DataGridViewColumnMerge(gv, e, 2, 2, 7);

                
            }

        }

        private void DataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            DataGridView gv = (DataGridView)sender; Rectangle rtHeader = gv.DisplayRectangle; rtHeader.Height = gv.ColumnHeadersHeight / 2; gv.Invalidate(rtHeader);

        }

        private void DataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            DataGridView gv = (DataGridView)sender; Rectangle rtHeader = gv.DisplayRectangle; rtHeader.Height = gv.ColumnHeadersHeight / 2; gv.Invalidate(rtHeader);
 
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1) { Rectangle r = e.CellBounds; r.Y += e.CellBounds.Height / 2; r.Height = e.CellBounds.Height / 2; e.PaintBackground(r, true); e.PaintContent(r); e.Handled = true; }
  
        }



        public void RegionDataView(int index)
        {
            sql.RegionDataView(index);
            DataGridView.Rows.Clear();

            for (int i = 0; i < StaticDashBoard.regionDatas.Count; i++)
            {
                string[] str = StaticDashBoard.regionDatas[i].ToArray();


                DataGridView.Rows.Add(str);
      
            }
        }
        private void btnGyeonggido_Click(object sender, EventArgs e)
        {
            regoinIndex = 1;
            RegionDataView(9);
            DisableButton();
            btnGyeonggido2.FillColor = Color.LightSalmon;
            btnGyeonggido2.ForeColor = Color.White;

        }

        private void btnGangwondo_Click(object sender, EventArgs e)
        {
            RegionDataView(10);
            regoinIndex = 1;
            DisableButton();
            btnGangwondo2.FillColor = Color.LightSalmon;
            btnGangwondo2.ForeColor = Color.White;
        }

        private void btnChungBuk_Click(object sender, EventArgs e)
        {
            RegionDataView(11);
            regoinIndex = 1;
            DisableButton();
            btnChungBuk2.FillColor = Color.LightSalmon;
            btnChungBuk2.ForeColor = Color.White;
        }

        private void btnChungNam_Click(object sender, EventArgs e)
        {
            RegionDataView(12);
            regoinIndex = 1;
            DisableButton();
            btnChungNam2.FillColor = Color.LightSalmon;
            btnChungNam2.ForeColor = Color.White;
        }

        private void btnGyeongBuk_Click(object sender, EventArgs e)
        {
            RegionDataView(13);
            regoinIndex = 1;
            DisableButton();
            btnGyeongBuk2.FillColor = Color.LightSalmon;
            btnGyeongBuk2.ForeColor = Color.White;



        }

        private void btnGyeongNam_Click(object sender, EventArgs e)
        {
            RegionDataView(14);
            regoinIndex = 1;
            DisableButton();
            btnGyeongNam2.FillColor = Color.LightSalmon;
            btnGyeongNam2.ForeColor = Color.White;

        }

        private void btnJeollaBuk_Click(object sender, EventArgs e)
        {
            RegionDataView(15);
            regoinIndex = 1;
            DisableButton();
            btnJeollaBuk2.FillColor = Color.LightSalmon;
            btnJeollaBuk2.ForeColor = Color.White;

        }

        private void btnJeollaNam_Click(object sender, EventArgs e)
        {
            RegionDataView(16);
            regoinIndex = 1;
            DisableButton();
            btnJeollaNam2.FillColor = Color.LightSalmon;
            btnJeollaNam2.ForeColor = Color.White;

        }

        private void btnDataAll_Click(object sender, EventArgs e)
        {
            RegionDataView(0);
            regoinIndex = 0;
            DisableButton();
            btnDataAll.FillColor = Color.LightSalmon;
            btnDataAll.ForeColor = Color.White;


        }

        private void DataGridViewColumnVisible(int index)
        {
            if (index == 0)
            {
                for (int i = 9; i < 19; i++)
                {
                    if(this.DataGridView.Columns[i].Visible == false)
                        this.DataGridView.Columns[i].Visible = true;
                }
            }
            else if(index > 0)
            {
                for (int i = 9; i < 19; i++)
                {
                    if (this.DataGridView.Columns[i].Visible == true)
                        this.DataGridView.Columns[i].Visible = false;
                }
            }
         
        }

        private void DataGridViewColumnMerge(DataGridView gv , PaintEventArgs e, int cCount, int wCount, int sCount)
        {

            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Center;

            format.LineAlignment = StringAlignment.Center;

            if (wCount > 1 && wCount < 3)
            {
                Rectangle r2 = gv.GetCellDisplayRectangle(sCount, -1, false);
                int width = gv.GetCellDisplayRectangle(sCount+1, -1, false).Width;
                r2.X += 1; r2.Y += 1; r2.Width = r2.Width + width - 2;
                r2.Height = (r2.Height / 2) - 2; e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[cCount], gv.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            else if(wCount > 2)
            {
                Rectangle r1 = gv.GetCellDisplayRectangle(sCount, -1, false);
                int width1 = gv.GetCellDisplayRectangle(sCount + 1, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(sCount + 2, -1, false).Width;
                r1.X += 1; r1.Y += 1;
                r1.Width = r1.Width + width1 + width2 - 2;
                r1.Height = (r1.Height / 2) - 2;
                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r1);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r1);
                e.Graphics.DrawString(strHeaders[cCount], gv.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r1, format);
            }
            else if(wCount == 1)
            {
                Rectangle r2 = gv.GetCellDisplayRectangle(sCount, -1, false);
                int width = gv.GetCellDisplayRectangle(sCount, -1, false).Width;
                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width - 2;
                r2.Height = (r2.Height) - 1; e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[cCount], gv.ColumnHeadersDefaultCellStyle.Font, new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
        }

        private void DisableButton()
        {
            btnGyeonggido2.FillColor = Color.White;
            btnGyeonggido2.ForeColor = Color.Black;
            btnGangwondo2.FillColor = Color.White;
            btnGangwondo2.ForeColor = Color.Black;
            btnChungBuk2.FillColor = Color.White;
            btnChungBuk2.ForeColor = Color.Black;
            btnChungNam2.FillColor = Color.White;
            btnChungNam2.ForeColor = Color.Black;
            btnGyeongBuk2.FillColor = Color.White;
            btnGyeongBuk2.ForeColor = Color.Black;
            btnGyeongNam2.FillColor = Color.White;
            btnGyeongNam2.ForeColor = Color.Black;
            btnJeollaBuk2.FillColor = Color.White;
            btnJeollaBuk2.ForeColor = Color.Black;
            btnJeollaNam2.FillColor = Color.White;
            btnJeollaNam2.ForeColor = Color.Black;
            btnDataAll.FillColor = Color.White;
            btnDataAll.ForeColor = Color.Black;
            
        }
    }
}
