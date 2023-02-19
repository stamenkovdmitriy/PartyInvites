using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // метод действия который выбирает стандартное представление подлежащее визуализации
        public IActionResult Index() 
        {
            return View();    
        }

        //  метод действия Rsvp отвечает за отображения изначальной пустой формы
        [HttpGet]  // атрибут объявляющий чем будет заниматься метод
        public ViewResult RsvpForm()
        {
            return View();
        }

        // метод Rsvp отвечающий за получение отправленных данных и принятие решения что с ними делать
        [HttpPost]  // атрибут объявляющий чем будет заниматься метод
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // что сделать - сохранить ответ от гостя
            if (ModelState.IsValid)   // свойство  проверяющее достоверность данных
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        // метод действия добавляющий конечную точку для ListResponses
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));  // с помощью Linq получать положительные ответы
        }

    }
}