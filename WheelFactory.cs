using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMicroservice
{
	public static class WheelFactory
	{
		public static IWheel CreateOutdoorWheel()
		{
			return new OutdoorWheel(64, 40, 76);
		}

		public static IWheel CreateIndoorWheel()
		{
			return new IndoorWheel(53, 32, 91);
		}
	}
}
