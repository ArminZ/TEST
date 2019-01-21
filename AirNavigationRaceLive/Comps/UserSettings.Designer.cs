﻿namespace AirNavigationRaceLive.Comps
{
    partial class UserSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkParcourAdditionalText = new System.Windows.Forms.CheckBox();
            this.chkDefaultDBDirectory = new System.Windows.Forms.CheckBox();
            this.textBoxDatabasePath = new System.Windows.Forms.TextBox();
            this.groupBoxChannel = new System.Windows.Forms.GroupBox();
            this.chkHasChannelFill = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownChannelFillAlpha = new System.Windows.Forms.NumericUpDown();
            this.btnChannelFillColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownChannelPen = new System.Windows.Forms.NumericUpDown();
            this.btnChannelColor = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSPFPColor = new System.Windows.Forms.Button();
            this.numericUpDownSPFPPen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSPFPShowCircle = new System.Windows.Forms.CheckBox();
            this.groupBoxSPFP = new System.Windows.Forms.GroupBox();
            this.btnPROHColorLayer = new System.Windows.Forms.Button();
            this.numericUpDownPROHAlpha = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownPROHBorderPen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxLayer = new System.Windows.Forms.GroupBox();
            this.chkShowPROHBorders = new System.Windows.Forms.CheckBox();
            this.btnPROHBorderColor = new System.Windows.Forms.Button();
            this.groupBoxIntersect = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIntersectRadius = new System.Windows.Forms.NumericUpDown();
            this.chkShowIntersectionCircles = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownIntersectPen = new System.Windows.Forms.NumericUpDown();
            this.btnIntersectColor = new System.Windows.Forms.Button();
            this.groupBoxCalculationType = new System.Windows.Forms.GroupBox();
            this.radioButtonPenaltyCalcTypeChannel = new System.Windows.Forms.RadioButton();
            this.radioButtonPenaltyCalcTypePROH = new System.Windows.Forms.RadioButton();
            this.groupBoxChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelFillAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSPFPPen)).BeginInit();
            this.groupBoxSPFP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHBorderPen)).BeginInit();
            this.groupBoxLayer.SuspendLayout();
            this.groupBoxIntersect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntersectRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntersectPen)).BeginInit();
            this.groupBoxCalculationType.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkParcourAdditionalText
            // 
            this.chkParcourAdditionalText.AutoSize = true;
            this.chkParcourAdditionalText.Location = new System.Drawing.Point(30, 109);
            this.chkParcourAdditionalText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkParcourAdditionalText.Name = "chkParcourAdditionalText";
            this.chkParcourAdditionalText.Size = new System.Drawing.Size(358, 24);
            this.chkParcourAdditionalText.TabIndex = 11;
            this.chkParcourAdditionalText.Text = "Parcour PDF export: Prompt for additional text";
            this.chkParcourAdditionalText.UseVisualStyleBackColor = true;
            // 
            // chkDefaultDBDirectory
            // 
            this.chkDefaultDBDirectory.AutoSize = true;
            this.chkDefaultDBDirectory.Location = new System.Drawing.Point(30, 46);
            this.chkDefaultDBDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDefaultDBDirectory.Name = "chkDefaultDBDirectory";
            this.chkDefaultDBDirectory.Size = new System.Drawing.Size(349, 24);
            this.chkDefaultDBDirectory.TabIndex = 10;
            this.chkDefaultDBDirectory.Text = "Database File: use a default DB file directory";
            this.chkDefaultDBDirectory.UseVisualStyleBackColor = true;
            // 
            // textBoxDatabasePath
            // 
            this.textBoxDatabasePath.Location = new System.Drawing.Point(427, 46);
            this.textBoxDatabasePath.Name = "textBoxDatabasePath";
            this.textBoxDatabasePath.Size = new System.Drawing.Size(503, 26);
            this.textBoxDatabasePath.TabIndex = 12;
            // 
            // groupBoxChannel
            // 
            this.groupBoxChannel.Controls.Add(this.chkHasChannelFill);
            this.groupBoxChannel.Controls.Add(this.label1);
            this.groupBoxChannel.Controls.Add(this.numericUpDownChannelFillAlpha);
            this.groupBoxChannel.Controls.Add(this.btnChannelFillColor);
            this.groupBoxChannel.Controls.Add(this.label5);
            this.groupBoxChannel.Controls.Add(this.numericUpDownChannelPen);
            this.groupBoxChannel.Controls.Add(this.btnChannelColor);
            this.groupBoxChannel.Location = new System.Drawing.Point(520, 179);
            this.groupBoxChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxChannel.Name = "groupBoxChannel";
            this.groupBoxChannel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxChannel.Size = new System.Drawing.Size(491, 167);
            this.groupBoxChannel.TabIndex = 30;
            this.groupBoxChannel.TabStop = false;
            this.groupBoxChannel.Text = "Channel Properties";
            // 
            // chkHasChannelFill
            // 
            this.chkHasChannelFill.AutoSize = true;
            this.chkHasChannelFill.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasChannelFill.Location = new System.Drawing.Point(207, 115);
            this.chkHasChannelFill.Name = "chkHasChannelFill";
            this.chkHasChannelFill.Size = new System.Drawing.Size(171, 24);
            this.chkHasChannelFill.TabIndex = 33;
            this.chkHasChannelFill.Text = "Use Channel Filling";
            this.chkHasChannelFill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Opacity (0=fully transparent) and Color";
            // 
            // numericUpDownChannelFillAlpha
            // 
            this.numericUpDownChannelFillAlpha.Location = new System.Drawing.Point(309, 71);
            this.numericUpDownChannelFillAlpha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownChannelFillAlpha.Name = "numericUpDownChannelFillAlpha";
            this.numericUpDownChannelFillAlpha.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownChannelFillAlpha.TabIndex = 31;
            this.numericUpDownChannelFillAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChannelFillColor
            // 
            this.btnChannelFillColor.BackColor = System.Drawing.Color.Red;
            this.btnChannelFillColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChannelFillColor.Location = new System.Drawing.Point(381, 69);
            this.btnChannelFillColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChannelFillColor.Name = "btnChannelFillColor";
            this.btnChannelFillColor.Size = new System.Drawing.Size(42, 28);
            this.btnChannelFillColor.TabIndex = 32;
            this.btnChannelFillColor.Text = "...";
            this.btnChannelFillColor.UseVisualStyleBackColor = false;
            this.btnChannelFillColor.Click += new System.EventHandler(this.ColorButtonGeneric_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Border, Pen Width and Color";
            // 
            // numericUpDownChannelPen
            // 
            this.numericUpDownChannelPen.DecimalPlaces = 1;
            this.numericUpDownChannelPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownChannelPen.Location = new System.Drawing.Point(307, 35);
            this.numericUpDownChannelPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownChannelPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownChannelPen.Name = "numericUpDownChannelPen";
            this.numericUpDownChannelPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownChannelPen.TabIndex = 26;
            this.numericUpDownChannelPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChannelColor
            // 
            this.btnChannelColor.BackColor = System.Drawing.Color.Red;
            this.btnChannelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChannelColor.Location = new System.Drawing.Point(379, 35);
            this.btnChannelColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChannelColor.Name = "btnChannelColor";
            this.btnChannelColor.Size = new System.Drawing.Size(44, 28);
            this.btnChannelColor.TabIndex = 29;
            this.btnChannelColor.Text = "...";
            this.btnChannelColor.UseVisualStyleBackColor = false;
            this.btnChannelColor.Click += new System.EventHandler(this.ColorButtonGeneric_Click);
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(936, 42);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(75, 35);
            this.btnDB.TabIndex = 31;
            this.btnDB.Text = "...";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(916, 681);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 41);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(822, 681);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 41);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSPFPColor
            // 
            this.btnSPFPColor.BackColor = System.Drawing.Color.Red;
            this.btnSPFPColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPFPColor.Location = new System.Drawing.Point(376, 45);
            this.btnSPFPColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSPFPColor.Name = "btnSPFPColor";
            this.btnSPFPColor.Size = new System.Drawing.Size(43, 28);
            this.btnSPFPColor.TabIndex = 29;
            this.btnSPFPColor.Text = "...";
            this.btnSPFPColor.UseVisualStyleBackColor = false;
            this.btnSPFPColor.Click += new System.EventHandler(this.ColorButtonGeneric_Click);
            // 
            // numericUpDownSPFPPen
            // 
            this.numericUpDownSPFPPen.DecimalPlaces = 1;
            this.numericUpDownSPFPPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownSPFPPen.Location = new System.Drawing.Point(304, 45);
            this.numericUpDownSPFPPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownSPFPPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSPFPPen.Name = "numericUpDownSPFPPen";
            this.numericUpDownSPFPPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownSPFPPen.TabIndex = 26;
            this.numericUpDownSPFPPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pen Width and Color for SP/FP gates";
            // 
            // chkSPFPShowCircle
            // 
            this.chkSPFPShowCircle.AutoSize = true;
            this.chkSPFPShowCircle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSPFPShowCircle.Location = new System.Drawing.Point(152, 79);
            this.chkSPFPShowCircle.Name = "chkSPFPShowCircle";
            this.chkSPFPShowCircle.Size = new System.Drawing.Size(216, 24);
            this.chkSPFPShowCircle.TabIndex = 30;
            this.chkSPFPShowCircle.Text = "Show Circle and Direction";
            this.chkSPFPShowCircle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSPFP
            // 
            this.groupBoxSPFP.Controls.Add(this.chkSPFPShowCircle);
            this.groupBoxSPFP.Controls.Add(this.label3);
            this.groupBoxSPFP.Controls.Add(this.numericUpDownSPFPPen);
            this.groupBoxSPFP.Controls.Add(this.btnSPFPColor);
            this.groupBoxSPFP.Location = new System.Drawing.Point(23, 354);
            this.groupBoxSPFP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSPFP.Name = "groupBoxSPFP";
            this.groupBoxSPFP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSPFP.Size = new System.Drawing.Size(491, 167);
            this.groupBoxSPFP.TabIndex = 29;
            this.groupBoxSPFP.TabStop = false;
            this.groupBoxSPFP.Text = "SP and FP Properties for new Parcour";
            // 
            // btnPROHColorLayer
            // 
            this.btnPROHColorLayer.BackColor = System.Drawing.Color.Red;
            this.btnPROHColorLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPROHColorLayer.Location = new System.Drawing.Point(370, 41);
            this.btnPROHColorLayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPROHColorLayer.Name = "btnPROHColorLayer";
            this.btnPROHColorLayer.Size = new System.Drawing.Size(43, 28);
            this.btnPROHColorLayer.TabIndex = 26;
            this.btnPROHColorLayer.Text = "...";
            this.btnPROHColorLayer.UseVisualStyleBackColor = false;
            this.btnPROHColorLayer.Click += new System.EventHandler(this.ColorButtonGeneric_Click);
            // 
            // numericUpDownPROHAlpha
            // 
            this.numericUpDownPROHAlpha.Location = new System.Drawing.Point(298, 43);
            this.numericUpDownPROHAlpha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPROHAlpha.Name = "numericUpDownPROHAlpha";
            this.numericUpDownPROHAlpha.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownPROHAlpha.TabIndex = 25;
            this.numericUpDownPROHAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 41);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label17.Size = new System.Drawing.Size(283, 25);
            this.label17.TabIndex = 24;
            this.label17.Text = "Opacity (0=fully transparent) and Color";
            // 
            // numericUpDownPROHBorderPen
            // 
            this.numericUpDownPROHBorderPen.DecimalPlaces = 1;
            this.numericUpDownPROHBorderPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPROHBorderPen.Location = new System.Drawing.Point(298, 75);
            this.numericUpDownPROHBorderPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPROHBorderPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPROHBorderPen.Name = "numericUpDownPROHBorderPen";
            this.numericUpDownPROHBorderPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownPROHBorderPen.TabIndex = 29;
            this.numericUpDownPROHBorderPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Pen Width and Color for Border";
            // 
            // groupBoxLayer
            // 
            this.groupBoxLayer.Controls.Add(this.chkShowPROHBorders);
            this.groupBoxLayer.Controls.Add(this.btnPROHBorderColor);
            this.groupBoxLayer.Controls.Add(this.label2);
            this.groupBoxLayer.Controls.Add(this.numericUpDownPROHBorderPen);
            this.groupBoxLayer.Controls.Add(this.label17);
            this.groupBoxLayer.Controls.Add(this.numericUpDownPROHAlpha);
            this.groupBoxLayer.Controls.Add(this.btnPROHColorLayer);
            this.groupBoxLayer.Location = new System.Drawing.Point(36, 179);
            this.groupBoxLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLayer.Name = "groupBoxLayer";
            this.groupBoxLayer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLayer.Size = new System.Drawing.Size(478, 167);
            this.groupBoxLayer.TabIndex = 28;
            this.groupBoxLayer.TabStop = false;
            this.groupBoxLayer.Text = "PROH Layer Properties for new Parcour";
            // 
            // chkShowPROHBorders
            // 
            this.chkShowPROHBorders.AutoSize = true;
            this.chkShowPROHBorders.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowPROHBorders.Location = new System.Drawing.Point(139, 133);
            this.chkShowPROHBorders.Name = "chkShowPROHBorders";
            this.chkShowPROHBorders.Size = new System.Drawing.Size(223, 24);
            this.chkShowPROHBorders.TabIndex = 31;
            this.chkShowPROHBorders.Text = "Draw PROH Layer borders";
            this.chkShowPROHBorders.UseVisualStyleBackColor = true;
            // 
            // btnPROHBorderColor
            // 
            this.btnPROHBorderColor.BackColor = System.Drawing.Color.Red;
            this.btnPROHBorderColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPROHBorderColor.Location = new System.Drawing.Point(370, 75);
            this.btnPROHBorderColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPROHBorderColor.Name = "btnPROHBorderColor";
            this.btnPROHBorderColor.Size = new System.Drawing.Size(43, 28);
            this.btnPROHBorderColor.TabIndex = 30;
            this.btnPROHBorderColor.Text = "...";
            this.btnPROHBorderColor.UseVisualStyleBackColor = false;
            this.btnPROHBorderColor.Click += new System.EventHandler(this.ColorButtonGeneric_Click);
            // 
            // groupBoxIntersect
            // 
            this.groupBoxIntersect.Controls.Add(this.label4);
            this.groupBoxIntersect.Controls.Add(this.numericUpDownIntersectRadius);
            this.groupBoxIntersect.Controls.Add(this.chkShowIntersectionCircles);
            this.groupBoxIntersect.Controls.Add(this.label7);
            this.groupBoxIntersect.Controls.Add(this.numericUpDownIntersectPen);
            this.groupBoxIntersect.Controls.Add(this.btnIntersectColor);
            this.groupBoxIntersect.Location = new System.Drawing.Point(520, 354);
            this.groupBoxIntersect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxIntersect.Name = "groupBoxIntersect";
            this.groupBoxIntersect.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxIntersect.Size = new System.Drawing.Size(491, 167);
            this.groupBoxIntersect.TabIndex = 34;
            this.groupBoxIntersect.TabStop = false;
            this.groupBoxIntersect.Text = "Intersection Point Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Circle radius in Nm";
            // 
            // numericUpDownIntersectRadius
            // 
            this.numericUpDownIntersectRadius.DecimalPlaces = 1;
            this.numericUpDownIntersectRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownIntersectRadius.Location = new System.Drawing.Point(302, 69);
            this.numericUpDownIntersectRadius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownIntersectRadius.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIntersectRadius.Name = "numericUpDownIntersectRadius";
            this.numericUpDownIntersectRadius.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownIntersectRadius.TabIndex = 32;
            this.numericUpDownIntersectRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkShowIntersectionCircles
            // 
            this.chkShowIntersectionCircles.AutoSize = true;
            this.chkShowIntersectionCircles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowIntersectionCircles.Location = new System.Drawing.Point(155, 115);
            this.chkShowIntersectionCircles.Name = "chkShowIntersectionCircles";
            this.chkShowIntersectionCircles.Size = new System.Drawing.Size(211, 24);
            this.chkShowIntersectionCircles.TabIndex = 31;
            this.chkShowIntersectionCircles.Text = "Show Intersection Points";
            this.chkShowIntersectionCircles.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pen Width and Color";
            // 
            // numericUpDownIntersectPen
            // 
            this.numericUpDownIntersectPen.DecimalPlaces = 1;
            this.numericUpDownIntersectPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownIntersectPen.Location = new System.Drawing.Point(302, 33);
            this.numericUpDownIntersectPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownIntersectPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIntersectPen.Name = "numericUpDownIntersectPen";
            this.numericUpDownIntersectPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownIntersectPen.TabIndex = 26;
            this.numericUpDownIntersectPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIntersectColor
            // 
            this.btnIntersectColor.BackColor = System.Drawing.Color.Red;
            this.btnIntersectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntersectColor.Location = new System.Drawing.Point(379, 31);
            this.btnIntersectColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIntersectColor.Name = "btnIntersectColor";
            this.btnIntersectColor.Size = new System.Drawing.Size(44, 28);
            this.btnIntersectColor.TabIndex = 29;
            this.btnIntersectColor.Text = "...";
            this.btnIntersectColor.UseVisualStyleBackColor = false;
            this.btnIntersectColor.Click += new System.EventHandler(this.ColorButtonGeneric_Click);
            // 
            // groupBoxCalculationType
            // 
            this.groupBoxCalculationType.Controls.Add(this.radioButtonPenaltyCalcTypeChannel);
            this.groupBoxCalculationType.Controls.Add(this.radioButtonPenaltyCalcTypePROH);
            this.groupBoxCalculationType.Location = new System.Drawing.Point(520, 528);
            this.groupBoxCalculationType.Name = "groupBoxCalculationType";
            this.groupBoxCalculationType.Size = new System.Drawing.Size(491, 121);
            this.groupBoxCalculationType.TabIndex = 35;
            this.groupBoxCalculationType.TabStop = false;
            this.groupBoxCalculationType.Text = "Penalty Calculation Type";
            // 
            // radioButtonPenaltyCalcTypeChannel
            // 
            this.radioButtonPenaltyCalcTypeChannel.AutoSize = true;
            this.radioButtonPenaltyCalcTypeChannel.Location = new System.Drawing.Point(17, 76);
            this.radioButtonPenaltyCalcTypeChannel.Name = "radioButtonPenaltyCalcTypeChannel";
            this.radioButtonPenaltyCalcTypeChannel.Size = new System.Drawing.Size(309, 24);
            this.radioButtonPenaltyCalcTypeChannel.TabIndex = 1;
            this.radioButtonPenaltyCalcTypeChannel.TabStop = true;
            this.radioButtonPenaltyCalcTypeChannel.Text = "Penalty when leaving assigned channel";
            this.radioButtonPenaltyCalcTypeChannel.UseVisualStyleBackColor = true;
            // 
            // radioButtonPenaltyCalcTypePROH
            // 
            this.radioButtonPenaltyCalcTypePROH.AutoSize = true;
            this.radioButtonPenaltyCalcTypePROH.Location = new System.Drawing.Point(17, 39);
            this.radioButtonPenaltyCalcTypePROH.Name = "radioButtonPenaltyCalcTypePROH";
            this.radioButtonPenaltyCalcTypePROH.Size = new System.Drawing.Size(311, 24);
            this.radioButtonPenaltyCalcTypePROH.TabIndex = 0;
            this.radioButtonPenaltyCalcTypePROH.TabStop = true;
            this.radioButtonPenaltyCalcTypePROH.Text = "Penalty when entering prohibited zones";
            this.radioButtonPenaltyCalcTypePROH.UseVisualStyleBackColor = true;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCalculationType);
            this.Controls.Add(this.groupBoxIntersect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.groupBoxChannel);
            this.Controls.Add(this.groupBoxSPFP);
            this.Controls.Add(this.groupBoxLayer);
            this.Controls.Add(this.textBoxDatabasePath);
            this.Controls.Add(this.chkParcourAdditionalText);
            this.Controls.Add(this.chkDefaultDBDirectory);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(1094, 802);
            this.groupBoxChannel.ResumeLayout(false);
            this.groupBoxChannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelFillAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSPFPPen)).EndInit();
            this.groupBoxSPFP.ResumeLayout(false);
            this.groupBoxSPFP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHBorderPen)).EndInit();
            this.groupBoxLayer.ResumeLayout(false);
            this.groupBoxLayer.PerformLayout();
            this.groupBoxIntersect.ResumeLayout(false);
            this.groupBoxIntersect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntersectRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntersectPen)).EndInit();
            this.groupBoxCalculationType.ResumeLayout(false);
            this.groupBoxCalculationType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkParcourAdditionalText;
        private System.Windows.Forms.CheckBox chkDefaultDBDirectory;
        private System.Windows.Forms.TextBox textBoxDatabasePath;
        private System.Windows.Forms.GroupBox groupBoxChannel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownChannelPen;
        private System.Windows.Forms.Button btnChannelColor;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSPFPColor;
        private System.Windows.Forms.NumericUpDown numericUpDownSPFPPen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSPFPShowCircle;
        private System.Windows.Forms.GroupBox groupBoxSPFP;
        private System.Windows.Forms.Button btnPROHColorLayer;
        private System.Windows.Forms.NumericUpDown numericUpDownPROHAlpha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownPROHBorderPen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxLayer;
        private System.Windows.Forms.GroupBox groupBoxIntersect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownIntersectPen;
        private System.Windows.Forms.Button btnIntersectColor;
        private System.Windows.Forms.GroupBox groupBoxCalculationType;
        private System.Windows.Forms.RadioButton radioButtonPenaltyCalcTypeChannel;
        private System.Windows.Forms.RadioButton radioButtonPenaltyCalcTypePROH;
        private System.Windows.Forms.CheckBox chkShowIntersectionCircles;
        private System.Windows.Forms.CheckBox chkShowPROHBorders;
        private System.Windows.Forms.Button btnPROHBorderColor;
        private System.Windows.Forms.CheckBox chkHasChannelFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownChannelFillAlpha;
        private System.Windows.Forms.Button btnChannelFillColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIntersectRadius;
    }
}
