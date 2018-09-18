using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    class MultipleChoiceQuestion : Question
    {

        String[] possibleAnswers;
        int answerIndex;

        public MultipleChoiceQuestion(String questionText, String[] possibleAnswers, int answerIndex) : base(questionText)
        {
            this.possibleAnswers = possibleAnswers;
            this.answerIndex = answerIndex;
        }

        /**
         * getQuestion()
         * @return Adds newline after each possible answer
         */
        public override String getQuestion()
        {
            String fullQuestion = questionText + "\r\n";
            foreach (String s in possibleAnswers)
            // for (String s : possibleAnswers)
            {
                fullQuestion += s + "\r\n";
            }
            return fullQuestion;
        }

        public override String getAnswer()
        {
            return possibleAnswers[answerIndex];
        }

        public override bool checkAnswer(String answer)
        {
            //return (answer.equalsIgnoreCase(possibleAnswers[answerIndex]));
            return (answer.Equals(answer, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
