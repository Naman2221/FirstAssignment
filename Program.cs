using System;
using System.Collections.Generic;
interface IDisplaying
{
    void DisplayingAssest();
    void DisplayListInMap(List<string> List);
}

interface ISearching
{
    void SearchInList(string Key);
    
}

interface IDelete
{
    void DeleteElementFromList(string Value);
}

interface IUpdate
{
    void UpdateElementInList(string Key,string Value);
}
namespace First_Assignment
{
    class Program 
    {
        
      
       public  int ChoiceOfUser()
       {
           Console.WriteLine("1.Adding In List\n2.Displaying List\n3.Searching Element\n4.Deleting Element\n5.Updating List\n6.Exit");
           Console.WriteLine("Enter Choice:");
           int option=Convert.ToInt32(TakeValueFromUser());
           return option;
       } 
      
       public void AddOpeartionInAssest(Software ObjectOfSoftware,Books ObjectOfBook,Hardware ObjectOfHardware )
       {
           Console.WriteLine("1.In Software\n2.In Books\n3.In Hardware");
           Console.Write("Enter Your Choice-");
           int choice=Convert.ToInt32(TakeValueFromUser());
           switch (choice)
           {
               case 1:
               ObjectOfSoftware.AddComponenetsOfSoftware();
               break;

               case 2:
               ObjectOfBook.AddComponenetsOfBook();
               break;

               case 3:
               ObjectOfHardware.AddComponenetsOfHardware();
               break;
              
              default:
              Console.WriteLine("Invalid Option");
              break;    
           }
            
       }
        

        public void DeleteOpeartionInAssest(Software ObjectOfSoftware,Books ObjectOfBook,Hardware ObjectOfHardware )
        {
           Console.WriteLine("1.In Software\n2.In Books\n3.In Hardware");
           Console.Write("Enter Your Choice-");
           int choice=Convert.ToInt32(TakeValueFromUser());
           Console.WriteLine("Enter Element You Want To Delete:");
           switch (choice)
           {
               case 1:
               ObjectOfSoftware.DeleteElementFromList(TakeValueFromUser());
               break;

               case 2:
               ObjectOfBook.DeleteElementFromList(TakeValueFromUser());
               break;

               case 3:
               ObjectOfHardware.DeleteElementFromList(TakeValueFromUser());
               break;
              
              default:
              Console.WriteLine("Invalid Option");
              break;    
           }
            
        }
          
         public void UpdateAssest(Software ObjectOfSoftware,Books ObjectOfBook,Hardware ObjectOfHardware )
        {
           Console.WriteLine("1.List Of Book\n2.List Of Hardware \n3.List Of Software");
           Console.Write("Enter Your Choice-");
           int choice=Convert.ToInt32(TakeValueFromUser());
           Console.WriteLine("First Enter The Key And Value You Want To Remove");
           switch (choice)
           {
               case 1:
               ObjectOfBook.UpdateElementInList(TakeValueFromUser(),TakeValueFromUser());
               break;

               case 2:
               ObjectOfHardware.UpdateElementInList(TakeValueFromUser(),TakeValueFromUser());
               break;

               case 3:
               ObjectOfSoftware.UpdateElementInList(TakeValueFromUser(),TakeValueFromUser());
               break;
              
              default:
              Console.WriteLine("Invalid Option");
              break;    
           }
        }
        
        public void DisplayingAssest(Software ObjectOfSoftware,Books ObjectOfBook,Hardware ObjectOfHardware )
        {
           Console.WriteLine("1.List Of Book\n2.List Of Hardware \n3.List Of Software");
           Console.Write("Enter Your Choice-");
           int choice=Convert.ToInt32(TakeValueFromUser());
           switch (choice)
           {
               case 1:
               ObjectOfBook.DisplayingAssest();
               break;

               case 2:
               ObjectOfHardware.DisplayingAssest();
               break;

               case 3:
               ObjectOfSoftware.DisplayingAssest();
               break;
              
              default:
              Console.WriteLine("Invalid Option");
              break;    
           }
              
              
              
        }

        
        public string TakeValueFromUser()
        {
            string value=Console.ReadLine();
            return value;
        }

        
       public void SearchingAssestInList(Software ObjectOfSoftware,Books ObjectOfBook,Hardware ObjectOfHardware)
       {
           Console.WriteLine("1.Search In Book\n2.Search In Hardware \n3.Search In Software");
           Console.Write("Enter Your Choice-");
           int choice=Convert.ToInt32(TakeValueFromUser());
           Console.Write("Enter The Key You Want To Search:");
           switch (choice)
           {
               case 1:
               ObjectOfBook.SearchInList(TakeValueFromUser());
               break;

               case 2:
               ObjectOfHardware.SearchInList(TakeValueFromUser());
               break;

               case 3:
               ObjectOfSoftware.SearchInList(TakeValueFromUser());
               break;
              
              default:
              Console.WriteLine("Invalid Option");
              break;    
           }
           
       }
       
        static void Main(string[] args)
        {
            Program ObjectOfProgram=new Program(); 
            Software ObjectOfSoftware=new Software();
            Books ObjectOfBook=new Books();
            Hardware ObjectOfHardware=new Hardware();
            int value = ObjectOfProgram.ChoiceOfUser();

            while(value<6){
                switch (value)
               {
                case 1:ObjectOfProgram.AddOpeartionInAssest(ObjectOfSoftware,ObjectOfBook,ObjectOfHardware);
                       break;  
                
                case 2:ObjectOfProgram.DisplayingAssest(ObjectOfSoftware,ObjectOfBook,ObjectOfHardware);     
                       break;

                case 3:ObjectOfProgram.SearchingAssestInList(ObjectOfSoftware,ObjectOfBook,ObjectOfHardware);
                       break;

                 case 4:ObjectOfProgram.DeleteOpeartionInAssest(ObjectOfSoftware,ObjectOfBook,ObjectOfHardware);      
                        break; 

                case 5:ObjectOfProgram.UpdateAssest(ObjectOfSoftware,ObjectOfBook,ObjectOfHardware);      
                        break;
               }
                value=ObjectOfProgram.ChoiceOfUser();   
            }
        }
    }
}
