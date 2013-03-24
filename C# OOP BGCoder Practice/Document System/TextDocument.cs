using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextDocument : Document, IEditable
{
    private string charset;

    public override void LoadProperty(string key, string value)
    {
        if (key == "charset")
        {
            this.Charset = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string Charset
    {
        get
        {
            return this.charset;
        }
        set
        {
            this.charset = value;
        }
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("charset", this.Charset));
    }
}
