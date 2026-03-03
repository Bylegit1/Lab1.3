using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Tests
{
    [TestClass()]
    public class LetterPercentageLogicTests
    {
        [TestMethod()]
        public void CountLettersTestOnlyRussianLetters()
        {
            string proposal = "Приветмир";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(9, result);
        }

        [TestMethod()]
        public void CountLettersTestOnlyEnglishLetters()
        {
            string proposal = "HelloWorld";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(10, result);
        }

        [TestMethod()]
        public void CountLettersTestMixedRussianAndEnglish()
        {
            string proposal = "HelloПривет";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(11, result);
        }

        [TestMethod()]
        public void CountLettersTestWithPunctuation()
        {
            string proposal = "Привет, мир!";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(9, result); 
        }

        [TestMethod()]
        public void CountLettersTestWithDigits()
        {
            string proposal = "Привет123мир";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(9, result); 
        }

        [TestMethod()]
        public void CountLettersTestEmptyString()
        {
            string proposal = "";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CountLettersTestOnlyDigits()
        {
            string proposal = "1234567890";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CountLettersTestOnlyPunctuation()
        {
            string proposal = "!@#$%^&*()";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CountLettersTestComplexSentence()
        {
            string proposal = "Здравствуйте, дорогие друзья! 123";
            int result = LetterPercentageLogic.CountLetters(proposal);
            Assert.AreEqual(25, result);
        }

        [TestMethod()]
        public void CalculatePercentageTestHalfLetters()
        {
            int letterCount = 5;
            int proposalLength = 10;
            int result = LetterPercentageLogic.CalcPercentage(letterCount, proposalLength);
            Assert.AreEqual(50, result);
        }

        [TestMethod()]
        public void CalculatePercentageTestAllLetters()
        {
            int letterCount = 10;
            int proposalLength = 10;
            int result = LetterPercentageLogic.CalcPercentage(letterCount, proposalLength);
            Assert.AreEqual(100, result);
        }

        [TestMethod()]
        public void CalculatePercentageTestNoLetters()
        {
            int letterCount = 0;
            int proposalLength = 10;
            int result = LetterPercentageLogic.CalcPercentage(letterCount, proposalLength);
            Assert.AreEqual(0, result);
        }
    }
}