namespace MultiColoredModernUI.Forms.Master
{
    partial class MasterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMemberAlter = new System.Windows.Forms.Button();
            this.textUseYN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserLevel = new System.Windows.Forms.TextBox();
            this.textUserPwd = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 378);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(883, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMemberAlter);
            this.panel2.Controls.Add(this.textUseYN);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textMac);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textUserLevel);
            this.panel2.Controls.Add(this.textUserPwd);
            this.panel2.Controls.Add(this.textUserName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 205);
            this.panel2.TabIndex = 1;
            // 
            // btnMemberAlter
            // 
            this.btnMemberAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMemberAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberAlter.Location = new System.Drawing.Point(796, 165);
            this.btnMemberAlter.Name = "btnMemberAlter";
            this.btnMemberAlter.Size = new System.Drawing.Size(75, 23);
            this.btnMemberAlter.TabIndex = 11;
            this.btnMemberAlter.Text = "수정";
            this.btnMemberAlter.UseVisualStyleBackColor = true;
            this.btnMemberAlter.Click += new System.EventHandler(this.btnMemberAlter_Click);
            // 
            // textUseYN
            // 
            this.textUseYN.BackColor = System.Drawing.Color.White;
            this.textUseYN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUseYN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textUseYN.Location = new System.Drawing.Point(573, 90);
            this.textUseYN.Name = "textUseYN";
            this.textUseYN.Size = new System.Drawing.Size(215, 13);
            this.textUseYN.TabIndex = 10;
            this.textUseYN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(492, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "UseYN :";
            // 
            // textMac
            // 
            this.textMac.BackColor = System.Drawing.Color.White;
            this.textMac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textMac.Location = new System.Drawing.Point(573, 33);
            this.textMac.Name = "textMac";
            this.textMac.Size = new System.Drawing.Size(215, 13);
            this.textMac.TabIndex = 8;
            this.textMac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(474, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "MacAddress :";
            // 
            // textUserLevel
            // 
            this.textUserLevel.BackColor = System.Drawing.Color.White;
            this.textUserLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textUserLevel.Location = new System.Drawing.Point(145, 147);
            this.textUserLevel.Name = "textUserLevel";
            this.textUserLevel.Size = new System.Drawing.Size(215, 13);
            this.textUserLevel.TabIndex = 6;
            this.textUserLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUserPwd
            // 
            this.textUserPwd.BackColor = System.Drawing.Color.White;
            this.textUserPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textUserPwd.Location = new System.Drawing.Point(145, 90);
            this.textUserPwd.Name = "textUserPwd";
            this.textUserPwd.Size = new System.Drawing.Size(215, 13);
            this.textUserPwd.TabIndex = 5;
            this.textUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.White;
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textUserName.Location = new System.Drawing.Point(145, 33);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(215, 13);
            this.textUserName.TabIndex = 3;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(59, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserPwd :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(56, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserLevel :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(883, 205);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 573;
            this.lineShape5.X2 = 784;
            this.lineShape5.Y1 = 108;
            this.lineShape5.Y2 = 108;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 573;
            this.lineShape4.X2 = 784;
            this.lineShape4.Y1 = 52;
            this.lineShape4.Y2 = 52;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 145;
            this.lineShape3.X2 = 356;
            this.lineShape3.Y1 = 165;
            this.lineShape3.Y2 = 165;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 145;
            this.lineShape2.X2 = 356;
            this.lineShape2.Y1 = 108;
            this.lineShape2.Y2 = 108;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 145;
            this.lineShape1.X2 = 356;
            this.lineShape1.Y1 = 52;
            this.lineShape1.Y2 = 52;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserLevel;
        private System.Windows.Forms.TextBox textUserPwd;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textUseYN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMac;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnMemberAlter;
    }
}