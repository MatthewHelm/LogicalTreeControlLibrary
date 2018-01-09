using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcs.LogicalTree.LogicalTreeControlLibrary
{
    public partial class ucLogicalTree: UserControl
    {
        public ucLogicalTree()
        {
            InitializeComponent();
        }

      private void ltvLogicalTree_AfterSelect(object sender, TreeViewEventArgs e)
      {

      }


      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);

         ltvLogicalTree = new LogicalTreeView();

      }
   }
}
