using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTableCS
{
    public class Game
    {
        private int correctAnswers;

        public int CorrectAnswers
        {
            get { return correctAnswers; }
        }

        private int wrongAnswers;

        public int WrongAnswers
        {
            get { return wrongAnswers; }
        }

        // time_start, time_end, difficult

        public Game()
        {
            correctAnswers = 0;
            wrongAnswers = 0;
        }

        public void Answer(bool result)
        {
            if(result) correctAnswers++;
            else wrongAnswers++;
        }
    }
}
