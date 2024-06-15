**You are tasked with creating a class called Student that represents a student's information. The class should demonstrate
encapsulation, properties with different access levels, a constructor, and methods to display student information and determine if
the student is an honor student.**

***Requirements:***

1. Private Variables (fields):
Create private instance variables (fields) for the following student attributes:
studentId (string), firstName (string), lastName (string), yearOfBirth (int), gpa (double)
2. Public Properties:
Create a public property for studentId with only a getter.
Create public properties for firstName and lastName with setters to ensure the user input is not empty.
Create a public property FullName to get the full name (concatenation of first name and last name).
Create a public property Age with only a getter. Use the constructor parameter yearOfBirth to calculate the age. The
statement to calculate the age is as follows:
int age = DateTime.Now.Year - yearOfBirth;
Create a public property for Gpa with a setter to ensure the GPA is between 0.0 and 4.0.
3. Constructor:
Create a constructor that takes the following parameters:
yearOfBirth (int), studentId (string)
Create another constructor that takes all the following parameters:
yearOfBirth (int), studentId (string), firstName (string), lastName (string), gpa (double)
4. Methods:
Implement the following methods in your Student class:
PrintStudentInfo() : This method should print the student's information (student ID, full name, age, and GPA) to the
console.
IsHonorStudent() : This method should return a boolean value indicating whether the student is an honor student (i.e.,
has a GPA of 3.5 or higher).
Instructions:
1. Create the Student class as described above.
2. Create an instance of the Student class in your main program, passing the year of birth in the constructor.
3. Demonstrate the use of the properties to set and get the student's information while enforcing the validation rules.
4. Use the PrintStudentInfo() method to display the student's information.
5. Use the IsHonorStudent() method to determine if the student is an honor student.
