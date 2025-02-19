using System;
using System.Collections.Generic;

// Interface for meal plans
interface IMealPlan
{
    string GetMealType();
}

// Different meal categories implementing IMealPlan
class VegetarianMeal : IMealPlan
{
    public string GetMealType() { return "Vegetarian Meal"; }
}

class VeganMeal : IMealPlan
{
    public string GetMealType() { return "Vegan Meal"; }
}

class KetoMeal : IMealPlan
{
    public string GetMealType() { return "Keto Meal"; }
}

class HighProteinMeal : IMealPlan
{
    public string GetMealType() { return "High-Protein Meal"; }
}

// Generic class for Meal
class Meal<T> where T : IMealPlan
{
    public string MealName { get; set; }
    public T MealType { get; set; }

    // Instead of using 'new T()', we pass an instance of T from outside
    public Meal(string name, T mealType)
    {
        MealName = name;
        MealType = mealType;
    }

    public void DisplayMeal()
    {
        Console.WriteLine("Meal Name: {0}", MealName);
        Console.WriteLine("Meal Type: {0}", MealType.GetMealType());
    }
}

// Meal Plan Generator class
class MealPlanGenerator
{
    private List<object> meals = new List<object>(); // Using object to store different types of Meal<T>

    public void AddMeal<T>(Meal<T> meal) where T : IMealPlan
    {
        meals.Add(meal);
    }

    public void DisplayAllMeals()
    {
        Console.WriteLine("\nMeal Plans:");
        foreach (var meal in meals)
        {
            dynamic dynamicMeal = meal; // Use dynamic typing to call the correct method
            dynamicMeal.DisplayMeal();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating meal objects
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>("Green Delight", new VegetarianMeal());
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>("Plant Power", new VeganMeal());
        Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>("Keto Booster", new KetoMeal());
        Meal<HighProteinMeal> proteinMeal = new Meal<HighProteinMeal>("Protein Punch", new HighProteinMeal());

        // Creating Meal Plan Generator
        MealPlanGenerator mealPlan = new MealPlanGenerator();

        // Adding meals
        mealPlan.AddMeal(vegMeal);
        mealPlan.AddMeal(veganMeal);
        mealPlan.AddMeal(ketoMeal);
        mealPlan.AddMeal(proteinMeal);

        // Display all meals
        mealPlan.DisplayAllMeals();
    }
}
