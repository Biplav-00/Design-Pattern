using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Game_Task_1
{
    
    public class Ball : Subject
    {
        private List<bool> ballsInBottle = new List<bool>() { false, false, false, false, false };
        private Random _random = new Random();
        private int ballIndex;
        private List<Observer> obseverList = new List<Observer>();
        
        public Ball()
        {
            generateRandom();
            
        }

        public void generateRandom()
        {
            ballIndex = _random.Next(5);
            ballsInBottle[ballIndex] = true;
        }

        public int BallIndex
        {
            get { return ballIndex; }
        }
        public void addObserver(Observer observer)
        {
            if (!obseverList.Contains(observer))
            {
                obseverList.Add(observer);
            }
        }

       
        public void removeObserver(Observer observer)
        {
            obseverList.Remove(observer);
        }

        public void notifyToObserver()
        {
            foreach (Observer observer in obseverList)
            {
                observer.update(this);
            }
        }

        public bool guess(int guessIndex)
        {
            if (ballsInBottle[guessIndex])
            {
                Console.WriteLine("congratulation you found  the ball in bottle {0}",guessIndex);
                notifyToObserver();
                return true;
            }
            else
            {
                Console.WriteLine("sorry the ball is not in  bottle {0} please  try again..",guessIndex);
               
                generateRandom();
                return false;
            }

            
        }
        
    }
}