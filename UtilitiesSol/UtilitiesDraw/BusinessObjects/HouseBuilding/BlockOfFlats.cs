using System;
using System.Collections.Generic;



namespace UtilitiesDraw.BusinessObjects.HouseBuilding
{



    public class BlockOfFlats : BuildingElement
    {



        private Address address;
        private List<Floor> floors;



        public BlockOfFlats(Address address)
        {
            this.address = address;
            this.floors = new List<Floor>();
        }



        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public List<Floor> Floors
        {
            get
            {
                return floors;
            }

            set
            {
                floors = value;
            }
        }



        /*
        • Adresa: K Ládví 344, Praha 8, 181 00
        • Patra:
        • 0. patro (přízemí)
        • Byt: 10,2 m x 3,2 m, dvoukřídlé dveře, dvě okna "Standard"
        • Byt: 5,5 m x 3,2 m, jednokřídlé dveře, jedno okno "Standard"
        • 1. patro (byt s francouzskými okny má balkon)
        • Byt: 8,2 m x 3,2 m, jednokřídlé dveře, dvě okna "Francouz"
        • Byt: 8,5 m x 3,2 m, jednokřídlé dveře, dvě okna "Standard"
        • 2. patro (s luxusním bytem a verandou)
        • Byt: 12,1 m x 4,5 m, dvoukřídlé dveře, jedno okno "Standard", jedno okno "Francouz"
        */
        public static BlockOfFlats GetKLadviBlockOfFlats()
        {
            BlockOfFlats block = new BlockOfFlats(Address.GetKLadviAddress());
            block.Floors.Add(Floor.GetGroundFloor());
            block.Floors.Add(Floor.GetFirstFloor());
            block.Floors.Add(Floor.GetSecondFloor());
            return block;
        }



    }



}
