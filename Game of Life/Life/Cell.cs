using System;


namespace GameOfLife
{
    class Cell
    {
        // initializes grid
        public Cell(int h, int w){
            if (h <= 0 || w <= 0)
                throw new ArgumentOutOfRangeException();

            H = h;
            W = w;
            T = 0;

            grid = new bool[h, w];
        }

        public int H { get; private set; }     
        public int W { get; private set; }      
        public int T { get; set; }            
        private bool[,] grid { get; set; }        

        public bool this[int y, int x]{
            get
            {
                if (outCheck(y, x))
                    throw new ArgumentOutOfRangeException();

                return grid[y, x];
            }

            set
            {
                if (outCheck(y, x))
                    throw new ArgumentOutOfRangeException();

                grid[y, x] = value;
            }
        }

        //next state of a cells at cord x y
        private bool processNext(int y, int x)
        {
            // checks cells
            if (outCheck(y, x))
                throw new ArgumentOutOfRangeException();

            // the results of kata rules
            switch (howManyLiveNeighbours(y, x)){
                case 2:
                    return grid[y, x];      // cell stays alive
                case 3:
                    return true;            // dead cell becomes alive
                default:
                    return false;
            }
        }

        private bool outCheck(int y, int x)
        {
            return y < 0 || y >= H || x < 0 || x >= W;
        }

        //number of live cells at cord x y
        private int howManyLiveNeighbours(int y, int x){
 
            if (outCheck(y, x))
                throw new ArgumentOutOfRangeException();

            int c = 0;

            for (var j = y - 1; j < y + 2; ++j)
                for (var i = x - 1; i < x + 2; ++i)
                    if (!outCheck(j, i))
                        c += Convert.ToInt32(grid[j, i]);

            return c - Convert.ToInt32(grid[y, x]);
        }


        //next generational cycle
        public void eachCycle(){

            bool[,] clone = nextGrid();

            //goes through all elemebts of the array
            for (var y = 0; y < H; ++y)
                for (var x = 0; x < W; ++x)
                    clone[y, x] = processNext(y, x);

            grid = clone;
            ++T;
        }
        
        //grid for next generation
        private bool[,] nextGrid(){

            bool[,] clone = new bool[H, W];

            for (var y = 0; y < H; ++y)
                for (var x = 0; x < W; ++x)
                    clone[y, x] = grid[y, x];

            return clone;
        }
    }
}