using System;
using System.IO;
using System.Collections.Generic;

namespace Develop03 
{
    class Scripture 
    {
        private string[] _words;
        public string[] GetWords()
        {
            UserInterface Ui = new UserInterface();
            string scripture = Ui.EnterScripture();
            char[] splitter = new char[]{' '};

            _words  = scripture.Split(splitter);

            return _words;

        }

    


    }
}