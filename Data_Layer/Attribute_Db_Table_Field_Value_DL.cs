using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer
{
   class Attribute_Db_Table_Field_Value_DL
   {
      public static bool InsertAttributeDbTableFieldValueRecord(Attribute_Db_Table_Field_Value objAttribute_Db_Table_Field_Value)
      {
         bool insertSuccessful = false;

         if (objAttribute_Db_Table_Field_Value == (Attribute_Db_Table_Field_Value)null)
         {
            return insertSuccessful;
         }

         string insertString = "INSERT INTO dbo.tblAttribute_Db_Table_Field_Value (attribute_db_table_field_value, attribute_db_table_field_id) VALUES ('{0}', {1})";

         insertString = string.Format(insertString, objAttribute_Db_Table_Field_Value.Attribute_Db_Table_Field_Value_Value, objAttribute_Db_Table_Field_Value.Attribute_Db_Table_Field_Id);

         insertSuccessful = Data_Layer.InsertTypeRecord(insertString, Data_Layer.ltConnectionString);

         return insertSuccessful;
      }


      public static List<Attribute_Db_Table_Field_Value> GetAttributeDbTableFieldValueRecordList(Attribute_Db_Table_Field objAttribute_Db_Table_Field)
      {
         String selectString = null;
         String insertString = null;

         List<Attribute_Db_Table_Field_Value> lstAttributeDbTableFieldValue = null;
         Attribute_Db_Table_Field_Value objAttributeDbTableFieldValue = null;

         if (objAttribute_Db_Table_Field == null)
         {
            return lstAttributeDbTableFieldValue;
         }

         lstAttributeDbTableFieldValue = new List<Attribute_Db_Table_Field_Value>();

         selectString = "SELECT " + objAttribute_Db_Table_Field.Attribute_Field_Id + ", " + objAttribute_Db_Table_Field.Attribute_Field_Desc + " FROM " + objAttribute_Db_Table_Field.Attribute_Db + '.' + objAttribute_Db_Table_Field.Attribute_Table;

         SqlConnection conn = new SqlConnection(Data_Layer.arcConnectionString);
         SqlCommand comm = new SqlCommand(selectString, conn);
         SqlDataReader rdr;

         try
         {
            conn.Open();
            rdr = comm.ExecuteReader();

            while (rdr.Read())
            {
               objAttributeDbTableFieldValue = new Attribute_Db_Table_Field_Value();
               objAttributeDbTableFieldValue.Attribute_Db_Table_Field_Value_Value = Convert.ToString(rdr["period_id"]);
               objAttributeDbTableFieldValue.Attribute_Db_Table_Field_Id = objAttribute_Db_Table_Field.Attribute_Db_Table_Field_Id;
               lstAttributeDbTableFieldValue.Add(objAttributeDbTableFieldValue);
            }

            for (int i = 0; i < lstAttributeDbTableFieldValue.Count; i++)
            {

               insertString = "INSERT INTO  [LogicalTree].[dbo].[tblAttribute_Db_Table_Field_Value] (attribute_db_table_field_value, attribute_db_table_field_id) values ('{0}', {1})";
               insertString = String.Format(insertString, lstAttributeDbTableFieldValue[i].Attribute_Db_Table_Field_Value_Value, lstAttributeDbTableFieldValue[i].Attribute_Db_Table_Field_Id);

               Data_Layer.InsertTypeRecord(insertString, Data_Layer.ltConnectionString);
            }
         }
         catch
         {
            lstAttributeDbTableFieldValue = null;
         }
         finally
         {
            conn.Close();
            comm.Dispose();
         }
         return lstAttributeDbTableFieldValue;
      }
   }
}
