bool containsDuplicates(int[] a) {
    if(a==null || a.Length==0)
        return false;
 
    HashSet<int> set = new HashSet<int>();
    foreach(int i in a){
        if(!set.Add(i)){
            return true;
        }
    }
 
    return false;
}