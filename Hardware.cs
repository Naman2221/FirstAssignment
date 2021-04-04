using System;
using System.Collections.Generic;



namespace First_Assignment{
    class Hardware:Program,IDisplaying,ISearching,IDelete{
      
      Dictionary<string,List<string>> Map=new Dictionary<string,List<string>>();
      
      

      public void AddComponenetsOfHardware()
      {
          Console.Write("Enter Name Of Hardware:");
          string NameOfHardware=TakeValueFromUser();
          Console.Write("Enter Id Of Hardware:");
          string IdOfHardware=TakeValueFromUser();
          InsertValueInMap(NameOfHardware, IdOfHardware);
      }

      public void InsertValueInMap(string NameOfHardware,string IdOfHardware)
      {
         if(Map.ContainsKey(NameOfHardware)==false)
         {
             List<string> List=new List<string>();
             List.Add(IdOfHardware);
             Map.Add(NameOfHardware,List);
            
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
             Console.WriteLine("Name Of Hardware is:"+Variable.Key);
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


    }
}