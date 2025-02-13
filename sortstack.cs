using System;

class Stack{
    static readonly int  maxsize=10; // Maximum size of the stack
    int top; // Index of the top element
    int[] stack = new int[maxsize]; // Array to store stack elements

    // Constructor to initialize the stack
    public Stack(){
        top = -1; // Stack is initially empty
    }

    // Method to check if the stack is empty
    public bool isEmpty(){
        return top < 0;
    }

    // Method to push an element onto the stack
    public void Push(int x){
        if(top >= maxsize - 1){ // Check for stack overflow
            return;
        }
        stack[++top] = x; // Increment top and insert element
    }

    // Method to pop an element from the stack
    public int Pop(){
        if(top < 0){ // Check for stack underflow
            return 0;
        }
        return stack[top--]; // Return top element and decrement top
    }
    
    // Method to display the top element of the stack
    public void Peek(){
        if(top < 0){ // Check if stack is empty
            return;
        }
        Console.WriteLine("Top element: " + stack[top]);
    }

    // Method to print all elements in the stack
    public void PrintStack(){
        if(top < 0){ // Check if stack is empty
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
        if(top < 0){ // Check if stack is empty
            Console.WriteLine("Stack is empty.");
            return;
        }
        Console.WriteLine("Number of elements in stack: " + (top + 1));
    }

    // Method to insert an element in sorted order
    private void InsertSorted(int x){
        if (isEmpty() || stack[top] <= x) {
            Push(x);
            return;
        }
        int temp = Pop();
        InsertSorted(x);
        Push(temp);
    }

    // Method to sort the stack using recursion
    public void SortStack(){
        if (!isEmpty()) {
            int temp = Pop();
            SortStack();
            InsertSorted(temp);
        }
    }
}

class Program{
    public static void Main(string[] args){
        Stack st = new Stack(); // Create a new stack
        
        // Push elements onto the stack
        st.Push(30);
        st.Push(10);
        st.Push(50);
        st.Push(20);
        st.Push(40);
        
        Console.WriteLine("Original Stack:");
        st.PrintStack();

        // Sort the stack
        st.SortStack();

        Console.WriteLine("Sorted Stack:");
        st.PrintStack();
    }
}
