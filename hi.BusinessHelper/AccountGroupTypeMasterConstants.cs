using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    class AccountGroupTypeMasterConstants
    {
        public static readonly string SelectCommand = "SELECT * FROM account_group_type_master";
        public static readonly string SelectWithIdCommand = "SELECT * FROM account_group_type_master WHERE account_group_type_id=@account_group_type_id";
        public static readonly string OverviewSelectCommand = "SELECT * FROM account_group_type_master";  ///add necessary columns, addition joints for the overview
        public static readonly string UpdateProcedureName = "dbo.usp_AccountGroupTypeMasterUpdate";

        
        public static readonly string SelectAccountTypeDW = "SELECT account_group_type_id,account_group_type FROM account_group_type_master";
    }
}
