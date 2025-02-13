using System;

class Stack{
    static readonly int  maxsize=10; // Maximum size of the stack
    int top; // Index of the top element
    int[] stack = new int[maxsize]; // Array to store stack elements

    // Constructor to initialize the stack
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
            Console.WriteLine("Overflow!");
            return;
        }
        stack[++top] = x; 
    }

    // Method to pop an element from the stack
    public int Pop(){
        if(top < 0){
            Console.WriteLine("Underflow!");
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
    public void Count(){
        if(top < 0){
            Console.WriteLine("Stack is empty.");
            return;
        }
        Console.WriteLine("Number of elements in stack: " + (top + 1));
    }
}

class Program{
    public static void Main(string[] args){
        Stack st = new Stack();
        
        // Push elements onto the stack
        st.Push(10);
        st.PrintStack();

        st.Push(20);
        st.PrintStack();

        st.Push(30);
        st.PrintStack();
        st.Count();

        // Check if stack is empty
        Console.WriteLine("Is stack empty: " + st.isEmpty());

        // Pop an element from the stack
        Console.WriteLine("Popped: " + st.Pop());
        st.PrintStack();

        // Peek at the top element
        st.Peek();
    }
}