﻿namespace MandarinNews
{
    partial class UC_Settings
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryCB = new System.Windows.Forms.ComboBox();
            this.SortCB = new System.Windows.Forms.ComboBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ThemeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InterfaceLanguageCB = new System.Windows.Forms.ComboBox();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NewsRegionCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CountryCB
            // 
            this.CountryCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CountryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryCB.FormattingEnabled = true;
            this.CountryCB.Items.AddRange(new object[] {
            "Русский",
            "English (US)",
            "English (GB)",
            "France",
            "Deutsch",
            "Українська",
            "Italiano"});
            this.CountryCB.Location = new System.Drawing.Point(262, 48);
            this.CountryCB.Name = "CountryCB";
            this.CountryCB.Size = new System.Drawing.Size(277, 30);
            this.CountryCB.TabIndex = 6;
            this.CountryCB.SelectedIndexChanged += new System.EventHandler(this.CountryCB_SelectedIndexChanged);
            // 
            // SortCB
            // 
            this.SortCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SortCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortCB.FormattingEnabled = true;
            this.SortCB.Items.AddRange(new object[] {
            "By relevancy",
            "By popularity",
            "By published at"});
            this.SortCB.Location = new System.Drawing.Point(262, 224);
            this.SortCB.Name = "SortCB";
            this.SortCB.Size = new System.Drawing.Size(277, 30);
            this.SortCB.TabIndex = 7;
            this.SortCB.SelectedIndexChanged += new System.EventHandler(this.SortCB_SelectedIndexChanged);
            // 
            // CategoryCB
            // 
            this.CategoryCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Items.AddRange(new object[] {
            "All",
            "Sports",
            "Science",
            "Entertainment",
            "Health",
            "Technology"});
            this.CategoryCB.Location = new System.Drawing.Point(262, 433);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(277, 30);
            this.CategoryCB.TabIndex = 8;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "News language";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "News sorting";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "News category";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(690, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Theme";
            // 
            // ThemeCB
            // 
            this.ThemeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ThemeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeCB.FormattingEnabled = true;
            this.ThemeCB.Items.AddRange(new object[] {
            "Deep sky blue",
            "Green",
            "Yellow",
            "Crimson red",
            "Magenta",
            "Dark blue",
            "White",
            "Black"});
            this.ThemeCB.Location = new System.Drawing.Point(920, 48);
            this.ThemeCB.Name = "ThemeCB";
            this.ThemeCB.Size = new System.Drawing.Size(277, 30);
            this.ThemeCB.TabIndex = 14;
            this.ThemeCB.SelectedIndexChanged += new System.EventHandler(this.ThemeCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(690, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Interface language";
            // 
            // InterfaceLanguageCB
            // 
            this.InterfaceLanguageCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InterfaceLanguageCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InterfaceLanguageCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterfaceLanguageCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InterfaceLanguageCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InterfaceLanguageCB.FormattingEnabled = true;
            this.InterfaceLanguageCB.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.InterfaceLanguageCB.Location = new System.Drawing.Point(920, 225);
            this.InterfaceLanguageCB.Name = "InterfaceLanguageCB";
            this.InterfaceLanguageCB.Size = new System.Drawing.Size(277, 30);
            this.InterfaceLanguageCB.TabIndex = 16;
            this.InterfaceLanguageCB.SelectedIndexChanged += new System.EventHandler(this.InterfaceLanguageCB_SelectedIndexChanged);
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.FlatAppearance.BorderSize = 0;
            this.DateCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateCheckBox.Location = new System.Drawing.Point(920, 617);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(242, 26);
            this.DateCheckBox.TabIndex = 18;
            this.DateCheckBox.Text = "Show only today\'s news";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1319, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 725);
            this.rightPanel.TabIndex = 20;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 725);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1329, 10);
            this.bottomPanel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "News region";
            // 
            // NewsRegionCB
            // 
            this.NewsRegionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewsRegionCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewsRegionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewsRegionCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsRegionCB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewsRegionCB.FormattingEnabled = true;
            this.NewsRegionCB.Items.AddRange(new object[] {
            "All",
            "Moscow",
            "Volgograd"});
            this.NewsRegionCB.Location = new System.Drawing.Point(262, 613);
            this.NewsRegionCB.Name = "NewsRegionCB";
            this.NewsRegionCB.Size = new System.Drawing.Size(277, 30);
            this.NewsRegionCB.TabIndex = 22;
            this.NewsRegionCB.SelectedIndexChanged += new System.EventHandler(this.NewsRegionCB_SelectedIndexChanged);
            // 
            // UC_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewsRegionCB);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.DateCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InterfaceLanguageCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ThemeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.SortCB);
            this.Controls.Add(this.CountryCB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1329, 735);
            this.BackColorChanged += new System.EventHandler(this.UC_Settings_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CountryCB;
        private System.Windows.Forms.ComboBox SortCB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ThemeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox InterfaceLanguageCB;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NewsRegionCB;
    }
}
