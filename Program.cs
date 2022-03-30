Console.WriteLine("****** Array Practice *******");

// 1. Creating arrays
Console.WriteLine("--- 1. Practice creating arrays ---");

// Example: Array of animals
string[] animalArray = {"fish", "cat", "bird", "dog"};
Console.WriteLine("Animals are:");
foreach (string i in animalArray)
{
    Console.WriteLine(i);
}
// 1.a. TODO: Make an array with some favorite foods

string[] favoriteFoods = {"raspberries", "strawberries", "pizza", "cheesecake"};

// console.log('My favorite foods are: ' + favoriteFoods);

// 1.b. TODO: Log your array of foods to the console with a message, similar
//      to the example above
Console.WriteLine("Favorite foods are:");
foreach (string food in favoriteFoods)
{
    Console.WriteLine(food);
}

// 2. Array.length - tells you how many items are in the array
Console.WriteLine("--- 2. Length of an array ---");

// Example: How many animals are in the array?
Console.WriteLine("Number of animals: " + animalArray.Length);

// 2.a. TODO: Log to the console the number of foods in your array
Console.WriteLine("Number of favorite foods: " + favoriteFoods.Length);

// 3. Accessing array items
Console.WriteLine("--- 3. Accessing items in an array ---");

// Example: Log the first animal from the array using it's array index
Console.WriteLine("First animal is " + animalArray[0]);

// 3.a. TODO: Log the second animal in the array
Console.WriteLine("Second animal is " + animalArray[1]);

// 3.b. TODO: Log the last animal in the array using it's array index
Console.WriteLine("Last animal is " + animalArray[3]);

// 3.c. (STRETCH) TODO: Log the last animal by using the array length,
//      instead of the exact index number of the last item
Console.WriteLine(animalArray[animalArray.Length-1]);

// 4. Adding & Removing Array Items
// console.log('--- 4. Adding and removing array items ---');

// Example: Add an animal to the end using Array.push
// animalArray.push('penguin');
// console.log('Added an animal to end,', animalArray);

// 4.a. TODO: Add a new food at the end of your array & log the array

// favoriteFoods.push('blueberries');
// console.log('Added a favorite food to end, ',favoriteFoods);

// Example: Remove the last animal by using Array.pop
// let removedAnimal = animalArray.pop();
// console.log('Removed the last animal', removedAnimal);
// console.log('The animals are now', animalArray);

// 4.b. TODO: Remove the food at the end of your array &
//      log both the food removed and the updated array

// let removedFood=favoriteFoods.pop();
// console.log('Removed the last favorite food', removedFood);
// console.log('My favorite foods are now', favoriteFoods);

// Example: Add an animal to the beginning using Array.unshift
// animalArray.unshift('walrus');
// console.log(`Added an animal to beginning: ${animalArray}`);

// 4.c. TODO: Add a food at the beginning of the array & log the array

// favoriteFoods.unshift('mangos');
// console.log(`Added a favorite food to beginning: ${favoriteFoods}`);

// Example: Remove the first animal using Array.shift
// removedAnimal = animalArray.shift();
// console.log('Removed the first animal', removedAnimal);
// console.log('The animals are now', animalArray);

// 4.d TODO: Remove the food at the beginning of your array &
//     log both the food removed and the updated array

// removedFood=favoriteFoods.shift();
// console.log('Removed the first favorite food', removedFood);
// console.log('My favorite foods are now', favoriteFoods);