using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POM;
using OpenQA.Selenium;
//using BDD.Utils;

namespace BDD.StepDefinitions
{

    [Binding]
    public sealed class LoginStepDefinition
    {
        private readonly IWebDriver driver;
        private readonly LoginPOM loginPage;

        public LoginStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
            this.loginPage = new LoginPOM(driver);

        }

        //static WebDriver driver = WebdriverUtils.getInstance();
        //LoginPOM loginPage = new LoginPOM(driver);

        [Given("user enters username (.*)")]
        public void GivenUserEntersUsername(string username)
        {
            loginPage.EnterUsername(username);

            //throw new PendingStepException();
        }

        [Given("user enters password (.*)")]
        public void GivenUserEntersPassword(string password)
        {
            loginPage.EnterPassword(password);

        }

        [When("user clicks login button")]
        public void WhenUserClicksLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        // 1. singleton найкраще підходить для logger, тому що вся інф-ція про тест екзекюшн повинна логуватись в 1 репорт;
        // 2. static не рекоменд. застосовувати до драйвера у випадку, коли тести раняться паралельно або асинхронно, тому що вони будуть використовувати 1 інстанс драйвера
        // і таким чином можуть змінювати контекст драйвера в неконтрольований спосіб 
        // ДЗ: 1.прочитати про Context Injection, передати поля через Context Injection https://docs.specflow.org/projects/specflow/en/latest/Bindings/Context-Injection.html
        // till here https://docs.specflow.org/projects/specflow/en/latest/Bindings/Context-Injection.html#advanced-options (incl)
        // передати тест дані в різні степ деф. класи:
        // *ств сутність тестових даних (НЕ абстрактний клас!) 
        // *з фіче файлу передати в *окремий* степ дефінішн клас тайтли товарів, які додаємо в корзину (тут має відбувтись ініціалізація полів тест моделі, як в прикладі)
        // *в іншому степ деф класі реалізувати перевірку того, шо ці тайтли відобразились на overview сторінці (додати 2: в одному вен, в іншому зен)
        //(передати через параметр конструктора тестову модель, зробити ассерт порівнявши дані тестової моделі і даних на сторінці) 
        //


        //Task 2: add 1 new scenario with another tag, execute each scenario using console with proper tag
        //

        // *. імплементувати передачу веб драйвера в різні степ дефінішн класи 
    }
}
