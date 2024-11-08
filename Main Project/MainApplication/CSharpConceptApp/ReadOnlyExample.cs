using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp
{
   		class ReadOnlyTest
		{    
	      //You have to initilize readonly varabiles while declaration or in constructor  
	      readonly int RollNo = 1284;  
	   
	      //Valid scenario  
	      readonly int Age;  
	   
	      readonly string Name = "Satish Kumar";  
	  
	      //readonly fields can be initlized in constructor  
	      public ReadOnlyTest(string name)
	      {  
	          Age = 23;  
	          Name = name;     
	      }

        //public changeName(string newName)
        //{
        //    Name = "Satish Kumar Vadlavalli"; ;   // Will result error.  
			
        //}
    }  

		class ReadOnlyExample
		{        
			//public static void Main()
			//{
			//	ReadOnlyTest obj = new ReadOnlyTest("Satish");
			//	Console.Read();
   //      }
    }  

}
