using Microsoft.AspNetCore.Mvc;
using RestAspNETPersonService.Models;
using RestAspNETPersonService.Business;

namespace RestAspNETBookService.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BooksController : ControllerBase
    {
        private IBookBusiness _BookBusiness;

        public BooksController(IBookBusiness BookBusiness)
        {
            _BookBusiness = BookBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_BookBusiness.findAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var Book = _BookBusiness.FindById(id);
            if (Book == null) return NotFound();
            return Ok(Book);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return new ObjectResult(_BookBusiness.Create(Book));
        }

        // PUT api/values/5        
        [HttpPut]
        public IActionResult Put([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            var updateBook = _BookBusiness.Update(Book);
            if (updateBook == null) return NoContent();
            return new ObjectResult(updateBook);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _BookBusiness.Delete(id);
            return NoContent();
        }
    }
}
