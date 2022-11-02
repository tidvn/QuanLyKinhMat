using QuanLyKinhMat.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKinhMat.GUI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }
        private void fMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Tổng Quan";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new GUI.fTongquan());

            label1.Text = UserDTO.Instance.Name;
            if (UserDTO.Instance.Admin == 3)
            {
                label2.Text = "Quản Lý";
            } else
            {
                label2.Text = "Nhân Viên";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Hàng Hoá";
            guna2PictureBox_val.Image = Properties.Resources.cubes_44604;
            container(new GUI.fHanghoa());
        }
    }
}
