﻿namespace TTC_Payroll_System.Forms
{
    partial class PayrollSummaryTeachers1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollSummaryTeachers1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.lblSummaryDate = new System.Windows.Forms.Label();
            this.pnlPrint2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCenterAdministrator = new System.Windows.Forms.Label();
            this.lblAccountingAssistant = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPayroll1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHalfMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSssLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPagibigRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPagibigCalamity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcLeaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcWithTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlPrint2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnExportToExcel);
            this.panel1.Controls.Add(this.pnlPrint);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnPayslip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 562);
            this.panel1.TabIndex = 1;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportToExcel.BackColor = System.Drawing.Color.Silver;
            this.btnExportToExcel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportToExcel.FlatAppearance.BorderSize = 2;
            this.btnExportToExcel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
            this.btnExportToExcel.Location = new System.Drawing.Point(793, 493);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(65, 65);
            this.btnExportToExcel.TabIndex = 4;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // pnlPrint
            // 
            this.pnlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.lblSummaryDate);
            this.pnlPrint.Controls.Add(this.pnlPrint2);
            this.pnlPrint.Controls.Add(this.pictureBox2);
            this.pnlPrint.Controls.Add(this.pictureBox1);
            this.pnlPrint.Controls.Add(this.label3);
            this.pnlPrint.Controls.Add(this.label2);
            this.pnlPrint.Controls.Add(this.label1);
            this.pnlPrint.Controls.Add(this.dgvPayroll1);
            this.pnlPrint.Location = new System.Drawing.Point(3, 3);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(993, 488);
            this.pnlPrint.TabIndex = 32;
            // 
            // lblSummaryDate
            // 
            this.lblSummaryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryDate.Location = new System.Drawing.Point(-1, 85);
            this.lblSummaryDate.Name = "lblSummaryDate";
            this.lblSummaryDate.Size = new System.Drawing.Size(987, 19);
            this.lblSummaryDate.TabIndex = 11;
            this.lblSummaryDate.Text = "Payroll Summary for Date";
            this.lblSummaryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPrint2
            // 
            this.pnlPrint2.Controls.Add(this.label5);
            this.pnlPrint2.Controls.Add(this.lblCenterAdministrator);
            this.pnlPrint2.Controls.Add(this.lblAccountingAssistant);
            this.pnlPrint2.Controls.Add(this.label6);
            this.pnlPrint2.Controls.Add(this.label4);
            this.pnlPrint2.Controls.Add(this.label8);
            this.pnlPrint2.Location = new System.Drawing.Point(3, 394);
            this.pnlPrint2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlPrint2.Name = "pnlPrint2";
            this.pnlPrint2.Size = new System.Drawing.Size(987, 93);
            this.pnlPrint2.TabIndex = 12;
            this.pnlPrint2.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Accounting Officer";
            // 
            // lblCenterAdministrator
            // 
            this.lblCenterAdministrator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCenterAdministrator.AutoSize = true;
            this.lblCenterAdministrator.Location = new System.Drawing.Point(692, 60);
            this.lblCenterAdministrator.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.lblCenterAdministrator.Name = "lblCenterAdministrator";
            this.lblCenterAdministrator.Size = new System.Drawing.Size(35, 13);
            this.lblCenterAdministrator.TabIndex = 9;
            this.lblCenterAdministrator.Text = "Name";
            // 
            // lblAccountingAssistant
            // 
            this.lblAccountingAssistant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAccountingAssistant.AutoSize = true;
            this.lblAccountingAssistant.Location = new System.Drawing.Point(94, 60);
            this.lblAccountingAssistant.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.lblAccountingAssistant.Name = "lblAccountingAssistant";
            this.lblAccountingAssistant.Size = new System.Drawing.Size(35, 13);
            this.lblAccountingAssistant.TabIndex = 9;
            this.lblAccountingAssistant.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Approved by:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prepared by:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(692, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Admin Officer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(641, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 53);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Luisita Business Park, San Miguel, Tarlac City";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "TARLAC TRAINING CENTER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jose and Demetria Cojuanco Foundation Inc.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvPayroll1
            // 
            this.dgvPayroll1.AllowUserToAddRows = false;
            this.dgvPayroll1.AllowUserToDeleteRows = false;
            this.dgvPayroll1.AllowUserToResizeColumns = false;
            this.dgvPayroll1.AllowUserToResizeRows = false;
            this.dgvPayroll1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayroll1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colEmployeeName,
            this.colPosition,
            this.colMonthlyRate,
            this.colHalfMonth,
            this.dgcSssLoan,
            this.dgcPagibigRegular,
            this.dgcPagibigCalamity,
            this.dgcLeaves,
            this.dgcWithTax,
            this.dgcNetPay});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayroll1.EnableHeadersVisualStyles = false;
            this.dgvPayroll1.Location = new System.Drawing.Point(0, 118);
            this.dgvPayroll1.Name = "dgvPayroll1";
            this.dgvPayroll1.RowHeadersVisible = false;
            this.dgvPayroll1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayroll1.Size = new System.Drawing.Size(990, 273);
            this.dgvPayroll1.TabIndex = 2;
            this.dgvPayroll1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayroll1_CellEndEdit);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmployeeName.FillWeight = 27F;
            this.colEmployeeName.HeaderText = "EMPLOYEE";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.ReadOnly = true;
            this.colEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPosition
            // 
            this.colPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPosition.FillWeight = 14F;
            this.colPosition.HeaderText = "POSITION";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMonthlyRate
            // 
            this.colMonthlyRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMonthlyRate.FillWeight = 7F;
            this.colMonthlyRate.HeaderText = "MONTHLY RATE";
            this.colMonthlyRate.Name = "colMonthlyRate";
            this.colMonthlyRate.ReadOnly = true;
            this.colMonthlyRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHalfMonth
            // 
            this.colHalfMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHalfMonth.FillWeight = 7F;
            this.colHalfMonth.HeaderText = "HALF MONTH";
            this.colHalfMonth.Name = "colHalfMonth";
            this.colHalfMonth.ReadOnly = true;
            this.colHalfMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcSssLoan
            // 
            this.dgcSssLoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcSssLoan.FillWeight = 7F;
            this.dgcSssLoan.HeaderText = "SSS LOAN";
            this.dgcSssLoan.Name = "dgcSssLoan";
            this.dgcSssLoan.ReadOnly = true;
            this.dgcSssLoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgcPagibigRegular
            // 
            this.dgcPagibigRegular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPagibigRegular.FillWeight = 7F;
            this.dgcPagibigRegular.HeaderText = "REGULAR";
            this.dgcPagibigRegular.Name = "dgcPagibigRegular";
            this.dgcPagibigRegular.ReadOnly = true;
            this.dgcPagibigRegular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcPagibigCalamity
            // 
            this.dgcPagibigCalamity.HeaderText = "CALAMITY";
            this.dgcPagibigCalamity.Name = "dgcPagibigCalamity";
            this.dgcPagibigCalamity.ReadOnly = true;
            this.dgcPagibigCalamity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcLeaves
            // 
            this.dgcLeaves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcLeaves.FillWeight = 7F;
            this.dgcLeaves.HeaderText = "LEAVES W/O PAY";
            this.dgcLeaves.Name = "dgcLeaves";
            this.dgcLeaves.ReadOnly = true;
            this.dgcLeaves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcWithTax
            // 
            this.dgcWithTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcWithTax.FillWeight = 9F;
            this.dgcWithTax.HeaderText = "WITHHOLDING TAX";
            this.dgcWithTax.Name = "dgcWithTax";
            this.dgcWithTax.ReadOnly = true;
            this.dgcWithTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcNetPay
            // 
            this.dgcNetPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcNetPay.FillWeight = 7F;
            this.dgcNetPay.HeaderText = "NETPAY";
            this.dgcNetPay.Name = "dgcNetPay";
            this.dgcNetPay.ReadOnly = true;
            this.dgcNetPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(3, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 65);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Silver;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(931, 493);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 65);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayslip
            // 
            this.btnPayslip.BackColor = System.Drawing.Color.Silver;
            this.btnPayslip.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPayslip.FlatAppearance.BorderSize = 2;
            this.btnPayslip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayslip.Image = ((System.Drawing.Image)(resources.GetObject("btnPayslip.Image")));
            this.btnPayslip.Location = new System.Drawing.Point(864, 493);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(65, 65);
            this.btnPayslip.TabIndex = 3;
            this.btnPayslip.Text = "PAYSLIP PRINT";
            this.btnPayslip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayslip.UseVisualStyleBackColor = false;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // PayrollSummaryTeachers1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1009, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayrollSummaryTeachers1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollSummaryforTeachers1";
            this.Load += new System.EventHandler(this.PayrollSummary1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            this.pnlPrint2.ResumeLayout(false);
            this.pnlPrint2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPayroll1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPayslip;
        private System.Windows.Forms.Panel pnlPrint2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCenterAdministrator;
        private System.Windows.Forms.Label lblAccountingAssistant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label lblSummaryDate;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthlyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHalfMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSssLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPagibigRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPagibigCalamity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLeaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcWithTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNetPay;
    }
}