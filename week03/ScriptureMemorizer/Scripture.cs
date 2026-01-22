public class Scripture
{
    private Reference _reference;
    private List<Word> _word = new List<Word>();
    public Scripture( Reference reference, string verse)
    {
        _reference = reference;
        List<string> words = verse.Split(' ').ToList();
        foreach (string text in words)
        {
            Word newWord = new Word(text);
            _word.Add(newWord);
        }
    }
    public void HideRandomWords()
    {
        if (!IsCompletleyHidden())
        {
            for (int i = 0; i < 3; i++)
            {
            List<int> visableWords = new List<int>();
            foreach (Word word in _word)
            {
                if (!word.IsHidden())
                {
                    visableWords.Add(_word.IndexOf(word));
                }
            }
            Random rnd = new Random();
            if (visableWords.Count != 0)
                {
                    int num = visableWords[rnd.Next(0,visableWords.Count)];
                    _word[num].Hide();
                }
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
            foreach (Word word in _word)
            {
                displayText += word.GetDisplayText();
                displayText += " ";
            }
            return displayText;
    }
    public bool IsCompletleyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _word)
        {
            
            if (!word.IsHidden())
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;
    }
}