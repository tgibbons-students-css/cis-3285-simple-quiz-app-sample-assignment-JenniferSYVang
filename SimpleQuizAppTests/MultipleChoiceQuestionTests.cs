using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleQuizApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication.Tests
{
    [TestClass()]
    public class MultipleChoiceQuestionTests
    {
        [TestMethod()]
        public void MultipleChoiceQuestionTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void getQuestion_NormalTest()
        {
            
            // Arrange
            String strQuestion = "Question\r\n1\r\n2\r\n3\r\n4";
            String[] strAnswers = { "1", "2", "3", "4" };

            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, 2);

            //Action
            String strResult = q.getQuestion();
            String answerResult = "Question\r\n1\r\n2\r\n3\r\n4";

            //Assert
            Assert.AreEqual(strQuestion, answerResult);
        }

        public void getQuestion_LongStringTest()
        {

            // Arrange
            String strQuestion = "abcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyzabcdefghijklmnopqurstuvwxyz";
            String strAnswer1 = "Answer LongStringTest 1";
            String strAnswer2 = "Answer LongStringTest 2";
            String strAnswer3 = "Answer LongStringTest 3";
            String strAnswer4 = "Answer LongStringTest 4, correct answer";
            String[] strAnswers = { strAnswer1, strAnswer2, strAnswer3, strAnswer4 };

            Question q = new MultipleChoiceQuestion(strQuestion, strAnswers, 3);

            //Action
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);
        }

        [TestMethod()]
        public void getAnswer_NormalTest()
        {
            // Arrange
            String strQuestion = "Test Get Answer 1";
            String strAnswer = "Answer for Get Answer 1";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act
            String strResult = q.getAnswer();

            //Assert
            Assert.AreEqual(strAnswer, strResult);
        }

        [TestMethod()]
        public void checkAnswer_NormalTest()
        {
            // Arrange
            String strQuestion = "Test checkAnswer NormalTest 1";
            String strAnswer = "Answer checkAnswer NormalTest 1";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswer));
        }
    }
}