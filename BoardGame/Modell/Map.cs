using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh.Modell
{
    public class Map
    {
        public  int Size { get; set; }
        public  Cell[,] CellGrid { get; set; }

        public Map(int size)
        {
            Size = size;
            CellGrid = new Cell[size,size];
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++)
                {
                    CellGrid[i,j] = new Cell(i,j);
                }
            }


           
            
            }
        public void IsLegalMethod(Cell currentCell)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    CellGrid[i, j].isLegal = false;
                    

                }
            }
            

        }

        public void MarkNextLegalMoves(Cell currentCell) {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    CellGrid[i, j].isLegal = false;
                   
                    

                }
            }
            
            if (currentCell.Colums < Size-1 && currentCell.Rows < Size-1) {
                CellGrid[currentCell.Rows + 1, currentCell.Colums + 1].isLegal = true;
            }


            if (0 < currentCell.Rows && 0 < currentCell.Colums) {
                CellGrid[currentCell.Rows - 1, currentCell.Colums - 1].isLegal = true;
            }


            if (currentCell.Rows < Size-1 && 0 < currentCell.Colums)
            {
                CellGrid[currentCell.Rows + 1, currentCell.Colums - 1].isLegal = true;
            }


            if (currentCell.Colums < Size-1 && 0 < currentCell.Rows)
            {
                CellGrid[currentCell.Rows - 1, currentCell.Colums + 1].isLegal = true;
            }





            if (0 < currentCell.Rows)
            {
                CellGrid[currentCell.Rows - 1, currentCell.Colums].isLegal = true;
            }
            if (0 < currentCell.Colums)
            {
                CellGrid[currentCell.Rows, currentCell.Colums - 1].isLegal = true;
            }


            if (currentCell.Rows < Size-1)
            {

                CellGrid[currentCell.Rows + 1, currentCell.Colums].isLegal = true;
            }
            if (currentCell.Colums < Size-1)
            {
                CellGrid[currentCell.Rows, currentCell.Colums + 1].isLegal = true;

            }
            





        }
        

        
    }

    



}
