
namespace СУБД_Автопроф
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bGuest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.avtoprofKOV2DataSet = new СУБД_Автопроф.avtoprofKOV2DataSet();
            this.BsUser = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new СУБД_Автопроф.avtoprofKOV2DataSetTableAdapters.UserTableAdapter();
            this.pCaptcha = new System.Windows.Forms.Panel();
            this.lT1 = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.lT2 = new System.Windows.Forms.Label();
            this.lT3 = new System.Windows.Forms.Label();
            this.lT4 = new System.Windows.Forms.Label();
            this.tbCap = new System.Windows.Forms.TextBox();
            this.pInputCap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tBlock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoprofKOV2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsUser)).BeginInit();
            this.pCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.pInputCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.Location = new System.Drawing.Point(213, 196);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(123, 25);
            this.bLogin.TabIndex = 1;
            this.bLogin.Text = "Войти";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(0, 144);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(198, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(0, 196);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(198, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // bGuest
            // 
            this.bGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
            this.bGuest.ForeColor = System.Drawing.Color.White;
            this.bGuest.Location = new System.Drawing.Point(343, 196);
            this.bGuest.Name = "bGuest";
            this.bGuest.Size = new System.Drawing.Size(157, 25);
            this.bGuest.TabIndex = 4;
            this.bGuest.Text = "Войти как гость";
            this.bGuest.UseVisualStyleBackColor = false;
            this.bGuest.Click += new System.EventHandler(this.bGuest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // avtoprofKOV2DataSet
            // 
            this.avtoprofKOV2DataSet.DataSetName = "avtoprofKOV2DataSet";
            this.avtoprofKOV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsUser
            // 
            this.BsUser.DataMember = "User";
            this.BsUser.DataSource = this.avtoprofKOV2DataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // pCaptcha
            // 
            this.pCaptcha.BackgroundImage = global::СУБД_Автопроф.Properties.Resources.CapcthaPaint;
            this.pCaptcha.Controls.Add(this.lT4);
            this.pCaptcha.Controls.Add(this.lT3);
            this.pCaptcha.Controls.Add(this.lT2);
            this.pCaptcha.Controls.Add(this.lT1);
            this.pCaptcha.Location = new System.Drawing.Point(3, 3);
            this.pCaptcha.Name = "pCaptcha";
            this.pCaptcha.Size = new System.Drawing.Size(120, 60);
            this.pCaptcha.TabIndex = 8;
            this.pCaptcha.Click += new System.EventHandler(this.pCaptcha_Click);
            this.pCaptcha.Paint += new System.Windows.Forms.PaintEventHandler(this.pCaptcha_Paint);
            // 
            // lT1
            // 
            this.lT1.AutoSize = true;
            this.lT1.BackColor = System.Drawing.Color.Transparent;
            this.lT1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT1.Location = new System.Drawing.Point(3, 19);
            this.lT1.Name = "lT1";
            this.lT1.Size = new System.Drawing.Size(36, 33);
            this.lT1.TabIndex = 1;
            this.lT1.Text = "A";
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbLogo.Image = global::СУБД_Автопроф.Properties.Resources.logo;
            this.PbLogo.Location = new System.Drawing.Point(406, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(117, 108);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // lT2
            // 
            this.lT2.AutoSize = true;
            this.lT2.BackColor = System.Drawing.Color.Transparent;
            this.lT2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT2.Location = new System.Drawing.Point(43, 0);
            this.lT2.Name = "lT2";
            this.lT2.Size = new System.Drawing.Size(36, 33);
            this.lT2.TabIndex = 2;
            this.lT2.Text = "A";
            // 
            // lT3
            // 
            this.lT3.AutoSize = true;
            this.lT3.BackColor = System.Drawing.Color.Transparent;
            this.lT3.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT3.Location = new System.Drawing.Point(53, 25);
            this.lT3.Name = "lT3";
            this.lT3.Size = new System.Drawing.Size(36, 33);
            this.lT3.TabIndex = 3;
            this.lT3.Text = "A";
            // 
            // lT4
            // 
            this.lT4.AutoSize = true;
            this.lT4.BackColor = System.Drawing.Color.Transparent;
            this.lT4.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lT4.Location = new System.Drawing.Point(86, 8);
            this.lT4.Name = "lT4";
            this.lT4.Size = new System.Drawing.Size(36, 33);
            this.lT4.TabIndex = 4;
            this.lT4.Text = "A";
            this.lT4.Click += new System.EventHandler(this.lT4_Click);
            // 
            // tbCap
            // 
            this.tbCap.Location = new System.Drawing.Point(130, 41);
            this.tbCap.Name = "tbCap";
            this.tbCap.Size = new System.Drawing.Size(157, 20);
            this.tbCap.TabIndex = 9;
            // 
            // pInputCap
            // 
            this.pInputCap.Controls.Add(this.label2);
            this.pInputCap.Controls.Add(this.pCaptcha);
            this.pInputCap.Controls.Add(this.tbCap);
            this.pInputCap.Location = new System.Drawing.Point(213, 118);
            this.pInputCap.Name = "pInputCap";
            this.pInputCap.Size = new System.Drawing.Size(298, 67);
            this.pInputCap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите каптчу";
            // 
            // tBlock
            // 
            this.tBlock.Interval = 10000;
            this.tBlock.Tick += new System.EventHandler(this.tBlock_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 229);
            this.Controls.Add(this.pInputCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bGuest);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"Автопроффесионал\"";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoprofKOV2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsUser)).EndInit();
            this.pCaptcha.ResumeLayout(false);
            this.pCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.pInputCap.ResumeLayout(false);
            this.pInputCap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private avtoprofKOV2DataSet avtoprofKOV2DataSet;
        private System.Windows.Forms.BindingSource BsUser;
        private avtoprofKOV2DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Panel pCaptcha;
        private System.Windows.Forms.Label lT1;
        private System.Windows.Forms.Label lT4;
        private System.Windows.Forms.Label lT3;
        private System.Windows.Forms.Label lT2;
        private System.Windows.Forms.TextBox tbCap;
        private System.Windows.Forms.Panel pInputCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tBlock;
    }
}

