using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApuAnimalsHotel
{
    /// <summary>
    /// Created with help of MSDN https://support.microsoft.com/en-us/help/319401/how-to-sort-a-listview-control-by-a-column-in-visual-c
    /// this class is to handle multiple sorting for Animal listview
    /// This class implements the interface IComparer
    /// </summary>
    class ListViewItemSorter : IComparer
    {
        /// <summary>
        /// Defines the column to be sorted
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// Specifies what type of sort ordering to be used (Asc. or Desc.)
        /// </summary>
        private SortOrder sortOrder;
        /// <summary>
        /// Case insensitive comparer object.
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;

        /// <summary>
        /// Class constructor. Includes initialization of elements.
        /// </summary>
        public ListViewItemSorter()
        {
            ColumnToSort = 0;
            sortOrder = SortOrder.None; 
            ObjectCompare = new CaseInsensitiveComparer();
        }
        /// <summary>
        /// Method inherited from the interface IComparer, compares two case-insensitive objects.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listViewX, listViewY;

            //Cast objects to be compared to listviewItem objects
            listViewX = (ListViewItem)x;
            listViewY = (ListViewItem)y;

            //Compare method.
            compareResult = ObjectCompare.Compare(listViewX.SubItems[ColumnToSort].Text, listViewY.SubItems[ColumnToSort].Text);

            //Choose correct return based on comparison type
            if(sortOrder==SortOrder.Ascending)
            {
                return compareResult;
            }
            else if(sortOrder==SortOrder.Descending)
            {
                return (-compareResult);
            }
            else
            {
                return 0;
            }
        }
        //Getter and setter of column object
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        /// <summary>
        /// Getter and setter of the Sort order to be applied
        /// </summary>
        public SortOrder Order
        {
            set
            {
                sortOrder = value;
            }
            get
            {
                return sortOrder;
            }
        }
    }
}
