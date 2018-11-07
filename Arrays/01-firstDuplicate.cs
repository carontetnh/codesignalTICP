/*
int firstDuplicate(int[] a) {
    char[] b = new char[a.Length];
    int i;
    for (i = 0; i < a.Length; i++) 
    {
        if(b[a[i] - 1] == 'd'){
            return a[i];
        }
        b[a[i] - 1] = 'd';
    }
    return -1;
}
*/

int firstDuplicate(int[] a) {
    int i;
    for(i = 0; i < a.Length; i++){
        if(a[Math.Abs(a[i])-1] < 0)
             return Math.Abs(a[i]);
            
        a[Math.Abs(a[i])-1] = -(a[Math.Abs(a[i])-1]);
    }
    
    return -1;
}
