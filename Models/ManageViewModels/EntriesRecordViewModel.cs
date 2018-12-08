using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSecurity.Models.ManageViewModels
{
    public class JournalEntriesViewModel
    {
        public List<JournalEntry> EntryList { get; set; }
    }
}
