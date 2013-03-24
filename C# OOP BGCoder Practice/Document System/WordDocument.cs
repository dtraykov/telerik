using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordDocument : OfficeDocument, IEditable
{
    private string numberOfCharacters;

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
        {
            this.NumberOfCharacters = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string NumberOfCharacters
    {
        get
        {
            return this.numberOfCharacters;
        }
        set
        {
            this.numberOfCharacters = value;
        }
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
    }
}
