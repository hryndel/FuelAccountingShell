namespace FuelAccountingShell.Forms
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.labelLogin = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEnter = new MaterialSkin.Controls.MaterialButton();
            this.buttonCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.textBoxPassword);
            this.materialCard1.Controls.Add(this.textBoxLogin);
            this.materialCard1.Controls.Add(this.labelPassword);
            this.materialCard1.Controls.Add(this.labelLogin);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 102);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(420, 164);
            this.materialCard1.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.HideSelection = true;
            this.textBoxPassword.Hint = "Введите пароль";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(123, 93);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.PrefixSuffixText = null;
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(250, 48);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.TrailingIcon = null;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AnimateReadOnly = false;
            this.textBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxLogin.Depth = 0;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLogin.HideSelection = true;
            this.textBoxLogin.Hint = "Введите логин";
            this.textBoxLogin.LeadingIcon = null;
            this.textBoxLogin.Location = new System.Drawing.Point(123, 17);
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
            this.textBoxLogin.Size = new System.Drawing.Size(250, 48);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.TabStop = false;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxLogin.TrailingIcon = null;
            this.textBoxLogin.UseSystemPasswordChar = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPassword.Location = new System.Drawing.Point(43, 115);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Depth = 0;
            this.labelLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelLogin.Location = new System.Drawing.Point(43, 39);
            this.labelLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 19);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.AutoSize = false;
            this.buttonEnter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEnter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEnter.Depth = 0;
            this.buttonEnter.HighEmphasis = true;
            this.buttonEnter.Icon = null;
            this.buttonEnter.Location = new System.Drawing.Point(17, 286);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEnter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEnter.Size = new System.Drawing.Size(196, 36);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEnter.UseAccentColor = false;
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
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
            this.buttonCancel.Location = new System.Drawing.Point(241, 286);
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
            // FormAuthorization
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(454, 343);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxLogin;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialLabel labelLogin;
        private MaterialSkin.Controls.MaterialButton buttonEnter;
        private MaterialSkin.Controls.MaterialButton buttonCancel;
    }
}