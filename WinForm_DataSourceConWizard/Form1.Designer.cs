namespace WinForm_DataSourceConWizard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label mASOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            this.studentDBDataSet = new WinForm_DataSourceConWizard.StudentDBDataSet();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new WinForm_DataSourceConWizard.StudentDBDataSetTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new WinForm_DataSourceConWizard.StudentDBDataSetTableAdapters.TableAdapterManager();
            this.sINHVIENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sINHVIENBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sINHVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASOTextBox = new System.Windows.Forms.TextBox();
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gIOITINHCheckBox = new System.Windows.Forms.CheckBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.dIENTHOAITextBox = new System.Windows.Forms.TextBox();
            mASOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingNavigator)).BeginInit();
            this.sINHVIENBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.studentDBDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinForm_DataSourceConWizard.StudentDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENBindingNavigator
            // 
            this.sINHVIENBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sINHVIENBindingNavigator.BindingSource = this.sINHVIENBindingSource;
            this.sINHVIENBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sINHVIENBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sINHVIENBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sINHVIENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sINHVIENBindingNavigatorSaveItem});
            this.sINHVIENBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sINHVIENBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sINHVIENBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sINHVIENBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sINHVIENBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sINHVIENBindingNavigator.Name = "sINHVIENBindingNavigator";
            this.sINHVIENBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sINHVIENBindingNavigator.Size = new System.Drawing.Size(1105, 27);
            this.sINHVIENBindingNavigator.TabIndex = 0;
            this.sINHVIENBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sINHVIENBindingNavigatorSaveItem
            // 
            this.sINHVIENBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sINHVIENBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sINHVIENBindingNavigatorSaveItem.Image")));
            this.sINHVIENBindingNavigatorSaveItem.Name = "sINHVIENBindingNavigatorSaveItem";
            this.sINHVIENBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sINHVIENBindingNavigatorSaveItem.Text = "Save Data";
            this.sINHVIENBindingNavigatorSaveItem.Click += new System.EventHandler(this.sINHVIENBindingNavigatorSaveItem_Click);
            // 
            // sINHVIENDataGridView
            // 
            this.sINHVIENDataGridView.AutoGenerateColumns = false;
            this.sINHVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sINHVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sINHVIENDataGridView.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENDataGridView.Location = new System.Drawing.Point(0, 230);
            this.sINHVIENDataGridView.Name = "sINHVIENDataGridView";
            this.sINHVIENDataGridView.RowHeadersWidth = 51;
            this.sINHVIENDataGridView.RowTemplate.Height = 24;
            this.sINHVIENDataGridView.Size = new System.Drawing.Size(1085, 220);
            this.sINHVIENDataGridView.TabIndex = 1;
            this.sINHVIENDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sINHVIENDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASO";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "HOTEN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn3.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "GIOITINH";
            this.dataGridViewCheckBoxColumn1.HeaderText = "GIOITINH";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIENTHOAI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIENTHOAI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // mASOLabel
            // 
            mASOLabel.AutoSize = true;
            mASOLabel.Location = new System.Drawing.Point(33, 51);
            mASOLabel.Name = "mASOLabel";
            mASOLabel.Size = new System.Drawing.Size(49, 16);
            mASOLabel.TabIndex = 2;
            mASOLabel.Text = "MASO:";
            // 
            // mASOTextBox
            // 
            this.mASOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASO", true));
            this.mASOTextBox.Location = new System.Drawing.Point(122, 48);
            this.mASOTextBox.Name = "mASOTextBox";
            this.mASOTextBox.Size = new System.Drawing.Size(200, 22);
            this.mASOTextBox.TabIndex = 3;
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(33, 79);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(58, 16);
            hOTENLabel.TabIndex = 4;
            hOTENLabel.Text = "HOTEN:";
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HOTEN", true));
            this.hOTENTextBox.Location = new System.Drawing.Point(122, 76);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.Size = new System.Drawing.Size(200, 22);
            this.hOTENTextBox.TabIndex = 5;
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(33, 108);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(80, 16);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nGAYSINHDateTimePicker
            // 
            this.nGAYSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sINHVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateTimePicker.Location = new System.Drawing.Point(122, 104);
            this.nGAYSINHDateTimePicker.Name = "nGAYSINHDateTimePicker";
            this.nGAYSINHDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.nGAYSINHDateTimePicker.TabIndex = 7;
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(33, 137);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(68, 16);
            gIOITINHLabel.TabIndex = 8;
            gIOITINHLabel.Text = "GIOITINH:";
            // 
            // gIOITINHCheckBox
            // 
            this.gIOITINHCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sINHVIENBindingSource, "GIOITINH", true));
            this.gIOITINHCheckBox.Location = new System.Drawing.Point(122, 132);
            this.gIOITINHCheckBox.Name = "gIOITINHCheckBox";
            this.gIOITINHCheckBox.Size = new System.Drawing.Size(200, 24);
            this.gIOITINHCheckBox.TabIndex = 9;
            this.gIOITINHCheckBox.Text = "Co Phai Nam Khong";
            this.gIOITINHCheckBox.UseVisualStyleBackColor = true;
            this.gIOITINHCheckBox.CheckedChanged += new System.EventHandler(this.gIOITINHCheckBox_CheckedChanged);
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(33, 165);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(54, 16);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "DIACHI:";
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(122, 162);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(200, 22);
            this.dIACHITextBox.TabIndex = 11;
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.Location = new System.Drawing.Point(33, 193);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(83, 16);
            dIENTHOAILabel.TabIndex = 12;
            dIENTHOAILabel.Text = "DIENTHOAI:";
            // 
            // dIENTHOAITextBox
            // 
            this.dIENTHOAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "DIENTHOAI", true));
            this.dIENTHOAITextBox.Location = new System.Drawing.Point(122, 190);
            this.dIENTHOAITextBox.Name = "dIENTHOAITextBox";
            this.dIENTHOAITextBox.Size = new System.Drawing.Size(200, 22);
            this.dIENTHOAITextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 470);
            this.Controls.Add(mASOLabel);
            this.Controls.Add(this.mASOTextBox);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENTextBox);
            this.Controls.Add(nGAYSINHLabel);
            this.Controls.Add(this.nGAYSINHDateTimePicker);
            this.Controls.Add(gIOITINHLabel);
            this.Controls.Add(this.gIOITINHCheckBox);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.dIACHITextBox);
            this.Controls.Add(dIENTHOAILabel);
            this.Controls.Add(this.dIENTHOAITextBox);
            this.Controls.Add(this.sINHVIENDataGridView);
            this.Controls.Add(this.sINHVIENBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingNavigator)).EndInit();
            this.sINHVIENBindingNavigator.ResumeLayout(false);
            this.sINHVIENBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private StudentDBDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private StudentDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sINHVIENBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sINHVIENBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sINHVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox mASOTextBox;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.DateTimePicker nGAYSINHDateTimePicker;
        private System.Windows.Forms.CheckBox gIOITINHCheckBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox dIENTHOAITextBox;
    }
}

