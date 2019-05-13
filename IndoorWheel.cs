namespace HelloWorldMicroservice
{
	public class IndoorWheel : IWheel
	{
		public IndoorWheel(int diameter, int width, int hardness)
		{
			Diameter = diameter;
			Width = width;
			Hardness = new Shore(hardness);
		}

		public int Diameter
		{
			get;
		}
		public int Width
		{
			get;
		}
		public Shore Hardness
		{
			get;
		}

		public string WheelSpecifications()
		{
			return $"Indoor Rollen: {Diameter} hoch, {Width} breit und mit einer Härte von {Hardness}";
		}
	}
}