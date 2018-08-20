//
// Definition for binary tree:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
bool isTreeSymmetric(Tree<int> t) {
    if(t == null)
        return true;
    
    return isMirror(t.left, t.right);
}

bool isMirror(Tree<int> x, Tree<int> y){
    if(x == null && y == null)
        return true;
    if(x != null && y == null)
        return false;
    if(x == null && y != null)
        return false;
    if(x.value != y.value)
        return false;
    return (isMirror(x.left, y.right) && isMirror(x.right, y.left));
}