namespace FUOATER_ALSALAHI
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtimvnom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxitems = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvimvoice = new System.Windows.Forms.DataGridView();
            this.colitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvimvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(230, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "شركة الصلاحي لتقنية المعلومات\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(310, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(265, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.alsalahi.com";
            this.linkLabel1.Click += new System.EventHandler(this.LinkLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // txtimvnom
            // 
            this.txtimvnom.ForeColor = System.Drawing.Color.Red;
            this.txtimvnom.Location = new System.Drawing.Point(139, 110);
            this.txtimvnom.Name = "txtimvnom";
            this.txtimvnom.Size = new System.Drawing.Size(136, 30);
            this.txtimvnom.TabIndex = 4;
            this.txtimvnom.Text = "00000123";
            this.txtimvnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtimvnom.TextChanged += new System.EventHandler(this.Txtimvnom_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.Color.Purple;
            this.txtDate.Location = new System.Drawing.Point(432, 110);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(168, 30);
            this.txtDate.TabIndex = 6;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.TextChanged += new System.EventHandler(this.TxtDate_TextChanged);
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDate_KeyPress);
            this.txtDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtDate_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(350, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "التاريخ:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtname
            // 
            this.txtname.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtname.Location = new System.Drawing.Point(139, 158);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(461, 30);
            this.txtname.TabIndex = 8;
            this.txtname.Text = "الاسم";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "اسم  الزبون";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(887, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "___________________________________________________________________________";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cbxitems
            // 
            this.cbxitems.FormattingEnabled = true;
            this.cbxitems.Location = new System.Drawing.Point(90, 229);
            this.cbxitems.Name = "cbxitems";
            this.cbxitems.Size = new System.Drawing.Size(273, 31);
            this.cbxitems.TabIndex = 10;
            this.cbxitems.SelectedIndexChanged += new System.EventHandler(this.Cbxitems_SelectedIndexChanged);
            this.cbxitems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbxitems_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "الصنف:";
            // 
            // txtbrice
            // 
            this.txtbrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtbrice.ForeColor = System.Drawing.Color.Black;
            this.txtbrice.Location = new System.Drawing.Point(204, 285);
            this.txtbrice.Name = "txtbrice";
            this.txtbrice.ReadOnly = true;
            this.txtbrice.Size = new System.Drawing.Size(159, 30);
            this.txtbrice.TabIndex = 13;
            this.txtbrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbrice.TextChanged += new System.EventHandler(this.TextBox2_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-3, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "السعربالدولار الامريكي\r\n";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtqty
            // 
            this.txtqty.ForeColor = System.Drawing.Color.Black;
            this.txtqty.Location = new System.Drawing.Point(379, 286);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(167, 30);
            this.txtqty.TabIndex = 15;
            this.txtqty.Text = "1";
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.TextChanged += new System.EventHandler(this.Txtqty_TextChanged);
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtqty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtqty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(438, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "الكمية:";
            // 
            // dgvimvoice
            // 
            this.dgvimvoice.AllowUserToAddRows = false;
            this.dgvimvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvimvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvimvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvimvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colitems,
            this.colqty,
            this.colrice,
            this.colsubtotal});
            this.dgvimvoice.Location = new System.Drawing.Point(16, 322);
            this.dgvimvoice.Name = "dgvimvoice";
            this.dgvimvoice.Size = new System.Drawing.Size(847, 110);
            this.dgvimvoice.TabIndex = 16;
            this.dgvimvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Dgvimvoice_CellBeginEdit);
            this.dgvimvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvimvoice_CellEndEdit);
            // 
            // colitems
            // 
            this.colitems.HeaderText = "الصنف";
            this.colitems.Name = "colitems";
            this.colitems.ReadOnly = true;
            // 
            // colqty
            // 
            this.colqty.HeaderText = "الكمية";
            this.colqty.Name = "colqty";
            // 
            // colrice
            // 
            this.colrice.HeaderText = "السعر";
            this.colrice.Name = "colrice";
            this.colrice.ReadOnly = true;
            // 
            // colsubtotal
            // 
            this.colsubtotal.HeaderText = "الاجمالي الفرعي";
            this.colsubtotal.Name = "colsubtotal";
            this.colsubtotal.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Purple;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.Yellow;
            this.txtTotal.Location = new System.Drawing.Point(552, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 33);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(576, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "الاجمالي";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(702, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 53);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnprint.Location = new System.Drawing.Point(786, 263);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(77, 53);
            this.btnprint.TabIndex = 20;
            this.btnprint.Text = "طياعة";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.Button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::FUOATER_ALSALAHI.Properties.Resources.ABDU2;
            this.pictureBox1.Location = new System.Drawing.Point(686, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 444);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvimvoice);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxitems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtimvnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HOME";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvimvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtimvnom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxitems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvimvoice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsubtotal;
    }
}

