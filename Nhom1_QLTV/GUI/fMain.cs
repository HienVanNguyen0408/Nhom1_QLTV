using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QLTV.GUI
{
    public partial class fMain : Form
    {
        
        public fMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EVent click QUản lí sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qUẢNLÍSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event click menutrip Độc giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void đỘCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event click Nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event click Thông tin trả mượn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tHÔNGTINTRẢMƯỢNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event click hướng dẫn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hƯỚNGDẪNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// EVent click menutrip Đăng XUất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fLogin().Show();
            this.Hide();
        }
    }
}
