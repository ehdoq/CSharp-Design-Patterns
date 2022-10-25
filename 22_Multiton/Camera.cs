namespace _22_Multiton
{
    public class Camera
    {
        static Dictionary<string, Camera> _camera = new();

        static object _lock = new object();
        public Guid Id { get; set; }
        private Camera()
        {
            Id = Guid.NewGuid();
        }

        public static Camera GetCamera(string brand)
        {
            lock (_lock)
            {
                if (!_camera.ContainsKey(brand))
                {
                    _camera.Add(brand, new Camera());
                }
            }
            return _camera[brand];
        }
    }
}