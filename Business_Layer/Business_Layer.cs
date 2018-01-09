using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;
using bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer
{
   class Business_Layer<T>
   {
      static public ObjectSaveType recordSaveType = ObjectSaveType.UpdateObject;

      public enum ObjectSaveType
      {
         InsertObject = 1,
         UpdateObject = 2
      }


      public static T ReturnCurrentTypeObject(BindingSource bindingSource)
      {
         T obj;
         obj = (T)bindingSource.Current;
         return obj;
      }


      public static String CreateQueryThatSelectsDistinctIdFieldValues(String db, String table, String idField)
      {
         String qry = null;

         if (String.IsNullOrEmpty(db) || String.IsNullOrEmpty(table) || String.IsNullOrEmpty(idField))
         {
            return qry;
         }

         qry = "SELECT DISTINCT" + idField + " FROM " + db + ".dbo." + table;

         return qry;
      }


      public static String GetCommaSeparatedList(List<String> lstIds)
      {
         if (lstIds == null)
            return null;

         String idList = null;

         idList = "(";

         for (int i = 0; i < lstIds.Count; i++)
         {
            idList = idList + lstIds[i];

            if (i + 1 == lstIds.Count)
            {
               idList = idList + ')';
            }
            else
            {
               idList = idList + ',';
            }
         }

         return idList;
      }


      public static String CreateQueryThatSelectsIdAndDescBasedOnListOfIdsAsInputCriteria(String db, String table, String idField, String descField, List<String> lstIds)
      {
         String qry = null;

         if (String.IsNullOrEmpty(db) || String.IsNullOrEmpty(table) || String.IsNullOrEmpty(idField) || (lstIds == null))
         {
            return qry;
         }

         String idList = GetCommaSeparatedList(lstIds);

         qry = "SELECT " + idField + ", " + descField + " FROM " + db + ".dbo." + table + " WHERE " + idField + " in " + idList;


         return qry;
      }
   }
}
