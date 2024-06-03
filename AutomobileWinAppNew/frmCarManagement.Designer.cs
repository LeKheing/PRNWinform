namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            txtCarID = new TextBox();
            txtManufacturer = new TextBox();
            txtCarName = new TextBox();
            lbPrice = new Label();
            label5 = new Label();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(25, 37);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(25, 73);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(25, 111);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(113, 29);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(252, 23);
            txtCarID.TabIndex = 1;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(113, 103);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(252, 23);
            txtManufacturer.TabIndex = 1;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(113, 65);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(252, 23);
            txtCarName.TabIndex = 1;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(405, 37);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 73);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 0;
            label5.Text = "Released Year";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(494, 29);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(251, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(494, 65);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(251, 23);
            txtReleaseYear.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(113, 143);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(85, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(320, 143);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(85, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(513, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 183);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(776, 220);
            dgvCarList.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(320, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(txtManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(label5);
            Controls.Add(lbManufacturer);
            Controls.Add(lbPrice);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private TextBox txtCarID;
        private TextBox txtManufacturer;
        private TextBox txtCarName;
        private Label lbPrice;
        private Label label5;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}