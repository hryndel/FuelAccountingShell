namespace FuelAccountingShell.Forms
{
    partial class FormAddEditDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditDriver));
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.labeliDriversLicense = new MaterialSkin.Controls.MaterialLabel();
            this.maskedTextBoxDriversLicense = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.masketTextBoxNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.textBoxPatronymic = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelPatronymic = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxSecondName = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelSecondName = new MaterialSkin.Controls.MaterialLabel();
            this.labelFirstName = new MaterialSkin.Controls.MaterialLabel();
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
            this.buttonCancel.Location = new System.Drawing.Point(286, 414);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(196, 36);
            this.buttonCancel.TabIndex = 7;
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
            this.buttonAccept.Location = new System.Drawing.Point(17, 414);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccept.Size = new System.Drawing.Size(196, 36);
            this.buttonAccept.TabIndex = 6;
            this.buttonAccept.Text = "Создать";
            this.buttonAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccept.UseAccentColor = false;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.labeliDriversLicense);
            this.materialCard.Controls.Add(this.maskedTextBoxDriversLicense);
            this.materialCard.Controls.Add(this.labelNumber);
            this.materialCard.Controls.Add(this.masketTextBoxNumber);
            this.materialCard.Controls.Add(this.textBoxPatronymic);
            this.materialCard.Controls.Add(this.labelPatronymic);
            this.materialCard.Controls.Add(this.textBoxSecondName);
            this.materialCard.Controls.Add(this.textBoxFirstName);
            this.materialCard.Controls.Add(this.labelSecondName);
            this.materialCard.Controls.Add(this.labelFirstName);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(465, 292);
            this.materialCard.TabIndex = 0;
            // 
            // labeliDriversLicense
            // 
            this.labeliDriversLicense.AutoSize = true;
            this.labeliDriversLicense.Depth = 0;
            this.labeliDriversLicense.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labeliDriversLicense.Location = new System.Drawing.Point(30, 242);
            this.labeliDriversLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.labeliDriversLicense.Name = "labeliDriversLicense";
            this.labeliDriversLicense.Size = new System.Drawing.Size(77, 19);
            this.labeliDriversLicense.TabIndex = 0;
            this.labeliDriversLicense.Text = "Лицензия:";
            // 
            // maskedTextBoxDriversLicense
            // 
            this.maskedTextBoxDriversLicense.AllowPromptAsInput = true;
            this.maskedTextBoxDriversLicense.AnimateReadOnly = false;
            this.maskedTextBoxDriversLicense.AsciiOnly = false;
            this.maskedTextBoxDriversLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maskedTextBoxDriversLicense.BeepOnError = false;
            this.maskedTextBoxDriversLicense.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskedTextBoxDriversLicense.Depth = 0;
            this.maskedTextBoxDriversLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maskedTextBoxDriversLicense.HidePromptOnLeave = false;
            this.maskedTextBoxDriversLicense.HideSelection = true;
            this.maskedTextBoxDriversLicense.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.maskedTextBoxDriversLicense.LeadingIcon = null;
            this.maskedTextBoxDriversLicense.Location = new System.Drawing.Point(123, 233);
            this.maskedTextBoxDriversLicense.Mask = "00-00-000000";
            this.maskedTextBoxDriversLicense.MaxLength = 32767;
            this.maskedTextBoxDriversLicense.MouseState = MaterialSkin.MouseState.OUT;
            this.maskedTextBoxDriversLicense.Name = "maskedTextBoxDriversLicense";
            this.maskedTextBoxDriversLicense.PasswordChar = '\0';
            this.maskedTextBoxDriversLicense.PrefixSuffixText = null;
            this.maskedTextBoxDriversLicense.PromptChar = '_';
            this.maskedTextBoxDriversLicense.ReadOnly = false;
            this.maskedTextBoxDriversLicense.RejectInputOnFirstFailure = false;
            this.maskedTextBoxDriversLicense.ResetOnPrompt = true;
            this.maskedTextBoxDriversLicense.ResetOnSpace = true;
            this.maskedTextBoxDriversLicense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBoxDriversLicense.SelectedText = "";
            this.maskedTextBoxDriversLicense.SelectionLength = 0;
            this.maskedTextBoxDriversLicense.SelectionStart = 0;
            this.maskedTextBoxDriversLicense.ShortcutsEnabled = true;
            this.maskedTextBoxDriversLicense.Size = new System.Drawing.Size(303, 36);
            this.maskedTextBoxDriversLicense.SkipLiterals = true;
            this.maskedTextBoxDriversLicense.TabIndex = 5;
            this.maskedTextBoxDriversLicense.TabStop = false;
            this.maskedTextBoxDriversLicense.Text = "__-__-______";
            this.maskedTextBoxDriversLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maskedTextBoxDriversLicense.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxDriversLicense.TrailingIcon = null;
            this.maskedTextBoxDriversLicense.UseSystemPasswordChar = false;
            this.maskedTextBoxDriversLicense.UseTallSize = false;
            this.maskedTextBoxDriversLicense.ValidatingType = null;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Depth = 0;
            this.labelNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNumber.Location = new System.Drawing.Point(30, 188);
            this.labelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(70, 19);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Телефон:";
            // 
            // masketTextBoxNumber
            // 
            this.masketTextBoxNumber.AllowPromptAsInput = true;
            this.masketTextBoxNumber.AnimateReadOnly = false;
            this.masketTextBoxNumber.AsciiOnly = false;
            this.masketTextBoxNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.masketTextBoxNumber.BeepOnError = false;
            this.masketTextBoxNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.masketTextBoxNumber.Depth = 0;
            this.masketTextBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.masketTextBoxNumber.HidePromptOnLeave = false;
            this.masketTextBoxNumber.HideSelection = true;
            this.masketTextBoxNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.masketTextBoxNumber.LeadingIcon = null;
            this.masketTextBoxNumber.Location = new System.Drawing.Point(123, 179);
            this.masketTextBoxNumber.Mask = "0(000)-000-00-00";
            this.masketTextBoxNumber.MaxLength = 32767;
            this.masketTextBoxNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.masketTextBoxNumber.Name = "masketTextBoxNumber";
            this.masketTextBoxNumber.PasswordChar = '\0';
            this.masketTextBoxNumber.PrefixSuffixText = null;
            this.masketTextBoxNumber.PromptChar = '_';
            this.masketTextBoxNumber.ReadOnly = false;
            this.masketTextBoxNumber.RejectInputOnFirstFailure = false;
            this.masketTextBoxNumber.ResetOnPrompt = true;
            this.masketTextBoxNumber.ResetOnSpace = true;
            this.masketTextBoxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.masketTextBoxNumber.SelectedText = "";
            this.masketTextBoxNumber.SelectionLength = 0;
            this.masketTextBoxNumber.SelectionStart = 0;
            this.masketTextBoxNumber.ShortcutsEnabled = true;
            this.masketTextBoxNumber.Size = new System.Drawing.Size(303, 36);
            this.masketTextBoxNumber.SkipLiterals = true;
            this.masketTextBoxNumber.TabIndex = 4;
            this.masketTextBoxNumber.TabStop = false;
            this.masketTextBoxNumber.Text = " (   )-   -  -";
            this.masketTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.masketTextBoxNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.masketTextBoxNumber.TrailingIcon = null;
            this.masketTextBoxNumber.UseSystemPasswordChar = false;
            this.masketTextBoxNumber.UseTallSize = false;
            this.masketTextBoxNumber.ValidatingType = null;
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
            this.textBoxPatronymic.Location = new System.Drawing.Point(123, 125);
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
            this.textBoxPatronymic.TabIndex = 3;
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
            this.labelPatronymic.Location = new System.Drawing.Point(30, 134);
            this.labelPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(75, 19);
            this.labelPatronymic.TabIndex = 0;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.AnimateReadOnly = false;
            this.textBoxSecondName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxSecondName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSecondName.Depth = 0;
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSecondName.HideSelection = true;
            this.textBoxSecondName.LeadingIcon = null;
            this.textBoxSecondName.Location = new System.Drawing.Point(123, 71);
            this.textBoxSecondName.MaxLength = 50;
            this.textBoxSecondName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.PasswordChar = '\0';
            this.textBoxSecondName.PrefixSuffixText = null;
            this.textBoxSecondName.ReadOnly = false;
            this.textBoxSecondName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSecondName.SelectedText = "";
            this.textBoxSecondName.SelectionLength = 0;
            this.textBoxSecondName.SelectionStart = 0;
            this.textBoxSecondName.ShortcutsEnabled = true;
            this.textBoxSecondName.Size = new System.Drawing.Size(303, 36);
            this.textBoxSecondName.TabIndex = 2;
            this.textBoxSecondName.TabStop = false;
            this.textBoxSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSecondName.TrailingIcon = null;
            this.textBoxSecondName.UseSystemPasswordChar = false;
            this.textBoxSecondName.UseTallSize = false;
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
            this.textBoxFirstName.Location = new System.Drawing.Point(123, 17);
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
            this.textBoxFirstName.TabIndex = 1;
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
            this.labelSecondName.Location = new System.Drawing.Point(30, 80);
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
            this.labelFirstName.Location = new System.Drawing.Point(30, 26);
            this.labelFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(37, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя:";
            // 
            // FormAddEditDriver
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(499, 465);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditDriver";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с водителем";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPatronymic;
        private MaterialSkin.Controls.MaterialLabel labelPatronymic;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxSecondName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFirstName;
        private MaterialSkin.Controls.MaterialLabel labelSecondName;
        private MaterialSkin.Controls.MaterialLabel labelFirstName;
        private MaterialSkin.Controls.MaterialLabel labeliDriversLicense;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskedTextBoxDriversLicense;
        private MaterialSkin.Controls.MaterialLabel labelNumber;
        private MaterialSkin.Controls.MaterialMaskedTextBox masketTextBoxNumber;
    }
}