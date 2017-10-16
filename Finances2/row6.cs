using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances2
{
    /*
    public class AvailableComparison
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class AvailableGovernmentType
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class AvailableYear
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class StateLocal
    {
        public string x { get; set; }
        public double y { get; set; }
    }

    public class Data
    {
        public List<StateLocal> state_local { get; set; }
    }

    public class Row
    {
        public string key { get; set; }
        public int order { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string lexicon_name { get; set; }
        public string parent { get; set; }
        public object type { get; set; }
        public Data data { get; set; }
        public List<object> children { get; set; }
    }
    */
    public class StateLocal2
    {
        public string x { get; set; }
        public double y { get; set; }
    }
    /*
    public class Data2
    {
        public List<StateLocal2> state_local { get; set; }
    }

    public class TotalRow
    {
        public string key { get; set; }
        public int order { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string lexicon_name { get; set; }
        public string parent { get; set; }
        public object type { get; set; }
        public Data2 data { get; set; }
        public List<object> children { get; set; }
    }

    public class DataTable
    {
        public string key { get; set; }
        public int order { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string lexicon_name { get; set; }
        public string type { get; set; }
        public List<Row> rows { get; set; }
        public List<TotalRow> total_rows { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public string lexicon_name { get; set; }
        public string name { get; set; }
        public int precision { get; set; }
        public List<AvailableComparison> available_comparisons { get; set; }
        public List<AvailableGovernmentType> available_government_types { get; set; }
        public List<AvailableYear> available_years { get; set; }
        public object available_adjustments { get; set; }
        public string current_comparison { get; set; }
        public string current_government_type { get; set; }
        public string current_year { get; set; }
        public List<object> current_adjustments { get; set; }
        public List<DataTable> data_tables { get; set; }
    }
    */
}
