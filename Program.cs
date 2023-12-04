
using System;

class Program
{
    static void Main() { // program starts here
        int[] nums = {1, 2, 23, 4}; //example variables
        int[] concatenatedList = getConcatenation(nums); // function call for the getConcatenation function
        
        Console.WriteLine("{");
        // Print the concatenated array elements
        foreach (int element in concatenatedList) { // this is where we print the results from concactenation
            Console.Write(element + ", ");
        }
         Console.WriteLine("} ");

    }

    static int[] getConcatenation(int[] nums) {
         int n = nums.Length; // we set n to nums size so that we can use it to reference and double the size of the new list
         int[] concatenatedList = new int[n * 2]; // here we double the new list
         
         for(int i = 0; i < n; i++) { //loop makes O(n) time complexity of the process
            concatenatedList[i] = nums[i]; //assign first element to first half of concatenated list
            concatenatedList[i + n] = nums[i]; //assign same element to second half of concatenated list
         }
        
        return concatenatedList; // this is the value we get back from the function call
    }
}


