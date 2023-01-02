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
    public partial class StatusDataManegement : Form
    {
        MssqlDashBoard sql = new MssqlDashBoard();

        int currentBtnIndex = 1;

        public StatusDataManegement()
        {
            InitializeComponent();
            DataView(currentBtnIndex, "", "");
            guna2ComboBox1.SelectedIndex = 0;
            btnBIS.BorderColor = Color.LightSalmon; ;

        }


        private void textSearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            textSearchBox.Text = "";
        }

        private void textSearchBox_Leave(object sender, EventArgs e)
        {
            if (textSearchBox.Text == "")
                textSearchBox.Text = "Search";
        }

        private void textSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = textSearchBox.Text;
               
                int index = guna2ComboBox1.SelectedIndex+1;

                guna2DataGridView1.Rows.Clear();

                sql.DataManegementView(currentBtnIndex, index, search);

                for (int j = 0; j < StaticDashBoard.dashBoard_DataMenegements.Count; j++)
                {
                    string[] str = StaticDashBoard.dashBoard_DataMenegements[j].ToArray();

                    guna2DataGridView1.Rows.Add(str);
                }
            }

        }

        private void btnBIS_Click(object sender, EventArgs e)
        {
            currentBtnIndex = 1;
            DataView(currentBtnIndex, "", "");
            DisableButton();
            textSearchBox.Text = "Search";
            btnBIS.BorderColor = Color.LightSalmon;

            ColumnVisible();

        }


        private void btnNonBIS_Click(object sender, EventArgs e)
        {
            currentBtnIndex = 2;
            DataView(currentBtnIndex, "", "");
            textSearchBox.Text = "Search";
            DisableButton();
            btnNonBIS.BorderColor = Color.LightSalmon;

            ColumnVisible();

        }

        private void btnSubway_Click(object sender, EventArgs e)
        {
            currentBtnIndex = 3;
            DataView(currentBtnIndex, "", "");
            textSearchBox.Text = "Search";
            DisableButton();
            btnSubway.BorderColor = Color.LightSalmon;

            ColumnVisible2();
        }

        private void btnEtc_Click(object sender, EventArgs e)
        {
            currentBtnIndex = 0;
            DataView(currentBtnIndex, "", "");
            textSearchBox.Text = "Search";
            DisableButton();
          
            btnEtc.BorderColor = Color.LightSalmon;


            ColumnVisible2();



        }

        public void DataView(int index, string searchType, string search)
        {
            guna2DataGridView1.Rows.Clear();

            sql.DataManegementView(currentBtnIndex, 0, search);

            ColumnVisible();

            for (int j = 0; j < StaticDashBoard.dashBoard_DataMenegements.Count; j++)
            {
                string[] str = StaticDashBoard.dashBoard_DataMenegements[j].ToArray();

                guna2DataGridView1.Rows.Add(str);
            }
        }

        public void ColumnVisible()
        {
            guna2DataGridView1.Columns[1].Visible = false;
            guna2DataGridView1.Columns[2].Visible = false;
            guna2DataGridView1.Columns[3].Visible = false;

            guna2DataGridView1.Columns[0].Visible = true;
            guna2DataGridView1.Columns[4].Visible = true;
            guna2DataGridView1.Columns[5].Visible = true;

        }

        public void ColumnVisible2()
        {

            guna2DataGridView1.Columns[2].Visible = true;

            guna2DataGridView1.Columns[0].Visible = false;        
            guna2DataGridView1.Columns[3].Visible = false;
            guna2DataGridView1.Columns[4].Visible = false;
            guna2DataGridView1.Columns[5].Visible = false;

        }

        private void DisableButton()
        {
            btnBIS.BorderColor = Color.LightGray;
            btnNonBIS.BorderColor = Color.LightGray;
            btnSubway.BorderColor = Color.LightGray;
            btnEtc.BorderColor = Color.LightGray;


        }
    }
}
