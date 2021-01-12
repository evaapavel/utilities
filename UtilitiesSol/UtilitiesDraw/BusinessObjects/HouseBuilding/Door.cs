using System;



namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class Door
    {



        private double width;
        private double height;
        private bool isDoubleWinged;



        public Door(double width, double height, bool isDoubleWinged)
        {
            this.width = width;
            this.height = height;
            this.isDoubleWinged = isDoubleWinged;
        }



        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public bool IsDoubleWinged
        {
            get
            {
                return isDoubleWinged;
            }

            set
            {
                isDoubleWinged = value;
            }
        }



        // Dveře: 0,9 metru x 2,2 metru, jednokřídlé
        public static Door GetSingleDoor()
        {
            Door door = new Door(0.9, 2.2, false);
            return door;
        }



        // Dveře: 1,8 metru x 2,1 metru, dvoukřídlé
        public static Door GetDoubleDoor()
        {
            Door door = new Door(1.8, 2.1, true);
            return door;
        }



    }



}
