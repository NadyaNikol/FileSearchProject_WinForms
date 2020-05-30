using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearchProject_WF
{
    public class TopWords
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Word { set; get; }
        public int CountWords { set; get; }

        public TopWords(string Word, int CountWords)
        {
            this.Word = Word;
            this.CountWords = CountWords;
        }
    }
}
