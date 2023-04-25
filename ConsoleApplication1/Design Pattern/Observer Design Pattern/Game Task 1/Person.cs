using System;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Game_Task_1
{
    public class Person : Observer
    {
        private Ball ball;

        public Person(Ball ball)
        {
            this.ball = ball;
        }
        public void update(Subject subject)
        {
            /*if (subject is Ball)
            {
                Ball ball = (Ball)subject;
                if (ball.guess(ball.BallIndex))
                {
                    Console.WriteLine("Congratulation you found the ball");
                   
                }
                else
                {
                    Environment.Exit(0);
                }*/
            Console.WriteLine("ball is found");
                
            }
           
           
        }
    }
