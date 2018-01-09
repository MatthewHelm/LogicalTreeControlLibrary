using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes
{
   class LogicalTreeData
   {
      private int _id;
      private String _desc;

      public LogicalTreeData()
      {

      }

      public int Id
      {
         get
         {
            return _id;
         }

         set
         {
            _id = value;
         }
      }

      public String Desc
      {
         get
         {
            return _desc;
         }

         set
         {
            _desc = value;
         }
      }
   }
}
