namespace Wind.Models
{
    public interface IGameMapObject
    {
        bool IsStaticObject
        {
            get;
        }

        bool IsWall
        {
            get;
        }

        res ObjectImage
        {
            get;
        }
    }
}