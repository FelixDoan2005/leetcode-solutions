# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def addTwoNumbers(self, l1, l2):

        l1_reversed = list(reversed(l1._list_node_to_array()))
        l1_combined = ""
        for i in l1_reversed:
            l1_combined += str(i)
        l2_reversed = list(reversed(l2._list_node_to_array()))
        l2_combined = ""
        for i in l2_reversed:
            l2_combined += str(i)
        x = (int(l1_combined) + int(l2_combined))
        string_list = list(reversed(str(x)))
        int_list = [int(i) for i in string_list]

        conv_to_listnode = ListNode()
        conv_to_listnode2 = conv_to_listnode._array_to_list_node(int_list)

        return(conv_to_listnode2)

                        
