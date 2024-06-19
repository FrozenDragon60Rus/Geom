namespace Geom.Figures
{
    public abstract class Figure
    {
        protected Figure() =>
			RightForm();

		public abstract double Area { get; }
        protected abstract void RightForm();
    }
}
