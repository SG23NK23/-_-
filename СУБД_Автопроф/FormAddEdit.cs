using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автопроф
{
    public partial class FormAddEdit : Form
    {
        public FormAddEdit()
        {
            InitializeComponent();
        }

        public bool Addind;

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.Provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.avtoprofKOV2DataSet.Provider);
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.avtoprofKOV2DataSet.Manufacturer);
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.avtoprofKOV2DataSet.Category);
            // TODO: This line of code loads data into the 'avtoprofKOV2DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.avtoprofKOV2DataSet.Product);

            if (Addind)
            {
                lNameForm.Text = "Добавление товара";
                bsProduct.AddNew();
                cbCat.SelectedIndex = 0;
                cbMan.SelectedIndex = 0;
                cbPr.SelectedIndex = 0;
            }
            else
            {
                lNameForm.Text = "Редактирование товара";
                tbArticl.ReadOnly = true;

                try
                {
                    pbPhotoTovar.Load(Application.StartupPath + "\\photo\\" + lPic.Text);
                }
                catch
                {
                    pbPhotoTovar.Load(Application.StartupPath + "\\photo\\picture.png");
                }
            }
        }

        private void bLoadPhoto_Click(object sender, EventArgs e)
        {
            if(openPhoto.ShowDialog() == DialogResult.OK)
            {
                Image im;
                try
                {
                    im = Image.FromFile(openPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Не удалось загрузить фото", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    openPhoto.FileName = "";
                    return;
                }
                if(!(im.Width <= 300&&im.Height <=200||im.Width <= 200&&im.Height<=300))
                {
                    MessageBox.Show("Размеры привысили 300Х200 или 200Х300", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    openPhoto.FileName = "";
                    return;
                }
                pbPhotoTovar.Image = im;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(tbArticl.Text.Trim() == "")
            {
                MessageBox.Show("Пустое поле артикль", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbName.Text.Trim() == "")
            {
                MessageBox.Show("Пустое поле название товара", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbCount.Text.Trim() == "")
            {
                MessageBox.Show("Пустое поле кол-во", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbCost.Text.Trim() == "")
            {
                MessageBox.Show("Пустое поле цена", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbDes.Text.Trim() == "")
            {
                MessageBox.Show("Пустое поле описание", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bsProductIF.Filter = $"ProductArticleNumber = '{tbArticl.Text}'";
            if (Addind && bsProductIF.Count > 0)
            {
                MessageBox.Show("Такой артикль используется", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(openPhoto.FileName != "")
            {
                string newFileName = Guid.NewGuid() + Path.GetExtension(openPhoto.FileName);
                File.Copy(openPhoto.FileName, Application.StartupPath + "\\photo\\" + newFileName);
                lPic.Text = newFileName;
            }

            bsProduct.EndEdit();
            this.productTableAdapter.Update(this.avtoprofKOV2DataSet.Product);
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCount_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int count = int.Parse(tbCount.Text);
                if (count < 0)
                {
                    MessageBox.Show("Не может быть отрицательным кол-во", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введено не целое число в кол-ве", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbCost_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                double Cost = int.Parse(tbCost.Text);
                if (Cost < 0)
                {
                    MessageBox.Show("Не может быть отрицательным цена", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введено не вещественое число в цене", "ОШИБКА АААА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
