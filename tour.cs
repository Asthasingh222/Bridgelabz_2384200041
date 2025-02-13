using System;

class CircularTour {
    public static int FindStartingPoint(int[] petrol, int[] distance) {
        int totalSurplus = 0, surplus = 0, start = 0;

        for (int i = 0; i < petrol.Length; i++) {
            totalSurplus += petrol[i] - distance[i]; // Net surplus over entire journey
            surplus += petrol[i] - distance[i];

            // If surplus becomes negative, reset start point
            if (surplus < 0) {
                surplus = 0;
                start = i + 1;
            }
        }

        return totalSurplus >= 0 ? start : -1; // If net surplus is negative, no tour possible
    }

    public static void Main() {
        int[] petrol = {4, 6, 7, 4};
        int[] distance = {6, 5, 3, 5};

        int startIndex = FindStartingPoint(petrol, distance);
        Console.WriteLine(startIndex == -1 ? "No circular tour possible" : "Start at petrol pump: {0}",startIndex);
    }
}
