using System;

namespace CSLab3
{
    class Premises
    {
        public double sqrMeters;
        public double ceilingHeight;

        public double SqrMeters
        {
            set
            {
                if (value < 8)
                {
                    sqrMeters = value;
                    Console.WriteLine("Caution! Area of room less than the minimum possible!");
                }
                else
                {
                    sqrMeters = value;
                }
            }
            get
            {
                return sqrMeters;
            }
        }
        public double CeilingHeight
        {
            set
            {
                if (value < 2.4)
                {
                    ceilingHeight = value;
                    Console.WriteLine("Caution! Height of ceiling in room less than the minimum possible!");
                }
                else
                {
                    ceilingHeight = value;
                }
            }
            get
            {
                return ceilingHeight;
            }
        }
        public int windowsNum;
        public Premises() { SqrMeters = 8; ceilingHeight = 2.4; windowsNum = 0; }

        public Premises(double x) { SqrMeters = x; ceilingHeight = 2.4; windowsNum = 0; }

        public Premises(double x, double y) { SqrMeters = x; ceilingHeight = y; windowsNum = 0; }

        public Premises(double x, double y, int n) { SqrMeters = x; ceilingHeight = y; windowsNum = n; }

        public void getInfo()
        {
            Console.WriteLine($"Area of the room: {sqrMeters}\nCeiling height: {ceilingHeight}\nNumber of windows: {windowsNum}\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Premises firstRoom = new Premises(20, 2.7, 3);
            firstRoom.getInfo();

            Premises secondRoom = new Premises(12, 2.7);
            secondRoom.getInfo();

            Premises thirdRoom = new Premises(6);
            thirdRoom.getInfo();

            Premises forthRoom = new Premises();
            forthRoom.getInfo();
        }
    }
}
