using System;
using System.Collections.Generic;

// Node class representing a user in the social media network
class UserNode {
    public int userID;         
    public string name;         
    public int age;            
    public List<int> friends;   
    public UserNode next; 

    // Constructor to initialize user details
    public UserNode(int userID, string name, int age) {
        this.userID = userID;
        this.name = name;
        this.age = age;
        this.friends = new List<int>(); // Initialize an empty list for storing friend IDs
        this.next = null; // Initially, there is no next user
    }
}

// Class representing the social media system
class SocialMedia {
    private UserNode head; // Head node of the linked list

    // Function to add a new user at the beginning of the list
    public void AddUser(int userID, string name, int age) {
        UserNode newUser = new UserNode(userID, name, age);
        newUser.next = head; // Insert the new user at the beginning
        head = newUser; // Update the head
        Console.WriteLine("User added successfully: " + name);
    }

    // Function to find a user by their User ID
    private UserNode FindUserByID(int userID) {
        UserNode temp = head;
        while (temp != null) {
            if (temp.userID == userID) return temp; // Return user if found
            temp = temp.next; // Move to the next user
        }
        return null; // Return null if user not found
    }

    // Function to search for a user by Name
    public void SearchUserByName(string name) {
        UserNode temp = head;
        bool found = false;
        while (temp != null) {
            if (temp.name==name) {
                Console.WriteLine("User Found: ID: " + temp.userID + ", Name: " + temp.name + ", Age: " + temp.age);
                found = true;
            }
            temp = temp.next;
        }
        if (!found) Console.WriteLine("User not found.");
    }

    // Function to add a friend connection between two users
    public void AddFriendConnection(int userID1, int userID2) {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        // Check if one or both user does not exist
        if (user1 == null || user2 == null) {
            Console.WriteLine("One or both users not found.");
            return;
        }

        // Ensure users are not adding themselves as friends
        if (userID1 == userID2) {
            Console.WriteLine("A user cannot be friends with themselves.");
            return;
        }

        // Add each other's IDs to the friend lists if not already friends
        if (!user1.friends.Contains(userID2)) {
            user1.friends.Add(userID2);
        }
        if (!user2.friends.Contains(userID1)) {
            user2.friends.Add(userID1);
        }

        Console.WriteLine("Friend connection added between " + user1.name + " and " + user2.name);
    }

    // Function to remove a friend connection
    public void RemoveFriendConnection(int userID1, int userID2) {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        // Check if both users exist
        if (user1 == null || user2 == null) {
            Console.WriteLine("One or both users not found.");
            return;
        }

        // Remove friend connection if exists
        if (user1.friends.Contains(userID2)) {
            user1.friends.Remove(userID2);
        }
        if (user2.friends.Contains(userID1)) {
            user2.friends.Remove(userID1);
        }

        Console.WriteLine("Friend connection removed between " + user1.name + " and " + user2.name);
    }

    // Function to display all friends of a specific user
    public void DisplayFriends(int userID) {
        UserNode user = FindUserByID(userID);
        if (user == null) {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine("Friends of " + user.name + ":");
        if (user.friends.Count == 0) {
            Console.WriteLine("No friends found.");
            return;
        }

        // Display each friend's ID
        foreach (int friendID in user.friends) {
            UserNode friend = FindUserByID(friendID);
            if (friend != null) {
                Console.WriteLine("Friend: " + friend.name + " (ID: " + friend.userID + ")");
            }
        }
    }

    // Function to find mutual friends between two users
    public void FindMutualFriends(int userID1, int userID2) {
        UserNode user1 = FindUserByID(userID1);
        UserNode user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null) {
            Console.WriteLine("One or both users not found.");
            return;
        }

        Console.WriteLine("Mutual friends between " + user1.name + " and " + user2.name + ":");
        List<int> mutualFriends = new List<int>();

        // Check common friends
        foreach (int friendID in user1.friends) {
            if (user2.friends.Contains(friendID)) {
                mutualFriends.Add(friendID);
            }
        }

        if (mutualFriends.Count == 0) {
            Console.WriteLine("No mutual friends found.");
            return;
        }

        // Display mutual friends
        foreach (int friendID in mutualFriends) {
            UserNode friend = FindUserByID(friendID);
            if (friend != null) {
                Console.WriteLine("Friend: " + friend.name + " (ID: " + friend.userID + ")");
            }
        }
    }

    // Function to count the number of friends a user has
    public void CountFriends(int userID) {
        UserNode user = FindUserByID(userID);
        if (user == null) {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine(user.name + " has " + user.friends.Count + " friends.");
    }
}

// Main program
class Program {
    public static void Main(string[] args) {
        SocialMedia network = new SocialMedia();

        // Adding users
        network.AddUser(101, "Priya", 25);
        network.AddUser(102, "Riya", 27);
        network.AddUser(103, "Siya", 30);
        network.AddUser(104, "David", 22);

        // Adding friend connections
        network.AddFriendConnection(101, 102);
        network.AddFriendConnection(101, 103);
        network.AddFriendConnection(102, 104);
        network.AddFriendConnection(103, 104);

        Console.WriteLine("-------------------------------");

        // Displaying friends of a user
        network.DisplayFriends(101);
        Console.WriteLine("-------------------------------");

        // Finding mutual friends
        network.FindMutualFriends(101, 104);
        Console.WriteLine("-------------------------------");

        // Searching for a user by name
        network.SearchUserByName("Siya");
        Console.WriteLine("-------------------------------");

        // Counting number of friends of a user
        network.CountFriends(102);
        Console.WriteLine("-------------------------------");

        // Removing a friend connection
        network.RemoveFriendConnection(101, 103);
        Console.WriteLine("-------------------------------");

        // Display updated friends list
        network.DisplayFriends(101);
    }
}
