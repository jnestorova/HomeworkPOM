using AutomationPractice.Factories;
using AutomationPractice.Models;
using AutomationPractice.Pages.PracticeFormPage;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using System;
using AutomationPractice.Pages;
using System.Net.Http.Headers;

namespace AutomationPractice.Tests.PracticeForm
{
    [TestFixture]
    public class PracticeFormTests : BaseTest
    {
        private PracticeFormPage _practiceFormPage;
        private PracticeFormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().
                GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation");
            CreateAccount();
            _practiceFormPage = new PracticeFormPage(Driver);
            _user = PracticeFormFactory.Create();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void CreateAnAccount_Success()
        {
            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("MY ACCOUNT", _practiceFormPage.Header.Text);
        }

        [Test]
        public void ValidateFirstNameIsRequiredField()
        {
            //Arange
            _user.FirstName = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("firstname is required.", _practiceFormPage.ErrorTextMessage.Text);
            _practiceFormPage.AssertErrorMessageBackgroundColor(_practiceFormPage.ErrorTextMessage);
        }

        [Test]
        public void ValidateLastNameIsRequiredField()
        {
            //Arange
            _user.LastName = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("lastname is required.", _practiceFormPage.ErrorTextMessage.Text);
            _practiceFormPage.AssertErrorMessageBackgroundColor(_practiceFormPage.ErrorTextMessage);
        }

        [Test]
        public void ValidatePasswordIsRequiredField()
        {
            //Arange
            _user.Password = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("passwd is required.", _practiceFormPage.ErrorTextMessage.Text);
        }

        [Test]
        public void ValidateCityIsRequiredField()
        {
            //Arange
            _user.City = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.AreEqual("city is required.", _practiceFormPage.ErrorTextMessage.Text);
        }

        [Test]
        public void VerifyInvalidPostCode()
        {
            //Arange
            _user.PostCode = "9456";

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            Assert.
                   AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", 
                            _practiceFormPage.ErrorTextMessage.Text);
        }
    }
}
