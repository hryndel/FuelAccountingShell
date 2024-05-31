namespace FuelAccountingShell.UserControls
{
    partial class UserControlFuelAccountingItem
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewFuelAccountingItems = new System.Windows.Forms.DataGridView();
            this.labelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanelHelp = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCardHelp = new MaterialSkin.Controls.MaterialCard();
            this.materialListBoxSort = new MaterialSkin.Controls.MaterialListBox();
            this.materialCardHelpTitle = new MaterialSkin.Controls.MaterialCard();
            this.labelHelp = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialListBoxTypes = new MaterialSkin.Controls.MaterialListBox();
            this.materialCardHelp2 = new MaterialSkin.Controls.MaterialCard();
            this.labelHelp2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCardMenu = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new MaterialSkin.Controls.MaterialButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialButton();
            this.buttonPdf = new MaterialSkin.Controls.MaterialButton();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.saveFileDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.ColumnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTruck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTrailer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuelStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuelAccountingItems)).BeginInit();
            this.flowLayoutPanelHelp.SuspendLayout();
            this.materialCardHelp.SuspendLayout();
            this.materialCardHelpTitle.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCardHelp2.SuspendLayout();
            this.materialCardMenu.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.dataGridViewFuelAccountingItems, 0, 1);
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
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dataGridViewFuelAccountingItems
            // 
            this.dataGridViewFuelAccountingItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuelAccountingItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDriver,
            this.ColumnTruck,
            this.ColumnTrailer,
            this.ColumnFuel,
            this.ColumnCount,
            this.ColumnFuelStation,
            this.ColumnStartDate,
            this.ColumnEndDate,
            this.ColumnPrice});
            this.dataGridViewFuelAccountingItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFuelAccountingItems.Location = new System.Drawing.Point(14, 113);
            this.dataGridViewFuelAccountingItems.Margin = new System.Windows.Forms.Padding(14, 3, 14, 3);
            this.dataGridViewFuelAccountingItems.Name = "dataGridViewFuelAccountingItems";
            this.dataGridViewFuelAccountingItems.Size = new System.Drawing.Size(1100, 553);
            this.dataGridViewFuelAccountingItems.TabIndex = 0;
            this.dataGridViewFuelAccountingItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFuelAccountingItems_CellFormatting);
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
            this.labelStatus.Size = new System.Drawing.Size(204, 19);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Количество записей: 0 из 0";
            // 
            // flowLayoutPanelHelp
            // 
            this.flowLayoutPanelHelp.AutoSize = true;
            this.flowLayoutPanelHelp.Controls.Add(this.materialCardHelp);
            this.flowLayoutPanelHelp.Controls.Add(this.materialCard1);
            this.flowLayoutPanelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHelp.Location = new System.Drawing.Point(1131, 113);
            this.flowLayoutPanelHelp.Name = "flowLayoutPanelHelp";
            this.flowLayoutPanelHelp.Size = new System.Drawing.Size(234, 553);
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
            this.materialCardHelp.Size = new System.Drawing.Size(234, 184);
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
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "По умолчанию";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "По убыванию";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "По возрастанию";
            this.materialListBoxSort.Items.Add(materialListBoxItem1);
            this.materialListBoxSort.Items.Add(materialListBoxItem2);
            this.materialListBoxSort.Items.Add(materialListBoxItem3);
            this.materialListBoxSort.Location = new System.Drawing.Point(14, 75);
            this.materialListBoxSort.Margin = new System.Windows.Forms.Padding(0);
            this.materialListBoxSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxSort.Name = "materialListBoxSort";
            this.materialListBoxSort.SelectedIndex = -1;
            this.materialListBoxSort.SelectedItem = null;
            this.materialListBoxSort.Size = new System.Drawing.Size(206, 95);
            this.materialListBoxSort.TabIndex = 6;
            this.materialListBoxSort.UseAccentColor = true;
            this.materialListBoxSort.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBoxSort_SelectedIndexChanged);
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
            this.labelHelp.Text = "Сортировка по дате прибытия";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            this.materialCard1.AutoSize = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialListBoxTypes);
            this.materialCard1.Controls.Add(this.materialCardHelp2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 194);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(234, 274);
            this.materialCard1.TabIndex = 0;
            // 
            // materialListBoxTypes
            // 
            this.materialListBoxTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListBoxTypes.BackColor = System.Drawing.Color.White;
            this.materialListBoxTypes.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxTypes.Depth = 0;
            this.materialListBoxTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxTypes.Location = new System.Drawing.Point(14, 75);
            this.materialListBoxTypes.Margin = new System.Windows.Forms.Padding(0);
            this.materialListBoxTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxTypes.Name = "materialListBoxTypes";
            this.materialListBoxTypes.SelectedIndex = -1;
            this.materialListBoxTypes.SelectedItem = null;
            this.materialListBoxTypes.Size = new System.Drawing.Size(206, 185);
            this.materialListBoxTypes.TabIndex = 7;
            this.materialListBoxTypes.UseAccentColor = true;
            this.materialListBoxTypes.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBoxTypes_SelectedIndexChanged);
            // 
            // materialCardHelp2
            // 
            this.materialCardHelp2.AutoSize = true;
            this.materialCardHelp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHelp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCardHelp2.Controls.Add(this.labelHelp2);
            this.materialCardHelp2.Depth = 0;
            this.materialCardHelp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHelp2.Location = new System.Drawing.Point(14, 14);
            this.materialCardHelp2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCardHelp2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHelp2.Name = "materialCardHelp2";
            this.materialCardHelp2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHelp2.Size = new System.Drawing.Size(206, 44);
            this.materialCardHelp2.TabIndex = 0;
            // 
            // labelHelp2
            // 
            this.labelHelp2.Depth = 0;
            this.labelHelp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHelp2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelHelp2.Location = new System.Drawing.Point(14, 14);
            this.labelHelp2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelHelp2.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelHelp2.Name = "labelHelp2";
            this.labelHelp2.Size = new System.Drawing.Size(176, 14);
            this.labelHelp2.TabIndex = 0;
            this.labelHelp2.Text = "Фильтрация по типу топлива";
            this.labelHelp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.materialCardMenu.TabIndex = 0;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoSize = true;
            this.flowLayoutPanelMenu.Controls.Add(this.buttonAdd);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDelete);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonPdf);
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
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAdd.UseAccentColor = false;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonDelete.Location = new System.Drawing.Point(137, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDelete.Size = new System.Drawing.Size(125, 54);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDelete.UseAccentColor = false;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPdf.AutoSize = false;
            this.buttonPdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPdf.Depth = 0;
            this.buttonPdf.HighEmphasis = true;
            this.buttonPdf.Icon = null;
            this.buttonPdf.Location = new System.Drawing.Point(270, 0);
            this.buttonPdf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPdf.Size = new System.Drawing.Size(125, 54);
            this.buttonPdf.TabIndex = 4;
            this.buttonPdf.Text = "PDF";
            this.buttonPdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPdf.UseAccentColor = false;
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.materialButtonPdf_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AnimateReadOnly = false;
            this.textBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.HideSelection = true;
            this.textBoxSearch.Hint = "Поиск по АЗС";
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
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.TrailingIcon = null;
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // saveFileDialogSave
            // 
            this.saveFileDialogSave.FileName = "Document";
            this.saveFileDialogSave.Filter = "PDF-файл|*.pdf";
            this.saveFileDialogSave.Title = "Сохранить накладную";
            // 
            // ColumnDriver
            // 
            this.ColumnDriver.DataPropertyName = "Driver";
            this.ColumnDriver.HeaderText = "Водитель";
            this.ColumnDriver.Name = "ColumnDriver";
            this.ColumnDriver.ToolTipText = "ФИО водителия | ВУ";
            // 
            // ColumnTruck
            // 
            this.ColumnTruck.DataPropertyName = "Truck";
            this.ColumnTruck.HeaderText = "Грузовик";
            this.ColumnTruck.Name = "ColumnTruck";
            this.ColumnTruck.ToolTipText = "Название грузовика | номер";
            // 
            // ColumnTrailer
            // 
            this.ColumnTrailer.DataPropertyName = "Trailer";
            this.ColumnTrailer.HeaderText = "Полуприцеп";
            this.ColumnTrailer.Name = "ColumnTrailer";
            this.ColumnTrailer.ToolTipText = "Название полупрциепа | номер";
            // 
            // ColumnFuel
            // 
            this.ColumnFuel.DataPropertyName = "Fuel";
            this.ColumnFuel.HeaderText = "Топливо";
            this.ColumnFuel.Name = "ColumnFuel";
            this.ColumnFuel.ToolTipText = "Тип топлива | имя поставщика";
            // 
            // ColumnCount
            // 
            this.ColumnCount.DataPropertyName = "Count";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.Name = "ColumnCount";
            // 
            // ColumnFuelStation
            // 
            this.ColumnFuelStation.DataPropertyName = "FuelStation";
            this.ColumnFuelStation.HeaderText = "АЗС";
            this.ColumnFuelStation.Name = "ColumnFuelStation";
            this.ColumnFuelStation.ToolTipText = "Название АЗС | адрес";
            // 
            // ColumnStartDate
            // 
            this.ColumnStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnStartDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnStartDate.FillWeight = 90F;
            this.ColumnStartDate.HeaderText = "Отправка";
            this.ColumnStartDate.Name = "ColumnStartDate";
            // 
            // ColumnEndDate
            // 
            this.ColumnEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.ColumnEndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnEndDate.FillWeight = 90F;
            this.ColumnEndDate.HeaderText = "Прибытие";
            this.ColumnEndDate.Name = "ColumnEndDate";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Price";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnPrice.HeaderText = "Сумма";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // UserControlFuelAccountingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "UserControlFuelAccountingItem";
            this.Size = new System.Drawing.Size(1368, 698);
            this.Load += new System.EventHandler(this.UserControlFuelAccountingItem_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuelAccountingItems)).EndInit();
            this.flowLayoutPanelHelp.ResumeLayout(false);
            this.flowLayoutPanelHelp.PerformLayout();
            this.materialCardHelp.ResumeLayout(false);
            this.materialCardHelp.PerformLayout();
            this.materialCardHelpTitle.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCardHelp2.ResumeLayout(false);
            this.materialCardMenu.ResumeLayout(false);
            this.materialCardMenu.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridViewFuelAccountingItems;
        private MaterialSkin.Controls.MaterialLabel labelStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHelp;
        private MaterialSkin.Controls.MaterialCard materialCardMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private MaterialSkin.Controls.MaterialButton buttonAdd;
        private MaterialSkin.Controls.MaterialButton buttonDelete;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxSearch;
        private MaterialSkin.Controls.MaterialButton buttonPdf;
        private MaterialSkin.Controls.MaterialCard materialCardHelp;
        private MaterialSkin.Controls.MaterialListBox materialListBoxSort;
        private MaterialSkin.Controls.MaterialCard materialCardHelpTitle;
        private MaterialSkin.Controls.MaterialLabel labelHelp;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListBox materialListBoxTypes;
        private MaterialSkin.Controls.MaterialCard materialCardHelp2;
        private MaterialSkin.Controls.MaterialLabel labelHelp2;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTruck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrailer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFuelStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
    }
}
