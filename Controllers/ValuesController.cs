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
		private readonly List<IWheel> _values;

		public ValuesController()
		{
			_values = new List<IWheel>
			{
				WheelFactory.CreateIndoorWheel(),
				WheelFactory.CreateOutdoorWheel()
			};
		}
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new ActionResult<IEnumerable<string>>(_values.Select((each) => each.WheelSpecifications()));
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			if (id >= _values.Count)
			{
				return null;
			}
			return new ActionResult<string>(_values[id].WheelSpecifications());
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] IWheel value)
		{
			_values.Add(value);
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] IWheel value)
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
