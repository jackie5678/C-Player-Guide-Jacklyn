using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Asteroids
{
    internal class Asteroid
    {
        public float PositionX {  get; private set; }
        public float PositionY { get; private set; }
        public float VelocityX { get; private set; }
        public float VelocityY { get; private set; }

        public Asteroid(float posX, float posY, float velocityX,float velocityY)
        {
            this.PositionX = posX;
            this.PositionY = posY;
            this.VelocityX = velocityX;
            this.VelocityY = velocityY;
        }

        public void Update()
        {
            PositionX += VelocityX;
            PositionY += VelocityY;
        }

      
    }
}
