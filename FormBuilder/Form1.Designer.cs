
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
            this.txtBoxOutPut = new System.Windows.Forms.TextBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.dataGridViewControls = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CssCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.InRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStepTwo = new System.Windows.Forms.Button();
            this.buttonStepOne = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControls)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxOutPut
            // 
            this.txtBoxOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutPut.Location = new System.Drawing.Point(12, 453);
            this.txtBoxOutPut.Multiline = true;
            this.txtBoxOutPut.Name = "txtBoxOutPut";
            this.txtBoxOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxOutPut.Size = new System.Drawing.Size(872, 309);
            this.txtBoxOutPut.TabIndex = 0;
            // 
            // btnCommand
            // 
            this.btnCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewControls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewControls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Title,
            this.Type,
            this.CssCol,
            this.InRow});
            this.dataGridViewControls.Location = new System.Drawing.Point(435, 26);
            this.dataGridViewControls.Name = "dataGridViewControls";
            this.dataGridViewControls.RowTemplate.Height = 25;
            this.dataGridViewControls.Size = new System.Drawing.Size(449, 379);
            this.dataGridViewControls.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "TextBox",
            "Select",
            "Number",
            "Date"});
            this.Type.Name = "Type";
            // 
            // CssCol
            // 
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
            // 
            // InRow
            // 
            this.InRow.HeaderText = "InRow";
            this.InRow.Name = "InRow";
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
            this.buttonSave.Size = new System.Drawing.Size(95, 38);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 765);
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
            this.Controls.Add(this.txtBoxOutPut);
            this.Text = "Form Builder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOutPut;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.DataGridView dataGridViewControls;
        private System.Windows.Forms.Button buttonStepTwo;
        private System.Windows.Forms.Button buttonStepOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn CssCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn InRow;
        private System.Windows.Forms.Button buttonSave;
    }
}

