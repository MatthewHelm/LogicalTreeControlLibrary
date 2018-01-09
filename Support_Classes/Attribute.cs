using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes
{
   class Attribute
   {
      private int _attribute_id;
      private string _attribute_name;


      public Attribute()
      {

      }


      public int Attribute_Id
      {
         get
         {
            return _attribute_id;
         }

         set
         {
            _attribute_id = value;
         }
      }

      public string Attribute_Name
      {
         get
         {
            return _attribute_name;
         }

         set
         {
            _attribute_name = value;
         }
      }
   }
}
