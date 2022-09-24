using System;
using System.Security.Authentication.ExtendedProtection;

namespace Assignment_1
{
    partial class Meun_Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meun_Index));
            this.MenuItem1 = new System.Windows.Forms.Label();
            this.MenuItem2 = new System.Windows.Forms.Label();
            this.MenuItem3 = new System.Windows.Forms.Label();
            this.MenuItem4 = new System.Windows.Forms.Label();
            this.MenuPrice1 = new System.Windows.Forms.Label();
            this.MenuPrice2 = new System.Windows.Forms.Label();
            this.MenuPrice3 = new System.Windows.Forms.Label();
            this.MenuPrice4 = new System.Windows.Forms.Label();
            this.MenuCount1 = new System.Windows.Forms.TextBox();
            this.MenuCount2 = new System.Windows.Forms.TextBox();
            this.MenuCount3 = new System.Windows.Forms.TextBox();
            this.MenuCount4 = new System.Windows.Forms.TextBox();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.SummaryBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.button_Order_3 = new System.Windows.Forms.Label();
            this.button_Order_4 = new System.Windows.Forms.Label();
            this.ServerNameDisplay = new System.Windows.Forms.TextBox();
            this.NumberPizzaOrderedDisplay = new System.Windows.Forms.TextBox();
            this.TotalTableReciptsDisplay = new System.Windows.Forms.TextBox();
            this.MenuContainer = new System.Windows.Forms.GroupBox();
            this.Menus = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSet = new System.Windows.Forms.TableLayoutPanel();
            this.OrderSumPannel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CompanySumPannel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AvgTransDisplay = new System.Windows.Forms.TextBox();
            this.CompanyTransaction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCompanyReceDisplay = new System.Windows.Forms.TextBox();
            this.CompTransDisplay = new System.Windows.Forms.TextBox();
            this.NumPizzaTotalDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuContainer.SuspendLayout();
            this.Menus.SuspendLayout();
            this.BtnSet.SuspendLayout();
            this.OrderSumPannel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CompanySumPannel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItem1
            // 
            this.MenuItem1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuItem1.AutoSize = true;
            this.MenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItem1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuItem1.Location = new System.Drawing.Point(2, 10);
            this.MenuItem1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(108, 18);
            this.MenuItem1.TabIndex = 1;
            this.MenuItem1.Text = " Ham Pizza";
            this.MenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuItem2
            // 
            this.MenuItem2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuItem2.AutoSize = true;
            this.MenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItem2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuItem2.Location = new System.Drawing.Point(2, 49);
            this.MenuItem2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(168, 18);
            this.MenuItem2.TabIndex = 2;
            this.MenuItem2.Text = " Pepperoni Pizza";
            this.MenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuItem3
            // 
            this.MenuItem3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuItem3.AutoSize = true;
            this.MenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItem3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuItem3.Location = new System.Drawing.Point(2, 88);
            this.MenuItem3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(168, 18);
            this.MenuItem3.TabIndex = 3;
            this.MenuItem3.Text = " Pineapple Pizza";
            this.MenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuItem4
            // 
            this.MenuItem4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuItem4.AutoSize = true;
            this.MenuItem4.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItem4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuItem4.Location = new System.Drawing.Point(2, 128);
            this.MenuItem4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuItem4.Name = "MenuItem4";
            this.MenuItem4.Size = new System.Drawing.Size(88, 18);
            this.MenuItem4.TabIndex = 4;
            this.MenuItem4.Text = " Calzoni";
            this.MenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPrice1
            // 
            this.MenuPrice1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuPrice1.AutoSize = true;
            this.MenuPrice1.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.MenuPrice1.Location = new System.Drawing.Point(301, 9);
            this.MenuPrice1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuPrice1.Name = "MenuPrice1";
            this.MenuPrice1.Size = new System.Drawing.Size(76, 20);
            this.MenuPrice1.TabIndex = 5;
            this.MenuPrice1.Text = "@ € 7.99";
            this.MenuPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPrice2
            // 
            this.MenuPrice2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuPrice2.AutoSize = true;
            this.MenuPrice2.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.MenuPrice2.Location = new System.Drawing.Point(301, 48);
            this.MenuPrice2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuPrice2.Name = "MenuPrice2";
            this.MenuPrice2.Size = new System.Drawing.Size(76, 20);
            this.MenuPrice2.TabIndex = 6;
            this.MenuPrice2.Text = "@ € 8.99";
            this.MenuPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPrice3
            // 
            this.MenuPrice3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuPrice3.AutoSize = true;
            this.MenuPrice3.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.MenuPrice3.Location = new System.Drawing.Point(301, 87);
            this.MenuPrice3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuPrice3.Name = "MenuPrice3";
            this.MenuPrice3.Size = new System.Drawing.Size(76, 20);
            this.MenuPrice3.TabIndex = 7;
            this.MenuPrice3.Text = "@ € 9.99";
            this.MenuPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPrice4
            // 
            this.MenuPrice4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuPrice4.AutoSize = true;
            this.MenuPrice4.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPrice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.MenuPrice4.Location = new System.Drawing.Point(301, 127);
            this.MenuPrice4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuPrice4.Name = "MenuPrice4";
            this.MenuPrice4.Size = new System.Drawing.Size(85, 20);
            this.MenuPrice4.TabIndex = 8;
            this.MenuPrice4.Text = "@ € 11.99";
            this.MenuPrice4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuCount1
            // 
            this.MenuCount1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuCount1.BackColor = System.Drawing.SystemColors.Control;
            this.MenuCount1.Location = new System.Drawing.Point(241, 2);
            this.MenuCount1.Margin = new System.Windows.Forms.Padding(2);
            this.MenuCount1.Multiline = true;
            this.MenuCount1.Name = "MenuCount1";
            this.MenuCount1.Size = new System.Drawing.Size(56, 35);
            this.MenuCount1.TabIndex = 9;
            this.MenuCount1.Text = "0";
            this.MenuCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuCount2
            // 
            this.MenuCount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuCount2.BackColor = System.Drawing.SystemColors.Control;
            this.MenuCount2.Location = new System.Drawing.Point(241, 41);
            this.MenuCount2.Margin = new System.Windows.Forms.Padding(2);
            this.MenuCount2.Multiline = true;
            this.MenuCount2.Name = "MenuCount2";
            this.MenuCount2.Size = new System.Drawing.Size(56, 35);
            this.MenuCount2.TabIndex = 10;
            this.MenuCount2.Text = "0";
            this.MenuCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuCount3
            // 
            this.MenuCount3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuCount3.BackColor = System.Drawing.SystemColors.Control;
            this.MenuCount3.Location = new System.Drawing.Point(241, 80);
            this.MenuCount3.Margin = new System.Windows.Forms.Padding(2);
            this.MenuCount3.Multiline = true;
            this.MenuCount3.Name = "MenuCount3";
            this.MenuCount3.Size = new System.Drawing.Size(56, 35);
            this.MenuCount3.TabIndex = 11;
            this.MenuCount3.Text = "0";
            this.MenuCount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuCount4
            // 
            this.MenuCount4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuCount4.BackColor = System.Drawing.SystemColors.Control;
            this.MenuCount4.Location = new System.Drawing.Point(241, 119);
            this.MenuCount4.Margin = new System.Windows.Forms.Padding(2);
            this.MenuCount4.Multiline = true;
            this.MenuCount4.Name = "MenuCount4";
            this.MenuCount4.Size = new System.Drawing.Size(56, 36);
            this.MenuCount4.TabIndex = 12;
            this.MenuCount4.Text = "0";
            this.MenuCount4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderBtn.Location = new System.Drawing.Point(15, 6);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(110, 30);
            this.OrderBtn.TabIndex = 14;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClrBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClrBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClrBtn.Location = new System.Drawing.Point(155, 6);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(110, 30);
            this.ClrBtn.TabIndex = 15;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // SummaryBtn
            // 
            this.SummaryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SummaryBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SummaryBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SummaryBtn.Location = new System.Drawing.Point(295, 6);
            this.SummaryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SummaryBtn.Name = "SummaryBtn";
            this.SummaryBtn.Size = new System.Drawing.Size(110, 30);
            this.SummaryBtn.TabIndex = 16;
            this.SummaryBtn.Text = "Summary";
            this.SummaryBtn.UseVisualStyleBackColor = false;
            this.SummaryBtn.Click += new System.EventHandler(this.SummaryBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitBtn.Location = new System.Drawing.Point(435, 6);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(110, 30);
            this.ExitBtn.TabIndex = 17;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 463);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(2, 7);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 18);
            this.label.TabIndex = 20;
            this.label.Text = "Server Name";
            // 
            // button_Order_3
            // 
            this.button_Order_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Order_3.AutoSize = true;
            this.button_Order_3.BackColor = System.Drawing.SystemColors.Control;
            this.button_Order_3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Order_3.Location = new System.Drawing.Point(2, 40);
            this.button_Order_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.button_Order_3.Name = "button_Order_3";
            this.button_Order_3.Size = new System.Drawing.Size(228, 18);
            this.button_Order_3.TabIndex = 21;
            this.button_Order_3.Text = "Number Pizza\'s Ordered";
            // 
            // button_Order_4
            // 
            this.button_Order_4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Order_4.AutoSize = true;
            this.button_Order_4.BackColor = System.Drawing.SystemColors.Control;
            this.button_Order_4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Order_4.Location = new System.Drawing.Point(2, 74);
            this.button_Order_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.button_Order_4.Name = "button_Order_4";
            this.button_Order_4.Size = new System.Drawing.Size(208, 18);
            this.button_Order_4.TabIndex = 22;
            this.button_Order_4.Text = "Total Table Receipts";
            // 
            // ServerNameDisplay
            // 
            this.ServerNameDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.ServerNameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerNameDisplay.Enabled = false;
            this.ServerNameDisplay.Location = new System.Drawing.Point(307, 2);
            this.ServerNameDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.ServerNameDisplay.Multiline = true;
            this.ServerNameDisplay.Name = "ServerNameDisplay";
            this.ServerNameDisplay.Size = new System.Drawing.Size(166, 29);
            this.ServerNameDisplay.TabIndex = 23;
            this.ServerNameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberPizzaOrderedDisplay
            // 
            this.NumberPizzaOrderedDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.NumberPizzaOrderedDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberPizzaOrderedDisplay.Enabled = false;
            this.NumberPizzaOrderedDisplay.Location = new System.Drawing.Point(307, 35);
            this.NumberPizzaOrderedDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.NumberPizzaOrderedDisplay.Multiline = true;
            this.NumberPizzaOrderedDisplay.Name = "NumberPizzaOrderedDisplay";
            this.NumberPizzaOrderedDisplay.Size = new System.Drawing.Size(166, 29);
            this.NumberPizzaOrderedDisplay.TabIndex = 24;
            this.NumberPizzaOrderedDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTableReciptsDisplay
            // 
            this.TotalTableReciptsDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.TotalTableReciptsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalTableReciptsDisplay.Enabled = false;
            this.TotalTableReciptsDisplay.Location = new System.Drawing.Point(307, 68);
            this.TotalTableReciptsDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.TotalTableReciptsDisplay.Multiline = true;
            this.TotalTableReciptsDisplay.Name = "TotalTableReciptsDisplay";
            this.TotalTableReciptsDisplay.Size = new System.Drawing.Size(166, 30);
            this.TotalTableReciptsDisplay.TabIndex = 25;
            this.TotalTableReciptsDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuContainer
            // 
            this.MenuContainer.Controls.Add(this.Menus);
            this.MenuContainer.Location = new System.Drawing.Point(95, 12);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(561, 184);
            this.MenuContainer.TabIndex = 26;
            this.MenuContainer.TabStop = false;
            this.MenuContainer.Text = "Menu";
            // 
            // Menus
            // 
            this.Menus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Menus.ColumnCount = 3;
            this.Menus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.Menus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66376F));
            this.Menus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.89956F));
            this.Menus.Controls.Add(this.MenuItem1, 0, 0);
            this.Menus.Controls.Add(this.MenuItem2, 0, 1);
            this.Menus.Controls.Add(this.MenuItem3, 0, 2);
            this.Menus.Controls.Add(this.MenuItem4, 0, 3);
            this.Menus.Controls.Add(this.MenuCount1, 1, 0);
            this.Menus.Controls.Add(this.MenuCount2, 1, 1);
            this.Menus.Controls.Add(this.MenuCount3, 1, 2);
            this.Menus.Controls.Add(this.MenuCount4, 1, 3);
            this.Menus.Controls.Add(this.MenuPrice1, 2, 0);
            this.Menus.Controls.Add(this.MenuPrice2, 2, 1);
            this.Menus.Controls.Add(this.MenuPrice3, 2, 2);
            this.Menus.Controls.Add(this.MenuPrice4, 2, 3);
            this.Menus.Location = new System.Drawing.Point(39, 24);
            this.Menus.Name = "Menus";
            this.Menus.RowCount = 4;
            this.Menus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Menus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Menus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Menus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Menus.Size = new System.Drawing.Size(475, 157);
            this.Menus.TabIndex = 0;
            // 
            // BtnSet
            // 
            this.BtnSet.ColumnCount = 4;
            this.BtnSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BtnSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BtnSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BtnSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BtnSet.Controls.Add(this.OrderBtn, 0, 0);
            this.BtnSet.Controls.Add(this.ClrBtn, 1, 0);
            this.BtnSet.Controls.Add(this.SummaryBtn, 2, 0);
            this.BtnSet.Controls.Add(this.ExitBtn, 3, 0);
            this.BtnSet.Location = new System.Drawing.Point(95, 202);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.RowCount = 1;
            this.BtnSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BtnSet.Size = new System.Drawing.Size(561, 42);
            this.BtnSet.TabIndex = 27;
            // 
            // OrderSumPannel
            // 
            this.OrderSumPannel.Controls.Add(this.tableLayoutPanel2);
            this.OrderSumPannel.Location = new System.Drawing.Point(95, 255);
            this.OrderSumPannel.Name = "OrderSumPannel";
            this.OrderSumPannel.Size = new System.Drawing.Size(561, 193);
            this.OrderSumPannel.TabIndex = 28;
            this.OrderSumPannel.TabStop = false;
            this.OrderSumPannel.Text = "Table Order Summary Data";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21053F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78947F));
            this.tableLayoutPanel2.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Order_3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_Order_4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TotalTableReciptsDisplay, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ServerNameDisplay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NumberPizzaOrderedDisplay, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CompanySumPannel
            // 
            this.CompanySumPannel.Controls.Add(this.tableLayoutPanel3);
            this.CompanySumPannel.Location = new System.Drawing.Point(95, 255);
            this.CompanySumPannel.Name = "CompanySumPannel";
            this.CompanySumPannel.Size = new System.Drawing.Size(561, 193);
            this.CompanySumPannel.TabIndex = 29;
            this.CompanySumPannel.TabStop = false;
            this.CompanySumPannel.Text = "Company Summary Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21053F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78947F));
            this.tableLayoutPanel3.Controls.Add(this.AvgTransDisplay, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.CompanyTransaction, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TotalCompanyReceDisplay, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.CompTransDisplay, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.NumPizzaTotalDisplay, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(39, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 147);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // AvgTransDisplay
            // 
            this.AvgTransDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.AvgTransDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvgTransDisplay.Enabled = false;
            this.AvgTransDisplay.Location = new System.Drawing.Point(307, 110);
            this.AvgTransDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.AvgTransDisplay.Multiline = true;
            this.AvgTransDisplay.Name = "AvgTransDisplay";
            this.AvgTransDisplay.Size = new System.Drawing.Size(166, 35);
            this.AvgTransDisplay.TabIndex = 27;
            this.AvgTransDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompanyTransaction
            // 
            this.CompanyTransaction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CompanyTransaction.AutoSize = true;
            this.CompanyTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.CompanyTransaction.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompanyTransaction.Location = new System.Drawing.Point(2, 9);
            this.CompanyTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyTransaction.Name = "CompanyTransaction";
            this.CompanyTransaction.Size = new System.Drawing.Size(268, 18);
            this.CompanyTransaction.TabIndex = 20;
            this.CompanyTransaction.Text = "Total Company Transactions";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Number Pizza\'s Ordered";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Company Receipts";
            // 
            // TotalCompanyReceDisplay
            // 
            this.TotalCompanyReceDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.TotalCompanyReceDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalCompanyReceDisplay.Enabled = false;
            this.TotalCompanyReceDisplay.Location = new System.Drawing.Point(307, 74);
            this.TotalCompanyReceDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.TotalCompanyReceDisplay.Multiline = true;
            this.TotalCompanyReceDisplay.Name = "TotalCompanyReceDisplay";
            this.TotalCompanyReceDisplay.Size = new System.Drawing.Size(166, 32);
            this.TotalCompanyReceDisplay.TabIndex = 25;
            this.TotalCompanyReceDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompTransDisplay
            // 
            this.CompTransDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.CompTransDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompTransDisplay.Enabled = false;
            this.CompTransDisplay.Location = new System.Drawing.Point(307, 2);
            this.CompTransDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.CompTransDisplay.Multiline = true;
            this.CompTransDisplay.Name = "CompTransDisplay";
            this.CompTransDisplay.Size = new System.Drawing.Size(166, 32);
            this.CompTransDisplay.TabIndex = 23;
            this.CompTransDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumPizzaTotalDisplay
            // 
            this.NumPizzaTotalDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.NumPizzaTotalDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumPizzaTotalDisplay.Enabled = false;
            this.NumPizzaTotalDisplay.Location = new System.Drawing.Point(307, 38);
            this.NumPizzaTotalDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.NumPizzaTotalDisplay.Multiline = true;
            this.NumPizzaTotalDisplay.Name = "NumPizzaTotalDisplay";
            this.NumPizzaTotalDisplay.Size = new System.Drawing.Size(166, 32);
            this.NumPizzaTotalDisplay.TabIndex = 24;
            this.NumPizzaTotalDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Avg Transaction Value";
            // 
            // Meun_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 566);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.CompanySumPannel);
            this.Controls.Add(this.OrderSumPannel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Meun_Index";
            this.Text = "meun_name_number_show";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuContainer.ResumeLayout(false);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.BtnSet.ResumeLayout(false);
            this.OrderSumPannel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CompanySumPannel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label MenuItem1;
        private System.Windows.Forms.Label MenuItem2;
        private System.Windows.Forms.Label MenuItem3;
        private System.Windows.Forms.Label MenuItem4;
        private System.Windows.Forms.Label MenuPrice1;
        private System.Windows.Forms.Label MenuPrice2;
        private System.Windows.Forms.Label MenuPrice3;
        private System.Windows.Forms.Label MenuPrice4;
        private System.Windows.Forms.TextBox MenuCount1;
        private System.Windows.Forms.TextBox MenuCount2;
        private System.Windows.Forms.TextBox MenuCount3;
        private System.Windows.Forms.TextBox MenuCount4;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button SummaryBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label button_Order_3;
        private System.Windows.Forms.Label button_Order_4;
        private System.Windows.Forms.TextBox ServerNameDisplay;
        private System.Windows.Forms.TextBox NumberPizzaOrderedDisplay;
        private System.Windows.Forms.TextBox TotalTableReciptsDisplay;
        private System.Windows.Forms.GroupBox MenuContainer;
        private System.Windows.Forms.TableLayoutPanel Menus;
        private System.Windows.Forms.TableLayoutPanel BtnSet;
        private System.Windows.Forms.GroupBox OrderSumPannel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox CompanySumPannel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label CompanyTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalCompanyReceDisplay;
        private System.Windows.Forms.TextBox CompTransDisplay;
        private System.Windows.Forms.TextBox NumPizzaTotalDisplay;
        private System.Windows.Forms.TextBox AvgTransDisplay;
        private System.Windows.Forms.Label label1;
    }
}