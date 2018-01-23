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
   class LogicalTreeView : TreeView
   {
      // private LogicalTreeNode m_CurrentNode = null;


      private LogicalTreeNode m_CurrentNode = null;
      private List<Attribute_Db_Table_Field> lstAttribute_Db_Table_Field;
      //     lstAttribute_Db_Table_Field

      // mch.  01.06.2018.  Added line below.
      private List<Support_Classes.Attribute> lstAttribute;


      private LogicalTreeNode n; // mch.  01.04.2018.  Moved n out from local variable

      public LogicalTreeView()
      {
            //List<Attribute_Db_Table_Field> lstAttribute_Table_Field = new List<Attribute_Db_Table_Field>();
            //lstAttribute_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();
            //String tmpStr = ((lstAttribute_Table_Field[0].Attribute_Db).Trim('[')).Trim(']');
            //LogicalTreeNode n = new LogicalTreeNode(tmpStr);
            //this.Nodes.Add(n);

            //  lstAttribute_Table_Field = new List<Attribute_Db_Table_Field>();
            // lstAttribute_Table_Field
            lstAttribute_Db_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();

         // mch.  01.06.2018.  Added line below.
         lstAttribute = Attribute_BL.GetAttributeList();

         // mch.  01.09.2018.  Test start 


         // Attribute_Db_Table_Field obj;

         //     obj = new Attribute_Db_Table_Field();


         List<Attribute_Db_Table_Field> lstAttr;
         Attribute_Db_Table_Field obj;

         lstAttr = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();

         
     //    Attribute_Db_Table_Field obj = (Attribute_Db_Table_Field) from att in lstAttribute where att.Attribute_Name == "Period" select att;

         obj = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldObjectGivenId(5, lstAttr);


         string sqlString = LogicalTreeData_BL.ConstructQueryString(obj);

         // mch.  01.09.2018.  End start 

         // lstAttribute_Table_Field
         String tmpStr = ((lstAttribute_Db_Table_Field[0].Attribute_Db).Trim('[')).Trim(']');

         // lstAttribute_Table_Field
         n = new LogicalTreeNode(tmpStr, lstAttribute, lstAttribute_Db_Table_Field);
         n.NodeType = NodeType.RootNode;



         this.Nodes.Add(n);
      }

      public LogicalTreeView(String text)
      {
         //List<Attribute_Db_Table_Field> lstAttribute_Table_Field = new List<Attribute_Db_Table_Field>();
         //lstAttribute_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();
         //String tmpStr = ((lstAttribute_Table_Field[0].Attribute_Db).Trim('[')).Trim(']');
         //LogicalTreeNode n = new LogicalTreeNode(tmpStr);
         //n.NodeType = NodeType.RootNode;
         //this.Nodes.Add(n);
         //m_CurrentNode = n;

         // lstAttribute_Table_Field = new List<Attribute_Db_Table_Field>();
         // lstAttribute_Table_Field
         lstAttribute_Db_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();

         // lstAttribute_Table_Field
         String tmpStr = ((lstAttribute_Db_Table_Field[0].Attribute_Db).Trim('[')).Trim(']');
         LogicalTreeNode n = new LogicalTreeNode(tmpStr);
         n.NodeType = NodeType.RootNode;
      }


      protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
      {
         //if (e.Button == MouseButtons.Right)
         //{
         //   if (e.Node.GetType() == typeof(LogicalTreeNode))
         //   {
         //      this.m_CurrentNode = (LogicalTreeNode)e.Node;
         //      this.Controls.Add(this.m_CurrentNode.ComboBox);
         //      this.m_CurrentNode.ComboBox.SetBounds(this.m_CurrentNode.Bounds.X - 1, this.m_CurrentNode.Bounds.Y - 2, this.m_CurrentNode.Bounds.Width + 25, this.m_CurrentNode.Bounds.Height - 10);


         //      this.m_CurrentNode.ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);
         //      this.m_CurrentNode.ComboBox.DropDownClosed += new EventHandler(ComboBox_LogicalTreeViewClosed);
         //   }
         //}


         if (e.Button == MouseButtons.Right)
         {
            if (e.Node.GetType() == typeof(LogicalTreeNode))
            {
               this.m_CurrentNode = (LogicalTreeNode)e.Node;
               this.m_CurrentNode.BindCmbAttribute();  // mch. 01.04.2018.  Moved line from LogicalTreeNode constructor to here.
               this.m_CurrentNode.m_ComboBox.DataSource = this.m_CurrentNode.LstAttribute;
               this.Controls.Add(this.m_CurrentNode.ComboBox);
               this.m_CurrentNode.ComboBox.SetBounds(this.m_CurrentNode.Bounds.X + 112, this.m_CurrentNode.Bounds.Y - 2, this.m_CurrentNode.Bounds.Width + 25, this.m_CurrentNode.Bounds.Height - 10);

               this.m_CurrentNode.ComboBox.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);
               this.m_CurrentNode.ComboBox.DropDownClosed += new EventHandler(ComboBox_LogicalTreeViewClosed);
            }
         }
         if (e.Button == MouseButtons.Left)
         {
         }
      }


      void ComboBox_LogicalTreeViewClosed(object sender, EventArgs e)
      {
 //        HideComboBox();
      }

      void ComboBox_SelectedValueChanged(object sender, EventArgs e)
      {
         //      int idx = Convert.ToInt32(m_CurrentNode.m_ComboBox.SelectedValue);
         //      List<Attribute_Db_Table_Field> lstAttribute_Db_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();
         //      Attribute_Db_Table_Field objAttribute_Db_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldObjectGivenId(idx, lstAttribute_Db_Table_Field);
         //      List<LogicalTreeData> lstLogicalTreeData = Attribute_Db_Table_Field_BL.GenerateAndExecuteQuery(objAttribute_Db_Table_Field);
         ////      this.SelectedNode = m_CurrentNode;

         //      foreach (LogicalTreeData i in lstLogicalTreeData)
         //      {
         //         switch (m_CurrentNode.NodeType)
         //         {
         //            case NodeType.RootNode:
         //               LogicalTreeNode n = new LogicalTreeNode(i.Desc);
         //               n.NodeType = NodeType.PassThroughNode;
         //               this.m_CurrentNode.Nodes.Add(n);
         //               break;
         //            case NodeType.PassThroughNode:
         //               break;
         //            case NodeType.TerminalNode:
         //               break;
         //         }
         //      }


         int idx = Convert.ToInt32(m_CurrentNode.m_ComboBox.SelectedValue);
         //        List<Attribute_Db_Table_Field> lstAttribute_Db_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldList();
         Attribute_Db_Table_Field objAttribute_Db_Table_Field = Attribute_Db_Table_Field_BL.GetAttributeDbTableFieldObjectGivenId(idx, lstAttribute_Db_Table_Field);
         List<LogicalTreeData> lstLogicalTreeData = Attribute_Db_Table_Field_BL.GenerateAndExecuteQuery(objAttribute_Db_Table_Field);

         // mch.  01.04.2018.  commented out line below.
         //   this.SelectedNode = m_CurrentNode;
         // mch.  This is, I think, where I am having problems with creating child node for root node.
         // mch.  I think what i need to do here is create the ...
         //     n.Nodes.Add()

         foreach (LogicalTreeData i in lstLogicalTreeData)
         {
            switch (m_CurrentNode.NodeType)
            {
               case NodeType.RootNode:
                  LogicalTreeNode c = new LogicalTreeNode(i.Desc);

                  c.NodeType = NodeType.PassThroughNode;
                  // mch.  01.04.2018.  changed from m_CurrentNode to n
                  this.n.Nodes.Add(c);
                  break;
               case NodeType.PassThroughNode:
                  break;
               case NodeType.TerminalNode:
                  break;
            }
         }
         HideComboBox();

      }


      private void HideComboBox()
      {
         if (this.m_CurrentNode != null)
         {
            // Unregister the event listener
            this.m_CurrentNode.ComboBox.SelectedValueChanged -= ComboBox_SelectedValueChanged;
            this.m_CurrentNode.ComboBox.DropDownClosed -= ComboBox_LogicalTreeViewClosed;

            // Copy the selected text from the ComboBox to the TreeNode
    //        this.m_CurrentNode.Text = this.m_CurrentNode.ComboBox.Text;

            // Hide the ComboBox
            this.m_CurrentNode.ComboBox.Hide();
            this.m_CurrentNode.ComboBox.DroppedDown = false;

            // Remove the control from the TreeView's list of currently-displayed controls
            this.Controls.Remove(this.m_CurrentNode.ComboBox);

            // And return to the default state (no ComboBox displayed)
            // mch.  01.05.2018.  Commented out line below.
            //  this.m_CurrentNode = null;  
         }

      }
   }
}
