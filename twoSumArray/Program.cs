/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
	public static int[] TwoSum(int[] nums, int target) {
		// Initialize a dictionary to store the number and its index
		Dictionary <int,int> map = new Dictionary<int,int>();

		// Iterate over the array
		for(int i =0; i< nums.Length; i++)
		{


			// Calculate the complement needed to reach the target
			int complement = target - nums[i];
			// If the complement exists in the dictionary, return the indices
			if(map.ContainsKey(complement))
			{
				return new int[] {map[complement], i};
			}
			// Otherwise, add the current number and its index to the dictionary
			map[nums[i]] = i;
		}


		// Return an empty array if no solution is found
		return new int[] {};
	}
	public static void Main()
	{
		int [] nums = {2,3,11,7};
		int target = 9;
		int[] res = TwoSum(nums,target);
		for(int i =0; i < res.Length; i++)
		{
			Console.WriteLine(res[i]);
		}
	}
}
