namespace CreateNewE3Component
{
    partial class e3ComponentForm
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
            this.e3BaseDataGridView = new System.Windows.Forms.DataGridView();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.fillBySelectedImbaseKeysToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBySelectedImbaseKeysToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.componentAttributeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentAttribute = new CreateNewE3Component.ComponentAttribute();
            this.componentAttributeTableAdapter = new CreateNewE3Component.ComponentAttributeTableAdapters.ComponentAttributeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.e3BaseDataGridView)).BeginInit();
            this.fillBySelectedImbaseKeysToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentAttributeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentAttribute)).BeginInit();
            this.SuspendLayout();
            // 
            // e3BaseDataGridView
            // 
            this.e3BaseDataGridView.AutoGenerateColumns = false;
            this.e3BaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.e3BaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.eNTRYDataGridViewTextBoxColumn,
            this.attributeNameDataGridViewTextBoxColumn,
            this.attributeValueDataGridViewTextBoxColumn});
            this.e3BaseDataGridView.DataSource = this.componentAttributeBindingSource;
            this.e3BaseDataGridView.Location = new System.Drawing.Point(485, 52);
            this.e3BaseDataGridView.Name = "e3BaseDataGridView";
            this.e3BaseDataGridView.RowTemplate.Height = 23;
            this.e3BaseDataGridView.Size = new System.Drawing.Size(953, 491);
            this.e3BaseDataGridView.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(24, 52);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(416, 491);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(24, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(122, 13);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Вставьте коды ImBase";
            // 
            // fillBySelectedImbaseKeysToolStrip
            // 
            this.fillBySelectedImbaseKeysToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBySelectedImbaseKeysToolStripButton});
            this.fillBySelectedImbaseKeysToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBySelectedImbaseKeysToolStrip.Name = "fillBySelectedImbaseKeysToolStrip";
            this.fillBySelectedImbaseKeysToolStrip.Size = new System.Drawing.Size(1448, 25);
            this.fillBySelectedImbaseKeysToolStrip.TabIndex = 4;
            this.fillBySelectedImbaseKeysToolStrip.Text = "fillBySelectedImbaseKeysToolStrip";
            this.fillBySelectedImbaseKeysToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBySelectedImbaseKeysToolStrip_ItemClicked);
            // 
            // fillBySelectedImbaseKeysToolStripButton
            // 
            this.fillBySelectedImbaseKeysToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBySelectedImbaseKeysToolStripButton.Name = "fillBySelectedImbaseKeysToolStripButton";
            this.fillBySelectedImbaseKeysToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.fillBySelectedImbaseKeysToolStripButton.Text = "Найти коды в базе";
            this.fillBySelectedImbaseKeysToolStripButton.Click += new System.EventHandler(this.fillBySelectedImbaseKeysToolStripButton_Click);
            // 
            // componentAttributeBindingSource
            // 
            this.componentAttributeBindingSource.DataMember = "ComponentAttribute";
            this.componentAttributeBindingSource.DataSource = this.componentAttribute;
            // 
            // componentAttribute
            // 
            this.componentAttribute.DataSetName = "ComponentAttribute";
            this.componentAttribute.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentAttributeTableAdapter
            // 
            this.componentAttributeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // eNTRYDataGridViewTextBoxColumn
            // 
            this.eNTRYDataGridViewTextBoxColumn.DataPropertyName = "ENTRY";
            this.eNTRYDataGridViewTextBoxColumn.HeaderText = "ENTRY";
            this.eNTRYDataGridViewTextBoxColumn.Name = "eNTRYDataGridViewTextBoxColumn";
            this.eNTRYDataGridViewTextBoxColumn.Width = 200;
            // 
            // attributeNameDataGridViewTextBoxColumn
            // 
            this.attributeNameDataGridViewTextBoxColumn.DataPropertyName = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.HeaderText = "AttributeName";
            this.attributeNameDataGridViewTextBoxColumn.Name = "attributeNameDataGridViewTextBoxColumn";
            this.attributeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // attributeValueDataGridViewTextBoxColumn
            // 
            this.attributeValueDataGridViewTextBoxColumn.DataPropertyName = "AttributeValue";
            this.attributeValueDataGridViewTextBoxColumn.HeaderText = "AttributeValue";
            this.attributeValueDataGridViewTextBoxColumn.Name = "attributeValueDataGridViewTextBoxColumn";
            this.attributeValueDataGridViewTextBoxColumn.Width = 200;
            // 
            // e3ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 556);
            this.Controls.Add(this.fillBySelectedImbaseKeysToolStrip);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.e3BaseDataGridView);
            this.Name = "e3ComponentForm";
            this.Text = "Компоненты базы E3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e3BaseDataGridView)).EndInit();
            this.fillBySelectedImbaseKeysToolStrip.ResumeLayout(false);
            this.fillBySelectedImbaseKeysToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentAttributeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentAttribute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView e3BaseDataGridView;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Label headerLabel;
        private ComponentAttribute componentAttribute;
        private System.Windows.Forms.BindingSource componentAttributeBindingSource;
        private ComponentAttributeTableAdapters.ComponentAttributeTableAdapter componentAttributeTableAdapter;
        private System.Windows.Forms.ToolStrip fillBySelectedImbaseKeysToolStrip;
        private System.Windows.Forms.ToolStripButton fillBySelectedImbaseKeysToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeValueDataGridViewTextBoxColumn;
    }
}

