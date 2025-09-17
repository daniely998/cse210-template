public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] textSplit = text.Split(" ");

        foreach (string part in textSplit)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(/*int numberToHide = 1*/)
    {
        Random random = new Random();
        Word word;
        do
        {
            int i = random.Next(0, _words.Count);
            word = _words[i];
        } while (word.isHidden() && !IsCompletelyHidden());
        word.Hide();
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            text += $" {word.GetDisplayText()}";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}