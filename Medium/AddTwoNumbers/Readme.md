# Add Two Numbers

## Problem Statement

Given two non-empty Linked List representing two non-negative integers. Digits are stored in the reverse order and each node contains a single digit. Add the two numbers and return the sum as a linked list.

The two numbers do not contain leading zeroes

**Example:**
```
2 -> 4 -> 3
5 -> 6 -> 4

7 -> 0 -> 8
```

1. The approach is straight-forward. We create a third Linked List and add each node from left to right carrying the number that go beyond single digits. The algorithm would look like
```
ListNode tempL1 = l1;
ListNode tempL2 = l2;

ListNode l3 = null;
ListNode temp = null;

int sum = 0;
int carry = 0;

while(tempL1 != null && tempL2 != null)
{
    sum = tempL1.val + tempL2.val + carry;
    
    tempL1 = tempL1.next;
    tempL2 = tempL2.next;
    
    int val = sum % 10;
    carry = sum / 10;
    
    ListNode node = new ListNode();
    node.val = val;
    
    if(l3 == null)
    {
        temp = node;
        l3 = temp;
        continue;
    }
    
    temp.next = node;
    temp = temp.next;
}

while(tempL1 != null)
{
    sum = tempL1.val + carry;
    
    tempL1 = tempL1.next;
    
    ListNode node = new ListNode();
    node.val = sum % 10;
    
    temp.next = node;
    temp = temp.next;
    carry = sum / 10;
}

while(tempL2 != null)
{
    sum = tempL2.val + carry;
    
    tempL2 = tempL2.next;
    
    ListNode node = new ListNode();
    node.val = sum % 10;
    
    temp.next = node;
    temp = temp.next;
    carry = sum / 10;
}

if(carry != 0)
{
    temp.next = new ListNode(carry);
}

return l3;

```