namespace Learning04
{
    class WritingAssignment : Assignment
    {
        private string _book;
        private string _author;

        public WritingAssignment(string studentName, string topic, string book, string author) : base(studentName,topic)
        {   
            _book = book;
            _author = author;
        }

        public string GetWritingInformation()
        {
            return $"{_book} by {_author}";
        }

    }
}