// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> rearrangeLastN(ListNode<int> l, int n) {
    
    if(l == null){
        return null;
    } 
    
    if(n == 0){
        return l;
    }
    
    
    ListNode<int> x = l;
    ListNode<int> ignoredlistListTail = null;
    ListNode<int> ignoredListHead = null;
    ListNode<int> current = null;
    ListNode<int> lastHead = null;
    
    int cont = 1;
    
    ListNode<int> rearrangeListHead = new ListNode<int>();
    rearrangeListHead.value = x.value;
    rearrangeListHead.next = x.next;
    ListNode<int> rearrangeTail = rearrangeListHead;
    x = x.next;
    
    while(x != null){
        if(cont < n)
        {
            current = new ListNode<int>();
            current.value = x.value;
            current.next = null;
            rearrangeTail.next = current;
            rearrangeTail = current;
            cont ++;    
        }
        else{
            lastHead = new ListNode<int>();
            lastHead.value = rearrangeListHead.value;
            
            if(ignoredListHead == null)
            {
                ignoredListHead = new ListNode<int>();
                ignoredListHead.value = lastHead.value;
                ignoredlistListTail = ignoredListHead;
            }
            else
            {
                ignoredlistListTail.next = lastHead;
                ignoredlistListTail = lastHead;
            }
            
            current = new ListNode<int>();
            current.value = x.value;
            current.next = null;
            rearrangeTail.next = current;
            rearrangeTail = current;
            
            if(rearrangeListHead.next == null){
                rearrangeListHead = rearrangeTail;
            } 
            else{
                rearrangeListHead = rearrangeListHead.next;
            }
        }
        x = x.next;
    }
    
    rearrangeTail.next = ignoredListHead;
    
    return rearrangeListHead;
}