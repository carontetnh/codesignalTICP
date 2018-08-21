int sumInRange(int[] nums, int[][] queries) {
     if(nums.Length==0 || queries.Length==0) 
          return 0;
     
     int mod= 1000000007;
    
     Dictionary <int,int> map = new Dictionary<int,int>();
     int sumPre = nums[0];
     map[0] = sumPre;
     for(int i= 1; i< nums.Length;i++){
          sumPre = sumPre + nums[i];
          map[i] = sumPre % mod;
     }   
    
     int sum=0;
     
     for(int i = 0; i< queries.Length;i++){
         if(queries[i][0]==0) 
              sum = sum%mod +  map[queries[i][1]] % mod;
         else 
              sum = sum%mod + map[queries[i][1]] - map[queries[i][0]-1] % mod;      
     }
     return (sum + mod) % mod;
}
