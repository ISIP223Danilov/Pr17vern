using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pr17vern
{
    internal static class DisplayNames
    {
        private static readonly Dictionary<string, string> _displayNames = new Dictionary<string, string> {
            { "dname", "Название" },
            { "id", "ID" }
        };
        public static string get(string db_name)
        {
            string ret;
            if (!_displayNames.TryGetValue(db_name, out ret))
                ret = db_name;
            return ret;
        }
        public static void default_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = get(e.PropertyName);
        }
    }
}
