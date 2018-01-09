using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;
using bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer
{
   class LogicalTreeData_BL
   {
      public static String ConstructQueryString(Attribute_Db_Table_Field obj)
      {
         String selectString = null;

         if (obj == null)
         {
            return selectString;
         }

         selectString = "SELECT DISTINCT " + "i." + obj.Attribute_Field_Id + ", " + "i." + obj.Attribute_Field_Desc + " FROM " + obj.Attribute_Db + ".[dbo].[tblCoins] c " ;
         selectString = selectString + "INNER JOIN " + obj.Attribute_Db + "." + obj.Attribute_Table + " i ON c.issuing_authority_id = i." + obj.Attribute_Field_Id;

         return selectString;
      }

   }
}
