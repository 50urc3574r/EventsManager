namespace EventManager
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname_rus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname_eng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname_rus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname_eng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_member_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveCSV = new System.Windows.Forms.SaveFileDialog();
            this.badgesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Stikers = new System.Windows.Forms.Button();
            this.csv_btn = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.Badges = new System.Windows.Forms.Button();
            this.StickersMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StickersDesing = new System.Windows.Forms.ToolStripMenuItem();
            this.StickersPrintAll = new System.Windows.Forms.ToolStripMenuItem();
            this.StickersPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.BadgesMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.List = new System.Windows.Forms.ToolStripMenuItem();
            this.BadgesDesing = new System.Windows.Forms.ToolStripMenuItem();
            this.BadgesPrintAll = new System.Windows.Forms.ToolStripMenuItem();
            this.BadgesPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Map_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Notes = new System.Windows.Forms.ToolStripMenuItem();
            this.Language = new System.Windows.Forms.ToolStripMenuItem();
            this.English = new System.Windows.Forms.ToolStripMenuItem();
            this.Russian = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgesBindingSource)).BeginInit();
            this.StickersMS.SuspendLayout();
            this.BadgesMS.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.password,
            this.firstname_rus,
            this.firstname_eng,
            this.lastname_rus,
            this.lastname_eng,
            this.country,
            this.city,
            this.company,
            this.mail});
            this.dataGridView1.DataSource = this.membersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 552);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.edit_btn_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // firstname_rus
            // 
            this.firstname_rus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstname_rus.DataPropertyName = "firstname_rus";
            this.firstname_rus.HeaderText = "firstname_rus";
            this.firstname_rus.Name = "firstname_rus";
            // 
            // firstname_eng
            // 
            this.firstname_eng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstname_eng.DataPropertyName = "firstname_eng";
            this.firstname_eng.HeaderText = "firstname_eng";
            this.firstname_eng.Name = "firstname_eng";
            // 
            // lastname_rus
            // 
            this.lastname_rus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastname_rus.DataPropertyName = "lastname_rus";
            this.lastname_rus.HeaderText = "lastname_rus";
            this.lastname_rus.Name = "lastname_rus";
            // 
            // lastname_eng
            // 
            this.lastname_eng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastname_eng.DataPropertyName = "lastname_eng";
            this.lastname_eng.HeaderText = "lastname_eng";
            this.lastname_eng.Name = "lastname_eng";
            // 
            // country
            // 
            this.country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "country";
            this.country.Name = "country";
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "city";
            this.city.Name = "city";
            // 
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.DataPropertyName = "company";
            this.company.HeaderText = "company";
            this.company.Name = "company";
            // 
            // mail
            // 
            this.mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "mail";
            this.mail.Name = "mail";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataSource = typeof(EventManager.Main.Members);
            // 
            // searchtextBox
            // 
            this.searchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtextBox.ForeColor = System.Drawing.Color.Black;
            this.searchtextBox.Location = new System.Drawing.Point(6, 28);
            this.searchtextBox.Multiline = true;
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(185, 20);
            this.searchtextBox.TabIndex = 3;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.add_member_btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Имя(анг)";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(85, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Пассворд";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(85, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 35;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(85, 50);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(85, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Юзернейм";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(85, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Имя";
            // 
            // add_member_btn
            // 
            this.add_member_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_member_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_member_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_member_btn.ForeColor = System.Drawing.Color.Black;
            this.add_member_btn.Location = new System.Drawing.Point(6, 286);
            this.add_member_btn.Name = "add_member_btn";
            this.add_member_btn.Size = new System.Drawing.Size(179, 32);
            this.add_member_btn.TabIndex = 49;
            this.add_member_btn.Text = "Добавить";
            this.add_member_btn.UseVisualStyleBackColor = false;
            this.add_member_btn.Click += new System.EventHandler(this.add_member_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(85, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(85, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Фамилия(анг)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Страна";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(85, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 43;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(85, 260);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Город";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(85, 234);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Компания";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 571);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // saveCSV
            // 
            this.saveCSV.DefaultExt = " ";
            this.saveCSV.Tag = "csv";
            // 
            // badgesBindingSource
            // 
            this.badgesBindingSource.DataMember = "Badges";
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(477, 28);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 8;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(315, 28);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(396, 28);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 10;
            this.edit_btn.Text = "Изменить";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Stikers
            // 
            this.Stikers.Location = new System.Drawing.Point(639, 28);
            this.Stikers.Name = "Stikers";
            this.Stikers.Size = new System.Drawing.Size(75, 23);
            this.Stikers.TabIndex = 11;
            this.Stikers.Text = "Наклейки";
            this.Stikers.UseVisualStyleBackColor = true;
            this.Stikers.Click += new System.EventHandler(this.Stikers_Click);
            // 
            // csv_btn
            // 
            this.csv_btn.Location = new System.Drawing.Point(558, 28);
            this.csv_btn.Name = "csv_btn";
            this.csv_btn.Size = new System.Drawing.Size(75, 23);
            this.csv_btn.TabIndex = 12;
            this.csv_btn.Text = "Экспорт";
            this.csv_btn.UseVisualStyleBackColor = true;
            this.csv_btn.Click += new System.EventHandler(this.csv_btn_Click);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(197, 28);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(112, 23);
            this.reload.TabIndex = 13;
            this.reload.Text = "Обновить";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Badges
            // 
            this.Badges.Location = new System.Drawing.Point(720, 28);
            this.Badges.Name = "Badges";
            this.Badges.Size = new System.Drawing.Size(75, 23);
            this.Badges.TabIndex = 14;
            this.Badges.Text = "Бейджи";
            this.Badges.UseVisualStyleBackColor = true;
            this.Badges.Click += new System.EventHandler(this.Badges_Click);
            // 
            // StickersMS
            // 
            this.StickersMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StickersDesing,
            this.StickersPrintAll,
            this.StickersPrint});
            this.StickersMS.Name = "contextMenuStrip1";
            this.StickersMS.Size = new System.Drawing.Size(185, 70);
            // 
            // StickersDesing
            // 
            this.StickersDesing.Name = "StickersDesing";
            this.StickersDesing.Size = new System.Drawing.Size(184, 22);
            this.StickersDesing.Text = "Шаблон";
            this.StickersDesing.Click += new System.EventHandler(this.StickersDesing_Click);
            // 
            // StickersPrintAll
            // 
            this.StickersPrintAll.Name = "StickersPrintAll";
            this.StickersPrintAll.Size = new System.Drawing.Size(184, 22);
            this.StickersPrintAll.Text = "Печать";
            this.StickersPrintAll.Click += new System.EventHandler(this.StickersPrintAll_Click);
            // 
            // StickersPrint
            // 
            this.StickersPrint.Name = "StickersPrint";
            this.StickersPrint.Size = new System.Drawing.Size(184, 22);
            this.StickersPrint.Text = "Печать выбранного";
            this.StickersPrint.Click += new System.EventHandler(this.StickersPrint_Click);
            // 
            // BadgesMS
            // 
            this.BadgesMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.List,
            this.BadgesDesing,
            this.BadgesPrintAll,
            this.BadgesPrint});
            this.BadgesMS.Name = "BadgesMS";
            this.BadgesMS.Size = new System.Drawing.Size(188, 92);
            // 
            // List
            // 
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(187, 22);
            this.List.Text = "Список";
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // BadgesDesing
            // 
            this.BadgesDesing.Name = "BadgesDesing";
            this.BadgesDesing.Size = new System.Drawing.Size(187, 22);
            this.BadgesDesing.Text = "Шаблон";
            this.BadgesDesing.Click += new System.EventHandler(this.BadgesDesing_Click);
            // 
            // BadgesPrintAll
            // 
            this.BadgesPrintAll.Name = "BadgesPrintAll";
            this.BadgesPrintAll.Size = new System.Drawing.Size(187, 22);
            this.BadgesPrintAll.Text = "Печать";
            this.BadgesPrintAll.Click += new System.EventHandler(this.BadgesPrintAll_Click);
            // 
            // BadgesPrint
            // 
            this.BadgesPrint.Name = "BadgesPrint";
            this.BadgesPrint.Size = new System.Drawing.Size(187, 22);
            this.BadgesPrint.Text = "Печать выбранного ";
            this.BadgesPrint.Click += new System.EventHandler(this.BadgesPrint_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Map_btn,
            this.Notes,
            this.Language});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Map_btn
            // 
            this.Map_btn.Name = "Map_btn";
            this.Map_btn.Size = new System.Drawing.Size(84, 20);
            this.Map_btn.Text = "Программа";
            this.Map_btn.Visible = false;
            // 
            // Notes
            // 
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(65, 20);
            this.Notes.Text = "Заметки";
            this.Notes.Click += new System.EventHandler(this.Notes_Click);
            // 
            // Language
            // 
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.English,
            this.Russian});
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(46, 20);
            this.Language.Text = "Язык";
            // 
            // English
            // 
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(152, 22);
            this.English.Text = "Английский";
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Russian
            // 
            this.Russian.Name = "Russian";
            this.Russian.Size = new System.Drawing.Size(152, 22);
            this.Russian.Text = "Русский";
            this.Russian.Click += new System.EventHandler(this.Russian_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 618);
            this.Controls.Add(this.Badges);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.csv_btn);
            this.Controls.Add(this.Stikers);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Участники ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badgesBindingSource)).EndInit();
            this.StickersMS.ResumeLayout(false);
            this.BadgesMS.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_member_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveCSV;
        private System.Windows.Forms.BindingSource badgesBindingSource;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname_rus;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname_eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname_rus;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname_eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button Stikers;
        private System.Windows.Forms.Button csv_btn;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button Badges;
        private System.Windows.Forms.ContextMenuStrip StickersMS;
        private System.Windows.Forms.ToolStripMenuItem StickersDesing;
        private System.Windows.Forms.ToolStripMenuItem StickersPrintAll;
        private System.Windows.Forms.ToolStripMenuItem StickersPrint;
        private System.Windows.Forms.ContextMenuStrip BadgesMS;
        private System.Windows.Forms.ToolStripMenuItem BadgesDesing;
        private System.Windows.Forms.ToolStripMenuItem BadgesPrint;
        private System.Windows.Forms.ToolStripMenuItem BadgesPrintAll;
        private System.Windows.Forms.ToolStripMenuItem List;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Map_btn;
        private System.Windows.Forms.ToolStripMenuItem Notes;
        private System.Windows.Forms.ToolStripMenuItem Language;
        private System.Windows.Forms.ToolStripMenuItem English;
        private System.Windows.Forms.ToolStripMenuItem Russian;
    }
}

