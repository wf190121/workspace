using System.Web.Http;
using System.Net.Http;
using System.Net;
using BookWeb.Models.Logic;

namespace BookWeb.ApiControllers
{
    public class BooksController : ApiController
    {


        // GET api/<controller>/5
        [HttpGet]
        public HttpResponseMessage GetList()
        {
            var books = new BookLogic();
            var result = books.GetBook();
            return Request.CreateResponse(HttpStatusCode.OK, new { bookList=result});
        }


    }
}