using System;

public class Reference
{
    private string _referenceText;

    public Reference(string reference)
    {
        _referenceText = reference;
    }

    public string GetDisplayText()
    {
        return _referenceText;
    }
}
