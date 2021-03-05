using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj thẻ thư viện
    /// </summary>
    class LibaryCard
    {
        public string CardCode { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Note { get; set; }
        
        /// <summary>
        /// Contructor
        /// </summary>
        public LibaryCard()
        {

        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="dataRow"></param>
        public LibaryCard(DataRow dataRow)
        {
            this.CardCode = dataRow["CardCode"].ToString();
            this.BeginDate = DateTime.Parse(dataRow["BeginDate"].ToString());
            this.ExpirationDate = DateTime.Parse(dataRow["ExpirationDate"].ToString());
            this.Note = dataRow["Note"].ToString();
        }
    }
}
