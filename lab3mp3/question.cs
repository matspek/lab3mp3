using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab3mp3
{
    public class Question
    {
        public string catorgy { get; }
        public string Statement { get; set; }
        public string[] Answers = new string[4];
        public int CorrectAnswer { get; set; }
    }
}
