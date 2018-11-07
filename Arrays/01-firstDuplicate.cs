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