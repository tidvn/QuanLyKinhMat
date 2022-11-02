using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace QuanLyKinhMat.GUI
{
    public partial class fHanghoa : Form
    {
        public fHanghoa()
        {
            InitializeComponent();
        }
        public static Image Uimg(string url)        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }
        private void fHanghoa_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(9);
            guna2DataGridView1.Rows[0].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[0].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[0].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[0].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[0].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[1].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[1].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[1].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[1].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[1].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[2].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[2].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[2].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[2].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[2].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[2].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[3].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[3].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[3].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[3].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[3].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[3].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[4].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[4].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[4].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[4].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[4].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[4].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[4].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[5].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[5].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[5].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[5].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[5].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[5].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[5].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[6].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[6].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[6].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[6].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[6].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[6].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[6].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[7].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[7].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[7].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[7].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[7].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[7].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[7].Cells[7].Value = "Jan 21,2020";

            guna2DataGridView1.Rows[8].Cells[1].Value = Uimg("https://cdn.iconscout.com/icon/premium/png-256-thumb/birthday-133-263363.png");
            guna2DataGridView1.Rows[8].Cells[2].Value = "Dian Cooper";
            guna2DataGridView1.Rows[8].Cells[3].Value = "(239)555-2020";
            guna2DataGridView1.Rows[8].Cells[4].Value = "Cilacap";
            guna2DataGridView1.Rows[8].Cells[5].Value = "Jan 21,2020 -13:30";
            guna2DataGridView1.Rows[8].Cells[6].Value = "Jan 21,2020";
            guna2DataGridView1.Rows[8].Cells[7].Value = "Jan 21,2020";
        }
    }
}
