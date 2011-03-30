﻿namespace DungeonEye.Forms
{
	partial class SquareForm
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
			this.CloseBox = new System.Windows.Forms.Button();
			this.DecorationTab = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.GlWallControl = new OpenTK.GLControl();
			this.MonstersTab = new System.Windows.Forms.TabPage();
			this.RemoveAllMonstersBox = new System.Windows.Forms.Button();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.SWMonsterBox = new System.Windows.Forms.TextBox();
			this.DeleteSWBox = new System.Windows.Forms.Button();
			this.EditSWBox = new System.Windows.Forms.Button();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.SEMonsterBox = new System.Windows.Forms.TextBox();
			this.DeleteSEBox = new System.Windows.Forms.Button();
			this.EditSEBox = new System.Windows.Forms.Button();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.NEMonsterBox = new System.Windows.Forms.TextBox();
			this.DeleteNEBox = new System.Windows.Forms.Button();
			this.EditNEBox = new System.Windows.Forms.Button();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.NWMonsterBox = new System.Windows.Forms.TextBox();
			this.DeleteNWBox = new System.Windows.Forms.Button();
			this.EditNWBox = new System.Windows.Forms.Button();
			this.ItemsTab = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.ClearAllItemsBox = new System.Windows.Forms.Button();
			this.AlcoveGroupBox = new System.Windows.Forms.GroupBox();
			this.AlcoveEastButton = new System.Windows.Forms.CheckBox();
			this.AlcoveWestButton = new System.Windows.Forms.CheckBox();
			this.AlcoveSouthButton = new System.Windows.Forms.CheckBox();
			this.AlcoveNorthButton = new System.Windows.Forms.CheckBox();
			this.ItemsBox = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.SEBox = new System.Windows.Forms.ListBox();
			this.SEAddItem = new System.Windows.Forms.Button();
			this.SERemoveItem = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.SWBox = new System.Windows.Forms.ListBox();
			this.SWAddItem = new System.Windows.Forms.Button();
			this.SWRemoveItem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NEBox = new System.Windows.Forms.ListBox();
			this.NEAddItem = new System.Windows.Forms.Button();
			this.NERemoveItem = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.NWBox = new System.Windows.Forms.ListBox();
			this.NWAddItem = new System.Windows.Forms.Button();
			this.NWRemoveItem = new System.Windows.Forms.Button();
			this.TabControlBox = new System.Windows.Forms.TabControl();
			this.ActorTab = new System.Windows.Forms.TabPage();
			this.ActorPanelBox = new System.Windows.Forms.Panel();
			this.DeleteActorBox = new System.Windows.Forms.Button();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.NorthDecorationBox = new System.Windows.Forms.RadioButton();
			this.WestDecorationBox = new System.Windows.Forms.RadioButton();
			this.SouthDecorationBox = new System.Windows.Forms.RadioButton();
			this.EastDecorationBox = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.ClearDecorationBox = new System.Windows.Forms.Button();
			this.DecorationIdBox = new System.Windows.Forms.NumericUpDown();
			this.DecorationTab.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.MonstersTab.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.ItemsTab.SuspendLayout();
			this.AlcoveGroupBox.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.TabControlBox.SuspendLayout();
			this.ActorTab.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.DecorationIdBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CloseBox
			// 
			this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBox.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.CloseBox.Location = new System.Drawing.Point(446, 517);
			this.CloseBox.Name = "CloseBox";
			this.CloseBox.Size = new System.Drawing.Size(75, 23);
			this.CloseBox.TabIndex = 1;
			this.CloseBox.Text = "Done";
			this.CloseBox.UseVisualStyleBackColor = true;
			// 
			// DecorationTab
			// 
			this.DecorationTab.Controls.Add(this.ClearDecorationBox);
			this.DecorationTab.Controls.Add(this.groupBox6);
			this.DecorationTab.Controls.Add(this.groupBox14);
			this.DecorationTab.Controls.Add(this.groupBox5);
			this.DecorationTab.Location = new System.Drawing.Point(4, 22);
			this.DecorationTab.Name = "DecorationTab";
			this.DecorationTab.Size = new System.Drawing.Size(501, 473);
			this.DecorationTab.TabIndex = 2;
			this.DecorationTab.Text = "Decoration";
			this.DecorationTab.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.GlWallControl);
			this.groupBox5.Location = new System.Drawing.Point(103, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(270, 220);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Preview :";
			// 
			// GlWallControl
			// 
			this.GlWallControl.BackColor = System.Drawing.Color.Black;
			this.GlWallControl.Location = new System.Drawing.Point(6, 19);
			this.GlWallControl.Name = "GlWallControl";
			this.GlWallControl.Size = new System.Drawing.Size(256, 192);
			this.GlWallControl.TabIndex = 0;
			this.GlWallControl.VSync = true;
			this.GlWallControl.Load += new System.EventHandler(this.GlWallControl_Load);
			this.GlWallControl.Paint += new System.Windows.Forms.PaintEventHandler(this.GlWallControl_Paint);
			this.GlWallControl.Resize += new System.EventHandler(this.GlWallControl_Resize);
			// 
			// MonstersTab
			// 
			this.MonstersTab.Controls.Add(this.RemoveAllMonstersBox);
			this.MonstersTab.Controls.Add(this.groupBox13);
			this.MonstersTab.Controls.Add(this.groupBox12);
			this.MonstersTab.Controls.Add(this.groupBox11);
			this.MonstersTab.Controls.Add(this.groupBox10);
			this.MonstersTab.Location = new System.Drawing.Point(4, 22);
			this.MonstersTab.Name = "MonstersTab";
			this.MonstersTab.Padding = new System.Windows.Forms.Padding(3);
			this.MonstersTab.Size = new System.Drawing.Size(501, 473);
			this.MonstersTab.TabIndex = 1;
			this.MonstersTab.Text = "Monsters";
			this.MonstersTab.UseVisualStyleBackColor = true;
			// 
			// RemoveAllMonstersBox
			// 
			this.RemoveAllMonstersBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveAllMonstersBox.Location = new System.Drawing.Point(6, 444);
			this.RemoveAllMonstersBox.Name = "RemoveAllMonstersBox";
			this.RemoveAllMonstersBox.Size = new System.Drawing.Size(492, 23);
			this.RemoveAllMonstersBox.TabIndex = 16;
			this.RemoveAllMonstersBox.Text = "Remove all monsters";
			this.RemoveAllMonstersBox.UseVisualStyleBackColor = true;
			this.RemoveAllMonstersBox.Click += new System.EventHandler(this.RemoveAllMonstersBox_Click);
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.SWMonsterBox);
			this.groupBox13.Controls.Add(this.DeleteSWBox);
			this.groupBox13.Controls.Add(this.EditSWBox);
			this.groupBox13.Location = new System.Drawing.Point(8, 91);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(171, 79);
			this.groupBox13.TabIndex = 15;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "South West :";
			// 
			// SWMonsterBox
			// 
			this.SWMonsterBox.Location = new System.Drawing.Point(6, 19);
			this.SWMonsterBox.Name = "SWMonsterBox";
			this.SWMonsterBox.ReadOnly = true;
			this.SWMonsterBox.Size = new System.Drawing.Size(159, 20);
			this.SWMonsterBox.TabIndex = 1;
			this.SWMonsterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DeleteSWBox
			// 
			this.DeleteSWBox.Location = new System.Drawing.Point(90, 45);
			this.DeleteSWBox.Name = "DeleteSWBox";
			this.DeleteSWBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteSWBox.TabIndex = 0;
			this.DeleteSWBox.Text = "Remove";
			this.DeleteSWBox.UseVisualStyleBackColor = true;
			this.DeleteSWBox.Click += new System.EventHandler(this.DeleteSWBox_Click);
			// 
			// EditSWBox
			// 
			this.EditSWBox.Location = new System.Drawing.Point(6, 45);
			this.EditSWBox.Name = "EditSWBox";
			this.EditSWBox.Size = new System.Drawing.Size(75, 23);
			this.EditSWBox.TabIndex = 0;
			this.EditSWBox.Text = "Edit...";
			this.EditSWBox.UseVisualStyleBackColor = true;
			this.EditSWBox.Click += new System.EventHandler(this.EditSWBox_Click);
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.SEMonsterBox);
			this.groupBox12.Controls.Add(this.DeleteSEBox);
			this.groupBox12.Controls.Add(this.EditSEBox);
			this.groupBox12.Location = new System.Drawing.Point(185, 91);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(171, 79);
			this.groupBox12.TabIndex = 15;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "South East :";
			// 
			// SEMonsterBox
			// 
			this.SEMonsterBox.Location = new System.Drawing.Point(6, 19);
			this.SEMonsterBox.Name = "SEMonsterBox";
			this.SEMonsterBox.ReadOnly = true;
			this.SEMonsterBox.Size = new System.Drawing.Size(159, 20);
			this.SEMonsterBox.TabIndex = 1;
			this.SEMonsterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DeleteSEBox
			// 
			this.DeleteSEBox.Location = new System.Drawing.Point(90, 45);
			this.DeleteSEBox.Name = "DeleteSEBox";
			this.DeleteSEBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteSEBox.TabIndex = 0;
			this.DeleteSEBox.Text = "Remove";
			this.DeleteSEBox.UseVisualStyleBackColor = true;
			this.DeleteSEBox.Click += new System.EventHandler(this.DeleteSEBox_Click);
			// 
			// EditSEBox
			// 
			this.EditSEBox.Location = new System.Drawing.Point(6, 45);
			this.EditSEBox.Name = "EditSEBox";
			this.EditSEBox.Size = new System.Drawing.Size(75, 23);
			this.EditSEBox.TabIndex = 0;
			this.EditSEBox.Text = "Edit...";
			this.EditSEBox.UseVisualStyleBackColor = true;
			this.EditSEBox.Click += new System.EventHandler(this.EditSEBox_Click);
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.NEMonsterBox);
			this.groupBox11.Controls.Add(this.DeleteNEBox);
			this.groupBox11.Controls.Add(this.EditNEBox);
			this.groupBox11.Location = new System.Drawing.Point(185, 6);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(171, 79);
			this.groupBox11.TabIndex = 15;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "North East :";
			// 
			// NEMonsterBox
			// 
			this.NEMonsterBox.Location = new System.Drawing.Point(6, 19);
			this.NEMonsterBox.Name = "NEMonsterBox";
			this.NEMonsterBox.ReadOnly = true;
			this.NEMonsterBox.Size = new System.Drawing.Size(159, 20);
			this.NEMonsterBox.TabIndex = 1;
			this.NEMonsterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DeleteNEBox
			// 
			this.DeleteNEBox.Location = new System.Drawing.Point(90, 45);
			this.DeleteNEBox.Name = "DeleteNEBox";
			this.DeleteNEBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteNEBox.TabIndex = 0;
			this.DeleteNEBox.Text = "Remove";
			this.DeleteNEBox.UseVisualStyleBackColor = true;
			this.DeleteNEBox.Click += new System.EventHandler(this.DeleteNEBox_Click);
			// 
			// EditNEBox
			// 
			this.EditNEBox.Location = new System.Drawing.Point(6, 45);
			this.EditNEBox.Name = "EditNEBox";
			this.EditNEBox.Size = new System.Drawing.Size(75, 23);
			this.EditNEBox.TabIndex = 0;
			this.EditNEBox.Text = "Edit...";
			this.EditNEBox.UseVisualStyleBackColor = true;
			this.EditNEBox.Click += new System.EventHandler(this.EditNEBox_Click);
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.NWMonsterBox);
			this.groupBox10.Controls.Add(this.DeleteNWBox);
			this.groupBox10.Controls.Add(this.EditNWBox);
			this.groupBox10.Location = new System.Drawing.Point(8, 6);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(171, 79);
			this.groupBox10.TabIndex = 15;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "North West :";
			// 
			// NWMonsterBox
			// 
			this.NWMonsterBox.Location = new System.Drawing.Point(6, 19);
			this.NWMonsterBox.Name = "NWMonsterBox";
			this.NWMonsterBox.ReadOnly = true;
			this.NWMonsterBox.Size = new System.Drawing.Size(159, 20);
			this.NWMonsterBox.TabIndex = 1;
			this.NWMonsterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DeleteNWBox
			// 
			this.DeleteNWBox.Location = new System.Drawing.Point(90, 45);
			this.DeleteNWBox.Name = "DeleteNWBox";
			this.DeleteNWBox.Size = new System.Drawing.Size(75, 23);
			this.DeleteNWBox.TabIndex = 0;
			this.DeleteNWBox.Text = "Remove";
			this.DeleteNWBox.UseVisualStyleBackColor = true;
			this.DeleteNWBox.Click += new System.EventHandler(this.DeleteNWBox_Click);
			// 
			// EditNWBox
			// 
			this.EditNWBox.Location = new System.Drawing.Point(6, 45);
			this.EditNWBox.Name = "EditNWBox";
			this.EditNWBox.Size = new System.Drawing.Size(75, 23);
			this.EditNWBox.TabIndex = 0;
			this.EditNWBox.Text = "Edit...";
			this.EditNWBox.UseVisualStyleBackColor = true;
			this.EditNWBox.Click += new System.EventHandler(this.EditNWBox_Click);
			// 
			// ItemsTab
			// 
			this.ItemsTab.Controls.Add(this.label1);
			this.ItemsTab.Controls.Add(this.ClearAllItemsBox);
			this.ItemsTab.Controls.Add(this.AlcoveGroupBox);
			this.ItemsTab.Controls.Add(this.ItemsBox);
			this.ItemsTab.Controls.Add(this.groupBox4);
			this.ItemsTab.Controls.Add(this.groupBox3);
			this.ItemsTab.Controls.Add(this.groupBox1);
			this.ItemsTab.Controls.Add(this.groupBox2);
			this.ItemsTab.Location = new System.Drawing.Point(4, 22);
			this.ItemsTab.Name = "ItemsTab";
			this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
			this.ItemsTab.Size = new System.Drawing.Size(501, 473);
			this.ItemsTab.TabIndex = 0;
			this.ItemsTab.Text = "Items";
			this.ItemsTab.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Item :";
			// 
			// ClearAllItemsBox
			// 
			this.ClearAllItemsBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearAllItemsBox.Location = new System.Drawing.Point(6, 444);
			this.ClearAllItemsBox.Name = "ClearAllItemsBox";
			this.ClearAllItemsBox.Size = new System.Drawing.Size(492, 23);
			this.ClearAllItemsBox.TabIndex = 23;
			this.ClearAllItemsBox.Text = "Remove all items";
			this.ClearAllItemsBox.UseVisualStyleBackColor = true;
			this.ClearAllItemsBox.Click += new System.EventHandler(this.ClearAllItemsBox_Click);
			// 
			// AlcoveGroupBox
			// 
			this.AlcoveGroupBox.Controls.Add(this.AlcoveEastButton);
			this.AlcoveGroupBox.Controls.Add(this.AlcoveWestButton);
			this.AlcoveGroupBox.Controls.Add(this.AlcoveSouthButton);
			this.AlcoveGroupBox.Controls.Add(this.AlcoveNorthButton);
			this.AlcoveGroupBox.Location = new System.Drawing.Point(399, 33);
			this.AlcoveGroupBox.Name = "AlcoveGroupBox";
			this.AlcoveGroupBox.Size = new System.Drawing.Size(96, 118);
			this.AlcoveGroupBox.TabIndex = 22;
			this.AlcoveGroupBox.TabStop = false;
			this.AlcoveGroupBox.Text = "Alcoves :";
			// 
			// AlcoveEastButton
			// 
			this.AlcoveEastButton.AutoSize = true;
			this.AlcoveEastButton.Location = new System.Drawing.Point(9, 92);
			this.AlcoveEastButton.Name = "AlcoveEastButton";
			this.AlcoveEastButton.Size = new System.Drawing.Size(47, 17);
			this.AlcoveEastButton.TabIndex = 3;
			this.AlcoveEastButton.Text = "East";
			this.AlcoveEastButton.UseVisualStyleBackColor = true;
			this.AlcoveEastButton.CheckedChanged += new System.EventHandler(this.AlcoveEastButton_CheckedChanged);
			// 
			// AlcoveWestButton
			// 
			this.AlcoveWestButton.AutoSize = true;
			this.AlcoveWestButton.Location = new System.Drawing.Point(9, 68);
			this.AlcoveWestButton.Name = "AlcoveWestButton";
			this.AlcoveWestButton.Size = new System.Drawing.Size(51, 17);
			this.AlcoveWestButton.TabIndex = 2;
			this.AlcoveWestButton.Text = "West";
			this.AlcoveWestButton.UseVisualStyleBackColor = true;
			this.AlcoveWestButton.CheckedChanged += new System.EventHandler(this.AlcoveWestButton_CheckedChanged);
			// 
			// AlcoveSouthButton
			// 
			this.AlcoveSouthButton.AutoSize = true;
			this.AlcoveSouthButton.Location = new System.Drawing.Point(9, 44);
			this.AlcoveSouthButton.Name = "AlcoveSouthButton";
			this.AlcoveSouthButton.Size = new System.Drawing.Size(54, 17);
			this.AlcoveSouthButton.TabIndex = 1;
			this.AlcoveSouthButton.Text = "South";
			this.AlcoveSouthButton.UseVisualStyleBackColor = true;
			this.AlcoveSouthButton.CheckedChanged += new System.EventHandler(this.AlcoveSouthButton_CheckedChanged);
			// 
			// AlcoveNorthButton
			// 
			this.AlcoveNorthButton.AutoSize = true;
			this.AlcoveNorthButton.Location = new System.Drawing.Point(9, 20);
			this.AlcoveNorthButton.Name = "AlcoveNorthButton";
			this.AlcoveNorthButton.Size = new System.Drawing.Size(52, 17);
			this.AlcoveNorthButton.TabIndex = 0;
			this.AlcoveNorthButton.Text = "North";
			this.AlcoveNorthButton.UseVisualStyleBackColor = true;
			this.AlcoveNorthButton.CheckedChanged += new System.EventHandler(this.AlcoveNorthButton_CheckedChanged);
			// 
			// ItemsBox
			// 
			this.ItemsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ItemsBox.FormattingEnabled = true;
			this.ItemsBox.Location = new System.Drawing.Point(51, 6);
			this.ItemsBox.Name = "ItemsBox";
			this.ItemsBox.Size = new System.Drawing.Size(147, 21);
			this.ItemsBox.Sorted = true;
			this.ItemsBox.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.SEBox);
			this.groupBox4.Controls.Add(this.SEAddItem);
			this.groupBox4.Controls.Add(this.SERemoveItem);
			this.groupBox4.Location = new System.Drawing.Point(204, 216);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(189, 177);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "South East or East alcove :";
			// 
			// SEBox
			// 
			this.SEBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SEBox.FormattingEnabled = true;
			this.SEBox.Location = new System.Drawing.Point(6, 21);
			this.SEBox.Name = "SEBox";
			this.SEBox.Size = new System.Drawing.Size(177, 121);
			this.SEBox.TabIndex = 5;
			this.SEBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SEBox_MouseDoubleClick);
			// 
			// SEAddItem
			// 
			this.SEAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SEAddItem.Location = new System.Drawing.Point(6, 148);
			this.SEAddItem.Name = "SEAddItem";
			this.SEAddItem.Size = new System.Drawing.Size(80, 23);
			this.SEAddItem.TabIndex = 4;
			this.SEAddItem.Text = "Add";
			this.SEAddItem.UseVisualStyleBackColor = true;
			this.SEAddItem.Click += new System.EventHandler(this.SEAddItem_Click);
			// 
			// SERemoveItem
			// 
			this.SERemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SERemoveItem.Location = new System.Drawing.Point(103, 148);
			this.SERemoveItem.Name = "SERemoveItem";
			this.SERemoveItem.Size = new System.Drawing.Size(80, 23);
			this.SERemoveItem.TabIndex = 2;
			this.SERemoveItem.Text = "Remove";
			this.SERemoveItem.UseVisualStyleBackColor = true;
			this.SERemoveItem.Click += new System.EventHandler(this.SERemoveItem_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.SWBox);
			this.groupBox3.Controls.Add(this.SWAddItem);
			this.groupBox3.Controls.Add(this.SWRemoveItem);
			this.groupBox3.Location = new System.Drawing.Point(9, 216);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(189, 177);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "South West or West alcove :";
			// 
			// SWBox
			// 
			this.SWBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SWBox.FormattingEnabled = true;
			this.SWBox.Location = new System.Drawing.Point(6, 21);
			this.SWBox.Name = "SWBox";
			this.SWBox.Size = new System.Drawing.Size(177, 121);
			this.SWBox.TabIndex = 5;
			this.SWBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SWBox_MouseDoubleClick);
			// 
			// SWAddItem
			// 
			this.SWAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SWAddItem.Location = new System.Drawing.Point(6, 148);
			this.SWAddItem.Name = "SWAddItem";
			this.SWAddItem.Size = new System.Drawing.Size(80, 23);
			this.SWAddItem.TabIndex = 4;
			this.SWAddItem.Text = "Add";
			this.SWAddItem.UseVisualStyleBackColor = true;
			this.SWAddItem.Click += new System.EventHandler(this.SWAddItem_Click);
			// 
			// SWRemoveItem
			// 
			this.SWRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SWRemoveItem.Location = new System.Drawing.Point(103, 148);
			this.SWRemoveItem.Name = "SWRemoveItem";
			this.SWRemoveItem.Size = new System.Drawing.Size(80, 23);
			this.SWRemoveItem.TabIndex = 2;
			this.SWRemoveItem.Text = "Remove";
			this.SWRemoveItem.UseVisualStyleBackColor = true;
			this.SWRemoveItem.Click += new System.EventHandler(this.SWRemoveItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NEBox);
			this.groupBox1.Controls.Add(this.NEAddItem);
			this.groupBox1.Controls.Add(this.NERemoveItem);
			this.groupBox1.Location = new System.Drawing.Point(204, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 177);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "North East or South alcove :";
			// 
			// NEBox
			// 
			this.NEBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NEBox.FormattingEnabled = true;
			this.NEBox.Location = new System.Drawing.Point(6, 21);
			this.NEBox.Name = "NEBox";
			this.NEBox.Size = new System.Drawing.Size(177, 121);
			this.NEBox.TabIndex = 5;
			this.NEBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NEBox_MouseDoubleClick);
			// 
			// NEAddItem
			// 
			this.NEAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.NEAddItem.Location = new System.Drawing.Point(6, 148);
			this.NEAddItem.Name = "NEAddItem";
			this.NEAddItem.Size = new System.Drawing.Size(80, 23);
			this.NEAddItem.TabIndex = 4;
			this.NEAddItem.Text = "Add";
			this.NEAddItem.UseVisualStyleBackColor = true;
			this.NEAddItem.Click += new System.EventHandler(this.NEAddItem_Click);
			// 
			// NERemoveItem
			// 
			this.NERemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NERemoveItem.Location = new System.Drawing.Point(103, 148);
			this.NERemoveItem.Name = "NERemoveItem";
			this.NERemoveItem.Size = new System.Drawing.Size(80, 23);
			this.NERemoveItem.TabIndex = 2;
			this.NERemoveItem.Text = "Remove";
			this.NERemoveItem.UseVisualStyleBackColor = true;
			this.NERemoveItem.Click += new System.EventHandler(this.NERemoveItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.NWBox);
			this.groupBox2.Controls.Add(this.NWAddItem);
			this.groupBox2.Controls.Add(this.NWRemoveItem);
			this.groupBox2.Location = new System.Drawing.Point(9, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(189, 177);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "North West or North alcove :";
			// 
			// NWBox
			// 
			this.NWBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NWBox.FormattingEnabled = true;
			this.NWBox.Location = new System.Drawing.Point(6, 21);
			this.NWBox.Name = "NWBox";
			this.NWBox.Size = new System.Drawing.Size(177, 121);
			this.NWBox.TabIndex = 5;
			this.NWBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NWBox_MouseDoubleClick);
			// 
			// NWAddItem
			// 
			this.NWAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.NWAddItem.Location = new System.Drawing.Point(6, 148);
			this.NWAddItem.Name = "NWAddItem";
			this.NWAddItem.Size = new System.Drawing.Size(80, 23);
			this.NWAddItem.TabIndex = 4;
			this.NWAddItem.Text = "Add";
			this.NWAddItem.UseVisualStyleBackColor = true;
			this.NWAddItem.Click += new System.EventHandler(this.NWAddItem_Click);
			// 
			// NWRemoveItem
			// 
			this.NWRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NWRemoveItem.Location = new System.Drawing.Point(103, 148);
			this.NWRemoveItem.Name = "NWRemoveItem";
			this.NWRemoveItem.Size = new System.Drawing.Size(80, 23);
			this.NWRemoveItem.TabIndex = 2;
			this.NWRemoveItem.Text = "Remove";
			this.NWRemoveItem.UseVisualStyleBackColor = true;
			this.NWRemoveItem.Click += new System.EventHandler(this.NWRemoveItem_Click);
			// 
			// TabControlBox
			// 
			this.TabControlBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabControlBox.Controls.Add(this.ItemsTab);
			this.TabControlBox.Controls.Add(this.MonstersTab);
			this.TabControlBox.Controls.Add(this.DecorationTab);
			this.TabControlBox.Controls.Add(this.ActorTab);
			this.TabControlBox.Location = new System.Drawing.Point(12, 12);
			this.TabControlBox.Name = "TabControlBox";
			this.TabControlBox.SelectedIndex = 0;
			this.TabControlBox.Size = new System.Drawing.Size(509, 499);
			this.TabControlBox.TabIndex = 0;
			// 
			// ActorTab
			// 
			this.ActorTab.Controls.Add(this.ActorPanelBox);
			this.ActorTab.Controls.Add(this.DeleteActorBox);
			this.ActorTab.Location = new System.Drawing.Point(4, 22);
			this.ActorTab.Name = "ActorTab";
			this.ActorTab.Size = new System.Drawing.Size(501, 473);
			this.ActorTab.TabIndex = 3;
			this.ActorTab.Text = "Actor";
			this.ActorTab.UseVisualStyleBackColor = true;
			this.ActorTab.Enter += new System.EventHandler(this.ActorTab_Enter);
			// 
			// ActorPanelBox
			// 
			this.ActorPanelBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActorPanelBox.Location = new System.Drawing.Point(3, 3);
			this.ActorPanelBox.Name = "ActorPanelBox";
			this.ActorPanelBox.Size = new System.Drawing.Size(495, 438);
			this.ActorPanelBox.TabIndex = 0;
			// 
			// DeleteActorBox
			// 
			this.DeleteActorBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteActorBox.Location = new System.Drawing.Point(6, 444);
			this.DeleteActorBox.Name = "DeleteActorBox";
			this.DeleteActorBox.Size = new System.Drawing.Size(492, 23);
			this.DeleteActorBox.TabIndex = 0;
			this.DeleteActorBox.Text = "Remove actor";
			this.DeleteActorBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.DeleteActorBox.UseVisualStyleBackColor = true;
			this.DeleteActorBox.Click += new System.EventHandler(this.DeleteActorBox_Click);
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.SouthDecorationBox);
			this.groupBox14.Controls.Add(this.EastDecorationBox);
			this.groupBox14.Controls.Add(this.WestDecorationBox);
			this.groupBox14.Controls.Add(this.NorthDecorationBox);
			this.groupBox14.Location = new System.Drawing.Point(3, 3);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(94, 109);
			this.groupBox14.TabIndex = 23;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Wall side";
			// 
			// NorthDecorationBox
			// 
			this.NorthDecorationBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.NorthDecorationBox.Checked = true;
			this.NorthDecorationBox.Location = new System.Drawing.Point(30, 22);
			this.NorthDecorationBox.Name = "NorthDecorationBox";
			this.NorthDecorationBox.Size = new System.Drawing.Size(28, 23);
			this.NorthDecorationBox.TabIndex = 0;
			this.NorthDecorationBox.TabStop = true;
			this.NorthDecorationBox.Text = "N";
			this.NorthDecorationBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NorthDecorationBox.UseVisualStyleBackColor = true;
			this.NorthDecorationBox.CheckedChanged += new System.EventHandler(this.NorthDecorationBox_CheckedChanged);
			// 
			// WestDecorationBox
			// 
			this.WestDecorationBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.WestDecorationBox.Location = new System.Drawing.Point(13, 51);
			this.WestDecorationBox.Name = "WestDecorationBox";
			this.WestDecorationBox.Size = new System.Drawing.Size(28, 23);
			this.WestDecorationBox.TabIndex = 0;
			this.WestDecorationBox.TabStop = true;
			this.WestDecorationBox.Text = "W";
			this.WestDecorationBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.WestDecorationBox.UseVisualStyleBackColor = true;
			this.WestDecorationBox.CheckedChanged += new System.EventHandler(this.WestDecorationBox_CheckedChanged);
			// 
			// SouthDecorationBox
			// 
			this.SouthDecorationBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.SouthDecorationBox.Location = new System.Drawing.Point(30, 80);
			this.SouthDecorationBox.Name = "SouthDecorationBox";
			this.SouthDecorationBox.Size = new System.Drawing.Size(28, 23);
			this.SouthDecorationBox.TabIndex = 0;
			this.SouthDecorationBox.TabStop = true;
			this.SouthDecorationBox.Text = "S";
			this.SouthDecorationBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SouthDecorationBox.UseVisualStyleBackColor = true;
			this.SouthDecorationBox.CheckedChanged += new System.EventHandler(this.SouthDecorationBox_CheckedChanged);
			// 
			// EastDecorationBox
			// 
			this.EastDecorationBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.EastDecorationBox.Location = new System.Drawing.Point(47, 51);
			this.EastDecorationBox.Name = "EastDecorationBox";
			this.EastDecorationBox.Size = new System.Drawing.Size(28, 23);
			this.EastDecorationBox.TabIndex = 0;
			this.EastDecorationBox.TabStop = true;
			this.EastDecorationBox.Text = "E";
			this.EastDecorationBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.EastDecorationBox.UseVisualStyleBackColor = true;
			this.EastDecorationBox.CheckedChanged += new System.EventHandler(this.EastDecorationBox_CheckedChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.DecorationIdBox);
			this.groupBox6.Location = new System.Drawing.Point(3, 118);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(94, 58);
			this.groupBox6.TabIndex = 24;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Decoration";
			// 
			// ClearDecorationBox
			// 
			this.ClearDecorationBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearDecorationBox.Location = new System.Drawing.Point(6, 444);
			this.ClearDecorationBox.Name = "ClearDecorationBox";
			this.ClearDecorationBox.Size = new System.Drawing.Size(492, 23);
			this.ClearDecorationBox.TabIndex = 25;
			this.ClearDecorationBox.Text = "Remove decoration";
			this.ClearDecorationBox.UseVisualStyleBackColor = true;
			// 
			// DecorationIdBox
			// 
			this.DecorationIdBox.Location = new System.Drawing.Point(6, 19);
			this.DecorationIdBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.DecorationIdBox.Name = "DecorationIdBox";
			this.DecorationIdBox.Size = new System.Drawing.Size(82, 20);
			this.DecorationIdBox.TabIndex = 0;
			this.DecorationIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DecorationIdBox.ThousandsSeparator = true;
			this.DecorationIdBox.ValueChanged += new System.EventHandler(this.DecorationIdBox_ValueChanged);
			// 
			// SquareForm
			// 
			this.AcceptButton = this.CloseBox;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 552);
			this.Controls.Add(this.CloseBox);
			this.Controls.Add(this.TabControlBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SquareForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Square wizard";
			this.Load += new System.EventHandler(this.MazeBlockForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MazeBlockForm_KeyDown);
			this.DecorationTab.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.MonstersTab.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.groupBox13.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.ItemsTab.ResumeLayout(false);
			this.ItemsTab.PerformLayout();
			this.AlcoveGroupBox.ResumeLayout(false);
			this.AlcoveGroupBox.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.TabControlBox.ResumeLayout(false);
			this.ActorTab.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.DecorationIdBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CloseBox;
		private System.Windows.Forms.TabPage DecorationTab;
		private System.Windows.Forms.GroupBox groupBox5;
		private OpenTK.GLControl GlWallControl;
		private System.Windows.Forms.TabPage MonstersTab;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.TextBox SWMonsterBox;
		private System.Windows.Forms.Button DeleteSWBox;
		private System.Windows.Forms.Button EditSWBox;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.TextBox SEMonsterBox;
		private System.Windows.Forms.Button DeleteSEBox;
		private System.Windows.Forms.Button EditSEBox;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.TextBox NEMonsterBox;
		private System.Windows.Forms.Button DeleteNEBox;
		private System.Windows.Forms.Button EditNEBox;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TextBox NWMonsterBox;
		private System.Windows.Forms.Button DeleteNWBox;
		private System.Windows.Forms.Button EditNWBox;
		private System.Windows.Forms.TabPage ItemsTab;
		private System.Windows.Forms.CheckBox AlcoveEastButton;
		private System.Windows.Forms.CheckBox AlcoveWestButton;
		private System.Windows.Forms.CheckBox AlcoveSouthButton;
		private System.Windows.Forms.CheckBox AlcoveNorthButton;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox SEBox;
		private System.Windows.Forms.Button SEAddItem;
		private System.Windows.Forms.Button SERemoveItem;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox SWBox;
		private System.Windows.Forms.Button SWAddItem;
		private System.Windows.Forms.Button SWRemoveItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox NEBox;
		private System.Windows.Forms.Button NEAddItem;
		private System.Windows.Forms.Button NERemoveItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox NWBox;
		private System.Windows.Forms.Button NWAddItem;
		private System.Windows.Forms.ComboBox ItemsBox;
		private System.Windows.Forms.Button NWRemoveItem;
		private System.Windows.Forms.TabControl TabControlBox;
		private System.Windows.Forms.Button ClearAllItemsBox;
		private System.Windows.Forms.Button RemoveAllMonstersBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox AlcoveGroupBox;
		private System.Windows.Forms.TabPage ActorTab;
		private System.Windows.Forms.Button DeleteActorBox;
		private System.Windows.Forms.Panel ActorPanelBox;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.RadioButton SouthDecorationBox;
		private System.Windows.Forms.RadioButton EastDecorationBox;
		private System.Windows.Forms.RadioButton WestDecorationBox;
		private System.Windows.Forms.RadioButton NorthDecorationBox;
		private System.Windows.Forms.Button ClearDecorationBox;
		private System.Windows.Forms.NumericUpDown DecorationIdBox;
	}
}