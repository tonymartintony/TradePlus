using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class AccountGroupMasterConstants
    {
        public static readonly string SelectCommand = "SELECT * FROM account_group_master";
        public static readonly string SelectWithIdCommand = "SELECT * FROM account_group_master WHERE account_group_id=@account_group_id";
        public static readonly string OverviewSelectCommand = "SELECT * FROM account_group_master";  ///add necessary columns, addition joints for the overview
        public static readonly string UpdateProcedureName = "dbo.usp_AccountGroupMasterUpdate";

        public static readonly string SelectAccountMasterDW = "SELECT account_group_id,account_group_name FROM account_group_master";
        public static readonly string SelectCommandGrid = "SELECT A.account_group_id,A.account_group_name,A.account_group_alias,B.account_group_name AS Parentname,C.account_group_type FROM account_group_master A "+
                                                            "LEFT JOIN account_group_master B ON A.parent_id=B.account_group_id"+
                                                            " JOIN account_group_type_master C ON A.account_group_type_id=C.account_group_type_id";
    }  
}
