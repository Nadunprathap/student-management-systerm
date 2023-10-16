
namespace WindowsFormsApp4
{
    partial class Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentTbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.departmentlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Detailstab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Departmenttab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApp4.databaseDataSet1();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.departmentTbTableAdapter = new WindowsFormsApp4.databaseDataSet1TableAdapters.DepartmentTbTableAdapter();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentlist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.departmentlist);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 673);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.departmentTbBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(272, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departmentTbBindingSource1
            // 
            this.departmentTbBindingSource1.DataMember = "DepartmentTb";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // departmentlist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.departmentlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.departmentlist.ColumnHeadersHeight = 4;
            this.departmentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.departmentlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.departmentlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.departmentlist.Location = new System.Drawing.Point(272, 57);
            this.departmentlist.Name = "departmentlist";
            this.departmentlist.RowHeadersVisible = false;
            this.departmentlist.Size = new System.Drawing.Size(458, 604);
            this.departmentlist.TabIndex = 2;
            this.departmentlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.departmentlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.departmentlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.departmentlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.departmentlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.departmentlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.departmentlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.departmentlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.departmentlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.departmentlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.departmentlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.departmentlist.ThemeStyle.HeaderStyle.Height = 4;
            this.departmentlist.ThemeStyle.ReadOnly = false;
            this.departmentlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.departmentlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.departmentlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.departmentlist.ThemeStyle.RowsStyle.Height = 22;
            this.departmentlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.departmentlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.departmentlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentlist_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Updatebtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Detailstab);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Departmenttab);
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 611);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(72, 25);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 91);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.DeepPink;
            this.Deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Deletebtn.Location = new System.Drawing.Point(72, 503);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(104, 29);
            this.Deletebtn.TabIndex = 17;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Updatebtn.Location = new System.Drawing.Point(132, 456);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(104, 29);
            this.Updatebtn.TabIndex = 16;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Chartreuse;
            this.Addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Addbtn.Location = new System.Drawing.Point(15, 456);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(107, 29);
            this.Addbtn.TabIndex = 15;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Department Dtails";
            // 
            // Detailstab
            // 
            this.Detailstab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Detailstab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detailstab.Location = new System.Drawing.Point(15, 311);
            this.Detailstab.Multiline = true;
            this.Detailstab.Name = "Detailstab";
            this.Detailstab.Size = new System.Drawing.Size(233, 92);
            this.Detailstab.TabIndex = 10;
            this.Detailstab.TextChanged += new System.EventHandler(this.Detailstab_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Name";
            // 
            // Departmenttab
            // 
            this.Departmenttab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Departmenttab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departmenttab.Location = new System.Drawing.Point(15, 221);
            this.Departmenttab.Name = "Departmenttab";
            this.Departmenttab.Size = new System.Drawing.Size(233, 22);
            this.Departmenttab.TabIndex = 3;
            this.Departmenttab.TextChanged += new System.EventHandler(this.Departmenttab_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // departmentTbBindingSource
            // 
            this.departmentTbBindingSource.DataMember = "DepartmentTb";
            this.departmentTbBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(-1, 613);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(194, 39);
            this.panel10.TabIndex = 19;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(99, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Logout";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(-1, 371);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(210, 39);
            this.panel8.TabIndex = 20;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(77, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dashbord";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(-1, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Department mange";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(-1, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 39);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(77, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Department";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(-1, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 39);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(62, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Student mange";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // departmentTbTableAdapter
            // 
            this.departmentTbTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.Addbtn;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.Updatebtn;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.Deletebtn;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(-1, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 39);
            this.panel4.TabIndex = 20;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(77, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Menu";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 673);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView departmentlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Detailstab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Departmenttab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private databaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource departmentTbBindingSource;
        private databaseDataSet1TableAdapters.DepartmentTbTableAdapter departmentTbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDetailsDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
     //   private databaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource departmentTbBindingSource1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label14;
        //   private databaseDataSet3TableAdapters.DepartmentTbTableAdapter departmentTbTableAdapter1;
    }
}