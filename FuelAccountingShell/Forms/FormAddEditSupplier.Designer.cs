namespace FuelAccountingShell.Forms
{
    partial class FormAddEditSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditSupplier));
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.multiTextBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.labelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.masketTextBoxNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.textBoxInn = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelInn = new MaterialSkin.Controls.MaterialLabel();
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
            this.buttonCancel.Location = new System.Drawing.Point(373, 427);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(196, 36);
            this.buttonCancel.TabIndex = 6;
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
            this.buttonAccept.Location = new System.Drawing.Point(50, 427);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccept.Size = new System.Drawing.Size(196, 36);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Создать";
            this.buttonAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccept.UseAccentColor = false;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.multiTextBoxDescription);
            this.materialCard.Controls.Add(this.labelDescription);
            this.materialCard.Controls.Add(this.labelNumber);
            this.materialCard.Controls.Add(this.masketTextBoxNumber);
            this.materialCard.Controls.Add(this.textBoxInn);
            this.materialCard.Controls.Add(this.textBoxName);
            this.materialCard.Controls.Add(this.labelInn);
            this.materialCard.Controls.Add(this.labelName);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(586, 305);
            this.materialCard.TabIndex = 0;
            // 
            // multiTextBoxDescription
            // 
            this.multiTextBoxDescription.AnimateReadOnly = false;
            this.multiTextBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiTextBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.multiTextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.multiTextBoxDescription.Depth = 0;
            this.multiTextBoxDescription.HideSelection = true;
            this.multiTextBoxDescription.Location = new System.Drawing.Point(123, 182);
            this.multiTextBoxDescription.MaxLength = 100;
            this.multiTextBoxDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.multiTextBoxDescription.Name = "multiTextBoxDescription";
            this.multiTextBoxDescription.PasswordChar = '\0';
            this.multiTextBoxDescription.ReadOnly = false;
            this.multiTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.multiTextBoxDescription.SelectedText = "";
            this.multiTextBoxDescription.SelectionLength = 0;
            this.multiTextBoxDescription.SelectionStart = 0;
            this.multiTextBoxDescription.ShortcutsEnabled = true;
            this.multiTextBoxDescription.Size = new System.Drawing.Size(429, 101);
            this.multiTextBoxDescription.TabIndex = 4;
            this.multiTextBoxDescription.TabStop = false;
            this.multiTextBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.multiTextBoxDescription.UseSystemPasswordChar = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Depth = 0;
            this.labelDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescription.Location = new System.Drawing.Point(30, 191);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(77, 19);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Описание:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Depth = 0;
            this.labelNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNumber.Location = new System.Drawing.Point(30, 134);
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
            this.masketTextBoxNumber.Location = new System.Drawing.Point(123, 125);
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
            this.masketTextBoxNumber.Size = new System.Drawing.Size(173, 36);
            this.masketTextBoxNumber.SkipLiterals = true;
            this.masketTextBoxNumber.TabIndex = 3;
            this.masketTextBoxNumber.TabStop = false;
            this.masketTextBoxNumber.Text = " (   )-   -  -";
            this.masketTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.masketTextBoxNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.masketTextBoxNumber.TrailingIcon = null;
            this.masketTextBoxNumber.UseSystemPasswordChar = false;
            this.masketTextBoxNumber.UseTallSize = false;
            this.masketTextBoxNumber.ValidatingType = null;
            // 
            // textBoxInn
            // 
            this.textBoxInn.AnimateReadOnly = false;
            this.textBoxInn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxInn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxInn.Depth = 0;
            this.textBoxInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxInn.HideSelection = true;
            this.textBoxInn.LeadingIcon = null;
            this.textBoxInn.Location = new System.Drawing.Point(123, 71);
            this.textBoxInn.MaxLength = 20;
            this.textBoxInn.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxInn.Name = "textBoxInn";
            this.textBoxInn.PasswordChar = '\0';
            this.textBoxInn.PrefixSuffixText = null;
            this.textBoxInn.ReadOnly = false;
            this.textBoxInn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxInn.SelectedText = "";
            this.textBoxInn.SelectionLength = 0;
            this.textBoxInn.SelectionStart = 0;
            this.textBoxInn.ShortcutsEnabled = true;
            this.textBoxInn.Size = new System.Drawing.Size(429, 36);
            this.textBoxInn.TabIndex = 2;
            this.textBoxInn.TabStop = false;
            this.textBoxInn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxInn.TrailingIcon = null;
            this.textBoxInn.UseSystemPasswordChar = false;
            this.textBoxInn.UseTallSize = false;
            this.textBoxInn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInn_KeyPress);
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
            this.textBoxName.Location = new System.Drawing.Point(123, 17);
            this.textBoxName.MaxLength = 50;
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
            // labelInn
            // 
            this.labelInn.AutoSize = true;
            this.labelInn.Depth = 0;
            this.labelInn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelInn.Location = new System.Drawing.Point(30, 80);
            this.labelInn.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelInn.Name = "labelInn";
            this.labelInn.Size = new System.Drawing.Size(38, 19);
            this.labelInn.TabIndex = 0;
            this.labelInn.Text = "ИНН:";
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
            // FormAddEditSupplier
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(620, 477);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditSupplier";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с поставщиком";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel labelNumber;
        private MaterialSkin.Controls.MaterialMaskedTextBox masketTextBoxNumber;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxInn;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialLabel labelInn;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 multiTextBoxDescription;
        private MaterialSkin.Controls.MaterialLabel labelDescription;
    }
}