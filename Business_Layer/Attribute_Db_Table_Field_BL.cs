using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;
using bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer
{
   class Attribute_Db_Table_Field_BL
   {
      public static bool InsertAttributeDbTableField(Attribute_Db_Table_Field objAttribute_Db_Table_Field)
      {
         bool insertSuccessful = false;
         insertSuccessful = Attribute_Db_Table_Field_DL.InsertAttributeDbTableFieldRecord(objAttribute_Db_Table_Field);
         return insertSuccessful;
      }


      public static bool UpdateAttributeDbTableField(Attribute_Db_Table_Field objAttribute_Db_Table_Field)
      {
         bool updateSuccessful = false;
         updateSuccessful = Attribute_Db_Table_Field_DL.UpdateAttributeDbTableFieldRecord(objAttribute_Db_Table_Field);
         return updateSuccessful;
      }

      public static bool DeleteAttributeDbTableField(Attribute_Db_Table_Field objAttribute_Db_Table_Field)
      {
         bool deleteSuccessful = false;
         deleteSuccessful = Attribute_Db_Table_Field_DL.DeleteAttributeDbTableFieldRecord(objAttribute_Db_Table_Field);
         return deleteSuccessful;
      }

      public static List<Attribute_Db_Table_Field> GetAttributeDbTableFieldList()
      {
         List<Attribute_Db_Table_Field> lstAttribute_Db_Table_Field = (List<Attribute_Db_Table_Field>)null;
         lstAttribute_Db_Table_Field = Attribute_Db_Table_Field_DL.GetAttributeDbTableFieldRecordList();
         return lstAttribute_Db_Table_Field;
      }

      public static List<String> GetDatabases()
      {
         List<String> lstDatabases = null;
         lstDatabases = Data_Layer.Attribute_Db_Table_Field_DL.GetDatabaseList("BCSWS7");
         return lstDatabases;
      }

      public static List<String> GetTables(String DatabaseName)
      {
         List<String> lstTables = null;
         lstTables = Data_Layer.Attribute_Db_Table_Field_DL.GetTableList(DatabaseName);
         return lstTables;
      }

      public static List<String> GetColumns(String tableName)
      {
         List<String> lstColumns = null;
         lstColumns = Data_Layer.Attribute_Db_Table_Field_DL.GetColumnsList(tableName);
         return lstColumns;
      }

      public static Attribute_Db_Table_Field GetAttributeDbTableFieldObjectGivenId(int id, List<Attribute_Db_Table_Field> lst)
      {
         Attribute_Db_Table_Field objAttribute_Db_Table_Field = null;

         if (lst == null)
         {
            return objAttribute_Db_Table_Field;
         }

         objAttribute_Db_Table_Field = new Attribute_Db_Table_Field();

         var obj  = (from i in lst
                    where i.Attribute_Id == id
                    select i).ToList();

         objAttribute_Db_Table_Field.Attribute_Id = obj[0].Attribute_Id;
         objAttribute_Db_Table_Field.Attribute_Db_Table_Field_Id = obj[0].Attribute_Db_Table_Field_Id;
         objAttribute_Db_Table_Field.Attribute_Db = obj[0].Attribute_Db;
         objAttribute_Db_Table_Field.Attribute_Table = obj[0].Attribute_Table;
         objAttribute_Db_Table_Field.Attribute_Field_Desc = obj[0].Attribute_Field_Desc;
         objAttribute_Db_Table_Field.Attribute_Field_Id = obj[0].Attribute_Field_Id;

         return objAttribute_Db_Table_Field;

      }

      public static List<LogicalTreeData> GenerateAndExecuteQuery(Attribute_Db_Table_Field objAttribute_Db_Table_Field)
      {
         List<LogicalTreeData> lstLogicalTreeData = null;
         lstLogicalTreeData = Attribute_Db_Table_Field_DL.GenerateAndExecuteQuery(objAttribute_Db_Table_Field);
         return lstLogicalTreeData;
      }
   }
}
