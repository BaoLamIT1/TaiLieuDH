using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_BODY.Controls.Add(childForm);
            panel_BODY.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Hệ thống quản lí: Hồ sơ nhân viên
        private void MenuItemHoSoNhanVien_Click(object sender, EventArgs e)
        {
            HoSoNhanVien hoSoNhanVien = new HoSoNhanVien();
            OpenChildForm(hoSoNhanVien);
            Label_Top.Text = hoSoNhanVien.Text;
        }
        // Hệ thống quản lí: Quá trình đào tạo


        private void MenuItemQuaTrinhDaoTao_Click(object sender, EventArgs e)
        {
            QTDT qTDT = new QTDT();
            OpenChildForm(qTDT);
            Label_Top.Text = qTDT.Text;
        }
        // Hệ thống quản lí: Quá trình công tác
        private void MenuItemQuaTrinhCongTac_Click(object sender, EventArgs e)
        {
            QTCT qTCT = new QTCT();
            OpenChildForm(qTCT);
            Label_Top.Text = qTCT.Text;
        }
        // Câu 4. Báo cáo QTĐT theo nhân viên hoặc theo trường đt hoặc theo ngành đào tạo						

        private void MenuItemBCQuaTrinhDaoTao_Click(object sender, EventArgs e)
        {
            BaoCaoQTDT bc1 = new BaoCaoQTDT();
            OpenChildForm(bc1);
            Label_Top.Text = bc1.Text;
        }
        // Câu 5. Báo cáo QTCT theo nhân viên hoặc theo phòng ban	
        private void MenuItemBCQuaTrinhCongTac_Click(object sender, EventArgs e)
        {
            BaoCaoQTCT bc2 = new BaoCaoQTCT();
            OpenChildForm(bc2);
            Label_Top.Text = bc2.Text;
        }
        // Câu 6. Báo cáo ds nhân viên theo cùng ngoại ngữ và chuyên môn						

        private void MenuItemBCNNvaCM_Click(object sender, EventArgs e)
        {
            BaoCaoNgoaiNguVaChuyenMon bc3 = new BaoCaoNgoaiNguVaChuyenMon();
            OpenChildForm(bc3);
            Label_Top.Text = bc3.Text;
        }
        // Câu 7. Báo cáo các thông tin chi tiết của QTĐT đang được đào tạo (chưa kết thúc)						

        private void MenuItemBCNVvaDT_Click(object sender, EventArgs e)
        {
            NhanVienDangTrongQTDT bc4 = new NhanVienDangTrongQTDT();

            OpenChildForm(bc4);
            Label_Top.Text = bc4.Text;
        }
        // Câu 1: Tìm kiếm QTDT Và QTCT
        private void MenuItemMaNV_Click(object sender, EventArgs e)
        {
            TimKiem1 timKiem1 = new TimKiem1();
            OpenChildForm(timKiem1);
            Label_Top.Text = timKiem1.Text;
        }
        // Câu 2 : Tìm kiếm hồ sơ nhân viên

        private void MenuItemTKHoSoNV_Click(object sender, EventArgs e)
        {
            TimKiem2 timKiem2 = new TimKiem2();
            OpenChildForm(timKiem2);
            Label_Top.Text = timKiem2.Text;
        }
        // Câu 3. Tìm kiếm QTĐT theo: nhân viên, trường đào tạo, hình thức đào tạo.						

        private void MenuItemTKQTDT_Click(object sender, EventArgs e)
        {
            TimKiem3 timKiem3 = new TimKiem3();
            OpenChildForm(timKiem3);
            Label_Top.Text = timKiem3.Text;
        }

       

        private void btnDX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ? ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
                FormDangNhap dangnhap = new FormDangNhap();
                dangnhap.ShowDialog();
            }
        }
    }
}
