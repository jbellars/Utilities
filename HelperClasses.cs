using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class HelperClasses
    {
    }

    /// <summary>
    /// Used for populating RadComboBoxes or DropDownLists that need to be set 
    /// based on a Sorting Key other than the DataText or DataValue.
    /// </summary>
    public class IndexedTextValuePair
    {
        public string Sortkey { get; set; }
        public string DataText { get; set; }
        public string DataValue { get; set; }
    }

    /// <summary>
    /// Contains pertinent EDS data concerning a User.
    /// </summary>
    public class EdsPerson
    {
        public string NetId { get; set; }
        public string FullName { get; set; }
        public string Emplid { get; set; }
        public int PersonType { get; set; }
    }

    /// <summary>
    /// Typically used for encapsulating Text and Value pairs for RadComboBoxes or DropDownLists.
    /// </summary>
    public class TextValuePair
    {
        public string DataText { get; set; }

        public string DataValue { get; set; }
    }
}
