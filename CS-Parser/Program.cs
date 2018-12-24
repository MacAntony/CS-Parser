using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;

namespace Parser
{
    class Program
    {
        /*
        Небольшой парсер на основе Selenium Webdriver и PhantomJS.
        Для запуска данного проетка нужно обезательно иметь Google Chrome. Иначе проект не заработает.
        Это связано с тем что парсинг происходит посредством браузера, в данном парсере это Chrome.
        ----------------------------------------------------------------------------------------------
        В будущем планируеться использовать другую методику парсинга. То есть вместо использования браузера
        парсер будет использовать какуето более простую технологию. К примеру Html Agility Pack.
        */

        static void Main(string[] args)
        {
            IWebDriver Browser; 
            Browser = new PhantomJSDriver();  // 16 по 17 строчку мы создаём объект для управления браузером.
            Browser
                .Navigate()
                .GoToUrl("https://www.google.com.ua/search?q=%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0&oq=%D0%9F%D0%BE%D0%B3%D0%BE&aqs=chrome.0.69i59j69i57j69i60.3422j0j7&sourceid=chrome&ie=UTF-8");
            // С 18 по 20 строчку мы переходим по данному URL. Это URL страничке в гугле, при запросе "погода".

            IWebElement Pogoda = Browser.FindElement(By.ClassName("wob_t")); //На этой строчке мы ищем элемент страницы по имени класса 'wob_t'. После того как мы нашли элемент мы копирем с него все даные, в обект.

            Console.Clear(); //Очищаем консоль от ненужного.
            //(Если убрать - комментировать данную строчку, то на выводе мы получаем кучу всяких ненужных для этого проекта данных)
            Console.WriteLine(Pogoda.Text); //Выводим результат.
            Console.ReadLine(); //Ожидаем пока пользователь нажмёт какую нибудь клавишу.
        }
    }
}