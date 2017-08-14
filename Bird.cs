namespace Interfaces
{
    public class Bird : ICanFly
    {
        public string Color { get; set; }
        public int WingSpan { get; set; }
        public int FlySpeed { get; set; }
        public int CurrentFlyingSpeed { get; set; }

        public void FlapWings()
        {
            this.CurrentFlyingSpeed += this.FlySpeed;
        }

        public void Glide()
        {
            this.CurrentFlyingSpeed -= this.FlySpeed;
        }
    }
}