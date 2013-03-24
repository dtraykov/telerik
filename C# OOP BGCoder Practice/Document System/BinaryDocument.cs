using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryDocument : Document
{
    private string size;

    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
        {
            this.Size = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string Size
    {
        get
        {
            return this.size;
        }
        set
        {
            this.size = value;
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("size", this.Size));
    }
}

