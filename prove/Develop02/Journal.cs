using System.Collections.Generic;

namespace Develop02
{
class Journal
    {
      public List<Entry> entries;

      public Journal ()
      {
        entries = new List<Entry>();
      }

      public List<Entry> GetAllEntries()
      {
        return entries;
      }

      public void StoreEntry (Entry entry)
      {
        entries.Add(entry); 
        
      }

    }
}