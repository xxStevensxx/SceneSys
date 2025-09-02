using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Numerics;

namespace SceneSys
{
    class Grid : IGrid
    {
        private int row;
        private int column;
        private int cellW;
        private int cellH;
        private Vector2 size;

        public Grid(int row, int column, int cellW, int cellH) {

            this.row = row;
            this.column = column;
            this.cellW = cellW;
            this.cellH = cellH;
            this.size = new Vector2(this.row * this.cellW, this.column * this.cellH);
        }
        

        public void Draw()
        {
            int spaceBetween = 10;

            for (int r = 0; r < row; r++) {

                int x = (GetScreenWidth() / 2 - (int)size.X / 2) + r * (cellW + spaceBetween);

                for (int c = 0; c < column; c++) {

                    int y = (GetScreenHeight() / 2 - (int)size.Y / 2) + c * (cellH + spaceBetween);

                    DrawRectangleLines(x, y, cellW, cellH, Color.Magenta);

                }
            }

        }
    }
}
