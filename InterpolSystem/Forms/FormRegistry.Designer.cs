namespace InterpolSystem.Forms
{
    partial class FormRegistry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            buttonClear = new Button();
            buttonSearch = new Button();
            txtSearch = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            buttonArchive = new Button();
            buttonHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(911, 475);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonArchive);
            panel1.Controls.Add(buttonHome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 100);
            panel1.TabIndex = 1;
            panel1.TabStop = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(800, 65);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(82, 29);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Очистити";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(800, 30);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(82, 29);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(646, 49);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(148, 27);
            txtSearch.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top;
            buttonAdd.Location = new Point(507, 49);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 0;
            label1.Text = "INTERPOL DATABASE";
            // 
            // buttonArchive
            // 
            buttonArchive.Anchor = AnchorStyles.Top;
            buttonArchive.Location = new Point(391, 49);
            buttonArchive.Name = "buttonArchive";
            buttonArchive.Size = new Size(94, 29);
            buttonArchive.TabIndex = 3;
            buttonArchive.Text = "Архів";
            buttonArchive.UseVisualStyleBackColor = true;
            buttonArchive.Click += buttonArchive_Click;
            // 
            // buttonHome
            // 
            buttonHome.Anchor = AnchorStyles.Top;
            buttonHome.Location = new Point(271, 49);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(94, 29);
            buttonHome.TabIndex = 2;
            buttonHome.Text = "Головна";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // FormRegistry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(911, 575);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "FormRegistry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistry";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonHome;
        private Button buttonArchive;
        private Button buttonRegistry;
        private Button buttonAdd;
        private Panel panelTop;
        private Label labelTitle;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtSearch;
        private Button buttonClear;
        private Button buttonSearch;
    }
}