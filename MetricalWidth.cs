namespace HelloWorldMicroservice
{
	public struct MetricalWidth
	{
		private int _value;
		private string _unit;

		public MetricalWidth(int value)
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