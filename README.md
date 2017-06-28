Kata: Game of Life

The Game of Life, is a cellular automation simulation invented by the British mathematician
John Horton Conway in 1970. For more background information, see https://en.wikipedia.org/
wiki/Conway%27s_Game_of_Life

Exploring the Algorithm: 
The Game of life uses a 2-dimensonal array to store information about the cells that are either in a dead state (Bool-false) or a live state (Boolean-true). 
Bases upon the rules:
1.	Any live cell with fewer than two live neighbors dies, as if caused by under population.
2.	Any live cell with more than three live neighbors dies, as if by overcrowding.
3.	Any live cell with two or three live neighbor’s lives on to the next generation.
4.	Any dead cell with exactly three live neighbors becomes a live cell.
5.	
The array ( grid[y,x] ), after placement of initial cells and pressing go, the program searches every point and compares them to the rules above. For each point there are eight possible neighbors, unless the point lies on the edges of the grid. 
The program only uses one array, but it could have easily been processed by using two. Each element is checked for dead/ alive and then counts how many neighbors. Once the neighbors are found/ or not found, the decision is pushed to a switch statement that either dead/alive/no change the cell.

