using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMicroservice.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly List<string> _values;

		public ValuesController()
		{
			_values = new List<string>
			{
				"Hallo World"
			};
		}
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return _values;
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			if (id >= _values.Count)
			{
				return "ID nicht vorhanden";
			}
			return _values[id];
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
			_values.Add(value);
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			_values.Insert(id, value);
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_values.RemoveAt(id);
		}
	}
}
