namespace FuelAccountingShell.Forms
{
    partial class FormAddEditFuel
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
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.buttonAccept = new MaterialSkin.Controls.MaterialButton();
            this.materialCard = new MaterialSkin.Controls.MaterialCard();
            this.comboBoxType = new MaterialSkin.Controls.MaterialComboBox();
            this.labelCount = new MaterialSkin.Controls.MaterialLabel();
            this.labelSupplier = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelPrice = new MaterialSkin.Controls.MaterialLabel();
            this.labelType = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxSupplier = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxCount = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.buttonCancel.Location = new System.Drawing.Point(294, 370);
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
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAccept.HighEmphasis = true;
            this.buttonAccept.Icon = null;
            this.buttonAccept.Location = new System.Drawing.Point(17, 370);
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
            this.materialCard.Controls.Add(this.textBoxCount);
            this.materialCard.Controls.Add(this.comboBoxSupplier);
            this.materialCard.Controls.Add(this.comboBoxType);
            this.materialCard.Controls.Add(this.labelCount);
            this.materialCard.Controls.Add(this.labelSupplier);
            this.materialCard.Controls.Add(this.textBoxPrice);
            this.materialCard.Controls.Add(this.labelPrice);
            this.materialCard.Controls.Add(this.labelType);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(473, 248);
            this.materialCard.TabIndex = 0;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoResize = false;
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxType.Depth = 0;
            this.comboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxType.DropDownHeight = 118;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.DropDownWidth = 121;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.IntegralHeight = false;
            this.comboBoxType.ItemHeight = 29;
            this.comboBoxType.Location = new System.Drawing.Point(130, 23);
            this.comboBoxType.MaxDropDownItems = 4;
            this.comboBoxType.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(303, 35);
            this.comboBoxType.StartIndex = 0;
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.UseTallSize = false;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Depth = 0;
            this.labelCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCount.Location = new System.Drawing.Point(30, 188);
            this.labelCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(93, 19);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Количество:";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Depth = 0;
            this.labelSupplier.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSupplier.Location = new System.Drawing.Point(30, 134);
            this.labelSupplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(90, 19);
            this.labelSupplier.TabIndex = 0;
            this.labelSupplier.Text = "Поставщик:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AnimateReadOnly = false;
            this.textBoxPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPrice.Depth = 0;
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrice.HideSelection = true;
            this.textBoxPrice.LeadingIcon = null;
            this.textBoxPrice.Location = new System.Drawing.Point(130, 71);
            this.textBoxPrice.MaxLength = 10;
            this.textBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PasswordChar = '\0';
            this.textBoxPrice.PrefixSuffixText = null;
            this.textBoxPrice.ReadOnly = false;
            this.textBoxPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPrice.SelectedText = "";
            this.textBoxPrice.SelectionLength = 0;
            this.textBoxPrice.SelectionStart = 0;
            this.textBoxPrice.ShortcutsEnabled = true;
            this.textBoxPrice.Size = new System.Drawing.Size(303, 36);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.TabStop = false;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPrice.TrailingIcon = null;
            this.textBoxPrice.UseSystemPasswordChar = false;
            this.textBoxPrice.UseTallSize = false;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Depth = 0;
            this.labelPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPrice.Location = new System.Drawing.Point(30, 80);
            this.labelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 19);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Цена:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Depth = 0;
            this.labelType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelType.Location = new System.Drawing.Point(30, 26);
            this.labelType.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(33, 19);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Тип:";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.AutoResize = false;
            this.comboBoxSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxSupplier.Depth = 0;
            this.comboBoxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxSupplier.DropDownHeight = 118;
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.DropDownWidth = 121;
            this.comboBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.IntegralHeight = false;
            this.comboBoxSupplier.ItemHeight = 29;
            this.comboBoxSupplier.Location = new System.Drawing.Point(130, 125);
            this.comboBoxSupplier.MaxDropDownItems = 4;
            this.comboBoxSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(303, 35);
            this.comboBoxSupplier.StartIndex = 0;
            this.comboBoxSupplier.TabIndex = 2;
            this.comboBoxSupplier.UseTallSize = false;
            // 
            // textBoxCount
            // 
            this.textBoxCount.AnimateReadOnly = false;
            this.textBoxCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxCount.Depth = 0;
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCount.HideSelection = true;
            this.textBoxCount.LeadingIcon = null;
            this.textBoxCount.Location = new System.Drawing.Point(130, 179);
            this.textBoxCount.MaxLength = 10;
            this.textBoxCount.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.PasswordChar = '\0';
            this.textBoxCount.PrefixSuffixText = null;
            this.textBoxCount.ReadOnly = false;
            this.textBoxCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCount.SelectedText = "";
            this.textBoxCount.SelectionLength = 0;
            this.textBoxCount.SelectionStart = 0;
            this.textBoxCount.ShortcutsEnabled = true;
            this.textBoxCount.Size = new System.Drawing.Size(303, 36);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.TabStop = false;
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCount.TrailingIcon = null;
            this.textBoxCount.UseSystemPasswordChar = false;
            this.textBoxCount.UseTallSize = false;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // FormAddEditFuel
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(507, 420);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddEditFuel";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с топливом";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialLabel labelCount;
        private MaterialSkin.Controls.MaterialLabel labelSupplier;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPrice;
        private MaterialSkin.Controls.MaterialLabel labelPrice;
        private MaterialSkin.Controls.MaterialLabel labelType;
        private MaterialSkin.Controls.MaterialComboBox comboBoxType;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxCount;
        private MaterialSkin.Controls.MaterialComboBox comboBoxSupplier;
    }
}