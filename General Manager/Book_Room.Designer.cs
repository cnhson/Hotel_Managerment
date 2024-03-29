﻿
namespace General_Manager.Form
{
    partial class Book_Room
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcheckinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcheckoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new General_Manager.HotelDataSet();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.book_btn = new System.Windows.Forms.Button();
            this.room_lb = new DevExpress.XtraEditors.LabelControl();
            this.roompanel = new DevExpress.XtraEditors.PanelControl();
            this.max_lb = new DevExpress.XtraEditors.LabelControl();
            this.max_tb = new DevExpress.XtraEditors.TextEdit();
            this.cost_lb = new DevExpress.XtraEditors.LabelControl();
            this.cost_tb = new DevExpress.XtraEditors.TextEdit();
            this.roomtype_cb = new System.Windows.Forms.ComboBox();
            this.checkout_picker = new System.Windows.Forms.DateTimePicker();
            this.checkout_lb = new DevExpress.XtraEditors.LabelControl();
            this.checkin_picker = new System.Windows.Forms.DateTimePicker();
            this.checkin_lb = new DevExpress.XtraEditors.LabelControl();
            this.roomtype_lb = new DevExpress.XtraEditors.LabelControl();
            this.roomid_lb = new DevExpress.XtraEditors.LabelControl();
            this.roomid_tb = new DevExpress.XtraEditors.TextEdit();
            this.customer_lb = new DevExpress.XtraEditors.LabelControl();
            this.title_lb = new DevExpress.XtraEditors.LabelControl();
            this.customerpanel = new DevExpress.XtraEditors.PanelControl();
            this.bdate_picker = new System.Windows.Forms.DateTimePicker();
            this.address_lb = new DevExpress.XtraEditors.LabelControl();
            this.address_tb = new DevExpress.XtraEditors.TextEdit();
            this.bdate_lb = new DevExpress.XtraEditors.LabelControl();
            this.phone_lb = new DevExpress.XtraEditors.LabelControl();
            this.phone_tb = new DevExpress.XtraEditors.TextEdit();
            this.name_lb = new DevExpress.XtraEditors.LabelControl();
            this.name_tb = new DevExpress.XtraEditors.TextEdit();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.roomTableAdapter = new General_Manager.HotelDataSetTableAdapters.RoomTableAdapter();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roompanel)).BeginInit();
            this.roompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomid_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerpanel)).BeginInit();
            this.customerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.address_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.dataGridView1);
            this.fluentDesignFormContainer1.Controls.Add(this.update_btn);
            this.fluentDesignFormContainer1.Controls.Add(this.cancel_btn);
            this.fluentDesignFormContainer1.Controls.Add(this.book_btn);
            this.fluentDesignFormContainer1.Controls.Add(this.room_lb);
            this.fluentDesignFormContainer1.Controls.Add(this.roompanel);
            this.fluentDesignFormContainer1.Controls.Add(this.customer_lb);
            this.fluentDesignFormContainer1.Controls.Add(this.title_lb);
            this.fluentDesignFormContainer1.Controls.Add(this.customerpanel);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 30);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1097, 702);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cbdateDataGridViewTextBoxColumn,
            this.caddressDataGridViewTextBoxColumn,
            this.cphoneDataGridViewTextBoxColumn,
            this.rtypeDataGridViewTextBoxColumn,
            this.rcheckinDataGridViewTextBoxColumn,
            this.rcheckoutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 439);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 245);
            this.dataGridView1.TabIndex = 8;
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "rid";
            this.ridDataGridViewTextBoxColumn.HeaderText = "Room ID";
            this.ridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            this.ridDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cbdateDataGridViewTextBoxColumn
            // 
            this.cbdateDataGridViewTextBoxColumn.DataPropertyName = "cbdate";
            this.cbdateDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.cbdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cbdateDataGridViewTextBoxColumn.Name = "cbdateDataGridViewTextBoxColumn";
            this.cbdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // caddressDataGridViewTextBoxColumn
            // 
            this.caddressDataGridViewTextBoxColumn.DataPropertyName = "caddress";
            this.caddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.caddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caddressDataGridViewTextBoxColumn.Name = "caddressDataGridViewTextBoxColumn";
            this.caddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cphoneDataGridViewTextBoxColumn
            // 
            this.cphoneDataGridViewTextBoxColumn.DataPropertyName = "cphone";
            this.cphoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cphoneDataGridViewTextBoxColumn.Name = "cphoneDataGridViewTextBoxColumn";
            this.cphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // rtypeDataGridViewTextBoxColumn
            // 
            this.rtypeDataGridViewTextBoxColumn.DataPropertyName = "rtype";
            this.rtypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.rtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rtypeDataGridViewTextBoxColumn.Name = "rtypeDataGridViewTextBoxColumn";
            this.rtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rcheckinDataGridViewTextBoxColumn
            // 
            this.rcheckinDataGridViewTextBoxColumn.DataPropertyName = "rcheckin";
            this.rcheckinDataGridViewTextBoxColumn.HeaderText = "Check In";
            this.rcheckinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcheckinDataGridViewTextBoxColumn.Name = "rcheckinDataGridViewTextBoxColumn";
            this.rcheckinDataGridViewTextBoxColumn.Width = 125;
            // 
            // rcheckoutDataGridViewTextBoxColumn
            // 
            this.rcheckoutDataGridViewTextBoxColumn.DataPropertyName = "rcheckout";
            this.rcheckoutDataGridViewTextBoxColumn.HeaderText = "Check Out";
            this.rcheckoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rcheckoutDataGridViewTextBoxColumn.Name = "rcheckoutDataGridViewTextBoxColumn";
            this.rcheckoutDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.update_btn.Location = new System.Drawing.Point(747, 346);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(131, 37);
            this.update_btn.TabIndex = 7;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.cancel_btn.Location = new System.Drawing.Point(945, 346);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(131, 37);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // book_btn
            // 
            this.book_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.book_btn.Location = new System.Drawing.Point(556, 346);
            this.book_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_btn.Name = "book_btn";
            this.book_btn.Size = new System.Drawing.Size(131, 37);
            this.book_btn.TabIndex = 5;
            this.book_btn.Text = "Book";
            this.book_btn.UseVisualStyleBackColor = true;
            this.book_btn.Click += new System.EventHandler(this.book_btn_Click);
            // 
            // room_lb
            // 
            this.room_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.room_lb.Appearance.Options.UseFont = true;
            this.room_lb.Appearance.Options.UseForeColor = true;
            this.room_lb.Location = new System.Drawing.Point(41, 68);
            this.room_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.room_lb.Name = "room_lb";
            this.room_lb.Size = new System.Drawing.Size(63, 29);
            this.room_lb.TabIndex = 4;
            this.room_lb.Text = "Room";
            // 
            // roompanel
            // 
            this.roompanel.Appearance.BackColor = System.Drawing.Color.Black;
            this.roompanel.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.roompanel.Appearance.BorderColor = System.Drawing.Color.Black;
            this.roompanel.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.roompanel.Appearance.Options.UseBackColor = true;
            this.roompanel.Appearance.Options.UseBorderColor = true;
            this.roompanel.Appearance.Options.UseForeColor = true;
            this.roompanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.roompanel.Controls.Add(this.max_lb);
            this.roompanel.Controls.Add(this.max_tb);
            this.roompanel.Controls.Add(this.cost_lb);
            this.roompanel.Controls.Add(this.cost_tb);
            this.roompanel.Controls.Add(this.roomtype_cb);
            this.roompanel.Controls.Add(this.checkout_picker);
            this.roompanel.Controls.Add(this.checkout_lb);
            this.roompanel.Controls.Add(this.checkin_picker);
            this.roompanel.Controls.Add(this.checkin_lb);
            this.roompanel.Controls.Add(this.roomtype_lb);
            this.roompanel.Controls.Add(this.roomid_lb);
            this.roompanel.Controls.Add(this.roomid_tb);
            this.roompanel.Location = new System.Drawing.Point(17, 86);
            this.roompanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roompanel.Name = "roompanel";
            this.roompanel.Size = new System.Drawing.Size(519, 316);
            this.roompanel.TabIndex = 3;
            // 
            // max_lb
            // 
            this.max_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.max_lb.Appearance.Options.UseFont = true;
            this.max_lb.Appearance.Options.UseForeColor = true;
            this.max_lb.Location = new System.Drawing.Point(278, 217);
            this.max_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.max_lb.Name = "max_lb";
            this.max_lb.Size = new System.Drawing.Size(153, 24);
            this.max_lb.TabIndex = 16;
            this.max_lb.Text = "Maximum people";
            // 
            // max_tb
            // 
            this.max_tb.Enabled = false;
            this.max_tb.Location = new System.Drawing.Point(278, 256);
            this.max_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.max_tb.Name = "max_tb";
            this.max_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.max_tb.Properties.Appearance.Options.UseFont = true;
            this.max_tb.Size = new System.Drawing.Size(224, 30);
            this.max_tb.TabIndex = 15;
            // 
            // cost_lb
            // 
            this.cost_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cost_lb.Appearance.Options.UseFont = true;
            this.cost_lb.Appearance.Options.UseForeColor = true;
            this.cost_lb.Location = new System.Drawing.Point(24, 217);
            this.cost_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cost_lb.Name = "cost_lb";
            this.cost_lb.Size = new System.Drawing.Size(40, 24);
            this.cost_lb.TabIndex = 14;
            this.cost_lb.Text = "Cost";
            // 
            // cost_tb
            // 
            this.cost_tb.Enabled = false;
            this.cost_tb.Location = new System.Drawing.Point(24, 256);
            this.cost_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cost_tb.Name = "cost_tb";
            this.cost_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.cost_tb.Properties.Appearance.Options.UseFont = true;
            this.cost_tb.Size = new System.Drawing.Size(224, 30);
            this.cost_tb.TabIndex = 13;
            // 
            // roomtype_cb
            // 
            this.roomtype_cb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.roomtype_cb.FormattingEnabled = true;
            this.roomtype_cb.Location = new System.Drawing.Point(278, 68);
            this.roomtype_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomtype_cb.Name = "roomtype_cb";
            this.roomtype_cb.Size = new System.Drawing.Size(223, 32);
            this.roomtype_cb.TabIndex = 12;
            this.roomtype_cb.SelectedIndexChanged += new System.EventHandler(this.roomtype_cb_SelectedIndexChanged);
            // 
            // checkout_picker
            // 
            this.checkout_picker.CustomFormat = "  dd / MM / yyyy ";
            this.checkout_picker.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.checkout_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkout_picker.Location = new System.Drawing.Point(278, 162);
            this.checkout_picker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkout_picker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.checkout_picker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.checkout_picker.Name = "checkout_picker";
            this.checkout_picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkout_picker.Size = new System.Drawing.Size(223, 32);
            this.checkout_picker.TabIndex = 11;
            // 
            // checkout_lb
            // 
            this.checkout_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkout_lb.Appearance.Options.UseFont = true;
            this.checkout_lb.Appearance.Options.UseForeColor = true;
            this.checkout_lb.Location = new System.Drawing.Point(278, 127);
            this.checkout_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkout_lb.Name = "checkout_lb";
            this.checkout_lb.Size = new System.Drawing.Size(91, 24);
            this.checkout_lb.TabIndex = 10;
            this.checkout_lb.Text = "Check Out";
            // 
            // checkin_picker
            // 
            this.checkin_picker.CustomFormat = "  dd / MM / yyyy ";
            this.checkin_picker.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.checkin_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkin_picker.Location = new System.Drawing.Point(24, 162);
            this.checkin_picker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkin_picker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.checkin_picker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.checkin_picker.Name = "checkin_picker";
            this.checkin_picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkin_picker.Size = new System.Drawing.Size(223, 32);
            this.checkin_picker.TabIndex = 9;
            // 
            // checkin_lb
            // 
            this.checkin_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkin_lb.Appearance.Options.UseFont = true;
            this.checkin_lb.Appearance.Options.UseForeColor = true;
            this.checkin_lb.Location = new System.Drawing.Point(24, 127);
            this.checkin_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkin_lb.Name = "checkin_lb";
            this.checkin_lb.Size = new System.Drawing.Size(77, 24);
            this.checkin_lb.TabIndex = 6;
            this.checkin_lb.Text = "Check In";
            // 
            // roomtype_lb
            // 
            this.roomtype_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.roomtype_lb.Appearance.Options.UseFont = true;
            this.roomtype_lb.Appearance.Options.UseForeColor = true;
            this.roomtype_lb.Location = new System.Drawing.Point(278, 38);
            this.roomtype_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomtype_lb.Name = "roomtype_lb";
            this.roomtype_lb.Size = new System.Drawing.Size(42, 24);
            this.roomtype_lb.TabIndex = 4;
            this.roomtype_lb.Text = "Type";
            // 
            // roomid_lb
            // 
            this.roomid_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomid_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.roomid_lb.Appearance.Options.UseFont = true;
            this.roomid_lb.Appearance.Options.UseForeColor = true;
            this.roomid_lb.Location = new System.Drawing.Point(24, 38);
            this.roomid_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomid_lb.Name = "roomid_lb";
            this.roomid_lb.Size = new System.Drawing.Size(19, 24);
            this.roomid_lb.TabIndex = 2;
            this.roomid_lb.Text = "ID";
            // 
            // roomid_tb
            // 
            this.roomid_tb.Location = new System.Drawing.Point(24, 69);
            this.roomid_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomid_tb.Name = "roomid_tb";
            this.roomid_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.roomid_tb.Properties.Appearance.Options.UseFont = true;
            this.roomid_tb.Size = new System.Drawing.Size(224, 30);
            this.roomid_tb.TabIndex = 0;
            // 
            // customer_lb
            // 
            this.customer_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.customer_lb.Appearance.Options.UseFont = true;
            this.customer_lb.Appearance.Options.UseForeColor = true;
            this.customer_lb.Location = new System.Drawing.Point(580, 68);
            this.customer_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer_lb.Name = "customer_lb";
            this.customer_lb.Size = new System.Drawing.Size(106, 29);
            this.customer_lb.TabIndex = 1;
            this.customer_lb.Text = "Customer";
            // 
            // title_lb
            // 
            this.title_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.title_lb.Appearance.Options.UseFont = true;
            this.title_lb.Appearance.Options.UseForeColor = true;
            this.title_lb.Location = new System.Drawing.Point(432, 7);
            this.title_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(252, 36);
            this.title_lb.TabIndex = 2;
            this.title_lb.Text = "Room Registration";
            // 
            // customerpanel
            // 
            this.customerpanel.Appearance.BackColor = System.Drawing.Color.Black;
            this.customerpanel.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.customerpanel.Appearance.BorderColor = System.Drawing.Color.Black;
            this.customerpanel.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customerpanel.Appearance.Options.UseBackColor = true;
            this.customerpanel.Appearance.Options.UseBorderColor = true;
            this.customerpanel.Appearance.Options.UseForeColor = true;
            this.customerpanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.customerpanel.Controls.Add(this.bdate_picker);
            this.customerpanel.Controls.Add(this.address_lb);
            this.customerpanel.Controls.Add(this.address_tb);
            this.customerpanel.Controls.Add(this.bdate_lb);
            this.customerpanel.Controls.Add(this.phone_lb);
            this.customerpanel.Controls.Add(this.phone_tb);
            this.customerpanel.Controls.Add(this.name_lb);
            this.customerpanel.Controls.Add(this.name_tb);
            this.customerpanel.Location = new System.Drawing.Point(556, 86);
            this.customerpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(519, 222);
            this.customerpanel.TabIndex = 0;
            // 
            // bdate_picker
            // 
            this.bdate_picker.CustomFormat = "  dd / MM / yyyy ";
            this.bdate_picker.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.bdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdate_picker.Location = new System.Drawing.Point(24, 162);
            this.bdate_picker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bdate_picker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.bdate_picker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.bdate_picker.Name = "bdate_picker";
            this.bdate_picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bdate_picker.Size = new System.Drawing.Size(223, 32);
            this.bdate_picker.TabIndex = 9;
            // 
            // address_lb
            // 
            this.address_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.address_lb.Appearance.Options.UseFont = true;
            this.address_lb.Appearance.Options.UseForeColor = true;
            this.address_lb.Location = new System.Drawing.Point(278, 127);
            this.address_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(75, 24);
            this.address_lb.TabIndex = 8;
            this.address_lb.Text = "Address";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(278, 166);
            this.address_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address_tb.Name = "address_tb";
            this.address_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.address_tb.Properties.Appearance.Options.UseFont = true;
            this.address_tb.Size = new System.Drawing.Size(224, 30);
            this.address_tb.TabIndex = 7;
            // 
            // bdate_lb
            // 
            this.bdate_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bdate_lb.Appearance.Options.UseFont = true;
            this.bdate_lb.Appearance.Options.UseForeColor = true;
            this.bdate_lb.Location = new System.Drawing.Point(24, 127);
            this.bdate_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bdate_lb.Name = "bdate_lb";
            this.bdate_lb.Size = new System.Drawing.Size(77, 24);
            this.bdate_lb.TabIndex = 6;
            this.bdate_lb.Text = "Birthday";
            // 
            // phone_lb
            // 
            this.phone_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.phone_lb.Appearance.Options.UseFont = true;
            this.phone_lb.Appearance.Options.UseForeColor = true;
            this.phone_lb.Location = new System.Drawing.Point(278, 38);
            this.phone_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(56, 24);
            this.phone_lb.TabIndex = 4;
            this.phone_lb.Text = "Phone";
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(278, 69);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.phone_tb.Properties.Appearance.Options.UseFont = true;
            this.phone_tb.Size = new System.Drawing.Size(224, 30);
            this.phone_tb.TabIndex = 3;
            // 
            // name_lb
            // 
            this.name_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Appearance.ForeColor = System.Drawing.Color.Black;
            this.name_lb.Appearance.Options.UseFont = true;
            this.name_lb.Appearance.Options.UseForeColor = true;
            this.name_lb.Location = new System.Drawing.Point(24, 38);
            this.name_lb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(53, 24);
            this.name_lb.TabIndex = 2;
            this.name_lb.Text = "Name";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(24, 69);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_tb.Name = "name_tb";
            this.name_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.name_tb.Properties.Appearance.Options.UseFont = true;
            this.name_tb.Size = new System.Drawing.Size(224, 30);
            this.name_tb.TabIndex = 0;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1097, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // Book_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 732);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Book_Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Book_Room_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roompanel)).EndInit();
            this.roompanel.ResumeLayout(false);
            this.roompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomid_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerpanel)).EndInit();
            this.customerpanel.ResumeLayout(false);
            this.customerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.address_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.PanelControl customerpanel;
        private DevExpress.XtraEditors.LabelControl title_lb;
        private DevExpress.XtraEditors.LabelControl customer_lb;
        private DevExpress.XtraEditors.TextEdit name_tb;
        private DevExpress.XtraEditors.LabelControl name_lb;
        private DevExpress.XtraEditors.LabelControl phone_lb;
        private DevExpress.XtraEditors.TextEdit phone_tb;
        private DevExpress.XtraEditors.LabelControl address_lb;
        private DevExpress.XtraEditors.TextEdit address_tb;
        private DevExpress.XtraEditors.LabelControl bdate_lb;
        private System.Windows.Forms.DateTimePicker bdate_picker;
        private DevExpress.XtraEditors.LabelControl room_lb;
        private DevExpress.XtraEditors.PanelControl roompanel;
        private System.Windows.Forms.ComboBox roomtype_cb;
        private System.Windows.Forms.DateTimePicker checkout_picker;
        private DevExpress.XtraEditors.LabelControl checkout_lb;
        private System.Windows.Forms.DateTimePicker checkin_picker;
        private DevExpress.XtraEditors.LabelControl checkin_lb;
        private DevExpress.XtraEditors.LabelControl roomtype_lb;
        private DevExpress.XtraEditors.LabelControl roomid_lb;
        private DevExpress.XtraEditors.TextEdit roomid_tb;
        private DevExpress.XtraEditors.LabelControl cost_lb;
        private DevExpress.XtraEditors.TextEdit cost_tb;
        private DevExpress.XtraEditors.LabelControl max_lb;
        private DevExpress.XtraEditors.TextEdit max_tb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button book_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcheckoutDataGridViewTextBoxColumn;
    }
}