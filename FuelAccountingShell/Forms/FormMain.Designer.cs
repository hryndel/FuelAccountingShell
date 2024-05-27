using FuelAccountingShell.UserControls;

namespace FuelAccountingShell.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDocument = new System.Windows.Forms.TabPage();
            this.userControlFuelAccountingItem = new FuelAccountingShell.UserControls.UserControlFuelAccountingItem();
            this.tabPageFuel = new System.Windows.Forms.TabPage();
            this.userControlFuel = new FuelAccountingShell.UserControls.UserControlFuel();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.userControlSupplier = new FuelAccountingShell.UserControls.UserControlSupplier();
            this.tabPageAzs = new System.Windows.Forms.TabPage();
            this.userControlFuelStation = new FuelAccountingShell.UserControls.UserControlFuelStation();
            this.tabPageDriver = new System.Windows.Forms.TabPage();
            this.userControlDriver = new FuelAccountingShell.UserControls.UserControlDriver();
            this.tabPageTrailer = new System.Windows.Forms.TabPage();
            this.userControlTrailer = new FuelAccountingShell.UserControls.UserControlTrailer();
            this.tabPageTruck = new System.Windows.Forms.TabPage();
            this.userControlTruck = new FuelAccountingShell.UserControls.UserControlTruck();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.userControlUser = new FuelAccountingShell.UserControls.UserControlUser();
            this.tabControl.SuspendLayout();
            this.tabPageDocument.SuspendLayout();
            this.tabPageFuel.SuspendLayout();
            this.tabPageSupplier.SuspendLayout();
            this.tabPageAzs.SuspendLayout();
            this.tabPageDriver.SuspendLayout();
            this.tabPageTrailer.SuspendLayout();
            this.tabPageTruck.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.SuspendLayout();

            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Azs.png");
            this.imageList.Images.SetKeyName(1, "Document.png");
            this.imageList.Images.SetKeyName(2, "Driver.png");
            this.imageList.Images.SetKeyName(3, "Fuel.png");
            this.imageList.Images.SetKeyName(4, "Supplier.png");
            this.imageList.Images.SetKeyName(5, "Trailer.png");
            this.imageList.Images.SetKeyName(6, "Truck.png");
            this.imageList.Images.SetKeyName(7, "User.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDocument);
            this.tabControl.Controls.Add(this.tabPageFuel);
            this.tabControl.Controls.Add(this.tabPageSupplier);
            this.tabControl.Controls.Add(this.tabPageAzs);
            this.tabControl.Controls.Add(this.tabPageDriver);
            this.tabControl.Controls.Add(this.tabPageTrailer);
            this.tabControl.Controls.Add(this.tabPageTruck);
            this.tabControl.Controls.Add(this.tabPageUser);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.ImageList = this.imageList;
            this.tabControl.Location = new System.Drawing.Point(0, 72);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1547, 795);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.materialTabControl_SelectedIndexChanged);
            // 
            // tabPageDocument
            // 
            this.tabPageDocument.Controls.Add(this.userControlFuelAccountingItem);
            this.tabPageDocument.ImageKey = "Document.png";
            this.tabPageDocument.Location = new System.Drawing.Point(4, 37);
            this.tabPageDocument.Name = "tabPageDocument";
            this.tabPageDocument.Size = new System.Drawing.Size(1539, 754);
            this.tabPageDocument.TabIndex = 0;
            this.tabPageDocument.Tag = "Накладные для заказов";
            this.tabPageDocument.Text = "Накладные";
            this.tabPageDocument.UseVisualStyleBackColor = true;
            // 
            // userControlFuelAccountingItem
            // 
            this.userControlFuelAccountingItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFuelAccountingItem.Location = new System.Drawing.Point(0, 0);
            this.userControlFuelAccountingItem.Name = "userControlFuelAccountingItem";
            this.userControlFuelAccountingItem.Size = new System.Drawing.Size(1539, 754);
            this.userControlFuelAccountingItem.TabIndex = 0;
            // 
            // tabPageFuel
            // 
            this.tabPageFuel.Controls.Add(this.userControlFuel);
            this.tabPageFuel.ImageKey = "Fuel.png";
            this.tabPageFuel.Location = new System.Drawing.Point(4, 37);
            this.tabPageFuel.Name = "tabPageFuel";
            this.tabPageFuel.Size = new System.Drawing.Size(1539, 754);
            this.tabPageFuel.TabIndex = 1;
            this.tabPageFuel.Tag = "Виды топлива";
            this.tabPageFuel.Text = "Топливо";
            this.tabPageFuel.UseVisualStyleBackColor = true;
            // 
            // userControlFuel
            // 
            this.userControlFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFuel.Location = new System.Drawing.Point(0, 0);
            this.userControlFuel.Name = "userControlFuel";
            this.userControlFuel.Size = new System.Drawing.Size(1539, 754);
            this.userControlFuel.TabIndex = 0;
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(this.userControlSupplier);
            this.tabPageSupplier.ImageKey = "Supplier.png";
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 37);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Size = new System.Drawing.Size(1539, 754);
            this.tabPageSupplier.TabIndex = 2;
            this.tabPageSupplier.Tag = "Поставщики топлива";
            this.tabPageSupplier.Text = "Поставщики";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // userControlSupplier
            // 
            this.userControlSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSupplier.Location = new System.Drawing.Point(0, 0);
            this.userControlSupplier.Name = "userControlSupplier";
            this.userControlSupplier.Size = new System.Drawing.Size(1539, 754);
            this.userControlSupplier.TabIndex = 0;
            // 
            // tabPageAzs
            // 
            this.tabPageAzs.Controls.Add(this.userControlFuelStation);
            this.tabPageAzs.ImageKey = "Azs.png";
            this.tabPageAzs.Location = new System.Drawing.Point(4, 37);
            this.tabPageAzs.Name = "tabPageAzs";
            this.tabPageAzs.Size = new System.Drawing.Size(1539, 754);
            this.tabPageAzs.TabIndex = 3;
            this.tabPageAzs.Tag = "Автозаправочные станции";
            this.tabPageAzs.Text = "АЗС";
            this.tabPageAzs.UseVisualStyleBackColor = true;
            // 
            // userControlFuelStation
            // 
            this.userControlFuelStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFuelStation.Location = new System.Drawing.Point(0, 0);
            this.userControlFuelStation.Name = "userControlFuelStation";
            this.userControlFuelStation.Size = new System.Drawing.Size(1539, 754);
            this.userControlFuelStation.TabIndex = 0;
            // 
            // tabPageDriver
            // 
            this.tabPageDriver.Controls.Add(this.userControlDriver);
            this.tabPageDriver.ImageKey = "Driver.png";
            this.tabPageDriver.Location = new System.Drawing.Point(4, 37);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Size = new System.Drawing.Size(1539, 754);
            this.tabPageDriver.TabIndex = 4;
            this.tabPageDriver.Tag = "Водители в компании";
            this.tabPageDriver.Text = "Водители";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // userControlDriver
            // 
            this.userControlDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDriver.Location = new System.Drawing.Point(0, 0);
            this.userControlDriver.Name = "userControlDriver";
            this.userControlDriver.Size = new System.Drawing.Size(1539, 754);
            this.userControlDriver.TabIndex = 0;
            // 
            // tabPageTrailer
            // 
            this.tabPageTrailer.Controls.Add(this.userControlTrailer);
            this.tabPageTrailer.ImageKey = "Trailer.png";
            this.tabPageTrailer.Location = new System.Drawing.Point(4, 37);
            this.tabPageTrailer.Name = "tabPageTrailer";
            this.tabPageTrailer.Size = new System.Drawing.Size(1539, 754);
            this.tabPageTrailer.TabIndex = 5;
            this.tabPageTrailer.Tag = "Топливные полуприцепы";
            this.tabPageTrailer.Text = "Полуприцепы";
            this.tabPageTrailer.UseVisualStyleBackColor = true;
            // 
            // userControlTrailer
            // 
            this.userControlTrailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTrailer.Location = new System.Drawing.Point(0, 0);
            this.userControlTrailer.Name = "userControlTrailer";
            this.userControlTrailer.Size = new System.Drawing.Size(1539, 754);
            this.userControlTrailer.TabIndex = 0;
            // 
            // tabPageTruck
            // 
            this.tabPageTruck.Controls.Add(this.userControlTruck);
            this.tabPageTruck.ImageKey = "Truck.png";
            this.tabPageTruck.Location = new System.Drawing.Point(4, 37);
            this.tabPageTruck.Name = "tabPageTruck";
            this.tabPageTruck.Size = new System.Drawing.Size(1539, 754);
            this.tabPageTruck.TabIndex = 6;
            this.tabPageTruck.Tag = "Грузовики в компании";
            this.tabPageTruck.Text = "Грузовики";
            this.tabPageTruck.UseVisualStyleBackColor = true;
            // 
            // userControlTruck
            // 
            this.userControlTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTruck.Location = new System.Drawing.Point(0, 0);
            this.userControlTruck.Name = "userControlTruck";
            this.userControlTruck.Size = new System.Drawing.Size(1539, 754);
            this.userControlTruck.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.userControlUser);
            this.tabPageUser.ImageKey = "User.png";
            this.tabPageUser.Location = new System.Drawing.Point(4, 37);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Size = new System.Drawing.Size(1539, 754);
            this.tabPageUser.TabIndex = 7;
            this.tabPageUser.Tag = "Пользователи в системе";
            this.tabPageUser.Text = "Пользователи";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // userControlUser
            // 
            this.userControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlUser.Location = new System.Drawing.Point(0, 0);
            this.userControlUser.Name = "userControlUser";
            this.userControlUser.Size = new System.Drawing.Size(1539, 754);
            this.userControlUser.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 870);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1550, 870);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладные для заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPageDocument.ResumeLayout(false);
            this.tabPageFuel.ResumeLayout(false);
            this.tabPageSupplier.ResumeLayout(false);
            this.tabPageAzs.ResumeLayout(false);
            this.tabPageDriver.ResumeLayout(false);
            this.tabPageTrailer.ResumeLayout(false);
            this.tabPageTruck.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDocument;
        private System.Windows.Forms.TabPage tabPageFuel;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TabPage tabPageAzs;
        private System.Windows.Forms.TabPage tabPageDriver;
        private System.Windows.Forms.TabPage tabPageTrailer;
        private System.Windows.Forms.TabPage tabPageTruck;
        private System.Windows.Forms.TabPage tabPageUser;
        private UserControlUser userControlUser;
        private UserControlTruck userControlTruck;
        private UserControlDriver userControlDriver;
        private UserControlTrailer userControlTrailer;
        private UserControlSupplier userControlSupplier;
        private UserControlFuelStation userControlFuelStation;
        private UserControlFuel userControlFuel;
        private UserControlFuelAccountingItem userControlFuelAccountingItem;
    }
}