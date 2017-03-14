using System;

namespace Inheritance
{

	class Program
	{
	
	   static void Main(string[] args)
	   {
		// information is stored here on the heap
		Teacher d = new Teacher();
		d.Teach();
		
		// a derived class is created to inherit from base
		Student s = new Student();
		s.Learn();
		s.Teach();
		Console.Read();

	   }

	   // creates a single base class 
	   class Teacher
	   {

		public void Teach()
		{
		   Console.WriteLine("Teach");
		}

	   }

	   // creates a child class derived from the base to inherit and also create its own method
	   class Student : Teacher
	   {

		public void Learn()
		{
		   Console.WriteLine("Learn");
		}

	   } // Output Teach
       //        Learn
       //        Teach //


	}


}