namespace Develop02
{
    ///<summary>
    ///The resposiblity of Entry is to record (or store) a 
    ///promt,response, and date
    ///<summary> 
    class Entry
    {
        string prompt;
        string response;
        string date;
        public string GetAsString()
        {
            return $"{prompt}\n{response}\n{date}\n";
        }
        public void Store (string prompt, string response, string date)
        { 
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }
}
