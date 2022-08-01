
namespace СУБД_Автопроф
{
    partial class FormTovar
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
            System.Windows.Forms.Label userSurnameLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userPatronymicLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTovar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lCountRecord = new System.Windows.Forms.Label();
            this.userPatronymicLabel1 = new System.Windows.Forms.Label();
            this.BsUser = new System.Windows.Forms.BindingSource(this.components);
            this.avtoprofKOV2DataSet = new СУБД_Автопроф.avtoprofKOV2DataSet();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.userSurnameLabel1 = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbDiscription = new System.Windows.Forms.CheckBox();
            this.cbProzvod = new System.Windows.Forms.CheckBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.cbCounts = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.comBoxMan = new System.Windows.Forms.ComboBox();
            this.bsManuf = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.userTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.TableAdapterManager();
            this.allmanufacturerTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.AllmanufacturerTableAdapter();
            this.comBoxSort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.ProductTableAdapter();
            this.bsOrderPr = new System.Windows.Forms.BindingSource(this.components);
            this.orderProductTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.OrderProductTableAdapter();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.lRole = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StL = new System.Windows.Forms.ToolStripStatusLabel();
            userSurnameLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userPatronymicLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoprofKOV2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManuf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderPr)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSurnameLabel
            // 
            userSurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userSurnameLabel.AutoSize = true;
            userSurnameLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            userSurnameLabel.Location = new System.Drawing.Point(717, 11);
            userSurnameLabel.Name = "userSurnameLabel";
            userSurnameLabel.Size = new System.Drawing.Size(71, 17);
            userSurnameLabel.TabIndex = 1;
            userSurnameLabel.Text = "Фамилия";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            userNameLabel.Location = new System.Drawing.Point(719, 34);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(35, 17);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Имя";
            // 
            // userPatronymicLabel
            // 
            userPatronymicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userPatronymicLabel.AutoSize = true;
            userPatronymicLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            userPatronymicLabel.Location = new System.Drawing.Point(717, 57);
            userPatronymicLabel.Name = "userPatronymicLabel";
            userPatronymicLabel.Size = new System.Drawing.Size(80, 17);
            userPatronymicLabel.TabIndex = 1;
            userPatronymicLabel.Text = "Отчество";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(userPatronymicLabel);
            this.panel1.Controls.Add(userNameLabel);
            this.panel1.Controls.Add(this.lCountRecord);
            this.panel1.Controls.Add(this.userPatronymicLabel1);
            this.panel1.Controls.Add(userSurnameLabel);
            this.panel1.Controls.Add(this.userNameLabel1);
            this.panel1.Controls.Add(this.userSurnameLabel1);
            this.panel1.Controls.Add(this.PbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 108);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(360, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Товары";
            // 
            // lCountRecord
            // 
            this.lCountRecord.AutoSize = true;
            this.lCountRecord.Location = new System.Drawing.Point(739, 85);
            this.lCountRecord.Name = "lCountRecord";
            this.lCountRecord.Size = new System.Drawing.Size(49, 14);
            this.lCountRecord.TabIndex = 4;
            this.lCountRecord.Text = "label6";
            // 
            // userPatronymicLabel1
            // 
            this.userPatronymicLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPatronymicLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUser, "UserPatronymic", true));
            this.userPatronymicLabel1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPatronymicLabel1.Location = new System.Drawing.Point(842, 57);
            this.userPatronymicLabel1.Name = "userPatronymicLabel1";
            this.userPatronymicLabel1.Size = new System.Drawing.Size(100, 23);
            this.userPatronymicLabel1.TabIndex = 2;
            this.userPatronymicLabel1.Text = "label1";
            // 
            // BsUser
            // 
            this.BsUser.DataMember = "User";
            this.BsUser.DataSource = this.avtoprofKOV2DataSet;
            // 
            // avtoprofKOV2DataSet
            // 
            this.avtoprofKOV2DataSet.DataSetName = "avtoprofKOV2DataSet";
            this.avtoprofKOV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUser, "UserName", true));
            this.userNameLabel1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel1.Location = new System.Drawing.Point(842, 34);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 2;
            this.userNameLabel1.Text = "label1";
            // 
            // userSurnameLabel1
            // 
            this.userSurnameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userSurnameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUser, "UserSurname", true));
            this.userSurnameLabel1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameLabel1.Location = new System.Drawing.Point(842, 11);
            this.userSurnameLabel1.Name = "userSurnameLabel1";
            this.userSurnameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userSurnameLabel1.TabIndex = 2;
            this.userSurnameLabel1.Text = "label1";
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbLogo.Image = global::СУБД_Автопроф.Properties.Resources.logo;
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(117, 108);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // DgvProduct
            // 
            this.DgvProduct.AllowUserToAddRows = false;
            this.DgvProduct.AllowUserToDeleteRows = false;
            this.DgvProduct.AllowUserToResizeColumns = false;
            this.DgvProduct.AllowUserToResizeRows = false;
            this.DgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.DgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.ColumnHeadersVisible = false;
            this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvProduct.GridColor = System.Drawing.Color.White;
            this.DgvProduct.Location = new System.Drawing.Point(0, 189);
            this.DgvProduct.MultiSelect = false;
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.ReadOnly = true;
            this.DgvProduct.RowHeadersVisible = false;
            this.DgvProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.DgvProduct.RowTemplate.DividerHeight = 20;
            this.DgvProduct.RowTemplate.Height = 100;
            this.DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProduct.Size = new System.Drawing.Size(954, 254);
            this.DgvProduct.TabIndex = 2;
            this.DgvProduct.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProduct_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Артикуль";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фото";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Продукт";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Кол-во";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск по: ";
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(85, 121);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(110, 18);
            this.cbName.TabIndex = 4;
            this.cbName.Text = "Наименованию";
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cbName_CheckedChanged);
            // 
            // cbDiscription
            // 
            this.cbDiscription.AutoSize = true;
            this.cbDiscription.Location = new System.Drawing.Point(201, 121);
            this.cbDiscription.Name = "cbDiscription";
            this.cbDiscription.Size = new System.Drawing.Size(82, 18);
            this.cbDiscription.TabIndex = 5;
            this.cbDiscription.Text = "Описанию";
            this.cbDiscription.UseVisualStyleBackColor = true;
            this.cbDiscription.CheckedChanged += new System.EventHandler(this.cbDiscription_CheckedChanged);
            // 
            // cbProzvod
            // 
            this.cbProzvod.AutoSize = true;
            this.cbProzvod.Location = new System.Drawing.Point(289, 122);
            this.cbProzvod.Name = "cbProzvod";
            this.cbProzvod.Size = new System.Drawing.Size(117, 18);
            this.cbProzvod.TabIndex = 6;
            this.cbProzvod.Text = "Производителю";
            this.cbProzvod.UseVisualStyleBackColor = true;
            this.cbProzvod.CheckedChanged += new System.EventHandler(this.cbProzvod_CheckedChanged);
            // 
            // cbPrice
            // 
            this.cbPrice.AutoSize = true;
            this.cbPrice.Location = new System.Drawing.Point(334, 151);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(54, 18);
            this.cbPrice.TabIndex = 7;
            this.cbPrice.Text = "Цене";
            this.cbPrice.UseVisualStyleBackColor = true;
            this.cbPrice.CheckedChanged += new System.EventHandler(this.cbcbPrice_CheckedChanged);
            // 
            // cbCounts
            // 
            this.cbCounts.AutoSize = true;
            this.cbCounts.Location = new System.Drawing.Point(394, 151);
            this.cbCounts.Name = "cbCounts";
            this.cbCounts.Size = new System.Drawing.Size(68, 18);
            this.cbCounts.TabIndex = 8;
            this.cbCounts.Text = "Кол-ву";
            this.cbCounts.UseVisualStyleBackColor = true;
            this.cbCounts.CheckedChanged += new System.EventHandler(this.cbCounts_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Строка для поиска";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(144, 149);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(184, 20);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // comBoxMan
            // 
            this.comBoxMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comBoxMan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsManuf, "manufacturerName", true));
            this.comBoxMan.DataSource = this.bsManuf;
            this.comBoxMan.DisplayMember = "manufacturerName";
            this.comBoxMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMan.FormattingEnabled = true;
            this.comBoxMan.Location = new System.Drawing.Point(179, 451);
            this.comBoxMan.Name = "comBoxMan";
            this.comBoxMan.Size = new System.Drawing.Size(149, 22);
            this.comBoxMan.TabIndex = 11;
            this.comBoxMan.ValueMember = "manufacturerName";
            this.comBoxMan.SelectedIndexChanged += new System.EventHandler(this.comBoxMan_SelectedIndexChanged);
            // 
            // bsManuf
            // 
            this.bsManuf.DataMember = "Allmanufacturer";
            this.bsManuf.DataSource = this.avtoprofKOV2DataSet;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выберите производителя";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickUpPointTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // allmanufacturerTableAdapter
            // 
            this.allmanufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // comBoxSort
            // 
            this.comBoxSort.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsManuf, "manufacturerName", true));
            this.comBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxSort.FormattingEnabled = true;
            this.comBoxSort.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.comBoxSort.Location = new System.Drawing.Point(468, 147);
            this.comBoxSort.Name = "comBoxSort";
            this.comBoxSort.Size = new System.Drawing.Size(158, 22);
            this.comBoxSort.TabIndex = 13;
            this.comBoxSort.SelectedIndexChanged += new System.EventHandler(this.comBoxSort_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Выберите тип сортировки";
            // 
            // bsProducts
            // 
            this.bsProducts.DataMember = "Product";
            this.bsProducts.DataSource = this.avtoprofKOV2DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // bsOrderPr
            // 
            this.bsOrderPr.DataMember = "OrderProduct";
            this.bsOrderPr.DataSource = this.avtoprofKOV2DataSet;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(334, 449);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(123, 25);
            this.bAdd.TabIndex = 15;
            this.bAdd.Text = "добавить товар";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bDel.ForeColor = System.Drawing.Color.White;
            this.bDel.Location = new System.Drawing.Point(463, 449);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(123, 25);
            this.bDel.TabIndex = 16;
            this.bDel.Text = "удалить";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.BackColor = System.Drawing.Color.Transparent;
            this.lRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUser, "UserRole", true));
            this.lRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.lRole.ForeColor = System.Drawing.Color.Transparent;
            this.lRole.Location = new System.Drawing.Point(905, 108);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(49, 14);
            this.lRole.TabIndex = 4;
            this.lRole.Text = "label6";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StL
            // 
            this.StL.BackColor = System.Drawing.Color.Transparent;
            this.StL.Name = "StL";
            this.StL.Size = new System.Drawing.Size(118, 17);
            this.StL.Text = "toolStripStatusLabel1";
            // 
            // FormTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lRole);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBoxMan);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCounts);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.cbProzvod);
            this.Controls.Add(this.cbDiscription);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(970, 540);
            this.Name = "FormTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"Автопроффесионал\"";
            this.Load += new System.EventHandler(this.FormTovar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoprofKOV2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManuf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderPr)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbLogo;
        private avtoprofKOV2DataSet avtoprofKOV2DataSet;
        private avtoprofKOV2DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label userPatronymicLabel1;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.Label userSurnameLabel1;
        private avtoprofKOV2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource BsUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbDiscription;
        private System.Windows.Forms.CheckBox cbProzvod;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbCounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox comBoxMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsManuf;
        private avtoprofKOV2DataSetTableAdapters.AllmanufacturerTableAdapter allmanufacturerTableAdapter;
        private System.Windows.Forms.ComboBox comBoxSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lCountRecord;
        private System.Windows.Forms.BindingSource bsProducts;
        private avtoprofKOV2DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource bsOrderPr;
        private avtoprofKOV2DataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StL;
    }
}