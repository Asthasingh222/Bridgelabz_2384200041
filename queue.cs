using System;

class Stack{
    static readonly int  maxsize=10;
    public int top;// Index of the top element
    public int[] stack = new int[maxsize];

    // Constructor to initialize empty stack
    public Stack(){
        top = -1; 
    }

    // Method to check if the stack is empty
    public bool isEmpty(){
        return top < 0;
    }

    // Method to push an element onto the stack
    public void Push(int x){
        // Check for stack overflow
        if(top >= maxsize - 1){ 
            return;
        }
        stack[++top] = x; 
    }

    // Method to pop an element from the stack
    public int Pop(){
        if(top < 0){
            return 0;
        }
        return stack[top--]; 
    }
    
    // Method to display the top element of the stack
    public void Peek(){
        if(top < 0){ 
            Console.WriteLine("Underflow! No element in the Stack.");
            return;
        }
        Console.WriteLine("Top element: " + stack[top]);
    }

    // Method to print all elements in the stack
    public void PrintStack(){
        if(top < 0){ 
            Console.WriteLine("Stack is empty.");
            return;
        }
        Console.WriteLine("Stack Elements:");
        for(int i = top; i >= 0; i--){
            Console.Write(stack[i] + "   ");
        }
        Console.WriteLine();
    }

    // Method to count the number of elements in the stack
    public int Count(){
        if(top < 0){
            return 0;
        }
        return (top+1);
    }
}
class Queue{
    Stack s1 = new Stack();
    Stack s2 = new Stack();

    // Method to push an element in the queue
    public void Enqueue(int x){
        while(s1.Count()>0){
            s2.Push(s1.Pop());
        }
        s1.Push(x);

        while(s2.Count()>0){
            s1.Push(s2.Pop());
        }
    }

    // Method to check if the queue is empty
    public bool IsEmpty(){
        return s1.Count()==0;
    }

    // Method to pop an element from the queue
    public int Dequeue(){
        if(s1.Count()==0){
            Console.WriteLine("Underflow! Queue is empty.");
            return 0;
        }
        return s1.Pop();
    }

    //method to print front element of the queue
    public void Peek(){
        if(s1.top < 0){ 
            Console.WriteLine("Underflow! No element in the Queue.");
            return;
        }
        Console.WriteLine("Front element: " + s1.stack[s1.top]);
    }

    //method to print queue elements
    public void PrintQueue(){
        if(s1.Count()==0){
            Console.WriteLine("Underflow! Queue is empty.");
            return;
        }
        Console.WriteLine("Queue Elements:");
        for(int i = s1.top; i>=0; i--){
            Console.Write(s1.stack[i] + "   ");
        }
        Console.WriteLine();

    }

    //method to count number of elements of the queue
    public int Count(){
        if(s1.top < 0){
            return 0;
        }
        return (s1.top+1);
    }


}
class Program{
    public static void Main(string[] args){
        Queue q = new Queue();
        
        // Push elements in the queue
        q.Enqueue(1);
        q.PrintQueue();

        q.Enqueue(2);
        q.PrintQueue();

        q.Enqueue(3);
        q.PrintQueue();
        q.Count();

        // Check if stack is empty
        Console.WriteLine("Is queue empty: " + q.IsEmpty());

        // Pop an element from the stack
        Console.WriteLine("Popped: " + q.Dequeue());
        q.PrintQueue();

        // Peek at the top element
        q.Peek();
    }
}