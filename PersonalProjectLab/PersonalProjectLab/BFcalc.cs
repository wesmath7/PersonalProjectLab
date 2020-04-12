using System;
namespace PersonalProjectLab
{
    public class BFcalc
    {
        public BFcalc()
        { }

        public decimal CalculateBoardFootage(int length, int width, int thickness)
        { 
        decimal boardFootage = 0.0m;

        boardFootage = (length* width * thickness)/144;
            return boardFootage;
        }
    }
}
