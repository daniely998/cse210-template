public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        string hideText = "";
        foreach (char c in _text)
        {
            hideText += "_";
        }
        _text = hideText;
        _isHidden = true;
    }

    // public void Show()
    // {

    // }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}