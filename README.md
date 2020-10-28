# MajorityElement
Create a function that takes an array of integers, and returns the majority element.
Majority Element is the value that seen more than n/2.

I am using Linq in this function. Once receiving the array:

- Group the array by element which will generate keys by using array.GroupBy()
- Order the array in descending order by element.Count()
- Since the array is sorted in descending order by .Count(), I can select the first element
