namespace Homework1
{
    partial class CustomerSide
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._orderNameColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderPriceColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._mealDescriptionBox = new System.Windows.Forms.RichTextBox();
            this._addButton = new System.Windows.Forms.Button();
            this._previousPageButton = new System.Windows.Forms.Button();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._pageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this._mealGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteButton,
            this._orderNameColumns,
            this._orderPriceColumns});
            this._orderDataGridView.Location = new System.Drawing.Point(565, 24);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.RowHeadersVisible = false;
            this._orderDataGridView.Size = new System.Drawing.Size(540, 675);
            this._orderDataGridView.TabIndex = 0;
            this._orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDataGridViewCellContent);
            // 
            // _deleteButton
            // 
            this._deleteButton.HeaderText = "Delete";
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._deleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._deleteButton.Width = 80;
            // 
            // _orderNameColumns
            // 
            this._orderNameColumns.HeaderText = "Name";
            this._orderNameColumns.Name = "_orderNameColumns";
            this._orderNameColumns.Width = 230;
            // 
            // _orderPriceColumns
            // 
            this._orderPriceColumns.HeaderText = "Unit Price";
            this._orderPriceColumns.Name = "_orderPriceColumns";
            this._orderPriceColumns.Width = 230;
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this._totalLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold);
            this._totalLabel.ForeColor = System.Drawing.Color.DarkRed;
            this._totalLabel.Location = new System.Drawing.Point(949, 715);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(89, 27);
            this._totalLabel.TabIndex = 1;
            this._totalLabel.Text = "Label1";
            this._totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._mealDescriptionBox);
            this._mealGroupBox.Controls.Add(this._addButton);
            this._mealGroupBox.Controls.Add(this._previousPageButton);
            this._mealGroupBox.Controls.Add(this._nextPageButton);
            this._mealGroupBox.Controls.Add(this._pageLabel);
            this._mealGroupBox.Location = new System.Drawing.Point(12, 24);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(515, 675);
            this._mealGroupBox.TabIndex = 2;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meals";
            // 
            // _mealDescriptionBox
            // 
            this._mealDescriptionBox.Location = new System.Drawing.Point(6, 534);
            this._mealDescriptionBox.Name = "_mealDescriptionBox";
            this._mealDescriptionBox.ReadOnly = true;
            this._mealDescriptionBox.Size = new System.Drawing.Size(502, 74);
            this._mealDescriptionBox.TabIndex = 4;
            this._mealDescriptionBox.Text = "";
            // 
            // _addButton
            // 
            this._addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._addButton.Location = new System.Drawing.Point(389, 617);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 21);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _previousPageButton
            // 
            this._previousPageButton.Location = new System.Drawing.Point(236, 642);
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(120, 21);
            this._previousPageButton.TabIndex = 2;
            this._previousPageButton.Text = "Previous Page";
            this._previousPageButton.UseVisualStyleBackColor = true;
            this._previousPageButton.Click += new System.EventHandler(this.ClickPreviousPageButton);
            // 
            // _nextPageButton
            // 
            this._nextPageButton.Location = new System.Drawing.Point(389, 643);
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(120, 21);
            this._nextPageButton.TabIndex = 1;
            this._nextPageButton.Text = "Next Page";
            this._nextPageButton.UseVisualStyleBackColor = true;
            this._nextPageButton.Click += new System.EventHandler(this.ClickNextPageButton);
            // 
            // _pageLabel
            // 
            this._pageLabel.AutoSize = true;
            this._pageLabel.Font = new System.Drawing.Font("新細明體", 16F);
            this._pageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._pageLabel.Location = new System.Drawing.Point(6, 643);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(60, 22);
            this._pageLabel.TabIndex = 0;
            this._pageLabel.Text = "label1";
            // 
            // CustomerSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 749);
            this.Controls.Add(this._mealGroupBox);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._orderDataGridView);
            this.Name = "CustomerSide";
            this.Text = "POS-Customer Side";
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).EndInit();
            this._mealGroupBox.ResumeLayout(false);
            this._mealGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _orderDataGridView;
        private System.Windows.Forms.Label _totalLabel;
        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _previousPageButton;
        private System.Windows.Forms.Button _nextPageButton;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.RichTextBox _mealDescriptionBox;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderNameColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderPriceColumns;
    }
}

