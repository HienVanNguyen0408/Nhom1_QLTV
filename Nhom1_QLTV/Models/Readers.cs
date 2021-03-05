using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj độc giả
    /// </summary>
    class Readers
    {
        public string ReadersCode { get; set; }
        public string ReadersName { get; set; }
        public string Address { get; set; }
        public string CardCode { get; set; }

        /// <summary>
        /// Contructor
        /// </summary>
        public Readers(){

        }
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="dataRow"></param>
        public Readers(DataRow dataRow)
        {
            this.ReadersCode = dataRow["ReadersCode"].ToString();
            this.ReadersName = dataRow["ReadersName"].ToString();
            this.Address = dataRow["Address"].ToString();
            this.CardCode = dataRow["CardCode"].ToString();
        }
    }
}
