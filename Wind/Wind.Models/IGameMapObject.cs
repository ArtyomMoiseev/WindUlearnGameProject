namespace Wind.Models
{
    public interface IGameMapObject
    {
        bool IsStaticObject
        {
            get;
        }

        string ObjectImage
        {
            get;
        }
    }
}