namespace HamzaeljayiEXOFINAL.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            label1 = new Label();
            panelLeft = new Panel();
            lblcount = new StatusStrip();
            groupBox1 = new GroupBox();
            btnrefresh = new Button();
            btndelete = new Button();
            btnadd = new Button();
            grpFilter = new GroupBox();
            cmbcategorie = new ComboBox();
            btnreinitialiser = new Button();
            grpSearch = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            lblstatus = new StatusStrip();
            dgvFAQs = new DataGridView();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            grpFilter.SuspendLayout();
            grpSearch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFAQs).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.BlueViolet;
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1027, 125);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(178, 45);
            label1.Name = "label1";
            label1.Size = new Size(431, 33);
            label1.TabIndex = 0;
            label1.Text = "Gestionnaire de FAQ - College Lasalle";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(lblcount);
            panelLeft.Controls.Add(groupBox1);
            panelLeft.Controls.Add(grpFilter);
            panelLeft.Controls.Add(grpSearch);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 125);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 532);
            panelLeft.TabIndex = 1;
            // 
            // lblcount
            // 
            lblcount.ImageScalingSize = new Size(20, 20);
            lblcount.Location = new Point(0, 510);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(250, 22);
            lblcount.TabIndex = 4;
            lblcount.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnrefresh);
            groupBox1.Controls.Add(btndelete);
            groupBox1.Controls.Add(btnadd);
            groupBox1.Location = new Point(0, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 198);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(29, 135);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(191, 47);
            btnrefresh.TabIndex = 2;
            btnrefresh.Text = "Rafraichir";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click_1;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.ForeColor = SystemColors.ButtonFace;
            btndelete.Location = new Point(29, 77);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(191, 52);
            btndelete.TabIndex = 1;
            btndelete.Text = "Supprimer";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click_1;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.Highlight;
            btnadd.ForeColor = SystemColors.ButtonFace;
            btnadd.Location = new Point(29, 26);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(191, 45);
            btnadd.TabIndex = 0;
            btnadd.Text = "Ajouter FAQ";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(cmbcategorie);
            grpFilter.Controls.Add(btnreinitialiser);
            grpFilter.Location = new Point(0, 125);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(250, 125);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filtre";
            // 
            // cmbcategorie
            // 
            cmbcategorie.FormattingEnabled = true;
            cmbcategorie.Location = new Point(29, 28);
            cmbcategorie.Name = "cmbcategorie";
            cmbcategorie.Size = new Size(191, 28);
            cmbcategorie.TabIndex = 2;
            cmbcategorie.Text = "--Toutes les categorie--";
            cmbcategorie.SelectedIndexChanged += cmbcategorie_SelectedIndexChanged;
            // 
            // btnreinitialiser
            // 
            btnreinitialiser.BackColor = SystemColors.Control;
            btnreinitialiser.ForeColor = SystemColors.ActiveCaptionText;
            btnreinitialiser.Location = new Point(29, 70);
            btnreinitialiser.Name = "btnreinitialiser";
            btnreinitialiser.Size = new Size(191, 49);
            btnreinitialiser.TabIndex = 1;
            btnreinitialiser.Text = "Reinitialiser";
            btnreinitialiser.UseVisualStyleBackColor = false;
            btnreinitialiser.Click += btnreinitialiser_Click;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Location = new Point(0, 0);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(250, 125);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Recherche";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.HotTrack;
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(29, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(191, 49);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Recherche";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(29, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblstatus);
            panel1.Controls.Add(dgvFAQs);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 532);
            panel1.TabIndex = 2;
            // 
            // lblstatus
            // 
            lblstatus.ImageScalingSize = new Size(20, 20);
            lblstatus.Location = new Point(0, 510);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(777, 22);
            lblstatus.TabIndex = 1;
            lblstatus.Text = "statusStrip2";
            // 
            // dgvFAQs
            // 
            dgvFAQs.AllowUserToAddRows = false;
            dgvFAQs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFAQs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFAQs.Dock = DockStyle.Fill;
            dgvFAQs.Location = new Point(0, 0);
            dgvFAQs.MultiSelect = false;
            dgvFAQs.Name = "dgvFAQs";
            dgvFAQs.ReadOnly = true;
            dgvFAQs.RowHeadersWidth = 51;
            dgvFAQs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFAQs.Size = new Size(777, 532);
            dgvFAQs.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 657);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "MainForm";
            Text = "MainForm - (Gestionnaire FAQ)";
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            groupBox1.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFAQs).EndInit();
            ResumeLayout(false);
            //      ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label1;
        private Panel panelLeft;
        private GroupBox grpSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private GroupBox grpFilter;
        private ComboBox cmbcategorie;
        private Button btnreinitialiser;
        private GroupBox groupBox1;
        private Button btnrefresh;
        private Button btndelete;
        private Button btnadd;
        private StatusStrip lblcount;
        private Panel panel1;
        private DataGridView dgvFAQs;
        private StatusStrip lblstatus;
    }
}
