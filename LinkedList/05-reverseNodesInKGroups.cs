// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> reverseNodesInKGroups(ListNode<int> l, int k) {
    
    if(k == 1){
        return l;  
    }
    
    ListNode<int> x = l;
    ListNode<int> final = null;
    ListNode<int> reverseHead = null;
    ListNode<int> prevReverseHead = null;
    ListNode<int> reverseTail = null;
    ListNode<int> lastTail = null;
    ListNode<int> current = null;
    int cont = 1;
    
    while(x != null){
        if(cont % k == 0){
            if(final == null){
                final = new ListNode<int>();
                final.value = x.value;
                final.next = reverseHead;
                lastTail = reverseTail;
            }
            else{
                prevReverseHead = reverseHead;
                reverseHead = new ListNode<int>();
                reverseHead.value = x.value;
                reverseHead.next = prevReverseHead;
                lastTail.next = reverseHead;
                lastTail = reverseTail;
            }
            
        }
        if(cont % k == 1)
        {
            reverseTail = new ListNode<int>();
            reverseTail.value = x.value;
            reverseHead = reverseTail;
            current = x;
        }
        else{
            if(reverseHead == null){
                reverseHead = new ListNode<int>();
                reverseHead.value = x.value;
            }
            else{
                prevReverseHead = reverseHead;
                reverseHead = new ListNode<int>();
                reverseHead.value = x.value;
                reverseHead.next = prevReverseHead;
            }
        }
        
        cont++;
        x = x.next; 
    }
    
    if((cont-1) % k != 0)
    {
        lastTail.next = current;
    }
    
    return final;
}
