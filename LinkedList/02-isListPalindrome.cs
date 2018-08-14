// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
bool isListPalindrome(ListNode<int> l) {
    if (l == null) 
        return true;
    
    ListNode<int> x = l;
    ListNode<int> mirror = null;
    ListNode<int> prev = null;
        
    while(x != null){
        mirror = new ListNode<int>();
        mirror.value = x.value;
        mirror.next = prev;
        
        prev = mirror; 
        x=x.next;
    }
    
    ListNode<int> y = mirror;
    x = l;
    
    while(x != null){
        if(x.value != y.value)
            return false;
        x = x.next;
        y = y.next;
    }
    
    return true;
}
