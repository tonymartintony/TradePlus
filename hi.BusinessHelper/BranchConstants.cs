using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class BranchConstants
    {
        public static readonly string SelectBranchCommand = "SELECT branch_id,branch_code,branch_name,country_name,telephone,email,fax FROM [dbo].[branch_master] JOIN [dbo].[country_master] ON [dbo].[branch_master].country_id=[dbo].[country_master].country_id";
        public static readonly string SelectBranchWithIdCommand = "SELECT * FROM [dbo].[branch_master] WHERE branch_id = @BranchId";
        public static readonly string InsertBranchCommand = "INSERT INTO [dbo].[branch_master] values (@BranchCode,@BranchName,@Printname,@Companyid,@BranchAddress,@BranchArea,@BranchZip,@BranchCountry,@BranchTel,@BranchFax,@BranchEmail,@BranchRemark,@BranchStatus);SELECT SCOPE_IDENTITY()";
        public static readonly string UpdateBranchCommand = "UPDATE [dbo].[branch_master] SET [branch_code] = @BranchCode, [branch_name] =@BranchName,[print_Name]=@Printname,[company_id] = @Companyid,[address] =@BranchAddress,[area] = @BranchArea, [zip]=@BranchZip,[country_id]= @BranchCountry,[telephone] =@BranchTel,[fax]=@BranchFax,[email]=@BranchEmail,[remark]=@BranchRemark,[is_active]=@BranchStatus WHERE [branch_id]=@BranchId";
        public static readonly string SelectAllBranchCommand = "SELECT branch_id,branch_code,branch_name FROM [dbo].[branch_master]";
        public static readonly string DeleteBranchWithIdCommand = "DELETE [dbo].[branch_master] WHERE branch_id=@BranchId";

        public static readonly string BranchDeleteProcedure = "delete_entity";
        public static readonly string SearchBranch = "SELECT branch_id,branch_code,branch_name FROM [dbo].[branch_master] WHERE 1=1"+" @Branchcode ";

        public static readonly string SelectBranchWithCodeCommand = "SELECT * FROM [dbo].[branch_master] WHERE branch_code = @BranchCode";
        
    }
}
