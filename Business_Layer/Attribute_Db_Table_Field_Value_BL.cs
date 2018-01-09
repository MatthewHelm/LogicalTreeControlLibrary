using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;
using bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer;


namespace bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer
{
   class Attribute_Db_Table_Field_Value_BL
   {
      public static Boolean InserAttributeDbTableFieldValue(Attribute_Db_Table_Field_Value objAttribute_Db_Table_Field_Value)
      {
         Boolean insertSuccessful = false;
         insertSuccessful = Data_Layer.Attribute_Db_Table_Field_Value_DL.InsertAttributeDbTableFieldValueRecord(objAttribute_Db_Table_Field_Value);
         return insertSuccessful;
      }

      public static List<Attribute_Db_Table_Field_Value> GetAttributeDbTableFieldValueList(Attribute_Db_Table_Field objAttribute_Db_Table_Field)
      {
         List<Attribute_Db_Table_Field_Value> lstAttribute_Db_Table_Field_Value = null;
         lstAttribute_Db_Table_Field_Value = Data_Layer.Attribute_Db_Table_Field_Value_DL.GetAttributeDbTableFieldValueRecordList(objAttribute_Db_Table_Field);
         return lstAttribute_Db_Table_Field_Value;
      }
   }
}
