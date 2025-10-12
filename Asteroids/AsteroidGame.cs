using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Asteroids
{
    internal class AsteroidGame
    {
        
        
        private List<Asteroid> myAsteroids = new List<Asteroid>();
        
  
       
        public void TestFunction()
        {
            Console.WriteLine($"I have {myAsteroids.Count} asteroids , present in game.");
            Console.WriteLine("Press 1 to view asteroid position");
        }


        public void Run()
        {
            while (true)
            {
                foreach (Asteroid a in myAsteroids)
                {
                    a.Update();
                    TrackPosition();
                }
            }
            
        }

        public void TrackPosition()
        {
            int keycode = 1;
            int input = Convert.ToInt32(Console.ReadLine());

            if(input == keycode)
            {
                foreach (Asteroid a in myAsteroids)
                {
                    Console.WriteLine($"Position at: X[{a.PositionX}] Y[{a.PositionY}]: Moving With : Y:[{a.VelocityY}] Velocity X:[{a.VelocityX}] Velocity");
                }
            }
           
        }

        public void SpawnAsteroids(int asteroidsToSpawn)
        {
            for(int i = 0; i < asteroidsToSpawn; i++)
            {
                Console.WriteLine($"Asteroid {i}");
                float posX = 0,posY = 0;
                float velocityX = 0, velocityY = 0;

                var random = new Random();

                posX += random.Next(1, 250);
                posY += random.Next(1, 250);
                velocityY += random.Next(3, 10);
                velocityX += random.Next(3, 10);

                Asteroid asteroid = new Asteroid(posX, posY, velocityX, velocityY);

                myAsteroids.Add(asteroid);
                
                
                
                Console.WriteLine($"Position at: X[{asteroid.PositionX}] Y[{asteroid.PositionY}]: Spawned with Velocity: Y[{asteroid.VelocityY}] : X[{asteroid.VelocityX}]");
                
              
            }
            
            TestFunction();
        }

     
    }


}
