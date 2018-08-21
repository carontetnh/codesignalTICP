bool sumOfTwo(int[] a, int[] b, int v) {
    
    HashSet<int> set = new HashSet<int>();
    foreach(int i in a){
        set.Add(i);
    }
    
    foreach(int i in b){
        if(!set.Add(v - i))
            return true;
    }
    
    return false;
}
