namespace HelloWorldMicroservice
{
	public interface IWheel
	{
		MetricalDiameter Diameter
		{
			get;
		}

		MetricalWidth Width
		{
			get;
		}

		Shore Hardness
		{
			get;
		}

		string WheelSpecifications();
	}
}