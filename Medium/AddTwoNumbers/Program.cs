using AddTwoNumbers;

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode tempL1 = l1;
    ListNode tempL2 = l2;

    ListNode l3 = null;
    ListNode temp = null;

    int sum = 0;
    int carry = 0;

    while (tempL1 != null && tempL2 != null)
    {
        sum = tempL1.val + tempL2.val + carry;

        tempL1 = tempL1.next;
        tempL2 = tempL2.next;

        int val = sum % 10;
        carry = sum / 10;

        ListNode node = new ListNode();
        node.val = val;

        if (l3 == null)
        {
            temp = node;
            l3 = temp;
            continue;
        }

        temp.next = node;
        temp = temp.next;
    }

    while (tempL1 != null)
    {
        sum = tempL1.val + carry;

        tempL1 = tempL1.next;

        ListNode node = new ListNode();
        node.val = sum % 10;

        temp.next = node;
        temp = temp.next;
        carry = sum / 10;
    }

    while (tempL2 != null)
    {
        sum = tempL2.val + carry;

        tempL2 = tempL2.next;

        ListNode node = new ListNode();
        node.val = sum % 10;

        temp.next = node;
        temp = temp.next;
        carry = sum / 10;
    }

    if (carry != 0)
    {
        temp.next = new ListNode(carry);
    }

    return l3;
}