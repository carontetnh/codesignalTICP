int[] findLongestSubarrayBySum(int s, int[] arr) {
    int contMayor = 0;
    int cont = 0;
    int x = 0;
    int y = 0;
    int i = 0;
    int j = 0;
    int currentSum = 0;
    
    int[] finalResult = new int[1];
    finalResult[0] = -1;
    
    while(j < arr.Length && i < arr.Length)
    {
        currentSum += arr[j];
        cont++;
        
        if(currentSum <= s){
            if(currentSum == s && cont > contMayor)
            {
                x = i + 1;
                y = j + 1;
                contMayor = cont;
            }
            j++;
        }
        else
        {
            currentSum = currentSum - (arr[i] + arr[j]);
            cont-=2;
            i++;
        }
    }    
    
    if(x != 0 && y != 0)
    {
        finalResult = new int[2];
        finalResult[0] = x;
        finalResult[1] = y;
    }
    
    return finalResult;
}