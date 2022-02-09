using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class CompanyConstants
    {
        public static readonly string SelectCompanyCommand = "SELECT company_id,company_name FROM  [dbo].[company_master]";
        public static readonly string UpdateCompnay = "UPDATE [dbo].[company_master] SET company_code=@CompanyCode,company_name=@CompanyName,print_name=@PrintName,description=@CompanyDescription,financialyear_id=@CompanyFinyr,address=@CompanyAddress, area=@CompanyArea,country_id=@CompanyCountry,telephone=@CompanyTel,zip=@CompanyZip,fax=@CompanyFax,email=@CompanyEmail,currency_id=@CompanyCurrency,logo=@CompanyLogo,project_name=@CompanyPname,project_logo=@CompanyPlogo,title=@CompanyTitle,version=@CompanyVersion,start_date=@CompanyStartdate,dateformat_id=@CompanyDisdate WHERE company_id=@ComapnyId";
        public static readonly string SelectCompanyWithIdCommand = "SELECT * FROM [dbo].[company_master] WHERE company_id=@ComapnyId";
        public static readonly string SelectCompanyCommandAll = "SELECT * FROM [dbo].[company_master] ";
    }
}
