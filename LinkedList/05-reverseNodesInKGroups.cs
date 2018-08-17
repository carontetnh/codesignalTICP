// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> reverseNodesInKGroups(ListNode<int> l, int k) {
      ListNode<int> x = l;
      ListNode<int> prev = null;
      ListNode<int> head = l;
      ListNode<int> head_before = null;
      ListNode<int> new_head = null;
      int index = 1;
      while(x != null) {
         ListNode<int> x_next = x.next;

         if(index != 0 && index % k == 0) {

            ListNode<int> x2 = head;
            ListNode<int> prev2 = x_next;

            while(x2 != x){
               ListNode<int> x2_next = x2.next;
               x2.next = prev2;
               prev2 = x2;
               x2 = x2_next;
            }

            x.next = prev2;

            if(index == k) {
               new_head = x;
            }

            if(head_before != null) head_before.next = x;
            head_before = head;
            head = x_next;
         }

         index++;
         prev = x;
         x = x_next;
      }

      if(new_head == null) return l;
      return new_head;
}
