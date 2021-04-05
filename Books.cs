using System;
using System.Collections.Generic;

namespace First_Assignment{
    class Books:Program,IDisplaying,ISearching,IDelete{
      
      Dictionary<string,List<string>> Map=new Dictionary<string,List<string>>();
      
      

      public void AddComponenetsOfBook()
      {
          Console.Write("Enter Name of Book:");
          string NameOfBook=TakeValueFromUser();
          Console.Write("Enter Author Name:");
          string AuthorOfBook=TakeValueFromUser();
          InsertValueInMap(NameOfBook, AuthorOfBook);
      }

      public void InsertValueInMap(string NameOfBook,string AuthorOfBook)
      {
         if(Map.ContainsKey(NameOfBook)==false)
         {
             List<string> List=new List<string>();
             List.Add(AuthorOfBook);
             Map.Add(NameOfBook,List);
         }
         else
         {
             Console.WriteLine("The Software is already present in the list");
         }
      }

      public void DisplayingAssest()
      {
         if(Map.Count == 0)
         {
             Console.WriteLine("No Element In  List ");
             return;
         }

         foreach (KeyValuePair<string,List<string>>  Variable in Map)
         {
             Console.WriteLine("Name Of Book is :"+Variable.Key);
             Console.WriteLine("Follows As:");
             DisplayListInMap(Variable.Value);
         }
     }


     public void SearchInList(string Key)
     {
         if(Map.ContainsKey(Key))
         {
             Console.WriteLine("Element  Is Present In The List");
         }
         else
         {
             Console.WriteLine("Element Is Not Present In List");
         }
     }

     public void DisplayListInMap(List<string> list)
     {
         foreach(string Value in list)
         {
             Console.WriteLine(Value);
         }
     }


     public void DeleteElementFromList(string Value)
     {
         if(Map.Remove(Value))
        {
            Console.WriteLine("Element Is Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Could Not Able To Delete The Element");
        }
     }

     public void UpdateElementInList(string Key,string Value)
     {
         if(Map.ContainsKey(Key))
         {
             List<string> list=Map[Key];
             list.Remove(Value);
             Console.WriteLine("Enter New Value You Want To Update");
             list.Add(TakeValueFromUser());
         }
     }

    }
}