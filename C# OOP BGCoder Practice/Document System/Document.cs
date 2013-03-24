using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Document : IDocument
{
    public string Name { get; protected set; }
    public string Content { get; protected set; }

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }

    public override string ToString()
    {
        List<KeyValuePair<string, object>> properties =
           new List<KeyValuePair<string, object>>();
        this.SaveAllProperties(properties);
        properties.Sort((a, b) => a.Key.CompareTo(b.Key));

        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append("[");

        foreach (var prop in properties)
        {
            if (prop.Value != null)
            {
                result.Append(string.Format("{0}={1};", prop.Key, prop.Value));
            }
        }

        result.Length = result.Length - 1;
        result.Append("]");

        return result.ToString();
    }
}
