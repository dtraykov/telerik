using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AudioDocument : MultimediaDocument
{
    private string sampleRate;

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.SampleRate = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string SampleRate
    {
        get
        {
            return this.sampleRate;
        }
        set
        {
            this.sampleRate = value;
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
    }
}