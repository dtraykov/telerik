using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VideoDocument : MultimediaDocument
{
    private string frameRate;

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public string FrameRate
    {
        get
        {
            return this.frameRate;
        }
        set
        {
            this.frameRate = value;
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
    }
}