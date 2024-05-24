namespace FuelAccountingShell.Forms
{
    partial class FormAddEditFuelStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditFuelStation));
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.multiTextBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.multiTextBoxAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.labelAddress = new MaterialSkin.Controls.MaterialLabel();
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
            this.buttonCancel.Location = new System.Drawing.Point(380, 433);
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
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAccept.HighEmphasis = true;
            this.buttonAccept.Icon = null;
            this.buttonAccept.Location = new System.Drawing.Point(50, 433);
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
            this.materialCard.Controls.Add(this.multiTextBoxDescription);
            this.materialCard.Controls.Add(this.multiTextBoxAddress);
            this.materialCard.Controls.Add(this.textBoxName);
            this.materialCard.Controls.Add(this.labelDescription);
            this.materialCard.Controls.Add(this.labelAddress);
            this.materialCard.Controls.Add(this.labelName);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(591, 311);
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
            this.multiTextBoxDescription.Location = new System.Drawing.Point(130, 188);
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
            this.multiTextBoxDescription.TabIndex = 2;
            this.multiTextBoxDescription.TabStop = false;
            this.multiTextBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.multiTextBoxDescription.UseSystemPasswordChar = false;
            // 
            // multiTextBoxAddress
            // 
            this.multiTextBoxAddress.AnimateReadOnly = false;
            this.multiTextBoxAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiTextBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.multiTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.multiTextBoxAddress.Depth = 0;
            this.multiTextBoxAddress.HideSelection = true;
            this.multiTextBoxAddress.Location = new System.Drawing.Point(130, 71);
            this.multiTextBoxAddress.MaxLength = 100;
            this.multiTextBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.multiTextBoxAddress.Name = "multiTextBoxAddress";
            this.multiTextBoxAddress.PasswordChar = '\0';
            this.multiTextBoxAddress.ReadOnly = false;
            this.multiTextBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.multiTextBoxAddress.SelectedText = "";
            this.multiTextBoxAddress.SelectionLength = 0;
            this.multiTextBoxAddress.SelectionStart = 0;
            this.multiTextBoxAddress.ShortcutsEnabled = true;
            this.multiTextBoxAddress.Size = new System.Drawing.Size(429, 101);
            this.multiTextBoxAddress.TabIndex = 1;
            this.multiTextBoxAddress.TabStop = false;
            this.multiTextBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.multiTextBoxAddress.UseSystemPasswordChar = false;
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
            this.textBoxName.Location = new System.Drawing.Point(130, 23);
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
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TabStop = false;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.TrailingIcon = null;
            this.textBoxName.UseSystemPasswordChar = false;
            this.textBoxName.UseTallSize = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Depth = 0;
            this.labelDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescription.Location = new System.Drawing.Point(30, 197);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(77, 19);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Описание:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Depth = 0;
            this.labelAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAddress.Location = new System.Drawing.Point(30, 80);
            this.labelAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(50, 19);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Адрес:";
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
            // FormAddEditFuelStation
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(625, 483);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddEditFuelStation";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с АЗС";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel labelAddress;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxName;
        private MaterialSkin.Controls.MaterialLabel labelDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 multiTextBoxDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 multiTextBoxAddress;
    }
}