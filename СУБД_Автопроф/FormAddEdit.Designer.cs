
namespace СУБД_Автопроф
{
    partial class FormAddEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productArticleNumberLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNameForm = new System.Windows.Forms.Label();
            this.lPic = new System.Windows.Forms.Label();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.avtoprofKOV2DataSet = new СУБД_Автопроф.avtoprofKOV2DataSet();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.CategoryTableAdapter();
            this.manufacturerTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.ManufacturerTableAdapter();
            this.providerTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.ProviderTableAdapter();
            this.tbArticl = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.pbPhotoTovar = new System.Windows.Forms.PictureBox();
            this.bsCategory = new System.Windows.Forms.BindingSource(this.components);
            this.bsManufactur = new System.Windows.Forms.BindingSource(this.components);
            this.bsProvider = new System.Windows.Forms.BindingSource(this.components);
            this.cbPr = new System.Windows.Forms.ComboBox();
            this.cbMan = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bLoadPhoto = new System.Windows.Forms.Button();
            this.openPhoto = new System.Windows.Forms.OpenFileDialog();
            this.bSave = new System.Windows.Forms.Button();
            this.bsProductIF = new System.Windows.Forms.BindingSource(this.components);
            productArticleNumberLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoprofKOV2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoTovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManufactur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductIF)).BeginInit();
            this.SuspendLayout();
            // 
            // productArticleNumberLabel
            // 
            productArticleNumberLabel.AutoSize = true;
            productArticleNumberLabel.Location = new System.Drawing.Point(75, 128);
            productArticleNumberLabel.Name = "productArticleNumberLabel";
            productArticleNumberLabel.Size = new System.Drawing.Size(56, 14);
            productArticleNumberLabel.TabIndex = 2;
            productArticleNumberLabel.Text = "Артикль";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(19, 151);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(112, 14);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Название товара";
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Location = new System.Drawing.Point(12, 183);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(119, 14);
            productQuantityInStockLabel.TabIndex = 5;
            productQuantityInStockLabel.Text = "Кол-во на складе";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(5, 209);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(126, 14);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "Единица измерения";
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(96, 235);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(35, 14);
            productCostLabel.TabIndex = 9;
            productCostLabel.Text = "Цена";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(5, 257);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(63, 14);
            productDescriptionLabel.TabIndex = 11;
            productDescriptionLabel.Text = "Описание";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lNameForm);
            this.panel1.Controls.Add(this.PbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 116);
            this.panel1.TabIndex = 2;
            // 
            // lNameForm
            // 
            this.lNameForm.AutoSize = true;
            this.lNameForm.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameForm.Location = new System.Drawing.Point(209, 41);
            this.lNameForm.Name = "lNameForm";
            this.lNameForm.Size = new System.Drawing.Size(88, 23);
            this.lNameForm.TabIndex = 3;
            this.lNameForm.Text = "Товары";
            // 
            // lPic
            // 
            this.lPic.AutoSize = true;
            this.lPic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductPhoto", true));
            this.lPic.Location = new System.Drawing.Point(760, 436);
            this.lPic.Name = "lPic";
            this.lPic.Size = new System.Drawing.Size(98, 14);
            this.lPic.TabIndex = 17;
            this.lPic.Text = "Название фото";
            // 
            // bsProduct
            // 
            this.bsProduct.DataMember = "Product";
            this.bsProduct.DataSource = this.avtoprofKOV2DataSet;
            // 
            // avtoprofKOV2DataSet
            // 
            this.avtoprofKOV2DataSet.DataSetName = "avtoprofKOV2DataSet";
            this.avtoprofKOV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbLogo.Image = global::СУБД_Автопроф.Properties.Resources.logo;
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(136, 116);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickUpPointTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // tbArticl
            // 
            this.tbArticl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductArticleNumber", true));
            this.tbArticl.Location = new System.Drawing.Point(140, 122);
            this.tbArticl.Name = "tbArticl";
            this.tbArticl.Size = new System.Drawing.Size(100, 20);
            this.tbArticl.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductName", true));
            this.tbName.Location = new System.Drawing.Point(140, 148);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbCount
            // 
            this.tbCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductQuantityInStock", true));
            this.tbCount.Location = new System.Drawing.Point(140, 177);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 20);
            this.tbCount.TabIndex = 6;
            this.tbCount.Validating += new System.ComponentModel.CancelEventHandler(this.tbCount_Validating);
            // 
            // tbQ
            // 
            this.tbQ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "Unit", true));
            this.tbQ.Location = new System.Drawing.Point(140, 203);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(100, 20);
            this.tbQ.TabIndex = 8;
            // 
            // tbCost
            // 
            this.tbCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbCost.Location = new System.Drawing.Point(140, 229);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 20);
            this.tbCost.TabIndex = 10;
            this.tbCost.Validating += new System.ComponentModel.CancelEventHandler(this.tbCost_Validating);
            // 
            // tbDes
            // 
            this.tbDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductDescription", true));
            this.tbDes.Location = new System.Drawing.Point(8, 274);
            this.tbDes.Multiline = true;
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(289, 122);
            this.tbDes.TabIndex = 12;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(430, 363);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(123, 40);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Отменить сохранение";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pbPhotoTovar
            // 
            this.pbPhotoTovar.Image = global::СУБД_Автопроф.Properties.Resources.picture;
            this.pbPhotoTovar.Location = new System.Drawing.Point(303, 122);
            this.pbPhotoTovar.Name = "pbPhotoTovar";
            this.pbPhotoTovar.Size = new System.Drawing.Size(121, 121);
            this.pbPhotoTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhotoTovar.TabIndex = 18;
            this.pbPhotoTovar.TabStop = false;
            // 
            // bsCategory
            // 
            this.bsCategory.DataMember = "Category";
            this.bsCategory.DataSource = this.avtoprofKOV2DataSet;
            // 
            // bsManufactur
            // 
            this.bsManufactur.DataMember = "Manufacturer";
            this.bsManufactur.DataSource = this.avtoprofKOV2DataSet;
            // 
            // bsProvider
            // 
            this.bsProvider.DataMember = "Provider";
            this.bsProvider.DataSource = this.avtoprofKOV2DataSet;
            // 
            // cbPr
            // 
            this.cbPr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduct, "IdProvider", true));
            this.cbPr.DataSource = this.bsProvider;
            this.cbPr.DisplayMember = "NameProvider";
            this.cbPr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPr.FormattingEnabled = true;
            this.cbPr.Location = new System.Drawing.Point(303, 373);
            this.cbPr.Name = "cbPr";
            this.cbPr.Size = new System.Drawing.Size(121, 22);
            this.cbPr.TabIndex = 19;
            this.cbPr.ValueMember = "IdProvider";
            // 
            // cbMan
            // 
            this.cbMan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduct, "IdManufacturer", true));
            this.cbMan.DataSource = this.bsManufactur;
            this.cbMan.DisplayMember = "ManufacturerName";
            this.cbMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMan.FormattingEnabled = true;
            this.cbMan.Location = new System.Drawing.Point(303, 322);
            this.cbMan.Name = "cbMan";
            this.cbMan.Size = new System.Drawing.Size(121, 22);
            this.cbMan.TabIndex = 20;
            this.cbMan.ValueMember = "IdManufacturer";
            // 
            // cbCat
            // 
            this.cbCat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduct, "IdCategory", true));
            this.cbCat.DataSource = this.bsCategory;
            this.cbCat.DisplayMember = "CategoryName";
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(303, 274);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(121, 22);
            this.cbCat.TabIndex = 21;
            this.cbCat.ValueMember = "idCategory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Поставщик";
            // 
            // bLoadPhoto
            // 
            this.bLoadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bLoadPhoto.ForeColor = System.Drawing.Color.White;
            this.bLoadPhoto.Location = new System.Drawing.Point(427, 123);
            this.bLoadPhoto.Name = "bLoadPhoto";
            this.bLoadPhoto.Size = new System.Drawing.Size(37, 25);
            this.bLoadPhoto.TabIndex = 27;
            this.bLoadPhoto.Text = "добавить товар";
            this.bLoadPhoto.UseVisualStyleBackColor = false;
            this.bLoadPhoto.Click += new System.EventHandler(this.bLoadPhoto_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Location = new System.Drawing.Point(430, 312);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(123, 45);
            this.bSave.TabIndex = 29;
            this.bSave.Text = "Сохранить товар";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bsProductIF
            // 
            this.bsProductIF.DataMember = "Product";
            this.bsProductIF.DataSource = this.avtoprofKOV2DataSet;
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 404);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lPic);
            this.Controls.Add(this.bLoadPhoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.cbMan);
            this.Controls.Add(this.cbPr);
            this.Controls.Add(this.pbPhotoTovar);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.tbDes);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(productQuantityInStockLabel);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(productArticleNumberLabel);
            this.Controls.Add(this.tbArticl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEdit";
            this.Load += new System.EventHandler(this.FormAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoprofKOV2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoTovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManufactur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lNameForm;
        private System.Windows.Forms.PictureBox PbLogo;
        private avtoprofKOV2DataSet avtoprofKOV2DataSet;
        private avtoprofKOV2DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private avtoprofKOV2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbArticl;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbDes;
        private System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.Label lPic;
        private System.Windows.Forms.PictureBox pbPhotoTovar;
        private avtoprofKOV2DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource bsCategory;
        private System.Windows.Forms.BindingSource bsManufactur;
        private System.Windows.Forms.BindingSource bsProvider;
        private avtoprofKOV2DataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private avtoprofKOV2DataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.ComboBox cbPr;
        private System.Windows.Forms.ComboBox cbMan;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bLoadPhoto;
        private System.Windows.Forms.OpenFileDialog openPhoto;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.BindingSource bsProductIF;
    }
}