using System;
using System.Collections.Generic;

// Represents a single node in the hash map (linked list node)
class HashNode<K, V>{
    public K Key;  // Key of the entry
    public V Value;  // Value of the entry
    public HashNode<K, V> Next;  // Pointer to the next node (for collision handling)

    // Constructor to initialize the node with key-value pair
    public HashNode(K key, V value){
        Key = key;
        Value = value;
        Next = null;
    }
}

// Custom HashMap class implementing separate chaining for collision handling
class CustomHashMap<K, V>{
    private readonly int size;  // Size of the hash table (number of buckets)
    private readonly LinkedList<HashNode<K, V>>[] map;  // Array of linked lists for separate chaining

    // Constructor to initialize the hash map with a given size (default 10)
    public CustomHashMap(int size = 10){
        this.size = size;
        map = new LinkedList<HashNode<K, V>>[size];

        // Initialize each bucket as an empty linked list
        for (int i = 0; i < size; i++){
            map[i] = new LinkedList<HashNode<K, V>>();
        }
    }

    // Hash function to compute the index for a given key
    private int GetHash(K key){
        return Math.Abs(key.GetHashCode()) % size;
    }

    // Inserts a key-value pair into the hash map
    public void Insert(K key, V value){
        int index = GetHash(key);  // Compute bucket index

        // Check if the key already exists; if so, update its value
        foreach (var node in map[index]){
            if (node.Key.Equals(key)){
                node.Value = value;
                return;
            }
        }

        // If key is not found, insert a new node at the end of the linked list
        map[index].AddLast(new HashNode<K, V>(key, value));
    }

    // Retrieves the value associated with a given key
    public V Get(K key){
        int index = GetHash(key);  // Compute bucket index

        // Search for the key in the linked list
        foreach (var node in map[index]){
            if (node.Key.Equals(key)){
                return node.Value;  // Return value if found
            }
        }

        // Throw exception if key is not found
        throw new KeyNotFoundException("Key not found in HashMap");
    }

    // Removes a key-value pair from the hash map
    public bool Remove(K key){
        int index = GetHash(key);  // Compute bucket index
        var list = map[index];

        // Search for the key and remove it if found
        foreach (var node in list){
            if (node.Key.Equals(key)){
                list.Remove(node);
                return true;
            }
        }
        return false;  // Return false if key is not found
    }

    // Prints the entire hash map (buckets and their contents)
    public void PrintMap(){
        for (int i = 0; i < size; i++){
            Console.Write("Bucket {0}: ", i);

            // Print all key-value pairs in the bucket
            foreach (var node in map[i]){
                Console.Write("[{0}: {1}] -> ", node.Key, node.Value);
            }
            Console.WriteLine("null");  // End of the linked list
        }
    }
}

// Main program to test the custom hash map
class Program{
    public static void Main(string[] args){
        CustomHashMap<int, string> hashMap = new CustomHashMap<int, string>();

        // Insert key-value pairs
        hashMap.Insert(1, "One");
        hashMap.Insert(2, "Two");
        hashMap.Insert(3, "Three");
        hashMap.Insert(11, "Eleven"); // Collision case (same bucket as key 1 in a size 10 map)

        Console.WriteLine("HashMap after insertions:");
        hashMap.PrintMap();

        // Retrieve a value by key
        Console.WriteLine("Value for key 2: {0}",hashMap.Get(2));

        // Remove a key and print the updated map
        hashMap.Remove(2);
        Console.WriteLine("HashMap after deleting key 2:");
        hashMap.PrintMap();
    }
}
