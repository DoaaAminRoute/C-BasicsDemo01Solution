using System.Runtime.CompilerServices;

namespace Demo01
{
	// 1] class
	// 2] Struct
	// 3] Enum
	// 4] Interface

	internal class Program
	{
		// Data + Behaviors [Field, Prop, Var + Methods]

		// 1] Class Level Variable Scope [Field]: Visible Only To Every Method Inside Class

		static string schoolName = "IPS";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">X is Frist Num</param>
		/// <param name="y">Y Second Num</param>
		/// <returns>esult Of Submission</returns>
		public int Sum(int x, int y)
		{
			return x + y;
		}
		static void Main(string[] args)  // Entry Point Of Console App
		{
			#region Comments & Regions
			//Ctrl + K , Crtl + C--> Comment
			// Ctrl + K , Crtl + U--> UnComment 

			///We Use Comment To Explain Code To Others(Or Future You)
			/// One Line Comment
			/// One Line Comment
			/// One Line Comment
			/// One Line Comment
			/// One Line Comment

			/*This IS Multi Line Comment
				BlaBla
				Doaa*/
			/* 1
			 * 2
			 * 3
			 */

			#endregion

			#region Variables Declaration

			//// DataType NameOfVar   =   Value

			//// Variable  Decalration With Intialzed
			//string studentName = "Ahmed" ;
			//int studentAge = 20;
			//double studentGPA = 3.5;  

			//// Name: Ahmed, Age: 20, GPA: 3.5

			//Console.WriteLine($"Name: {studentName}, Age: {studentAge}, GPA: {studentGPA}"); // String InterPolation

			// Console.WriteLine(schoolName);



			#endregion

			#region Variable Scope

			// 2] Method Level var: Only Visible Inside Method Only 
			// 
			//string name = "Ahmed";

			//Console.WriteLine(name);

			//// 3] Scope Level Variable : Visble Within Scope 
			//if (true)
			//{
			//	int Points = 5;

			//	Console.WriteLine(Points);
			//}

			// Console.WriteLine(Points); // Invalid
			#endregion

			#region Naming Convention 


			//string studentName; // camelCase
			//string StudentName; // PascalCase



			#endregion

			#region Value Type Data Type

			//int age;
			/// Declare For Uninitialzed Variable Of Type Int
			/// CLR Will Allocate 4 Uninitialzed Bytes AT STACK
			//age = 20;
			//// Intailze Age With 20

			//int copiedAge = age; // 20

			//Console.WriteLine(age);
			//Console.WriteLine(copiedAge);

			//Console.WriteLine("*************************");

			//copiedAge = 25;


			//Console.WriteLine(age);     
			//Console.WriteLine(copiedAge);


			#endregion

			#region Reference Type Data Type

			//Student student01;
			///// Declare For Refernce Of Type "Student", Refering To The Default Value Of Refernce Types = NULL
			///// This Refernce "student01" Can Refer To An Object From Type Student Or Another Type "Inheriting From Student"
			///// CLR Will Allocate 4Bytes For Reference "student01" AT STACK
			///// CLR Will Allocate Zero Bytes At HEAP

			//student01 = new Student();
			//// new
			////// 1. Allocate The Required Number Of Bytes In HEAP (Object Size + CLR Overhead varicables)
			///// 2. Initialize Allocated Bytes With It is Default Value Of It is Data Type 
			///// 3. Call User_defined Constructor If Exists
			///// 4. Assign The Allocate Object To Reference "student" 

			//student01.id = 10;

			////Console.WriteLine(student01.id);


			//Student student02 = student01;

			//Console.WriteLine(student01.id);  // 10
			//Console.WriteLine(student02.id);  // 10


			//student02.id = 20;

			//Console.WriteLine("************************");

			//Console.WriteLine(student01.id); // 20
			//Console.WriteLine(student02.id); // 20



			//string name01 = "Doaa";
			//string name02 = "Mariam";

			//Console.WriteLine(name01);
			//Console.WriteLine(name02);

			//Console.WriteLine("*******************");


			//name02 = name01; // Address Of Doaa

			//Console.WriteLine(name01);
			//Console.WriteLine(name02);

			//Console.WriteLine("*******************");

			//name02 = "Hamda";

			//Console.WriteLine(name01);
			//Console.WriteLine(name02);

			//// String Special Refernce Type  "Immutable" Like Value Type 




			#endregion

		}


	}
}
