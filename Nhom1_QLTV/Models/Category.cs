using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Thể loại
    /// </summary>
    class Category
    {
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {

        }
        public Category(DataRow dataRow)
        {
            this.CategoryCode = dataRow["CategoryCode"].ToString();
            this.CategoryName = dataRow["CategoryName"].ToString();
        }
    }
}
