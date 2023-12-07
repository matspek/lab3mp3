using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3mp3
{
    public class Quiz
        {
            public List<Question> _questions;
            private string _title = string.Empty;
         //   public List<Question> Questions => _questions;
            public string Title => _title;

            public Quiz()
            {
                _questions = new List<Question>();
            }

        }
    }
