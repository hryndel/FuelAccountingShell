namespace FuelAccountingShell.UserControls
{
    partial class UserControlTruck
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTrucks = new System.Windows.Forms.DataGridView();
            this.labelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanelHelp = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCardHelp = new MaterialSkin.Controls.MaterialCard();
            this.materialListBoxSort = new MaterialSkin.Controls.MaterialListBox();
            this.materialCardHelpTitle = new MaterialSkin.Controls.MaterialCard();
            this.labelHelp = new MaterialSkin.Controls.MaterialLabel();
            this.materialCardMenu = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new MaterialSkin.Controls.MaterialButton();
            this.buttonEdit = new MaterialSkin.Controls.MaterialButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialButton();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrucks)).BeginInit();
            this.flowLayoutPanelHelp.SuspendLayout();
            this.materialCardHelp.SuspendLayout();
            this.materialCardHelpTitle.SuspendLayout();
            this.materialCardMenu.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.dataGridViewTrucks, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelStatus, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelHelp, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.materialCardMenu, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1368, 698);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // dataGridViewTrucks
            // 
            this.dataGridViewTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrucks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnNumber,
            this.ColumnVin});
            this.dataGridViewTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrucks.Location = new System.Drawing.Point(14, 113);
            this.dataGridViewTrucks.Margin = new System.Windows.Forms.Padding(14, 3, 14, 3);
            this.dataGridViewTrucks.Name = "dataGridViewTrucks";
            this.dataGridViewTrucks.Size = new System.Drawing.Size(1100, 553);
            this.dataGridViewTrucks.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Depth = 0;
            this.labelStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelStatus.Location = new System.Drawing.Point(14, 674);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(14, 5, 3, 5);
            this.labelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(195, 19);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Количесто записей: 0 из 0";
            // 
            // flowLayoutPanelHelp
            // 
            this.flowLayoutPanelHelp.AutoSize = true;
            this.flowLayoutPanelHelp.Controls.Add(this.materialCardHelp);
            this.flowLayoutPanelHelp.Location = new System.Drawing.Point(1131, 113);
            this.flowLayoutPanelHelp.Name = "flowLayoutPanelHelp";
            this.flowLayoutPanelHelp.Size = new System.Drawing.Size(234, 271);
            this.flowLayoutPanelHelp.TabIndex = 2;
            // 
            // materialCardHelp
            // 
            this.materialCardHelp.AutoSize = true;
            this.materialCardHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHelp.Controls.Add(this.materialListBoxSort);
            this.materialCardHelp.Controls.Add(this.materialCardHelpTitle);
            this.materialCardHelp.Depth = 0;
            this.materialCardHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCardHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHelp.Location = new System.Drawing.Point(0, 0);
            this.materialCardHelp.Margin = new System.Windows.Forms.Padding(0);
            this.materialCardHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHelp.Name = "materialCardHelp";
            this.materialCardHelp.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHelp.Size = new System.Drawing.Size(234, 271);
            this.materialCardHelp.TabIndex = 0;
            // 
            // materialListBoxSort
            // 
            this.materialListBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListBoxSort.BackColor = System.Drawing.Color.White;
            this.materialListBoxSort.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxSort.Depth = 0;
            this.materialListBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem4.SecondaryText = "";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "По умолчанию";
            materialListBoxItem5.SecondaryText = "";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "По убыванию";
            materialListBoxItem6.SecondaryText = "";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "По возрастанию";
            this.materialListBoxSort.Items.Add(materialListBoxItem4);
            this.materialListBoxSort.Items.Add(materialListBoxItem5);
            this.materialListBoxSort.Items.Add(materialListBoxItem6);
            this.materialListBoxSort.Location = new System.Drawing.Point(14, 75);
            this.materialListBoxSort.Margin = new System.Windows.Forms.Padding(0);
            this.materialListBoxSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxSort.Name = "materialListBoxSort";
            this.materialListBoxSort.SelectedIndex = -1;
            this.materialListBoxSort.SelectedItem = null;
            this.materialListBoxSort.Size = new System.Drawing.Size(206, 182);
            this.materialListBoxSort.TabIndex = 1;
            this.materialListBoxSort.UseAccentColor = true;
            // 
            // materialCardHelpTitle
            // 
            this.materialCardHelpTitle.AutoSize = true;
            this.materialCardHelpTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHelpTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCardHelpTitle.Controls.Add(this.labelHelp);
            this.materialCardHelpTitle.Depth = 0;
            this.materialCardHelpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHelpTitle.Location = new System.Drawing.Point(14, 14);
            this.materialCardHelpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.materialCardHelpTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHelpTitle.Name = "materialCardHelpTitle";
            this.materialCardHelpTitle.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHelpTitle.Size = new System.Drawing.Size(206, 44);
            this.materialCardHelpTitle.TabIndex = 0;
            // 
            // labelHelp
            // 
            this.labelHelp.Depth = 0;
            this.labelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHelp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelHelp.Location = new System.Drawing.Point(14, 14);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(176, 14);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = "Сортировка по названию";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCardMenu
            // 
            this.materialCardMenu.AutoSize = true;
            this.materialCardMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardMenu.Controls.Add(this.flowLayoutPanelMenu);
            this.materialCardMenu.Depth = 0;
            this.materialCardMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCardMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardMenu.Location = new System.Drawing.Point(14, 14);
            this.materialCardMenu.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardMenu.Name = "materialCardMenu";
            this.materialCardMenu.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardMenu.Size = new System.Drawing.Size(1100, 82);
            this.materialCardMenu.TabIndex = 3;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoSize = true;
            this.flowLayoutPanelMenu.Controls.Add(this.buttonAdd);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonEdit);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDelete);
            this.flowLayoutPanelMenu.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(1072, 54);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.AutoSize = false;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.HighEmphasis = true;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(4, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAdd.Size = new System.Drawing.Size(125, 54);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAdd.UseAccentColor = false;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.AutoSize = false;
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEdit.Depth = 0;
            this.buttonEdit.HighEmphasis = true;
            this.buttonEdit.Icon = null;
            this.buttonEdit.Location = new System.Drawing.Point(137, 0);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEdit.Size = new System.Drawing.Size(125, 54);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEdit.UseAccentColor = false;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.AutoSize = false;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.HighEmphasis = true;
            this.buttonDelete.Icon = null;
            this.buttonDelete.Location = new System.Drawing.Point(270, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDelete.Size = new System.Drawing.Size(125, 54);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDelete.UseAccentColor = false;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AnimateReadOnly = false;
            this.textBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.HideSelection = true;
            this.textBoxSearch.Hint = "Поиск по названию";
            this.textBoxSearch.LeadingIcon = null;
            this.textBoxSearch.Location = new System.Drawing.Point(402, 3);
            this.textBoxSearch.MaxLength = 20;
            this.textBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PrefixSuffixText = null;
            this.textBoxSearch.ReadOnly = false;
            this.textBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.Size = new System.Drawing.Size(250, 48);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.TrailingIcon = null;
            this.textBoxSearch.UseSystemPasswordChar = false;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.DataPropertyName = "Number";
            this.ColumnNumber.HeaderText = "Номер";
            this.ColumnNumber.Name = "ColumnNumber";
            // 
            // ColumnVin
            // 
            this.ColumnVin.DataPropertyName = "Vin";
            this.ColumnVin.HeaderText = "VIN";
            this.ColumnVin.Name = "ColumnVin";
            // 
            // UserControlTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "UserControlTruck";
            this.Size = new System.Drawing.Size(1368, 698);
            this.Load += new System.EventHandler(this.UserControlTruck_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrucks)).EndInit();
            this.flowLayoutPanelHelp.ResumeLayout(false);
            this.flowLayoutPanelHelp.PerformLayout();
            this.materialCardHelp.ResumeLayout(false);
            this.materialCardHelp.PerformLayout();
            this.materialCardHelpTitle.ResumeLayout(false);
            this.materialCardMenu.ResumeLayout(false);
            this.materialCardMenu.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridViewTrucks;
        private MaterialSkin.Controls.MaterialLabel labelStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHelp;
        private MaterialSkin.Controls.MaterialCard materialCardHelp;
        private MaterialSkin.Controls.MaterialListBox materialListBoxSort;
        private MaterialSkin.Controls.MaterialCard materialCardHelpTitle;
        private MaterialSkin.Controls.MaterialLabel labelHelp;
        private MaterialSkin.Controls.MaterialCard materialCardMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private MaterialSkin.Controls.MaterialButton buttonAdd;
        private MaterialSkin.Controls.MaterialButton buttonEdit;
        private MaterialSkin.Controls.MaterialButton buttonDelete;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVin;
    }
}
