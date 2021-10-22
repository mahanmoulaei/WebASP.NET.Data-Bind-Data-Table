using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; //To allow calling Data classes properties and methods and members => for example DataSet or Datatable

namespace WebDataBindDataTable
{
    public partial class index : System.Web.UI.Page
    {
        //What is static?
        //With static classes, you cannot create objects of any static class and cannot access members (properties + methods) using an object.

        //Why use static? 
        //The compiler can check to make sure that no instance is ACCIDENTALLY ADDED.
        static DataTable dataTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            dataTable = CreateTable();
        }

        private static DataTable CreateTable()
        {
            //"dataSet" is an Object Variable - instance of the Object class!
            //Creating the table
            DataTable dataTable = new DataTable("Courses");

            //Creating columns of the table
            dataTable.Columns.Add("Number", typeof(string));
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("Duration", typeof(Int32));
            dataTable.Columns.Add("Teacher", typeof(string));

            //Creating rows of the table
            DataRow dataRow = dataTable.NewRow();
            dataRow["Number"] = "420-P16-AS";
            dataRow["Title"] = "Structured Programming";
            dataRow["Duration"] = 70;
            dataRow["Teacher"] = "Quang Hoang Cao";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Number"] = "420-P26-AS";
            dataRow["Title"] = "OOP";
            dataRow["Duration"] = 90;
            dataRow["Teacher"] = "Houria Houmel";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Number"] = "420-P35-AS";
            dataRow["Title"] = "DataBase";
            dataRow["Duration"] = 40;
            dataRow["Teacher"] = "Hoang Nguyen";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Number"] = "420-P55-AS";
            dataRow["Title"] = "ASP";
            dataRow["Duration"] = 70;
            dataRow["Teacher"] = "Dimitri";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Number"] = "420-P95-AS";
            dataRow["Title"] = "Android";
            dataRow["Duration"] = 20;
            dataRow["Teacher"] = "Alex Vilvert";
            dataTable.Rows.Add(dataRow);

            return dataTable;
        }

        protected void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable table = dataTable.Clone();
            //Different Method As Previous Line Using On Next Line
            foreach(DataRow row in dataTable.Rows)
            {
                if (row["Number"].ToString() == lstCourses.SelectedItem.Text)
                {
                    txtNumber.Text = row["Number"].ToString();
                    txtTitle.Text = row["Title"].ToString();
                    txtDuration.Text = row["Duration"].ToString();
                    txtTeacher.Text = row["Teacher"].ToString();
                    break;
                }
            }
        }

        protected void cboTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = dataTable.Clone();

            if (!Page.IsPostBack)
            {
                lstCourses.DataTextField = "Number";
            }
        }

        protected void gridResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}