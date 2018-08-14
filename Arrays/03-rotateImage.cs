int[][] rotateImage(int[][] a){ 
    
    int len = a.GetLength(0);
    int[][] resultImage = new int[len][];
    
    for(int i = 0; i< len; i++)
    {
        resultImage[i] = new int[len];
    }
    
    
    
    for(int j = 0; j < len; j++){
        for(int i = len - 1; i >= 0; i--)
        {
            resultImage[j][(len - 1) - i] = a[i][j];
        }
    }

    return resultImage;
}
