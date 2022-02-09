using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class CategoryMasterConstants
    {
        public static readonly string SelectCommand =
        "Select M.category_id,M.Category_name,T.Category_Name as ParentName,M.alias_name,level_name,M.description from category_master M" +
        " Left join (Select category_id,category_name from category_master) T " +
        " On T.category_id=M.parent_id JOIN level_category ON M.level_id = level_category.level_id";

        public static readonly string SelectWithIdCommand = "SELECT category_id,category_name,level_id,parent_id,alias_name,description,active FROM category_master WHERE level_id=@level_id-1";
        public static readonly string OverviewSelectCommand = "SELECT *  FROM category_master";  ///add necessary columns, addition joints for the overview
        public static readonly string UpdateProcedureName = "dbo.usp_CategoryMasterUpdate";
        public static readonly string SelectcatCommand = "SELECT *  FROM category_master where category_id = @category_id";

        public static readonly string SelectCategoryWithLevelID = "SELECT category_id,category_name FROM category_master where level_id = @LevelId";
        public static readonly string SelectCategoryWithLevelIDPromotion = "SELECT category_id,category_name,0 as Active FROM category_master where level_id = @LevelId";
        public static readonly string SelectWithParentID = "SELECT category_id,category_name  FROM category_master where parent_id = @ParentId";
    }
}
