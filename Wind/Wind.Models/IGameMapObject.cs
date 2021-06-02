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
        
        string ObjectImage
        {
            get;
        }

        void Change();

        double StreamForce
        {
            get;
        }
        Direction direction { get; set; }
    }
}