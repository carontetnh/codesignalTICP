// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2) {
    
    if(l1 == null && l2 == null){
        return null;
    }
    
    ListNode<int> finalListHead = new ListNode<int>();
    ListNode<int> finalListNode = new ListNode<int>();
    ListNode<int> x = l1;
    ListNode<int> y = l2;
    bool flag = false;
    
    if(x != null && y != null)
    {
        if(x.value <= y.value){
            finalListHead.value = x.value;
            x = x.next;
        }
        else{
            finalListHead.value = y.value;
            y = y.next;
        }
        flag = true;
    }
    
    finalListNode = finalListHead;
    
    while(x != null && y != null)
    {
        finalListNode.next = new ListNode<int>();
        finalListNode = finalListNode.next;
        
        if(x.value <= y.value){
            finalListNode.value = x.value;
            x = x.next;
        }
        else{
            finalListNode.value = y.value;
            y = y.next;
        }
    }
    
    while(x != null){
        if(!flag){
            finalListHead.value = x.value;
            x = x.next;
            flag = true;
            finalListNode = finalListHead;
        }
        else{
            finalListNode.next = new ListNode<int>();
            finalListNode = finalListNode.next;
            finalListNode.value = x.value;
            x = x.next;
        }
    }
    
    while(y != null){
        if(!flag){
            finalListHead.value = y.value;
            y = y.next;
            flag = true;
            finalListNode = finalListHead;
        }
        else{
            finalListNode.next = new ListNode<int>();
            finalListNode = finalListNode.next;
            finalListNode.value = y.value;
            y = y.next;
        }
    }
    
    return finalListHead;
}
