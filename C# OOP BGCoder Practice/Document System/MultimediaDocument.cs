using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultimediaDocument : BinaryDocument
{
    private string length;

    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
        {
            this.Length = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string Length
    {
        get
        {
            return this.length;
        }
        set
        {
            this.length = value;
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("length", this.Length));
    }
}