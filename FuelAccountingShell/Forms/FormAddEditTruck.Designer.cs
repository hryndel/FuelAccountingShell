namespace FuelAccountingShell.Forms
{
    partial class FormAddEditTruck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditTruck));
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.labelVin = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxVin = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.maskedTextBoxNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.buttonCancel.Location = new System.Drawing.Point(370, 305);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(196, 36);
            this.buttonCancel.TabIndex = 5;
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
            this.buttonAccept.Location = new System.Drawing.Point(61, 305);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccept.Size = new System.Drawing.Size(196, 36);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Создать";
            this.buttonAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccept.UseAccentColor = false;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.maskedTextBoxNumber);
            this.materialCard.Controls.Add(this.labelVin);
            this.materialCard.Controls.Add(this.textBoxVin);
            this.materialCard.Controls.Add(this.textBoxName);
            this.materialCard.Controls.Add(this.labelNumber);
            this.materialCard.Controls.Add(this.labelName);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(597, 183);
            this.materialCard.TabIndex = 0;
            // 
            // labelVin
            // 
            this.labelVin.AutoSize = true;
            this.labelVin.Depth = 0;
            this.labelVin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelVin.Location = new System.Drawing.Point(30, 134);
            this.labelVin.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVin.Name = "labelVin";
            this.labelVin.Size = new System.Drawing.Size(30, 19);
            this.labelVin.TabIndex = 0;
            this.labelVin.Text = "VIN:";
            // 
            // textBoxVin
            // 
            this.textBoxVin.AnimateReadOnly = false;
            this.textBoxVin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxVin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxVin.Depth = 0;
            this.textBoxVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxVin.HideSelection = true;
            this.textBoxVin.LeadingIcon = null;
            this.textBoxVin.Location = new System.Drawing.Point(143, 125);
            this.textBoxVin.MaxLength = 20;
            this.textBoxVin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.PasswordChar = '\0';
            this.textBoxVin.PrefixSuffixText = null;
            this.textBoxVin.ReadOnly = false;
            this.textBoxVin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxVin.SelectedText = "";
            this.textBoxVin.SelectionLength = 0;
            this.textBoxVin.SelectionStart = 0;
            this.textBoxVin.ShortcutsEnabled = true;
            this.textBoxVin.Size = new System.Drawing.Size(429, 36);
            this.textBoxVin.TabIndex = 3;
            this.textBoxVin.TabStop = false;
            this.textBoxVin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxVin.TrailingIcon = null;
            this.textBoxVin.UseSystemPasswordChar = false;
            this.textBoxVin.UseTallSize = false;
            // 
            // textBoxName
            // 
            this.textBoxName.AnimateReadOnly = false;
            this.textBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxName.Depth = 0;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxName.HideSelection = true;
            this.textBoxName.LeadingIcon = null;
            this.textBoxName.Location = new System.Drawing.Point(143, 17);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PrefixSuffixText = null;
            this.textBoxName.ReadOnly = false;
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.ShortcutsEnabled = true;
            this.textBoxName.Size = new System.Drawing.Size(429, 36);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.TrailingIcon = null;
            this.textBoxName.UseSystemPasswordChar = false;
            this.textBoxName.UseTallSize = false;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Depth = 0;
            this.labelNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNumber.Location = new System.Drawing.Point(30, 80);
            this.labelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(54, 19);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.Location = new System.Drawing.Point(30, 26);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.AllowPromptAsInput = true;
            this.maskedTextBoxNumber.AnimateReadOnly = false;
            this.maskedTextBoxNumber.AsciiOnly = false;
            this.maskedTextBoxNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maskedTextBoxNumber.BeepOnError = false;
            this.maskedTextBoxNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskedTextBoxNumber.Depth = 0;
            this.maskedTextBoxNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maskedTextBoxNumber.HidePromptOnLeave = false;
            this.maskedTextBoxNumber.HideSelection = true;
            this.maskedTextBoxNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.maskedTextBoxNumber.LeadingIcon = null;
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(143, 70);
            this.maskedTextBoxNumber.Mask = "L000LL009";
            this.maskedTextBoxNumber.MaxLength = 32767;
            this.maskedTextBoxNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.PasswordChar = '\0';
            this.maskedTextBoxNumber.PrefixSuffixText = null;
            this.maskedTextBoxNumber.PromptChar = '_';
            this.maskedTextBoxNumber.ReadOnly = false;
            this.maskedTextBoxNumber.RejectInputOnFirstFailure = false;
            this.maskedTextBoxNumber.ResetOnPrompt = true;
            this.maskedTextBoxNumber.ResetOnSpace = true;
            this.maskedTextBoxNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBoxNumber.SelectedText = "";
            this.maskedTextBoxNumber.SelectionLength = 0;
            this.maskedTextBoxNumber.SelectionStart = 0;
            this.maskedTextBoxNumber.ShortcutsEnabled = true;
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(429, 36);
            this.maskedTextBoxNumber.SkipLiterals = true;
            this.maskedTextBoxNumber.TabIndex = 2;
            this.maskedTextBoxNumber.TabStop = false;
            this.maskedTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maskedTextBoxNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxNumber.TrailingIcon = null;
            this.maskedTextBoxNumber.UseSystemPasswordChar = false;
            this.maskedTextBoxNumber.UseTallSize = false;
            this.maskedTextBoxNumber.ValidatingType = null;
            // 
            // FormAddEditTruck
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(631, 358);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditTruck";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с грузовиком";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel labelVin;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxVin;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialLabel labelNumber;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskedTextBoxNumber;
    }
}