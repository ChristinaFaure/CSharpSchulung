namespace HelloWorldMicroservice
{
	public struct MetricalDiameter
	{
		private readonly int _value;
		private readonly string _unit;

		public MetricalDiameter(int value)
		{
			_value = value;
			_unit = "mm";
		}

		public override string ToString()
		{
			return $"{_value} {_unit}";
		}
	}
}