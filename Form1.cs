using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LBTemplate
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        bool cbGroupsCreated = false;
        bool cbStudentCreated = false;
        String StudentName;
        bool isMale;
        bool fileLoaded;
        String[] text;
        String[] param;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyStudents");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [dbo].[Groups]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cb_Group.DataSource = dt;
            cb_Group.DisplayMember = "GroupName";
            cb_Group.ValueMember = "GroupID";
            cbGroupsCreated = true;
            cb_Group_SelectedIndexChanged(sender, e);
        }

        private void cb_Group_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (!cbGroupsCreated)
                return;

            String value = cb_Group.SelectedValue.ToString();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [dbo].[Students] WHERE [GroupID] = {value}", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cb_Student.DataSource = dt;
            cb_Student.DisplayMember = "FullName";
            cb_Student.ValueMember = "StudentID";
            cbStudentCreated = true;
            cb_Student_SelectedIndexChanged(sender, e);
        }

        private void cb_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbStudentCreated)
                return;

            String value = cb_Student.SelectedValue.ToString();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [dbo].[Students] WHERE [StudentID] = {value}", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow[] dr = dt.Select();
            StudentName = dr[0].ItemArray[2].ToString();
            isMale = dr[0].ItemArray[3].ToString() == "M";

            label2.Text = StudentName;
            label3.Text = isMale.ToString();

            if (fileLoaded)
                rtb_Template_Update();
        }

        private void rtb_Template_Update()
        {
            if (!fileLoaded)
                return;

            String value = cb_Student.SelectedValue.ToString();
            SqlCommand sqlCommand = new SqlCommand($"SELECT [Not done], [Homework], [Wrong] FROM [dbo].[Account] WHERE [StudentID] = {value}", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DataRow[] dr = dt.Select();
            param = new String[dr[0].ItemArray.Length];
            for (int i = 0; i < param.Length; ++i)
            {
                param[i] = dr[0].ItemArray[i].ToString();
            }           

            label2.Text = StudentName;
            label3.Text = isMale.ToString();

            rtb_Template.Clear();
            foreach (String str in text)
                rtb_Template.AppendText(FormatLine(str) + '\n');
        }

        private String FormatLine(String str)
        {
            String result = str.Replace("{Имя}", StudentName.Split(' ')[0]);
            result = result.Replace("{л/ла}", (isMale) ? "л": "ла");
            result = result.Replace("{ка/цы}", (isMale) ? "ка": "цы");
            result = result.Replace("{-/ла}", (isMale) ? "": "ла");
            result = result.Replace("{-/а}", (isMale) ? "": "а");
            for (int i = 0; i < param.Length; ++i)
                result = result.Replace("{" + i + "}", param[i]);
            return result;
        }

        private void btn_LoadTemplate_Click(object sender, EventArgs e)
        {
            fileLoaded = true;
            ofd_OpenTemplate.ShowDialog();
            String FileName = ofd_OpenTemplate.FileName;
            text = File.ReadAllLines(FileName, Encoding.UTF8);            
            rtb_Template_Update();
        }

        private void btn_ClearTemplate_Click(object sender, EventArgs e)
        {
            rtb_Template.Clear();
            fileLoaded = false;
        }
    }
}
