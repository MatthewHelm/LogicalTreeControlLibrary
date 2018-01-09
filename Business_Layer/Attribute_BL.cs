using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support_Classes = bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;
using bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer
{
   class Attribute_BL
   {
      public static Boolean InsertAttribute(Support_Classes.Attribute objAttribute)
      {
         bool insertSuccessful = false;
         insertSuccessful = Attribute_DL.InsertAttributeRecord(objAttribute);
         return insertSuccessful;
      }

      public static List<Support_Classes.Attribute> GetAttributeList()
      {
         List<Support_Classes.Attribute> lstAttribute = null;
         lstAttribute = Data_Layer.Attribute_DL.GetAttributeRecordList();
         return lstAttribute;
      }


      public static Boolean UpdateAttribute(Support_Classes.Attribute objAttribute)
      {
         Boolean updateSuccessful = false;
         updateSuccessful = Attribute_DL.UpdateAttributeRecord(objAttribute);
         return updateSuccessful;
      }
   }
}
