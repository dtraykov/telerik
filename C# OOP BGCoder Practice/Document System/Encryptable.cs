using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Encryptable : BinaryDocument, IEncryptable
{
    private bool isEncrypted = false;

    public bool IsEncrypted
    {
        get
        {
            return this.isEncrypted;
        }
    }

    public void Encrypt()
    {
        this.isEncrypted = true;
    }

    public void Decrypt()
    {
        this.isEncrypted = false;
    }

    public override string ToString()
    {
        if (IsEncrypted)
        {
            return string.Format("{0}[encrypted]", this.GetType().Name);
        }
        else
        {
            return base.ToString();
        }
    }
}
