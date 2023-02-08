
namespace FormBuilder
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtBoxOutPutUi = new System.Windows.Forms.TextBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.dataGridViewControls = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CssCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.InRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceHolder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonStepTwo = new System.Windows.Forms.Button();
            this.buttonStepOne = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxOutPutForm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControls)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxOutPutUi
            // 
            this.txtBoxOutPutUi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutPutUi.Location = new System.Drawing.Point(12, 453);
            this.txtBoxOutPutUi.Multiline = true;
            this.txtBoxOutPutUi.Name = "txtBoxOutPutUi";
            this.txtBoxOutPutUi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxOutPutUi.Size = new System.Drawing.Size(417, 309);
            this.txtBoxOutPutUi.TabIndex = 0;
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(435, 409);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(349, 38);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "Final Command";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(12, 26);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxInput.Size = new System.Drawing.Size(199, 379);
            this.txtBoxInput.TabIndex = 2;
            this.txtBoxInput.Text = resources.GetString("txtBoxInput.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "> Step 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "> Step Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "> Step Three";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 15;
            this.listBoxItems.Location = new System.Drawing.Point(217, 26);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxItems.Size = new System.Drawing.Size(212, 379);
            this.listBoxItems.TabIndex = 4;
            // 
            // dataGridViewControls
            // 
            this.dataGridViewControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewControls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewControls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewControls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.Name,
            this.Title,
            this.Type,
            this.CssCol,
            this.InRow,
            this.PlaceHolder});
            this.dataGridViewControls.Location = new System.Drawing.Point(435, 26);
            this.dataGridViewControls.Name = "dataGridViewControls";
            this.dataGridViewControls.RowTemplate.Height = 25;
            this.dataGridViewControls.Size = new System.Drawing.Size(720, 379);
            this.dataGridViewControls.TabIndex = 5;
            // 
            // Order
            // 
            this.Order.FillWeight = 40F;
            this.Order.HeaderText = "ترتیب";
            this.Order.Name = "Order";
            // 
            // Name
            // 
            this.Name.FillWeight = 89.54315F;
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            // 
            // Title
            // 
            this.Title.FillWeight = 89.54315F;
            this.Title.HeaderText = "عنوان نمایشی";
            this.Title.Name = "Title";
            // 
            // Type
            // 
            this.Type.FillWeight = 89.54315F;
            this.Type.HeaderText = "نوع";
            this.Type.Items.AddRange(new object[] {
            "TextBox",
            "Select",
            "Number",
            "Date",
            "CheckBox"});
            this.Type.Name = "Type";
            // 
            // CssCol
            // 
            this.CssCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CssCol.FillWeight = 60F;
            this.CssCol.HeaderText = "CssCol";
            this.CssCol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CssCol.Name = "CssCol";
            this.CssCol.Width = 60;
            // 
            // InRow
            // 
            this.InRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InRow.FillWeight = 50F;
            this.InRow.HeaderText = "ردیف";
            this.InRow.Name = "InRow";
            this.InRow.Width = 50;
            // 
            // PlaceHolder
            // 
            this.PlaceHolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlaceHolder.FillWeight = 70F;
            this.PlaceHolder.HeaderText = "PlaceHolder";
            this.PlaceHolder.Name = "PlaceHolder";
            this.PlaceHolder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlaceHolder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PlaceHolder.Width = 70;
            // 
            // buttonStepTwo
            // 
            this.buttonStepTwo.Location = new System.Drawing.Point(217, 409);
            this.buttonStepTwo.Name = "buttonStepTwo";
            this.buttonStepTwo.Size = new System.Drawing.Size(212, 38);
            this.buttonStepTwo.TabIndex = 1;
            this.buttonStepTwo.Text = "Step Two";
            this.buttonStepTwo.UseVisualStyleBackColor = true;
            this.buttonStepTwo.Click += new System.EventHandler(this.buttonStepTwo_Click);
            // 
            // buttonStepOne
            // 
            this.buttonStepOne.Location = new System.Drawing.Point(12, 409);
            this.buttonStepOne.Name = "buttonStepOne";
            this.buttonStepOne.Size = new System.Drawing.Size(199, 38);
            this.buttonStepOne.TabIndex = 1;
            this.buttonStepOne.Text = "Step One";
            this.buttonStepOne.UseVisualStyleBackColor = true;
            this.buttonStepOne.Click += new System.EventHandler(this.buttonStepOne_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(789, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(366, 38);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxOutPutForm
            // 
            this.textBoxOutPutForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutPutForm.Location = new System.Drawing.Point(435, 453);
            this.textBoxOutPutForm.Multiline = true;
            this.textBoxOutPutForm.Name = "textBoxOutPutForm";
            this.textBoxOutPutForm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutPutForm.Size = new System.Drawing.Size(720, 309);
            this.textBoxOutPutForm.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 765);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewControls);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.buttonStepOne);
            this.Controls.Add(this.buttonStepTwo);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.textBoxOutPutForm);
            this.Controls.Add(this.txtBoxOutPutUi);
            this.Text = "Form Builder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOutPutUi;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.DataGridView dataGridViewControls;
        private System.Windows.Forms.Button buttonStepTwo;
        private System.Windows.Forms.Button buttonStepOne;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxOutPutForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn CssCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn InRow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PlaceHolder;
    }
}

