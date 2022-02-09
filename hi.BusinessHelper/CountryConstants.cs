using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public  static class CountryConstants
    {
        public static readonly string SelectCountryCommand = "SELECT country_id,country_name FROM  [dbo].[country_master] WHERE is_active=1";
    }
}
