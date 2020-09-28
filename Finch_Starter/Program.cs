using FinchAPI;
using System;

namespace Finch_Starter
{
    class Program
    {
        // *************************************************************
        // Application:     Finch Starter Solution
        // Author:          Velis, John E
        // Description:
        // Date Created:    5/20/2016
        // Date Revised:    
        // *************************************************************

        static void Main(string[] args)
        {
            //
            // create a new Finch object
            //
            Finch myFinch;
            myFinch = new Finch();

            //Finch myFinch = new Finch();

            //
            // call the connect method
            //
            //
            myFinch.connect();

            //
            // begin your code
            //

            //LIGHT FLASHING
            //for (int i = 0; i < 5; i++)
            //{
            //    myFinch.setLED(255, 0, 0);
            //    myFinch.wait(1000);
            //    myFinch.setLED(0, 0, 0);
            //    myFinch.wait(500);
            //}


            ////TONE OFF AND ON
            //for (int i = 0; i < 5; i++)
            //{
            //    myFinch.noteOn(261);
            //    myFinch.wait(1000);
            //    myFinch.noteOff();
            //    myFinch.wait(200);
            //}

            ////MOVE FINCH
            //myFinch.setMotors(255, 255);
            //myFinch.wait(2000);
            //myFinch.setMotors(0, 0);


            ////TURN THREE WAYS
            //myFinch.setMotors(255, 0);
            //myFinch.setMotors(255, -255);
            //myFinch.setMotors(255, 128);


            ////WADDLE 
            //for (int i = 0; i < 5; i++)
            //{
            //    myFinch.setMotors(255, 128);
            //    myFinch.wait(2000);
            //    myFinch.setMotors(128, 255);
            //    myFinch.wait(1000);
            //}


            //COLORS DIM COLORS BRIGHTEN
            //for (int i = 0; i < 255; i++)
            //{
            //    myFinch.setLED(i, 0, 0);
            //    myFinch.wait(10);
            //}
            //for (int i = 255; i > 0; i--)
            //{
            //    myFinch.setLED(i, 0, 0);
            //    myFinch.wait(10);
            //}


            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            //
            //end of your code
            //

            //
            // call the disconnect method
            //
            myFinch.disConnect();
        }
    }
}
