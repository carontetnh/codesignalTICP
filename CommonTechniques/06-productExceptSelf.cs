/*
int productExceptSelf(int[] nums, int m) {
    
    int currentSum = 0;
    int[] f = new int[nums.Length];
    
    for(int i = 0; i < nums.Length; i++)
    {
        f[i] = productExceptSelfF(nums,m,i);
    }
    
    for(int i = 0; i < nums.Length; i++)
    {
        currentSum = currentSum + f[i]; 
    }
    
    return currentSum % m;
}

int productExceptSelfF(int[] nums, int m, int j){
    int total = 1;
    for(int i = 0; i < nums.Length; i++) 
    {  
        if(i != j)
            total = (total * nums[i]) % m;
    }
    return total;
}
*/

int productExceptSelf(int[] nums, int m) 
{
    /*Horner's method*/
    int p = 1, g = 0;
    foreach(int x in nums)
    {
        g = (g * x + p) % m;
        p = (p * x) % m;
    }
    return g;
}