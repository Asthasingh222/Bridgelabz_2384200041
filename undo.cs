using System;

class TextNode {
    public string content;
    public TextNode next;
    public TextNode prev;
    
    public TextNode(string content) {
        this.content = content;
        this.next = null;
        this.prev = null;
    }
}

class TextEditor {
    private TextNode head;
    private TextNode current;
    private int maxSize = 10;
    private int size = 0;

    // Add a new state (action) to the list
    public void AddState(string newContent) {
        TextNode newNode = new TextNode(newContent);
        
        if (head == null) {
            head = newNode;
            current = newNode;
        } 
        else{
            newNode.prev = current;
            current.next = newNode;
            current = newNode;
        }
        
        // Ensure history doesn't exceed max size
        if (size == maxSize) {
            head = head.next;
            head.prev = null;
        }
        else    size++;
    }

    // Undo functionality - moves to the previous state
    public void Undo() {
        //if there is atleast one state available before current state
        if (current != null && current.prev != null) {
            current = current.prev;
            Console.WriteLine("Undo: " + current.content);
        } 
        else Console.WriteLine("No more undo steps available.");
    }

    // Redo functionality - moves to the next state
    public void Redo() {
        //if there is atleast one state available after current state
        if (current != null && current.next != null) {
            current = current.next;
            Console.WriteLine("Redo: " + current.content);
        } 
        else Console.WriteLine("No more redo steps available.");
    }

    // Display the current state of the text
    public void DisplayCurrentState() {
        if (current != null) Console.WriteLine("Current Text: " + current.content);
        else Console.WriteLine("Text editor is empty.");
    }
}

class Program {
    public static void Main(string[] args) {
        TextEditor editor = new TextEditor();
        
        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");
        
        editor.DisplayCurrentState();
        editor.Undo();
        editor.Undo();
        editor.Redo();
        
        editor.AddState("Hello Universe");
        editor.DisplayCurrentState();
    }
}
