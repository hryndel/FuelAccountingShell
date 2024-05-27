namespace FuelAccountingShell.UserControls
{
    partial class UserControlUser
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
            this.flowLayoutPanelHelp = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCardHelp = new MaterialSkin.Controls.MaterialCard();
            this.materialListBoxRoles = new MaterialSkin.Controls.MaterialListBox();
            this.materialCardHelpTitle = new MaterialSkin.Controls.MaterialCard();
            this.labelHelp = new MaterialSkin.Controls.MaterialLabel();
            this.labelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.materialCardMenu = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new MaterialSkin.Controls.MaterialButton();
            this.buttonEdit = new MaterialSkin.Controls.MaterialButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialButton();
            this.textBoxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.flowLayoutPanelHelp.SuspendLayout();
            this.materialCardHelp.SuspendLayout();
            this.materialCardHelpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.materialCardMenu.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.materialCardHelp.Controls.Add(this.materialListBoxRoles);
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
            // materialListBoxRoles
            // 
            this.materialListBoxRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListBoxRoles.BackColor = System.Drawing.Color.White;
            this.materialListBoxRoles.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxRoles.Depth = 0;
            this.materialListBoxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxRoles.Location = new System.Drawing.Point(14, 75);
            this.materialListBoxRoles.Margin = new System.Windows.Forms.Padding(0);
            this.materialListBoxRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxRoles.Name = "materialListBoxRoles";
            this.materialListBoxRoles.SelectedIndex = -1;
            this.materialListBoxRoles.SelectedItem = null;
            this.materialListBoxRoles.Size = new System.Drawing.Size(206, 182);
            this.materialListBoxRoles.TabIndex = 5;
            this.materialListBoxRoles.UseAccentColor = true;
            this.materialListBoxRoles.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBoxRoles_SelectedIndexChanged);
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
            this.labelHelp.Text = "Фильтрация по ролям";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirstName,
            this.ColumnLastName,
            this.ColumnPatronymic,
            this.ColumnMail,
            this.ColumnLogin,
            this.ColumnUserType});
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(14, 113);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(14, 3, 14, 3);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(1100, 553);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUsers_CellFormatting);
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.DataPropertyName = "FirstName";
            this.ColumnFirstName.HeaderText = "Имя";
            this.ColumnFirstName.Name = "ColumnFirstName";
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.DataPropertyName = "LastName";
            this.ColumnLastName.HeaderText = "Фамилия";
            this.ColumnLastName.Name = "ColumnLastName";
            // 
            // ColumnPatronymic
            // 
            this.ColumnPatronymic.DataPropertyName = "Patronymic";
            this.ColumnPatronymic.HeaderText = "Отчество";
            this.ColumnPatronymic.Name = "ColumnPatronymic";
            // 
            // ColumnMail
            // 
            this.ColumnMail.DataPropertyName = "Mail";
            this.ColumnMail.HeaderText = "Почта";
            this.ColumnMail.Name = "ColumnMail";
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.DataPropertyName = "Login";
            this.ColumnLogin.HeaderText = "Логин";
            this.ColumnLogin.Name = "ColumnLogin";
            // 
            // ColumnUserType
            // 
            this.ColumnUserType.DataPropertyName = "UserType";
            this.ColumnUserType.FillWeight = 70F;
            this.ColumnUserType.HeaderText = "Роль";
            this.ColumnUserType.Name = "ColumnUserType";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.dataGridViewUsers, 0, 1);
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
            this.buttonAdd.TabIndex = 1;
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
            this.buttonEdit.TabIndex = 2;
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
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDelete.UseAccentColor = false;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AnimateReadOnly = false;
            this.textBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSearch.Depth = 0;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.HideSelection = true;
            this.textBoxSearch.Hint = "Поиск по логину";
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
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.TrailingIcon = null;
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // UserControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "UserControlUser";
            this.Size = new System.Drawing.Size(1368, 698);
            this.Load += new System.EventHandler(this.UserControlUser_Load);
            this.flowLayoutPanelHelp.ResumeLayout(false);
            this.flowLayoutPanelHelp.PerformLayout();
            this.materialCardHelp.ResumeLayout(false);
            this.materialCardHelp.PerformLayout();
            this.materialCardHelpTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.materialCardMenu.ResumeLayout(false);
            this.materialCardMenu.PerformLayout();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHelp;
        private MaterialSkin.Controls.MaterialLabel labelStatus;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialCard materialCardMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private MaterialSkin.Controls.MaterialButton buttonAdd;
        private MaterialSkin.Controls.MaterialButton buttonEdit;
        private MaterialSkin.Controls.MaterialButton buttonDelete;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxSearch;
        private MaterialSkin.Controls.MaterialCard materialCardHelp;
        private MaterialSkin.Controls.MaterialListBox materialListBoxRoles;
        private MaterialSkin.Controls.MaterialCard materialCardHelpTitle;
        private MaterialSkin.Controls.MaterialLabel labelHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserType;
    }
}
