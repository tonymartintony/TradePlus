using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class BarcodeMasterConstants
    {
        public static readonly string SelectCommand = "SELECT * FROM barcode_master";
        public static readonly string SelectWithIdCommand = "SELECT * FROM barcode_master WHERE barcode_id=@barcode_id";
        public static readonly string OverviewSelectCommand = "SELECT * FROM barcode_master";  ///add necessary columns, addition joints for the overview
        public static readonly string UpdateProcedureName = "dbo.usp_BarcodeMasterUpdate";
    }  
}
