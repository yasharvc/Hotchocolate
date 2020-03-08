using Microsoft.AspNetCore.Mvc;

namespace Controllers{
    public class HomeController:Controller{
        public ContentResult index(){
            return Content("Test");
        }
    }
}