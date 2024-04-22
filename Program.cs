// Initialize a list of strings with duplicates
List<string> items = new List<string> { "A", "B", "C", "D", "C" };
// Create a HashSet to track seen items
HashSet<string> seenItems = new HashSet<string>();

// Loop through each item in the list
foreach (var item in items)
{
    // Check if the item is already in the HashSet (seenItems)
    if (!seenItems.Add(item))  // Add returns false if the item was already in the set
    {
        // Print message if the item is a duplicate
        Console.WriteLine($"{item} - this item is a duplicate");
    }
    else
    {
        // Print message if the item is unique
        Console.WriteLine($"{item} - this item is unique");
    }
}
