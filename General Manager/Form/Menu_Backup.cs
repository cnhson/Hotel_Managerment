using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General_Manager.Form;
using System.Data.Entity;
namespace General_Manager.Form
{
    public partial class Manager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Manager()
        {
            InitializeComponent();
        }
        Hotel_ManagementEntities2 db;

        private void ExitProgram() {
            DialogResult delete = MessageBox.Show("Are you sure close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                {
                }
        }
        public void Skin()
        {
            //DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            //theme.LookAndFeel.SkinName = "Valentine";
        }


        private void M010103_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ExitProgram();

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotel_ManagementDataSet2.Employee);
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet1.Employee' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Employee' table. You can move, or remove it, as needed.
            db = new Hotel_ManagementEntities2();
            db.Employees.Load();
            employeeBindingSource1.DataSource = db.Employees.Local;
        }

        private void M010201_ItemClick(object sender, ItemClickEventArgs e)
        {
            Display_User display = new Display_User();
            display.Show();
        }

        private void M010202_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void M010101_ItemClick(object sender, ItemClickEventArgs e)
        {          
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void PicturePictureEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picturePictureEdit.Image = Image.FromFile(open.FileName);
            }
        }

        private void M010501_ItemClick(object sender, ItemClickEventArgs e)
        {
            employeeBindingSource1.AddNew();
        }

        private void M010503_ItemClick(object sender, ItemClickEventArgs e)
        {
            db.SaveChanges();

        }

        private void M010502_ItemClick(object sender, ItemClickEventArgs e)
        {
            employeeBindingSource1.RemoveCurrent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}