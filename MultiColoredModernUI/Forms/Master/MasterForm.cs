using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.Master
{
    public partial class MasterForm : Form
    {
        Mssql sql = new Mssql();

        public MasterForm()
        {
            InitializeComponent();
            CreateListView();
            sql.Members();
            ItemAddListView();

        }

        public void CreateListView()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("UserName");
            listView1.Columns.Add("UserPwd");
            listView1.Columns.Add("UserLevel");
            listView1.Columns.Add("MacAddress");
            listView1.Columns.Add("UseYN");

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            IEnumerator enm = listView1.SelectedIndices.GetEnumerator();

            int currIndex = -1;

            while (enm.MoveNext())
            {
                currIndex = (int)enm.Current;
            }


            this.textUserName.Text = StaticMaster.members[currIndex][0].ToString();
            this.textUserPwd.Text = StaticMaster.members[currIndex][1].ToString();
            this.textUserLevel.Text = StaticMaster.members[currIndex][2].ToString();
            this.textMac.Text = StaticMaster.members[currIndex][3].ToString();
            this.textUseYN.Text = StaticMaster.members[currIndex][4].ToString();

            

        }

        public void ItemAddListView()
        {
            for (int i = 0; i < StaticMaster.members.Count; i++)
            {
                string[] str = StaticMaster.members[i].ToArray();

                ListViewItem item = new ListViewItem(str);

                listView1.Items.Add(item);
            }
        }

        private void btnMemberAlter_Click(object sender, EventArgs e)
        {
            if (textUserName.Text != "" && textUserPwd.Text != "" && textUserLevel.Text != "" && textUseYN.Text != "" && textMac.Text != "")
            {
                sql.MemberAlter(textUserName.Text, textUserPwd.Text, Convert.ToInt16(textUserLevel.Text), textMac.Text, textUseYN.Text);
                MessageBox.Show("정보 수정 완료");
            }
            else
                MessageBox.Show("공백을 채워 주세요");
        }
    }
}
