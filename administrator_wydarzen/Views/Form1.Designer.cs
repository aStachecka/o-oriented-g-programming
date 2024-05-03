namespace administrator_wydarzen.Views
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbEvent = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.cbPriorFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbEvent.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEvent
            // 
            this.gbEvent.BackColor = System.Drawing.Color.Pink;
            this.gbEvent.Controls.Add(this.btnAdd);
            this.gbEvent.Controls.Add(this.btnDelete);
            this.gbEvent.Controls.Add(this.btnLoad);
            this.gbEvent.Controls.Add(this.btnSave);
            this.gbEvent.Controls.Add(this.cbPriority);
            this.gbEvent.Controls.Add(this.label5);
            this.gbEvent.Controls.Add(this.cbType);
            this.gbEvent.Controls.Add(this.label4);
            this.gbEvent.Controls.Add(this.label3);
            this.gbEvent.Controls.Add(this.dateTimePicker);
            this.gbEvent.Controls.Add(this.label2);
            this.gbEvent.Controls.Add(this.tbDesc);
            this.gbEvent.Controls.Add(this.label1);
            this.gbEvent.Controls.Add(this.tbTitle);
            this.gbEvent.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEvent.Location = new System.Drawing.Point(12, 12);
            this.gbEvent.Name = "gbEvent";
            this.gbEvent.Size = new System.Drawing.Size(339, 536);
            this.gbEvent.TabIndex = 0;
            this.gbEvent.TabStop = false;
            this.gbEvent.Text = "Dane wydarzenia";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(74, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(74, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoad.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(74, 429);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(191, 39);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(74, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPriority.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Mało ważne",
            "Średnio ważne",
            "Bardzo ważne"});
            this.cbPriority.Location = new System.Drawing.Point(6, 291);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(326, 26);
            this.cbPriority.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Priorytet";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbType.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Rozrywka",
            "Zdrowie",
            "Sport",
            "Inne"});
            this.cbType.Location = new System.Drawing.Point(6, 239);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(326, 26);
            this.cbType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Pink;
            this.dateTimePicker.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(6, 188);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(326, 25);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis";
            // 
            // tbDesc
            // 
            this.tbDesc.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbDesc.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDesc.Location = new System.Drawing.Point(6, 108);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(326, 54);
            this.tbDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbTitle.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTitle.Location = new System.Drawing.Point(6, 57);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(326, 25);
            this.tbTitle.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.PaleVioletRed;
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.label8);
            this.gbFilter.Controls.Add(this.dateTimePickerFilter);
            this.gbFilter.Controls.Add(this.cbTypeFilter);
            this.gbFilter.Controls.Add(this.cbPriorFilter);
            this.gbFilter.Controls.Add(this.label7);
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(357, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1040, 77);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtrowanie";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFilter.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(871, 22);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(163, 49);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filtruj";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(591, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data";
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePickerFilter.CalendarTitleBackColor = System.Drawing.Color.Pink;
            this.dateTimePickerFilter.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFilter.Location = new System.Drawing.Point(591, 45);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(274, 25);
            this.dateTimePickerFilter.TabIndex = 13;
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbTypeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTypeFilter.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Rozrywka",
            "Zdrowie",
            "Sport",
            "Inne"});
            this.cbTypeFilter.Location = new System.Drawing.Point(292, 45);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(293, 26);
            this.cbTypeFilter.TabIndex = 14;
            // 
            // cbPriorFilter
            // 
            this.cbPriorFilter.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbPriorFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPriorFilter.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPriorFilter.FormattingEnabled = true;
            this.cbPriorFilter.Items.AddRange(new object[] {
            "Mało ważne",
            "Średnio ważne",
            "Bardzo ważne"});
            this.cbPriorFilter.Location = new System.Drawing.Point(6, 46);
            this.cbPriorFilter.Name = "cbPriorFilter";
            this.cbPriorFilter.Size = new System.Drawing.Size(280, 26);
            this.cbPriorFilter.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(288, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Typ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Priorytet";
            // 
            // lvEvents
            // 
            this.lvEvents.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chDesc,
            this.chDate,
            this.chType,
            this.chPriority});
            this.lvEvents.Cursor = System.Windows.Forms.Cursors.Help;
            this.lvEvents.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new System.Drawing.Point(357, 96);
            this.lvEvents.MultiSelect = false;
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(1040, 452);
            this.lvEvents.TabIndex = 3;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            this.lvEvents.SelectedIndexChanged += new System.EventHandler(this.selectEvent);
            // 
            // chTitle
            // 
            this.chTitle.Text = "Tytuł";
            this.chTitle.Width = 200;
            // 
            // chDesc
            // 
            this.chDesc.DisplayIndex = 4;
            this.chDesc.Text = "Opis";
            this.chDesc.Width = 500;
            // 
            // chDate
            // 
            this.chDate.DisplayIndex = 1;
            this.chDate.Text = "Data";
            this.chDate.Width = 95;
            // 
            // chType
            // 
            this.chType.DisplayIndex = 2;
            this.chType.Text = "Typ";
            this.chType.Width = 120;
            // 
            // chPriority
            // 
            this.chPriority.DisplayIndex = 3;
            this.chPriority.Text = "Priorytet";
            this.chPriority.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1409, 555);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Administrator wydarzeń";
            this.gbEvent.ResumeLayout(false);
            this.gbEvent.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEvent;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.ComboBox cbTypeFilter;
        private System.Windows.Forms.ComboBox cbPriorFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chPriority;
        private System.Windows.Forms.ColumnHeader chDesc;
        public System.Windows.Forms.ListView lvEvents;
    }
}

