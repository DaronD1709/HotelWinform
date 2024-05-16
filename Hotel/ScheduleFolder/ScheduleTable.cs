using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.ScheduleFolder
{
    public partial class ScheduleTable : Form
    {
        public ScheduleTable()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void ScheduleTable_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            // Tạo DataTable cho thời khóa biểu
            DataTable scheduleTable = new DataTable();

            // Thêm các cột tương ứng với 7 ngày trong tuần
            scheduleTable.Columns.Add("Shift");
            scheduleTable.Columns.Add("MONDAY");
            scheduleTable.Columns.Add("TUESDAY");
            scheduleTable.Columns.Add("WEDNESDAY");
            scheduleTable.Columns.Add("THURSDAY");
            scheduleTable.Columns.Add("FRIDAY");
            scheduleTable.Columns.Add("SATURDAY");
            scheduleTable.Columns.Add("SUNDAY");

            // Thêm các hàng cho 2 khung giờ
            DataRow row1 = scheduleTable.NewRow();
            row1["Shift"] = "7h - 19h";
            row1["MONDAY"] = "";
            row1["TUESDAY"] = "";
            row1["WEDNESDAY"] = "";
            row1["THURSDAY"] = "";
            row1["FRIDAY"] = "";
            row1["SATURDAY"] = "";
            row1["SUNDAY"] = "";
            scheduleTable.Rows.Add(row1);

            DataRow row2 = scheduleTable.NewRow();
            row2["Shift"] = "20h - 6h";
            row2["MONDAY"] = "";
            row2["TUESDAY"] = "";
            row2["WEDNESDAY"] = "";
            row2["THURSDAY"] = "";
            row2["FRIDAY"] = "";
            row2["SATURDAY"] = "";
            row2["SUNDAY"] = "";
            scheduleTable.Rows.Add(row2);

            // Gán DataTable cho DataGridView
            dataGridView1.DataSource = scheduleTable;



            // Thiết lập các thuộc tính hiển thị cho DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        }
    }
}
