using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearchProject_WF
{
    public class Statistic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string Word { set; get; }
        public string PathOfFile { set; get; }
        public int Size { set; get; }
        public int NumOfWordFound { set; get; }
        public int NumOfReplacedWord { set; get; }

        public Statistic(string Word, string PathOfFile, int Size, int NumOfWordFound, int NumOfReplacedWord)
        {
            this.Word = Word;
            this.PathOfFile = PathOfFile;
            this.Size = Size;
            this.NumOfWordFound = NumOfWordFound;
            this.NumOfReplacedWord = NumOfReplacedWord;
        }

    }
}
