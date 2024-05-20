namespace FuelAccountingShell.Forms
{
    partial class FormAddEditFuelAccountingItem
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
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelFuelStation = new MaterialSkin.Controls.MaterialLabel();
            this.labelCount = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxTrailer = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxDriver = new MaterialSkin.Controls.MaterialComboBox();
            this.labelFuel = new MaterialSkin.Controls.MaterialLabel();
            this.labelTrailer = new MaterialSkin.Controls.MaterialLabel();
            this.labelTruck = new MaterialSkin.Controls.MaterialLabel();
            this.labelDriver = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxTruck = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxFuel = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.comboBoxFuelStation = new MaterialSkin.Controls.MaterialComboBox();
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
            this.buttonCancel.Location = new System.Drawing.Point(535, 370);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancel.Size = new System.Drawing.Size(353, 36);
            this.buttonCancel.TabIndex = 9;
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
            this.buttonAccept.Location = new System.Drawing.Point(50, 370);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAccept.Size = new System.Drawing.Size(353, 36);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Создать";
            this.buttonAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAccept.UseAccentColor = false;
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // materialCard
            // 
            this.materialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard.Controls.Add(this.comboBoxFuelStation);
            this.materialCard.Controls.Add(this.textBoxCount);
            this.materialCard.Controls.Add(this.comboBoxFuel);
            this.materialCard.Controls.Add(this.comboBoxTruck);
            this.materialCard.Controls.Add(this.dateTimePickerEndDate);
            this.materialCard.Controls.Add(this.dateTimePickerStartDate);
            this.materialCard.Controls.Add(this.labelEndDate);
            this.materialCard.Controls.Add(this.labelStartDate);
            this.materialCard.Controls.Add(this.labelFuelStation);
            this.materialCard.Controls.Add(this.labelCount);
            this.materialCard.Controls.Add(this.comboBoxTrailer);
            this.materialCard.Controls.Add(this.comboBoxDriver);
            this.materialCard.Controls.Add(this.labelFuel);
            this.materialCard.Controls.Add(this.labelTrailer);
            this.materialCard.Controls.Add(this.labelTruck);
            this.materialCard.Controls.Add(this.labelDriver);
            this.materialCard.Depth = 0;
            this.materialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard.Location = new System.Drawing.Point(17, 102);
            this.materialCard.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard.Name = "materialCard";
            this.materialCard.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard.Size = new System.Drawing.Size(900, 248);
            this.materialCard.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePickerEndDate.CustomFormat = "";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(568, 177);
            this.dateTimePickerEndDate.MinimumSize = new System.Drawing.Size(303, 40);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(303, 40);
            this.dateTimePickerEndDate.TabIndex = 7;
            this.dateTimePickerEndDate.Value = new System.DateTime(2024, 5, 20, 23, 8, 4, 0);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePickerStartDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePickerStartDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerStartDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePickerStartDate.CustomFormat = "";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(568, 125);
            this.dateTimePickerStartDate.MinimumSize = new System.Drawing.Size(303, 40);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(303, 40);
            this.dateTimePickerStartDate.TabIndex = 6;
            this.dateTimePickerStartDate.Value = new System.DateTime(2024, 5, 20, 23, 8, 4, 0);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Depth = 0;
            this.labelEndDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelEndDate.Location = new System.Drawing.Point(468, 191);
            this.labelEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(85, 19);
            this.labelEndDate.TabIndex = 0;
            this.labelEndDate.Text = "Получение:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Depth = 0;
            this.labelStartDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelStartDate.Location = new System.Drawing.Point(468, 137);
            this.labelStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(78, 19);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Отправка:";
            // 
            // labelFuelStation
            // 
            this.labelFuelStation.AutoSize = true;
            this.labelFuelStation.Depth = 0;
            this.labelFuelStation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFuelStation.Location = new System.Drawing.Point(468, 83);
            this.labelFuelStation.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFuelStation.Name = "labelFuelStation";
            this.labelFuelStation.Size = new System.Drawing.Size(35, 19);
            this.labelFuelStation.TabIndex = 0;
            this.labelFuelStation.Text = "АЗС:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Depth = 0;
            this.labelCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCount.Location = new System.Drawing.Point(468, 29);
            this.labelCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(93, 19);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Количество:";
            // 
            // comboBoxTrailer
            // 
            this.comboBoxTrailer.AutoResize = false;
            this.comboBoxTrailer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTrailer.Depth = 0;
            this.comboBoxTrailer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTrailer.DropDownHeight = 118;
            this.comboBoxTrailer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrailer.DropDownWidth = 121;
            this.comboBoxTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTrailer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTrailer.FormattingEnabled = true;
            this.comboBoxTrailer.IntegralHeight = false;
            this.comboBoxTrailer.ItemHeight = 29;
            this.comboBoxTrailer.Location = new System.Drawing.Point(130, 125);
            this.comboBoxTrailer.MaxDropDownItems = 4;
            this.comboBoxTrailer.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTrailer.Name = "comboBoxTrailer";
            this.comboBoxTrailer.Size = new System.Drawing.Size(303, 35);
            this.comboBoxTrailer.StartIndex = 0;
            this.comboBoxTrailer.TabIndex = 2;
            this.comboBoxTrailer.UseTallSize = false;
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.AutoResize = false;
            this.comboBoxDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxDriver.Depth = 0;
            this.comboBoxDriver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxDriver.DropDownHeight = 118;
            this.comboBoxDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriver.DropDownWidth = 121;
            this.comboBoxDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.IntegralHeight = false;
            this.comboBoxDriver.ItemHeight = 29;
            this.comboBoxDriver.Location = new System.Drawing.Point(130, 23);
            this.comboBoxDriver.MaxDropDownItems = 4;
            this.comboBoxDriver.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(303, 35);
            this.comboBoxDriver.StartIndex = 0;
            this.comboBoxDriver.TabIndex = 0;
            this.comboBoxDriver.UseTallSize = false;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Depth = 0;
            this.labelFuel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFuel.Location = new System.Drawing.Point(30, 188);
            this.labelFuel.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(69, 19);
            this.labelFuel.TabIndex = 0;
            this.labelFuel.Text = "Топливо:";
            // 
            // labelTrailer
            // 
            this.labelTrailer.AutoSize = true;
            this.labelTrailer.Depth = 0;
            this.labelTrailer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTrailer.Location = new System.Drawing.Point(30, 134);
            this.labelTrailer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTrailer.Name = "labelTrailer";
            this.labelTrailer.Size = new System.Drawing.Size(95, 19);
            this.labelTrailer.TabIndex = 0;
            this.labelTrailer.Text = "Полуприцеп:";
            // 
            // labelTruck
            // 
            this.labelTruck.AutoSize = true;
            this.labelTruck.Depth = 0;
            this.labelTruck.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTruck.Location = new System.Drawing.Point(30, 80);
            this.labelTruck.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(75, 19);
            this.labelTruck.TabIndex = 0;
            this.labelTruck.Text = "Грузовик:";
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Depth = 0;
            this.labelDriver.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDriver.Location = new System.Drawing.Point(30, 26);
            this.labelDriver.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(77, 19);
            this.labelDriver.TabIndex = 0;
            this.labelDriver.Text = "Водитель:";
            // 
            // comboBoxTruck
            // 
            this.comboBoxTruck.AutoResize = false;
            this.comboBoxTruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTruck.Depth = 0;
            this.comboBoxTruck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTruck.DropDownHeight = 118;
            this.comboBoxTruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTruck.DropDownWidth = 121;
            this.comboBoxTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTruck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTruck.FormattingEnabled = true;
            this.comboBoxTruck.IntegralHeight = false;
            this.comboBoxTruck.ItemHeight = 29;
            this.comboBoxTruck.Location = new System.Drawing.Point(130, 71);
            this.comboBoxTruck.MaxDropDownItems = 4;
            this.comboBoxTruck.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTruck.Name = "comboBoxTruck";
            this.comboBoxTruck.Size = new System.Drawing.Size(303, 35);
            this.comboBoxTruck.StartIndex = 0;
            this.comboBoxTruck.TabIndex = 1;
            this.comboBoxTruck.UseTallSize = false;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.AutoResize = false;
            this.comboBoxFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxFuel.Depth = 0;
            this.comboBoxFuel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxFuel.DropDownHeight = 118;
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.DropDownWidth = 121;
            this.comboBoxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.IntegralHeight = false;
            this.comboBoxFuel.ItemHeight = 29;
            this.comboBoxFuel.Location = new System.Drawing.Point(130, 179);
            this.comboBoxFuel.MaxDropDownItems = 4;
            this.comboBoxFuel.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(303, 35);
            this.comboBoxFuel.StartIndex = 0;
            this.comboBoxFuel.TabIndex = 3;
            this.comboBoxFuel.UseTallSize = false;
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
            this.textBoxCount.Location = new System.Drawing.Point(568, 26);
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
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.TabStop = false;
            this.textBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCount.TrailingIcon = null;
            this.textBoxCount.UseSystemPasswordChar = false;
            this.textBoxCount.UseTallSize = false;
            // 
            // comboBoxFuelStation
            // 
            this.comboBoxFuelStation.AutoResize = false;
            this.comboBoxFuelStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxFuelStation.Depth = 0;
            this.comboBoxFuelStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxFuelStation.DropDownHeight = 118;
            this.comboBoxFuelStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuelStation.DropDownWidth = 121;
            this.comboBoxFuelStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxFuelStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxFuelStation.FormattingEnabled = true;
            this.comboBoxFuelStation.IntegralHeight = false;
            this.comboBoxFuelStation.ItemHeight = 29;
            this.comboBoxFuelStation.Location = new System.Drawing.Point(568, 74);
            this.comboBoxFuelStation.MaxDropDownItems = 4;
            this.comboBoxFuelStation.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxFuelStation.Name = "comboBoxFuelStation";
            this.comboBoxFuelStation.Size = new System.Drawing.Size(303, 35);
            this.comboBoxFuelStation.StartIndex = 0;
            this.comboBoxFuelStation.TabIndex = 5;
            this.comboBoxFuelStation.UseTallSize = false;
            // 
            // FormAddEditFuelAccountingItem
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(934, 419);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.materialCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddEditFuelAccountingItem";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работы с накладной";
            this.materialCard.ResumeLayout(false);
            this.materialCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonCancel;
        private MaterialSkin.Controls.MaterialButton buttonAccept;
        private MaterialSkin.Controls.MaterialCard materialCard;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTrailer;
        private MaterialSkin.Controls.MaterialComboBox comboBoxDriver;
        private MaterialSkin.Controls.MaterialLabel labelFuel;
        private MaterialSkin.Controls.MaterialLabel labelTrailer;
        private MaterialSkin.Controls.MaterialLabel labelTruck;
        private MaterialSkin.Controls.MaterialLabel labelDriver;
        private MaterialSkin.Controls.MaterialLabel labelEndDate;
        private MaterialSkin.Controls.MaterialLabel labelStartDate;
        private MaterialSkin.Controls.MaterialLabel labelFuelStation;
        private MaterialSkin.Controls.MaterialLabel labelCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTruck;
        private MaterialSkin.Controls.MaterialComboBox comboBoxFuel;
        private MaterialSkin.Controls.MaterialComboBox comboBoxFuelStation;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxCount;
    }
}