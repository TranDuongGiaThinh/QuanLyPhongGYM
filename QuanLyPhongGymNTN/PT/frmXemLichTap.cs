using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyPhongGymNTN.PT
{
    public partial class frmXemLichTap : Form
    {
        int maTaiKhoan;
        lichTapBUS bus = new lichTapBUS();

        public frmXemLichTap(int maTaiKhoan)
        {
            InitializeComponent();

            dgvLichTap.AllowUserToAddRows = false;
            dgvLichTap.AutoGenerateColumns = false;

            this.maTaiKhoan = maTaiKhoan;
        }

        private void frmXemLichTap_Load(object sender, EventArgs e)
        {
            dgvLichTap.DataSource = bus.LoadTheoPT(maTaiKhoan);
        }

        private void dgvLichTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
