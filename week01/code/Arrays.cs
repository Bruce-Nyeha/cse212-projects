public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


           // STEP 1: Create a new array with a fixed size matching the 'length' requested.
           // If length is 5, this creates a container with 5 empty slots.

            // STEP 2: Use a loop to walk through every single slot in the array, starting at index 0.
            // STEP 3: Multiply the base number by the multiplier.
        // Because array indexes start at 0 (0, 1, 2...), but math multiples start at 1 (x1, x2, x3...), 
        // we add 1 to our current loop index 'i' to get the correct multiplier.
         // STEP 4: Return the completed array back to the program.
             
             double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = number * (i + 1);
            }


        return result; // replace this return statement with your own 

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

      // STEP 1: Calculate the exact split index where the back chunk starts.
// Formula: Total count minus the rotation amount. (e.g., 9 - 3 = index 6)

// STEP 2: Use GetRange to slice the "Back Chunk" from the split index to the end.
// (This grabs elements: 7, 8, 9)

// STEP 3: Use GetRange to slice the "Front Chunk" from index 0 up to the split index.
// (This grabs elements: 1, 2, 3, 4, 5, 6)

// STEP 4: Empty out the original list entirely using .Clear().

// STEP 5: Paste the "Back Chunk" into the original list first using .AddRange().

// STEP 6: Paste the "Front Chunk" immediately behind it using .AddRange().
    int splitIndex = data.Count - amount;
        List<int> backChunk = data.GetRange(splitIndex, amount);
        List<int> frontChunk = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(backChunk);
        data.AddRange(frontChunk);
    }
}
