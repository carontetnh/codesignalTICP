// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b) {
    ListNode<int> x = a;
    ListNode<int> y = b;
    ListNode<int> mirror1 = null;
    ListNode<int> prev1 = null;
    ListNode<int> mirror2 = null;
    ListNode<int> prev2 = null;
    
    while(x != null || y != null){
        if(x != null){
            mirror1 = new ListNode<int>();
            mirror1.value = x.value;
            mirror1.next = prev1;
            prev1 = mirror1; 
            x=x.next;
        }
        
        if(y != null){
            mirror2 = new ListNode<int>();
            mirror2.value = y.value;
            mirror2.next = prev2;
            prev2 = mirror2; 
            y=y.next;
        }
    }
    
    ListNode<int> part1 = mirror1;
    ListNode<int> part2 = mirror2;
    ListNode<int> result = null;
    ListNode<int> prev = null;
    
    int cont = 0;
    
    
    while(part1 != null || part2 != null){
        result = new ListNode<int>();
        result.value = 0;
        if(part1 != null){
            result.value += part1.value;
            part1=part1.next;
        }
        if(part2 != null){
            result.value += part2.value;
            part2=part2.next;
        }
        
        result.value += cont;
        cont = 0;
        
        if(result.value / 10000 > 0){
            cont = result.value/10000;
            result.value = result.value % 10000;
        }
        
        result.next = prev;
        prev = result;
    }
    
    if(cont > 0){
        result = new ListNode<int>();
        result.value = cont;
        result.next = prev;
    }
    
    return result;
}
