using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administrator_wydarzen.Views
{
    public class ListViewItemComparer : IComparer
    {
        private int column;
        private SortOrder sortOrder;

        public ListViewItemComparer(int column, SortOrder order)
        {
            this.column = column;
            sortOrder = order;
        }

        public int Compare(object x, object y)
        {
            int result;
            ListViewItem listViewItemX = x as ListViewItem;
            ListViewItem listViewItemY = y as ListViewItem;

            if (listViewItemX == null || listViewItemY == null)
                result = 0;
            else
                result = String.Compare(listViewItemX.SubItems[column].Text, listViewItemY.SubItems[column].Text);

            if (sortOrder == SortOrder.Descending)
                result *= -1;

            return result;
        }
    }
}
