//
// Definition for binary tree:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
bool hasPathWithGivenSum(Tree<int> t, int s) {
    return hasPathWithGivenSumFunc(t, s, 0);
}

bool hasPathWithGivenSumFunc(Tree<int> x, int s, int total){
    if(x == null){
        return s == total;
    }
    
    if(x.left == null && x.right == null){
        return s == total + x.value;
    }
       
    if(x.left != null && hasPathWithGivenSumFunc(x.left, s, total + x.value))
       return true;
    
    if(x.right != null && hasPathWithGivenSumFunc(x.right, s, total + x.value))
       return true;
       
    return false;
}
