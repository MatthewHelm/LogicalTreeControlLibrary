using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcs.LogicalTree.LogicalTreeControlLibrary.Support_Classes;
using bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer;

namespace bcs.LogicalTree.LogicalTreeControlLibrary
{

   enum NodeType
   {
      RootNode,
      PassThroughNode,
      TerminalNode
   }


   class LogicalTreeNode :  TreeNode
   {


      public ComboBox m_ComboBox = new ComboBox();


      public ComboBox ComboBox
      {
         get
         {
            this.m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            return this.m_ComboBox;
         }
         set
         {
            this.m_ComboBox = value;
            this.m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
         }
      }

      private NodeType nodeType;

      public NodeType NodeType
      {
         get
         {
            return nodeType;
         }

         set
         {
            nodeType = value;
         }
      }


      private List<Support_Classes.Attribute> lstAttribute;


      // mch. 01.04.2018.  Added property.
      public List<Support_Classes.Attribute> LstAttribute
      {
         get
         {
            return lstAttribute;
         }

         set
         {
            lstAttribute = value;
         }

      }



      private List<Support_Classes.Attribute_Db_Table_Field> lstAttribute_Db_Table_Field;

      BindingSource bnsAttribute = new BindingSource();

      public LogicalTreeNode(string text) : base(text)
      {
         //this.BindCmbAttribute();
         //lstAttribute = bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer.Attribute_BL.GetAttributeList();
         //lstAttribute_Db_Table_Field = bcs.LogicalTree.LogicalTreeControlLibrary.Business_Layer.Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();
         //ComboBox.DataSource = lstAttribute;
      }


      public LogicalTreeNode(string text, List<Support_Classes.Attribute> lstAttribute, List<Attribute_Db_Table_Field> lstAttributeDbTableField) : base(text)
      {
         this.lstAttribute = lstAttribute;
         this.lstAttribute_Db_Table_Field = lstAttributeDbTableField;
      }

      // mch 01.04.2018.  Changed from private to public
      public void BindCmbAttribute()
      {
         bnsAttribute = new BindingSource();
         lstAttribute = Attribute_BL.GetAttributeList();
         bnsAttribute.DataSource = lstAttribute;
         ComboBox.DataSource = bnsAttribute.DataSource;
         ComboBox.DisplayMember = "Attribute_Name";
         ComboBox.ValueMember = "Attribute_Id";
      }

   }
}
