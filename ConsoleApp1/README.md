Stage 2 – Polymorphism with List, Array and IEnumerable

In this stage, we extended the previous implementation so the method can accept different input types: 

1-using method overloading :

i create a two seprate method 

List<int> FilterNumbers(List<int> numbers)
List<int> FilterNumbers(int[] numbers)

both have the saame but diffrent parameter type ->polymorphism via overloading.

Using IEnumerable<int>:
i added another method 
List<int> FilterNumbers(IEnumerable<int> numbers)
This version supports any collection type