namespace Consnake.Core.Interfaces.Game
{
    public interface IRenderer<T> where T : class
    {
        void Render(T renderObject);
    }
}
