namespace FuelAccountingShell.Forms
{
    partial class FormAddEditTrailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditTrailer));
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.labelCapacity = new MaterialSkin.Controls.MaterialLabel();
            this.masketTextBoxNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.textBoxCapacity = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
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
            this.buttonCancel.TabIndex = 4;
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
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Создать";
            this.buttonAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccept.UseAccentColor = false;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.labelCapacity);
            this.materialCard.Controls.Add(this.masketTextBoxNumber);
            this.materialCard.Controls.Add(this.textBoxCapacity);
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
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Depth = 0;
            this.labelCapacity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCapacity.Location = new System.Drawing.Point(30, 134);
            this.labelCapacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(106, 19);
            this.labelCapacity.TabIndex = 0;
            this.labelCapacity.Text = "Вместимость:";
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
            this.masketTextBoxNumber.Location = new System.Drawing.Point(143, 71);
            this.masketTextBoxNumber.Mask = "LL0000 000";
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
            this.masketTextBoxNumber.Size = new System.Drawing.Size(173, 36);
            this.masketTextBoxNumber.SkipLiterals = true;
            this.masketTextBoxNumber.TabIndex = 1;
            this.masketTextBoxNumber.TabStop = false;
            this.masketTextBoxNumber.Text = "       ";
            this.masketTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.masketTextBoxNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.masketTextBoxNumber.TrailingIcon = null;
            this.masketTextBoxNumber.UseSystemPasswordChar = false;
            this.masketTextBoxNumber.UseTallSize = false;
            this.masketTextBoxNumber.ValidatingType = null;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.AnimateReadOnly = false;
            this.textBoxCapacity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxCapacity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxCapacity.Depth = 0;
            this.textBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCapacity.HideSelection = true;
            this.textBoxCapacity.LeadingIcon = null;
            this.textBoxCapacity.Location = new System.Drawing.Point(143, 125);
            this.textBoxCapacity.MaxLength = 5;
            this.textBoxCapacity.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.PasswordChar = '\0';
            this.textBoxCapacity.PrefixSuffixText = null;
            this.textBoxCapacity.ReadOnly = false;
            this.textBoxCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCapacity.SelectedText = "";
            this.textBoxCapacity.SelectionLength = 0;
            this.textBoxCapacity.SelectionStart = 0;
            this.textBoxCapacity.ShortcutsEnabled = true;
            this.textBoxCapacity.Size = new System.Drawing.Size(429, 36);
            this.textBoxCapacity.TabIndex = 2;
            this.textBoxCapacity.TabStop = false;
            this.textBoxCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCapacity.TrailingIcon = null;
            this.textBoxCapacity.UseSystemPasswordChar = false;
            this.textBoxCapacity.UseTallSize = false;
            this.textBoxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapacity_KeyPress);
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
            this.textBoxName.TabIndex = 0;
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
            // FormAddEditTrailer
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
            this.Name = "FormAddEditTrailer";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с полуприцепом";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel labelCapacity;
        private MaterialSkin.Controls.MaterialMaskedTextBox masketTextBoxNumber;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxCapacity;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialLabel labelNumber;
        private MaterialSkin.Controls.MaterialLabel labelName;
    }
}