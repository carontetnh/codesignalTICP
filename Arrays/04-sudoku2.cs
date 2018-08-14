bool reviewC(char[][] grid, int i, int j){
    for(int c = 0; c < 9; c++){
        if(i != c && grid[i][j] == grid[c][j])
            return false;
    }
    return true;
}

bool reviewR(char[][] grid, int i, int j){
    for(int c = 0; c < 9; c++){
        if(j != c && grid[i][j] == grid[i][c])
            return false;
    }
    return true;
}

bool reviewGrid(int i, int j,int x, int y, char[][]grid)
{
    for(int a = i; a < i+3;a++){
        for(int b = j; b < j+3;b++){
            if((a != x && b !=y) && grid[x][y] == grid[a][b])
                return false;
        }
    }
    return true;
}

bool reviewSubGrid(char[][] grid, int i, int j){
    if(i >= 0 && i<3){
        if(j >= 0 && j<3){
            return reviewGrid(0,0,i,j,grid);
        }
        if(j >= 3 && j<6){
            return reviewGrid(0,3,i,j,grid);
        }
        if(j >= 6 && j<9){
            return reviewGrid(0,6,i,j,grid);
        }
    }
    if(i >= 3 && i<6){
        if(j >= 0 && j<3){
            return reviewGrid(3,0,i,j,grid);
        }
        if(j >= 3 && j<6){
            return reviewGrid(3,3,i,j,grid);
        }
        if(j >= 6 && j<9){
            return reviewGrid(3,6,i,j,grid);
        }
    }
    if(i >= 6 && i<9){
        if(j >= 0 && j<3){
            return reviewGrid(6,0,i,j,grid);
        }
        if(j >= 3 && j<6){
            return reviewGrid(6,3,i,j,grid);
        }
        if(j >= 6 && j<9){
            return reviewGrid(6,6,i,j,grid);
        }
    }
    return true;
}

bool sudoku2(char[][] grid) {
    for(int i = 0; i < 9; i++){
        for(int j=0; j < 9; j++)
        {
            if(grid[i][j] != '.'){
                if(!reviewC(grid,i,j) || !reviewR(grid,i,j) || !reviewSubGrid(grid,i,j))
                   return false;
            }
        }
    }
    return true;
}
