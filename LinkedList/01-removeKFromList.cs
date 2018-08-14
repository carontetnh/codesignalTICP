// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> removeKFromList(ListNode<int> l, int k) {
    ListNode<int> x = l;
    ListNode<int> prev = null;
    while(x != null){
        ListNode<int> x_next = x.next;
        if(x.value == k)
        {
            if(prev != null)
            {
                prev.next = x_next;
            }
            else{
                l= x_next;
            }
        }
        else{
            prev = x;
        }
        x=x_next;
    }
    return l;
}
