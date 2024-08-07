using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUOATER_ALSALAHI
{
    public partial class HOME : Form
    {
       // private readonly object cbxItems;
       // private object value;
        public HOME()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.alsalahi.com");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void HOME_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyyy/mm/dd");
            Dictionary<int, string> itemsData = new Dictionary<int, string>();
            itemsData.Add(250, "لاب توب DELL");

            itemsData.Add(200, "لاب توب HP");

            itemsData.Add(320, "لاب توب سامسونج");

            itemsData.Add(150, "لاب توب توشيبا");

            itemsData.Add(270, "لاب توب ابل");

            itemsData.Add(240, "لاب توب LENOVO");

            itemsData.Add(10, "كيبورد عادي");

            itemsData.Add(15, "كيبورد عادي DELL");

            itemsData.Add(20, "كيبود بلوتوث ");

            itemsData.Add(9, " ماوس عادي DELL");

            itemsData.Add(7, "كيبورد عادي HP");

            itemsData.Add(8, "ماوس عادي HP");

            itemsData.Add(680, " طابعة ليزر");

            itemsData.Add(400, " طابعة حبر");

            itemsData.Add(550, " سوتش منفذ24");

            itemsData.Add(560, "روتر انترنت");

            itemsData.Add(450, "طابعة إبسون ");

            cbxitems.DataSource = new BindingSource(itemsData,dataMember: null);


          cbxitems.DisplayMember = "value";

            cbxitems.ValueMember = "key";

            txtbrice.Text = cbxitems.SelectedValue.ToString();

             
            foreach(DataGridViewColumn col in dgvimvoice.Columns)
            {
                col.DefaultCellStyle.ForeColor = Color.Navy;//لوان ما داخل ا
            }

            dgvimvoice.Columns[1].DefaultCellStyle.ForeColor = Color.Red;//الوان حقل الداتا
            dgvimvoice.Columns[3].DefaultCellStyle.ForeColor = Color.DarkGreen;//ايضا لون حقل الداتا

               

            txtname.Focus();
            txtname.Select();
            txtname.SelectAll();
        }

        private void TxtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtDate_MouseDown(object sender, MouseEventArgs e)
        {
          if(e.Button == MouseButtons.Right)
            {
                txtDate.ContextMenu = new ContextMenu();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtimvnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //برمجة زر الطباعة

           // ((form)PrintPreviewDialog).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {   

               printDocument1.Print(); 
            }
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                cbxitems.Focus();
            }
        }

        private void Cbxitems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtqty.Focus();//عند تشغيل الفورم يتم التركيز على خانة ادخال الاسم للادخال
                txtqty.SelectAll();

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {


            if (cbxitems.SelectedIndex <= -1) return;//عدم السماح باضافة صنف غير موجد في الخيارات

            //برمجة زر الاضافة 
            string item = cbxitems.Text;

            int qty = Convert.ToUInt16(txtqty.Text);

            int price = Convert.ToUInt16(txtbrice.Text);

            int subTotal = qty * price;

            object[] row = { item, qty, price, subTotal };

            dgvimvoice.Rows.Add(row);

            txtTotal.Text = (Convert.ToInt16(txtTotal.Text)+ subTotal) + " ";
        }

        private void Txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)//يضيف ويعيد الموشر الى حقل الاضافة من جديد
            {
                btnAdd.PerformClick();
                cbxitems.Focus();
                
            }
        }

        private void Cbxitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbrice.Text = cbxitems.SelectedValue.ToString();//السعر  يضهر بمجرد اختيار الصنف 

        }

        private void Txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;// الكمية اذا لقيتها ليست رقم وليست كنترول الغي
               //يعني لا يقبل الا ارقام فقط     
        }

        string oldqty = "1";
        //private Font f;

        private void Dgvimvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           if(dgvimvoice.CurrentRow !=null)
            {
                oldqty = dgvimvoice.CurrentRow.Cells["colqty"].Value + " ";
                    }


            // حدث اذا حاولت تعدل على الكمية ب  احرف  يلغي   التعديل
        }

        private void Dgvimvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //لما ينتهي التعديل  يعيد القيمة السابقة 

            if (dgvimvoice.CurrentRow != null)
            {

                string newQty = dgvimvoice.CurrentRow.Cells["colqty"].Value + " ";

                if (oldqty == newQty)
                {
                    return;
                }

                if (!Regex.IsMatch(newQty, "^\\ d + $"))
                {
                    dgvimvoice.CurrentRow.Cells["colqty"].Value = oldqty;


                }
                else
                {
                    int p = (int)dgvimvoice.CurrentRow.Cells["colrice"].Value;
                    int q = Convert.ToInt16(newQty);
                    dgvimvoice.CurrentRow.Cells["colsubtotal"].Value = (q * p);

                    int newtoTotal = 0;
                    foreach(DataGridViewRow r in dgvimvoice.Rows)
                    {
                        newtoTotal += Convert.ToInt32(r.Cells["colsubtotal"].Value);
                    }
                    txtTotal.Text = newtoTotal + " ";

                }

            }

        }

        private void Txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
           //تخطيط الطباعة
            int margin = 0;
            
            e.Graphics.DrawImage(Properties.Resources.ABDU2, 5, 5, 200, 200);//شعار في الفاتورة

            //e.Graphics.DrawString("#NO" + txtimvnom.Text, Brushes.Red,(e.PageBounds.Width - fontsizeNo.width)/2 ,margin);


                        float F = margin = 40 ;
            Font f = new Font("Arial", 18, FontStyle.Bold);


            String strNO = "#NO" + txtimvnom.Text;

            String strData = "التاريخ" + txtDate.Text;

            String strName = "اسم العميل"+" : " + txtname.Text;

            SizeF fontsizeNo = e.Graphics.MeasureString(strNO, f);

            SizeF fontSizeDate = e.Graphics.MeasureString(strData, f);

            SizeF fontSizeName = e.Graphics.MeasureString(strName, f);


          // e.Graphics.DrawImage(Properties.Resources.الشعار, margin, margin , 200 , 200);

            //int margin = 0;
                e.Graphics.DrawString( strNO,f,Brushes.Red,( e.PageBounds.Width - fontsizeNo.Width )/ 2, margin);//رقم الفاتورة

            e.Graphics.DrawString(strData, f, Brushes.Navy, e.PageBounds.Width - fontSizeDate.Width-margin, margin + fontsizeNo.Height);//طباعة التاريخ

            e.Graphics.DrawString(strName,f,Brushes.Navy,e.PageBounds.Width - fontSizeName.Width - margin,margin + fontsizeNo.Height + fontSizeDate.Height);//طباعة اسم الزبون

            float preHeights = margin + fontsizeNo.Height + fontSizeDate.Height + fontSizeName.Height + 70;

           // int margin = 0;

            e.Graphics.DrawRectangle(Pens.Black, margin, preHeights, e.PageBounds.Width - margin * 2, e.PageBounds.Height - margin - preHeights);//مريع الفاتوره

            float colHeigt = 60;

            float col1width = 300;
            float col2width = 125 + col1width;
            float col3width = 125 + col2width;
            float col4widh = 125 + col3width;
            
            e.Graphics.DrawLine(Pens.Black, margin, preHeights + colHeigt, e.PageBounds.Width - margin, preHeights + colHeigt);

            e.Graphics.DrawString("الصنف", f,Brushes.Black, e.PageBounds.Width - margin * 2-col1width, preHeights);//كتابة الصنف في الفاتورة
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin *2 - col1width, preHeights, e.PageBounds.Width - margin *2 - col1width, e.PageBounds.Height-margin);//يرسم العمود للصنف

            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHeights);//كتابة الكمية في الفاتورة
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin *2 -col2width, preHeights, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height -margin);//يرسم العمود للكنية

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHeights);//كتابة السعر في الفاتورة

            e.Graphics.DrawLine(Pens.Black,e.PageBounds.Width - margin *2 - col3width, preHeights, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height- margin);//يرسم العمود للسعر

            e.Graphics.DrawString("اجمالي", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4widh, preHeights);//كتابة اجمالي السعر في الفاتورة


            ///______________________________كتابة البيانات داخل الفاتورة______//

            float rowsHeight = 60;
            for(int x = 0; x < dgvimvoice.Rows.Count; x +=1)
            {


                e.Graphics.DrawString(dgvimvoice.Rows[x].Cells[0].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHeights + rowsHeight);
                e.Graphics.DrawString(dgvimvoice.Rows[x].Cells[1].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col2width, preHeights + rowsHeight);
                e.Graphics.DrawString(dgvimvoice.Rows[x].Cells[2].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col3width, preHeights + rowsHeight);
                e.Graphics.DrawString(dgvimvoice.Rows[x].Cells[3].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col4widh, preHeights + rowsHeight);


                e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeigt, e.PageBounds.Width - margin, preHeights + rowsHeight+ colHeigt);//رسم سطر تحت كل طلب
                rowsHeight += 60;
            }
            e.Graphics.DrawString("الاجمالي بالدولار", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col3width, preHeights + rowsHeight);
            e.Graphics.DrawString(txtTotal.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col4widh, preHeights + rowsHeight);

            e.Graphics.DrawLine(Pens.Black, margin, preHeights + rowsHeight + colHeigt, e.PageBounds.Width - margin, preHeights + rowsHeight + colHeigt);//رسم سطر تحت كل طلب


        }

    }

    }