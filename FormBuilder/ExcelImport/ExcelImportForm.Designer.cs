namespace Gerdoo.Helper.ExcelImport
{
    partial class ExcelImportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorkerLoading = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.loadingControlLoad = new Gerdoo.UserControls.LoadingControl();
            this.buttonRemoveFromResultGrid = new System.Windows.Forms.Button();
            this.buttonAddToResultGrid = new System.Windows.Forms.Button();
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.excelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCommand = new System.Windows.Forms.Panel();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.buttonOpenExcelFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxRepitiveName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewMappedData = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaveError = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panelCommand.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMappedData)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorkerLoading
            // 
            this.backgroundWorkerLoading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerLoading.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1264, 782);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panelGrid);
            this.tabPage1.Controls.Add(this.panelCommand);
            this.tabPage1.Controls.Add(this.panelTop);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1256, 744);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مرحله اول";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.loadingControlLoad);
            this.panelGrid.Controls.Add(this.buttonRemoveFromResultGrid);
            this.panelGrid.Controls.Add(this.buttonAddToResultGrid);
            this.panelGrid.Controls.Add(this.dataGridViewExcel);
            this.panelGrid.Controls.Add(this.dataGridViewResult);
            this.panelGrid.Controls.Add(this.label5);
            this.panelGrid.Controls.Add(this.label4);
            this.panelGrid.Enabled = false;
            this.panelGrid.Location = new System.Drawing.Point(10, 108);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1236, 547);
            this.panelGrid.TabIndex = 1;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // loadingControlLoad
            // 
            this.loadingControlLoad.BackColor = System.Drawing.Color.White;
            this.loadingControlLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadingControlLoad.Location = new System.Drawing.Point(529, 241);
            this.loadingControlLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadingControlLoad.Name = "loadingControlLoad";
            this.loadingControlLoad.Size = new System.Drawing.Size(186, 155);
            this.loadingControlLoad.TabIndex = 2;
            this.loadingControlLoad.Visible = false;
            // 
            // buttonRemoveFromResultGrid
            // 
            this.buttonRemoveFromResultGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveFromResultGrid.Location = new System.Drawing.Point(578, 237);
            this.buttonRemoveFromResultGrid.Name = "buttonRemoveFromResultGrid";
            this.buttonRemoveFromResultGrid.Size = new System.Drawing.Size(75, 37);
            this.buttonRemoveFromResultGrid.TabIndex = 1;
            this.buttonRemoveFromResultGrid.Text = ">>";
            this.buttonRemoveFromResultGrid.UseVisualStyleBackColor = false;
            // 
            // buttonAddToResultGrid
            // 
            this.buttonAddToResultGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToResultGrid.Location = new System.Drawing.Point(578, 196);
            this.buttonAddToResultGrid.Name = "buttonAddToResultGrid";
            this.buttonAddToResultGrid.Size = new System.Drawing.Size(75, 37);
            this.buttonAddToResultGrid.TabIndex = 1;
            this.buttonAddToResultGrid.Text = "<<";
            this.buttonAddToResultGrid.UseVisualStyleBackColor = false;
            this.buttonAddToResultGrid.Click += new System.EventHandler(this.buttonAddToResultGrid_Click);
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.AllowUserToAddRows = false;
            this.dataGridViewExcel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewExcel.ColumnHeadersHeight = 40;
            this.dataGridViewExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExcel.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewExcel.Location = new System.Drawing.Point(673, 35);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.ReadOnly = true;
            this.dataGridViewExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewExcel.RowHeadersVisible = false;
            this.dataGridViewExcel.RowHeadersWidth = 5;
            this.dataGridViewExcel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewExcel.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewExcel.RowTemplate.Height = 27;
            this.dataGridViewExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcel.Size = new System.Drawing.Size(547, 457);
            this.dataGridViewExcel.TabIndex = 0;
            this.dataGridViewExcel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExcel_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ستون های فایل اکسل";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewResult.ColumnHeadersHeight = 40;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excelColumn,
            this.AppColumn});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewResult.Location = new System.Drawing.Point(14, 35);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 5;
            this.dataGridViewResult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewResult.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewResult.RowTemplate.Height = 27;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(547, 457);
            this.dataGridViewResult.TabIndex = 0;
            this.dataGridViewResult.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResult_CellMouseDoubleClick);
            // 
            // excelColumn
            // 
            this.excelColumn.HeaderText = "ستون فایل اکسل";
            this.excelColumn.Name = "excelColumn";
            // 
            // AppColumn
            // 
            this.AppColumn.HeaderText = "ستون متناظر در برنامه";
            this.AppColumn.Name = "AppColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "ستون های متناظر اکسل با برنامه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(881, 14);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ستون های فایل اکسل انتخابی";
            // 
            // panelCommand
            // 
            this.panelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommand.Controls.Add(this.btnNextStep);
            this.panelCommand.Controls.Add(this.buttonOpenExcelFile);
            this.panelCommand.Controls.Add(this.buttonHelp);
            this.panelCommand.Controls.Add(this.buttonClose);
            this.panelCommand.Location = new System.Drawing.Point(10, 662);
            this.panelCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCommand.Name = "panelCommand";
            this.panelCommand.Size = new System.Drawing.Size(1236, 77);
            this.panelCommand.TabIndex = 2;
            this.panelCommand.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Enabled = false;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextStep.Location = new System.Drawing.Point(16, 18);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(106, 37);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.Text = ">>  مرحله بعد";
            this.btnNextStep.UseVisualStyleBackColor = false;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // buttonOpenExcelFile
            // 
            this.buttonOpenExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenExcelFile.Location = new System.Drawing.Point(128, 18);
            this.buttonOpenExcelFile.Name = "buttonOpenExcelFile";
            this.buttonOpenExcelFile.Size = new System.Drawing.Size(138, 37);
            this.buttonOpenExcelFile.TabIndex = 1;
            this.buttonOpenExcelFile.Text = "... انتخاب فایل اکسل";
            this.buttonOpenExcelFile.UseVisualStyleBackColor = false;
            this.buttonOpenExcelFile.Click += new System.EventHandler(this.buttonOpenExcelFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.Location = new System.Drawing.Point(1027, 18);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 37);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "راهنما";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(1110, 18);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 37);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "لغو";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.comboBoxStore);
            this.panelTop.Controls.Add(this.comboBox1);
            this.panelTop.Controls.Add(this.comboBoxSheet);
            this.panelTop.Controls.Add(this.comboBoxGroup);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.checkBoxRepitiveName);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Enabled = false;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelTop.Location = new System.Drawing.Point(10, 5);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1236, 95);
            this.panelTop.TabIndex = 3;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(14, 18);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxStore.Size = new System.Drawing.Size(185, 24);
            this.comboBoxStore.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "انبار"});
            this.comboBox1.Location = new System.Drawing.Point(673, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(429, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(673, 56);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSheet.Size = new System.Drawing.Size(429, 24);
            this.comboBoxSheet.TabIndex = 2;
            this.comboBoxSheet.SelectedValueChanged += new System.EventHandler(this.comboBoxSheet_SelectedValueChanged);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(291, 18);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxGroup.Size = new System.Drawing.Size(177, 24);
            this.comboBoxGroup.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1110, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "انتخاب بخش";
            // 
            // checkBoxRepitiveName
            // 
            this.checkBoxRepitiveName.AutoSize = true;
            this.checkBoxRepitiveName.Location = new System.Drawing.Point(447, 57);
            this.checkBoxRepitiveName.Name = "checkBoxRepitiveName";
            this.checkBoxRepitiveName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRepitiveName.Size = new System.Drawing.Size(113, 21);
            this.checkBoxRepitiveName.TabIndex = 1;
            this.checkBoxRepitiveName.Text = "پذیرفتن نام تکراری";
            this.checkBoxRepitiveName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRepitiveName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1110, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "انتخاب شیت اکسل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "انتخاب انبار";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب گروه کالا";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridViewMappedData);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "مرحله دوم";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(13, 660);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 77);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1115, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "لغو";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(14, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "تایید";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridViewMappedData
            // 
            this.dataGridViewMappedData.AllowUserToAddRows = false;
            this.dataGridViewMappedData.AllowUserToDeleteRows = false;
            this.dataGridViewMappedData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMappedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMappedData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMappedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMappedData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.Name,
            this.Count,
            this.Status,
            this.HaveError});
            this.dataGridViewMappedData.EnableHeadersVisualStyles = false;
            this.dataGridViewMappedData.Location = new System.Drawing.Point(8, 23);
            this.dataGridViewMappedData.Name = "dataGridViewMappedData";
            this.dataGridViewMappedData.RowHeadersVisible = false;
            this.dataGridViewMappedData.RowTemplate.Height = 25;
            this.dataGridViewMappedData.Size = new System.Drawing.Size(1242, 518);
            this.dataGridViewMappedData.TabIndex = 4;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "#";
            this.RowNumber.Name = "RowNumber";
            // 
            // Name
            // 
            this.Name.HeaderText = "نام کالا";
            this.Name.Name = "Name";
            // 
            // Count
            // 
            this.Count.HeaderText = "تعداد کالا";
            this.Count.Name = "Count";
            // 
            // Status
            // 
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            // 
            // HaveError
            // 
            this.HaveError.HeaderText = "Error";
            this.HaveError.Name = "HaveError";
            this.HaveError.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HaveError.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HaveError.Visible = false;
            // 
            // ExcelImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 782);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "ورود داده از اکسل";
            this.Load += new System.EventHandler(this.ExcelImportForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panelCommand.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMappedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelGrid;
        private UserControls.LoadingControl loadingControlLoad;
        private System.Windows.Forms.Button buttonRemoveFromResultGrid;
        private System.Windows.Forms.Button buttonAddToResultGrid;
        private System.Windows.Forms.DataGridView dataGridViewExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn excelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCommand;
        private System.Windows.Forms.Button buttonOpenExcelFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxRepitiveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewMappedData;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HaveError;
    }
}