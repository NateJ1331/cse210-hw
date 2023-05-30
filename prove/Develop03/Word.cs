namespace Develop03
    {
        class Word 
        {   
            public string hide(string word)
            {
                string underscores = "";

                for(int i = 0; i < word.Length; i++)
                {
                    underscores = underscores + "_" ;
                }
                
                underscores = underscores + " ";
                return underscores;
            }
        

    }
