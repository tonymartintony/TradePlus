using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class BankMasterConstants
    {
        public static readonly string SelectCommand = "SELECT * FROM bank_master WHERE bank_id=@bank_id";
        public static readonly string SelectCommandsearch = "SELECT * FROM bank_master";
        public static readonly string SelectWithIdCommand = "SELECT * FROM bank_master WHERE bank_id=@bank_id";
        public static readonly string OverviewSelectCommand = "SELECT * FROM bank_master";  ///add necessary columns, addition joints for the overview
        public static readonly string UpdateProcedureName = "dbo.usp_BankMasterUpdate";
        public static readonly string SelectCommandaccount = "Select account_id,account_name from account_master where account_group_id=4";
    }  
}
