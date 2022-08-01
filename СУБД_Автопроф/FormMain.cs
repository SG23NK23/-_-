using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автопроф
{
    public partial class FormMain : Form
    {
        public static string txtcon = @"Data Source=213.155.192.79,3002;Initial Catalog=avtoprofKOV2;Persist Security Info=True;User ID=u47_11;Password=5cnf";
        public FormMain()
        {
            InitializeComponent();
        }

        string cap;
        /// <summary>
        /// Это каптча. генерация её.
        /// </summary>
        void GetCap()
        {
            cap = Guid.NewGuid().ToString();
            cap = cap.Substring(0, 4).ToUpper();
            lT1.Text = cap[0].ToString();
            lT2.Text = cap[1].ToString();
            lT3.Text = cap[2].ToString();
            lT4.Text = cap[3].ToString();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            pInputCap.Visible = false;
            // GetCap();
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.avtoprofKOV2DataSet.User);

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BsUser.EndEdit();

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            //bool fNotLog = false;
            BsUser.Filter = $"UserLogin = '{tbLogin.Text}' and UserPassword = '{tbPass.Text}'";
            

            if (pInputCap.Visible && tbCap.Text.ToUpper() != cap)
            {
                MessageBox.Show("Каптча ошибка", "Не правильно ведено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetCap();
                bLogin.Enabled = false;
                tBlock.Start();
                return;
            }

            if (BsUser.Count == 0 || (tbPass.Text == "-" && tbLogin.Text == "-"))
            {
                MessageBox.Show("ОШИБКА","Что-то с паролем или логином",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (pInputCap.Visible == false)
                {
                    pInputCap.Visible = true;
                    GetCap();
                }
                else
                {
                    GetCap();
                    bLogin.Enabled = false;
                    tBlock.Start();
                }
                return;
            }

           
            FormTovar frm = new FormTovar();
            frm.BsUser.Filter = this.BsUser.Filter;
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tbLogin.Clear();
            tbPass.Clear();

            tbCap.Clear();
            pInputCap.Visible = false;
            
        }

        private void bGuest_Click(object sender, EventArgs e)
        {
            BsUser.Filter = $"UserLogin = '-' and UserPassword = '-'";
            FormTovar frm = new FormTovar();
            frm.BsUser.Filter = this.BsUser.Filter;
            this.Hide();
            frm.ShowDialog();
            this.Show();
            tbLogin.Clear();
            tbPass.Clear();
            tbCap.Clear();
            pInputCap.Visible = false;
        }

        private void pCaptcha_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), rnd.Next(100), rnd.Next(100), rnd.Next(pCaptcha.Width), rnd.Next(pCaptcha.Height));
            }
            
        }

        private void lT4_Click(object sender, EventArgs e)
        {

        }

        private void pCaptcha_Click(object sender, EventArgs e)
        {
            
           
        }

        private void tBlock_Tick(object sender, EventArgs e)
        {
            bLogin.Enabled = true;
            tBlock.Stop();
        }
    }
}
