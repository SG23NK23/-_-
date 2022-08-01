using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автопроф
{
    public partial class FormTovar : Form
    {
        public FormTovar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Вывод списка товарвов
        /// </summary>
        void OutPut()
        {
            SqlConnection con = new SqlConnection(FormMain.txtcon);
            con.Open();

            string txtfind = "";

            if (cbName.Checked && tbSearch.Text.Trim() != "none")
                txtfind += $" and ProductName LIKE '%{tbSearch.Text}%'";
            if (cbDiscription.Checked && tbSearch.Text.Trim() != "none")
                txtfind += $" and ProductDescription LIKE '%{tbSearch.Text}%'";
            if (cbProzvod.Checked && tbSearch.Text.Trim() != "none")
                txtfind += $" and ManufacturerName LIKE '%{tbSearch.Text}%'";

            if (cbPrice.Checked && tbSearch.Text.Trim() != "")
                txtfind += $" and ProductCost = {tbSearch.Text}";
            if (cbCounts.Checked && tbSearch.Text.Trim() != "")
                txtfind += $" and ProductQuantityInStock = {tbSearch.Text}";

            if (comBoxMan.SelectedIndex > 0)
                txtfind += $" and ManufacturerName = '{comBoxMan.Text}'";

            string txtq = @"SELECT        Product.ProductArticleNumber, Product.ProductName, Product.ProductDescription, Manufacturer.ManufacturerName, Product.ProductCost, Product.ProductQuantityInStock, Product.ProductPhoto
FROM            Product INNER JOIN
                         Manufacturer ON Product.IdManufacturer = Manufacturer.IdManufacturer where 1 > 0 "+txtfind;

            if (comBoxSort.SelectedIndex == 0)
                txtq += " order by ProductCost asc";
            else
                txtq += " order by ProductCost desc";

            DgvProduct.Rows.Clear();

            try
            {
                SqlCommand q = new SqlCommand(txtq, con);
                SqlDataReader rez = q.ExecuteReader();


                while (rez.Read())
                {
                    string txtPr = rez["ProductName"] + "\r\n" + rez["ProductDescription"] + "\r\n" + "Производитель: " + rez["ManufacturerName"] + "\r\n" + "Цена: " + rez["ProductCost"];
                    try
                    {
                        DgvProduct.Rows.Add(rez["ProductArticleNumber"], Image.FromFile(Application.StartupPath + "\\photo\\" + rez["ProductPhoto"]), txtPr, "На складе: " + rez["ProductQuantityInStock"]);
                    }
                    catch
                    {
                        DgvProduct.Rows.Add(rez["ProductArticleNumber"], Image.FromFile(Application.StartupPath + "\\photo\\picture.png"), txtPr, "На складе: " + rez["ProductQuantityInStock"]);
                    }

                    if (rez["ProductQuantityInStock"].ToString() == "0")
                        DgvProduct.Rows[DgvProduct.RowCount - 1].DefaultCellStyle.BackColor = Color.Gray;

                }
                
            }
            catch { }
            con.Close();

            lCountRecord.Text = $"Отображается {DgvProduct.RowCount} из {bsProducts.Count}";
            if (DgvProduct.RowCount == 0 && tbSearch.Text.Trim() != "")
                StL.Text = "  Товары не найдены";
            else
                StL.Text = "  ";

        }

        private void FormTovar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.OrderProduct' table. You can move, or remove it, as needed.
            this.orderProductTableAdapter.Fill(this.avtoprofKOV2DataSet.OrderProduct);
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.avtoprofKOV2DataSet.Product);


            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.avtoprofKOV2DataSet.User);
            this.allmanufacturerTableAdapter.Fill(this.avtoprofKOV2DataSet.Allmanufacturer);

            comBoxSort.SelectedIndex = 0;
            OutPut();

            bAdd.Enabled = lRole.Text == "1";
            bDel.Enabled = lRole.Text == "1";

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void cbDiscription_CheckedChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void cbProzvod_CheckedChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void cbcbPrice_CheckedChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void cbCounts_CheckedChanged(object sender, EventArgs e)
        {
            OutPut();
        }

      
        private void comBoxMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void comBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutPut();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FormAddEdit frm = new FormAddEdit();
            frm.Addind = true;
            frm.ShowDialog();
            this.productTableAdapter.Fill(this.avtoprofKOV2DataSet.Product);
            OutPut();
        }
        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Удалить?", "удаление внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            string del = "";
            del = DgvProduct.CurrentRow.Cells[0].Value.ToString();
            bsOrderPr.Filter = $" ProductArticleNumber = '{del}'";
            if (bsOrderPr.Count > 0)
            {
                MessageBox.Show("не возможно удалить так как он выполняется", "ошибка стойте", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DgvProduct.Rows.Clear();
            SqlConnection con = new SqlConnection(FormMain.txtcon);
            con.Open();
            string txtq = $@"delete from Product
where ProductArticleNumber = '{del}'";
            SqlCommand q = new SqlCommand(txtq, con);
            q.ExecuteNonQuery();
            con.Close();
            bsOrderPr.RemoveFilter();
            this.productTableAdapter.Fill(this.avtoprofKOV2DataSet.Product);
            OutPut();
        }
        /// <summary>
        /// обработка функциии редактирование через двойное нажатие для админа по товару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lRole.Text != "1")
                return;
            
            FormAddEdit frm = new FormAddEdit();
            frm.Addind = false;
            string del = "";
            del = DgvProduct.CurrentRow.Cells[0].Value.ToString();
            frm.bsProduct.Filter = $" ProductArticleNumber = '{del}'";
            frm.ShowDialog();
            this.productTableAdapter.Fill(this.avtoprofKOV2DataSet.Product);
            OutPut();
        }
    }
}
