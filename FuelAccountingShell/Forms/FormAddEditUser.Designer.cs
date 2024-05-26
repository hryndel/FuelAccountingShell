namespace FuelAccountingShell.Forms
{
    partial class FormAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditUser));
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.comboBoxUserType = new MaterialSkin.Controls.MaterialComboBox();
            this.labelSupplier = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPatronymic = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelSecondName = new MaterialSkin.Controls.MaterialLabel();
            this.labelFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelLogin = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelMail = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMail = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = false;
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCancel.Depth = 0;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.HighEmphasis = true;
            this.buttonCancel.Icon = null;
            this.buttonCancel.Location = new System.Drawing.Point(511, 361);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(364, 36);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonCancel.UseAccentColor = false;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.AutoSize = false;
            this.buttonAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAccept.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAccept.Depth = 0;
            this.buttonAccept.HighEmphasis = true;
            this.buttonAccept.Icon = null;
            this.buttonAccept.Location = new System.Drawing.Point(61, 361);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccept.Size = new System.Drawing.Size(364, 36);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "Создать";
            this.buttonAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccept.UseAccentColor = false;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.comboBoxUserType);
            this.materialCard.Controls.Add(this.labelSupplier);
            this.materialCard.Controls.Add(this.textBoxPatronymic);
            this.materialCard.Controls.Add(this.labelPatronymic);
            this.materialCard.Controls.Add(this.textBoxLastName);
            this.materialCard.Controls.Add(this.textBoxFirstName);
            this.materialCard.Controls.Add(this.labelSecondName);
            this.materialCard.Controls.Add(this.labelFirstName);
            this.materialCard.Controls.Add(this.labelPassword);
            this.materialCard.Controls.Add(this.textBoxPassword);
            this.materialCard.Controls.Add(this.labelLogin);
            this.materialCard.Controls.Add(this.textBoxLogin);
            this.materialCard.Controls.Add(this.labelMail);
            this.materialCard.Controls.Add(this.textBoxMail);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(905, 239);
            this.materialCard.TabIndex = 0;
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.AutoResize = false;
            this.comboBoxUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxUserType.Depth = 0;
            this.comboBoxUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxUserType.DropDownHeight = 118;
            this.comboBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserType.DropDownWidth = 121;
            this.comboBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.IntegralHeight = false;
            this.comboBoxUserType.ItemHeight = 29;
            this.comboBoxUserType.Location = new System.Drawing.Point(574, 127);
            this.comboBoxUserType.MaxDropDownItems = 4;
            this.comboBoxUserType.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(303, 35);
            this.comboBoxUserType.StartIndex = 0;
            this.comboBoxUserType.TabIndex = 6;
            this.comboBoxUserType.UseTallSize = false;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Depth = 0;
            this.labelSupplier.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSupplier.Location = new System.Drawing.Point(468, 134);
            this.labelSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(42, 19);
            this.labelSupplier.TabIndex = 0;
            this.labelSupplier.Text = "Роль:";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.AnimateReadOnly = false;
            this.textBoxPatronymic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPatronymic.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPatronymic.Depth = 0;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPatronymic.HideSelection = true;
            this.textBoxPatronymic.LeadingIcon = null;
            this.textBoxPatronymic.Location = new System.Drawing.Point(124, 125);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.PasswordChar = '\0';
            this.textBoxPatronymic.PrefixSuffixText = null;
            this.textBoxPatronymic.ReadOnly = false;
            this.textBoxPatronymic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPatronymic.SelectedText = "";
            this.textBoxPatronymic.SelectionLength = 0;
            this.textBoxPatronymic.SelectionStart = 0;
            this.textBoxPatronymic.ShortcutsEnabled = true;
            this.textBoxPatronymic.Size = new System.Drawing.Size(303, 36);
            this.textBoxPatronymic.TabIndex = 2;
            this.textBoxPatronymic.TabStop = false;
            this.textBoxPatronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPatronymic.TrailingIcon = null;
            this.textBoxPatronymic.UseSystemPasswordChar = false;
            this.textBoxPatronymic.UseTallSize = false;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Depth = 0;
            this.labelPatronymic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPatronymic.Location = new System.Drawing.Point(31, 134);
            this.labelPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(75, 19);
            this.labelPatronymic.TabIndex = 0;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AnimateReadOnly = false;
            this.textBoxLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxLastName.Depth = 0;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLastName.HideSelection = true;
            this.textBoxLastName.LeadingIcon = null;
            this.textBoxLastName.Location = new System.Drawing.Point(124, 71);
            this.textBoxLastName.MaxLength = 50;
            this.textBoxLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PasswordChar = '\0';
            this.textBoxLastName.PrefixSuffixText = null;
            this.textBoxLastName.ReadOnly = false;
            this.textBoxLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLastName.SelectedText = "";
            this.textBoxLastName.SelectionLength = 0;
            this.textBoxLastName.SelectionStart = 0;
            this.textBoxLastName.ShortcutsEnabled = true;
            this.textBoxLastName.Size = new System.Drawing.Size(303, 36);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TabStop = false;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxLastName.TrailingIcon = null;
            this.textBoxLastName.UseSystemPasswordChar = false;
            this.textBoxLastName.UseTallSize = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AnimateReadOnly = false;
            this.textBoxFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFirstName.Depth = 0;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxFirstName.HideSelection = true;
            this.textBoxFirstName.LeadingIcon = null;
            this.textBoxFirstName.Location = new System.Drawing.Point(124, 17);
            this.textBoxFirstName.MaxLength = 50;
            this.textBoxFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PasswordChar = '\0';
            this.textBoxFirstName.PrefixSuffixText = null;
            this.textBoxFirstName.ReadOnly = false;
            this.textBoxFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFirstName.SelectedText = "";
            this.textBoxFirstName.SelectionLength = 0;
            this.textBoxFirstName.SelectionStart = 0;
            this.textBoxFirstName.ShortcutsEnabled = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(303, 36);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TabStop = false;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxFirstName.TrailingIcon = null;
            this.textBoxFirstName.UseSystemPasswordChar = false;
            this.textBoxFirstName.UseTallSize = false;
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Depth = 0;
            this.labelSecondName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSecondName.Location = new System.Drawing.Point(31, 80);
            this.labelSecondName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(74, 19);
            this.labelSecondName.TabIndex = 0;
            this.labelSecondName.Text = "Фамилия:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Depth = 0;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFirstName.Location = new System.Drawing.Point(31, 26);
            this.labelFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(37, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPassword.Location = new System.Drawing.Point(469, 80);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 19);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.HideSelection = true;
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(574, 70);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PrefixSuffixText = null;
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(303, 36);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.TrailingIcon = null;
            this.textBoxPassword.UseSystemPasswordChar = false;
            this.textBoxPassword.UseTallSize = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Depth = 0;
            this.labelLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelLogin.Location = new System.Drawing.Point(469, 26);
            this.labelLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 19);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AnimateReadOnly = false;
            this.textBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxLogin.Depth = 0;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLogin.HideSelection = true;
            this.textBoxLogin.LeadingIcon = null;
            this.textBoxLogin.Location = new System.Drawing.Point(574, 14);
            this.textBoxLogin.MaxLength = 20;
            this.textBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PasswordChar = '\0';
            this.textBoxLogin.PrefixSuffixText = null;
            this.textBoxLogin.ReadOnly = false;
            this.textBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLogin.SelectedText = "";
            this.textBoxLogin.SelectionLength = 0;
            this.textBoxLogin.SelectionStart = 0;
            this.textBoxLogin.ShortcutsEnabled = true;
            this.textBoxLogin.Size = new System.Drawing.Size(303, 36);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.TabStop = false;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxLogin.TrailingIcon = null;
            this.textBoxLogin.UseSystemPasswordChar = false;
            this.textBoxLogin.UseTallSize = false;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Depth = 0;
            this.labelMail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelMail.Location = new System.Drawing.Point(31, 191);
            this.labelMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(51, 19);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "Почта:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.AnimateReadOnly = false;
            this.textBoxMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxMail.Depth = 0;
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxMail.HideSelection = true;
            this.textBoxMail.LeadingIcon = null;
            this.textBoxMail.Location = new System.Drawing.Point(124, 181);
            this.textBoxMail.MaxLength = 320;
            this.textBoxMail.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.PasswordChar = '\0';
            this.textBoxMail.PrefixSuffixText = null;
            this.textBoxMail.ReadOnly = false;
            this.textBoxMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMail.SelectedText = "";
            this.textBoxMail.SelectionLength = 0;
            this.textBoxMail.SelectionStart = 0;
            this.textBoxMail.ShortcutsEnabled = true;
            this.textBoxMail.Size = new System.Drawing.Size(303, 36);
            this.textBoxMail.TabIndex = 3;
            this.textBoxMail.TabStop = false;
            this.textBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMail.TrailingIcon = null;
            this.textBoxMail.UseSystemPasswordChar = false;
            this.textBoxMail.UseTallSize = false;
            // 
            // FormAddEditUser
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(939, 412);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditUser";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с пользователем";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPassword;
        private MaterialSkin.Controls.MaterialLabel labelLogin;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxLogin;
        private MaterialSkin.Controls.MaterialLabel labelMail;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxMail;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPatronymic;
        private MaterialSkin.Controls.MaterialLabel labelPatronymic;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxLastName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFirstName;
        private MaterialSkin.Controls.MaterialLabel labelSecondName;
        private MaterialSkin.Controls.MaterialLabel labelFirstName;
        private MaterialSkin.Controls.MaterialComboBox comboBoxUserType;
        private MaterialSkin.Controls.MaterialLabel labelSupplier;
    }
}