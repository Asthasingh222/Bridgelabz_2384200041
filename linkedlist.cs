using System;
class Node {
    public int Data;
    public Node Next;

    public Node(int data) {
        Data = data;
        Next = null;
    }
}
class Program{
    public static void Main(string[] args){
        Node n1=new Node(13);
        Node n2=new Node(14);
        n1.Next=n2;
        Node head =n1;
        while(head!=null){
            Console.WriteLine(head.Data);
            head=head.Next;
        }
    }
}
