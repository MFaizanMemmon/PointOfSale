using CosmaticProject.Database_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmaticProject.Source_Code
{
    class ComboHelper
    {
        public static void FillUserType(ComboBox cb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserTypeID");
            dt.Columns.Add("UserType");
            dt.Rows.Add("0", "--Select User Type--");
            var dbData = DataAccess.Retrive("select * from tblUserType");
            if (dbData != null)
            {
                if (dbData.Rows.Count > 0)
                {
                    foreach (DataRow type in dbData.Rows)
                    {
                        dt.Rows.Add(type[0], type[1]);
                    }
                }
                cb.DataSource = dt;
                cb.DisplayMember = "UserType";
                cb.ValueMember = "UserTypeID";
            }
        }

        public static void FillProductCategory(ComboBox cb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryID");
            dt.Columns.Add("Name");
            dt.Rows.Add("0", "--Select Product Category--");
            var dbData = DataAccess.Retrive("select * from tblCategory");
            if (dbData != null)
            {
                if (dbData.Rows.Count > 0)
                {
                    foreach (DataRow type in dbData.Rows)
                    {
                        dt.Rows.Add(type[0], type[2]);
                    }
                }
                cb.DataSource = dt;
                cb.DisplayMember = "Name";
                cb.ValueMember = "CategoryID";
            }
        }

        public static void FillProductUnit(ComboBox cb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UnitID");
            dt.Columns.Add("UnitName");
            dt.Rows.Add("0", "--Select Unit--");
            var dbData = DataAccess.Retrive("select * from tblProductUnit");
            if (dbData != null)
            {
                if (dbData.Rows.Count > 0)
                {
                    foreach (DataRow type in dbData.Rows)
                    {
                        dt.Rows.Add(type[0], type[1]);
                    }
                }
                cb.DataSource = dt;
                cb.DisplayMember = "UnitName";
                cb.ValueMember = "UnitID";
            }
        }

        public static void FillProductByCategory(ComboBox cb, string CategoryID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ItemID");
            dt.Columns.Add("ProductName");
            dt.Rows.Add("0", "--Select Product--");
            var dbData = DataAccess.Retrive("select * from tblProduct where CategoryID = '" + CategoryID + "'");
            if (dbData != null)
            {
                if (dbData.Rows.Count > 0)
                {
                    foreach (DataRow type in dbData.Rows)
                    {
                        dt.Rows.Add(type[0], type[9]);
                    }
                   
                }
                cb.DataSource = dt;
                cb.DisplayMember = "ProductName";
                cb.ValueMember = "ItemID";

            }
            else
            {
                cb.DataSource = null;
            }

        }
    }
}
