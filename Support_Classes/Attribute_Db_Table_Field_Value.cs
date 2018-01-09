using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes
{
   class Attribute_Db_Table_Field_Value
   {
      private int _attribute_db_table_field_value_id;
      private string _attribute_db_table_field_value_value;
      private int _attribute_db_table_field_id;


      public Attribute_Db_Table_Field_Value()
      {
      }

      public int Attribute_Db_Table_Field_Value_Id
      {
         get
         {
            return _attribute_db_table_field_value_id;
         }

         set
         {
            _attribute_db_table_field_value_id = value;
         }
      }

      public string Attribute_Db_Table_Field_Value_Value
      {
         get
         {
            return _attribute_db_table_field_value_value;
         }

         set
         {
            _attribute_db_table_field_value_value = value;
         }
      }

      public int Attribute_Db_Table_Field_Id
      {
         get
         {
            return _attribute_db_table_field_id;
         }

         set
         {
            _attribute_db_table_field_id = value;
         }
      }
   }
}
