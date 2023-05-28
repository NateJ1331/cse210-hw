namespace Develop03
    {
        class Word 
        {
            private bool _isHidden = true;
            private string _word; 
            private string _underscores;

            public string GetWord(string word)
            {     
                if(_isHidden == true)
                {
                    return word;
                }
                
                else
                {
                    return _underscores;
                }
            }
        }

    }
