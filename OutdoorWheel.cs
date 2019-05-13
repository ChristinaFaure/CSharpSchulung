namespace HelloWorldMicroservice
{
	public class OutdoorWheel : IWheel
	{
		public OutdoorWheel(int diameter, int width, int hardness)
		{
			Diameter = diameter;
			Width = width;
			Hardness = new Shore(hardness);
		}

		public int Diameter { get; }
		public int Width { get; }
		public Shore Hardness { get; }
		public string WheelSpecifications()
		{
			return $"Outdoor Rollen: {Diameter} hoch, {Width} breit und mit einer Härte von {Hardness}";
		}
	}
}