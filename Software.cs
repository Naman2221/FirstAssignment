using System;
using System.Collections.Generic;

namespace First_Assignment{
    class Software:Program,IDisplaying,ISearching,IDelete,IUpdate{
      
      Dictionary<string,List<string>> Map=new Dictionary<string,List<string>>();
      
      

      public void AddComponenetsOfSoftware()
      {
          Console.Write("Enter Name Of Software:");
          string NameOfSoftware=TakeValueFromUser();
          Console.Write("Enter Version:");
          string VersionOfSoftware=TakeValueFromUser();
          InsertValueInMap(NameOfSoftware, VersionOfSoftware);
      }

      public void InsertValueInMap(string NameOfSoftware,string VersionOfSoftware)
      {
         if(Map.ContainsKey(NameOfSoftware)==false)
         {
             List<string> List=new List<string>();
             List.Add(VersionOfSoftware);
             Map.Add(NameOfSoftware,List);
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
             Console.WriteLine("Name Of Software is:"+Variable.Key);
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