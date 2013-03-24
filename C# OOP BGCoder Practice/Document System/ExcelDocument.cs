using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExcelDocument : OfficeDocument
{
    private string numberOfRows;
    private string numberOfCols;

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
        {
            this.NumberOfRows = value;
        }
        else if (key=="cols")
        {
            this.NumberOfCols = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string NumberOfCols
    {
        get
        {
            return this.numberOfCols;
        }
        set
        {
            this.numberOfCols = value;
        }
    }

    public string NumberOfRows
    {
        get
        {
            return this.numberOfRows;
        }
        set
        {
            this.numberOfRows = value;
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
        output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
    }
}
