using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PDFDocument : Encryptable
{
    private string numberOfPages;

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.NumberOfPages = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string NumberOfPages
    {
        get
        {
            return this.numberOfPages;
        }
        set
        {
            this.numberOfPages = value;
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
    }
}
