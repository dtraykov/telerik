using System;
using System.Collections.Generic;

public class DocumentSystem
{
    private static List<IDocument> documents = new List<IDocument>();

    static void Main()
    {


        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }

    private static void AddDocument(IDocument doc, string[] attributes)
    {
        string key;
        string value;

        foreach (var attribute in attributes)
        {
            string[] prop = attribute.Split('=');
            key = prop[0];
            value = prop[1];
            doc.LoadProperty(key, value);
        }

        if (doc.Name != null)
        {
            documents.Add(doc);
            Console.WriteLine("Document added: " + doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddTextDocument(string[] attributes)
    {
        AddDocument(new TextDocument(), attributes);
    }

    private static void AddPdfDocument(string[] attributes)
    {
        AddDocument(new PDFDocument(), attributes);
    }

    private static void AddWordDocument(string[] attributes)
    {
        AddDocument(new WordDocument(), attributes);
    }

    private static void AddExcelDocument(string[] attributes)
    {
        AddDocument(new ExcelDocument(), attributes);
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AddDocument(new AudioDocument(), attributes);
    }

    private static void AddVideoDocument(string[] attributes)
    {
        AddDocument(new VideoDocument(), attributes);
    }

    private static void ListDocuments()
    {
        if (documents.Count > 0)
        {
            foreach (var item in documents)
            {
                Console.WriteLine(item.ToString());
            }
        }
        else
        {
            Console.WriteLine("No documents found");
        }
    }

    private static void EncryptDocument(string name)
    {
        bool findDocument = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    Console.WriteLine("Document encrypted: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: {0}", name);
                }
                findDocument = true;
            }
        }
        if (!findDocument)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool findDocument = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Decrypt();
                    Console.WriteLine("Document decrypted: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document does not support decryption: {0}", name);
                }
                findDocument = true;
            }
        }
        if (!findDocument)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void EncryptAllDocuments()
    {
        bool findDocument = false;
        foreach (var doc in documents)
        {
            if (doc is IEncryptable)
            {
                ((IEncryptable)doc).Encrypt();
                findDocument = true;
            }
        }
        if (!findDocument)
        {
            Console.WriteLine("No encryptable documents found");
        }
        else
        {
            Console.WriteLine("All documents encrypted");
        }
    }

    private static void ChangeContent(string name, string content)
    {
        bool findDocument = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                if (doc is IEditable)
                {
                    ((IEditable)doc).ChangeContent(content);
                    Console.WriteLine("Document content changed: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document is not editable: {0}", name);
                }
                findDocument = true;
            }
        }
        if (!findDocument)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }
}
