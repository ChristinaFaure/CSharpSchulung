namespace HelloWorldMicroservice
{
	public struct Shore
	{
		private readonly int _value;
		private readonly char _unit;

		public Shore(int value)
		{
			this._value = value;
			this._unit = 'A';
		}

		public override string ToString()
		{
			return $"{_value}{_unit}";
		}
	}
}