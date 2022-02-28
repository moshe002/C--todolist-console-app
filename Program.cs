// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n");

Console.WriteLine("TO DO LIST v0.1");

Console.WriteLine("\n");
Console.WriteLine("Main Menu:");

 List <string> todoList = new List<string>();

for(int m = 0; m < m+1; m++) {
    Console.WriteLine("A. Add to do (Input 5 to dos) \nB. Delete to do (if you have finished it) \nC. Exit");
    char z = Console.ReadLine()[0];
    
    
    if(z == 'A' || z == 'a'){                      
                   for(int y = 0; y < 5; y++) {    //works but will only ask for 5 todos
                        Console.WriteLine("Add to do: ");
                        todoList.Add(Console.ReadLine()); 
                   }//end of for loop
                   Console.WriteLine("----------------------------");
                   
                    //foreach(string todo in todoList){
                        //Console.WriteLine("TO DO: " + todo);
                            for(int u = 0; u < todoList.Count(); u++) {
                                Console.WriteLine(u + " TO DO: " + todoList[u]);
                                }
                    //}//end of foreach
                    Console.WriteLine("----------------------------");
    }//end of if 
    else if (z == 'B' || z == 'b'){

        Console.WriteLine("Input number on the to do that you want to delete: ");
        int k = Convert.ToInt32(Console.ReadLine());

        todoList.RemoveAt(k);

        Console.WriteLine("----------------------------");
        // foreach(string todo in todoList){
        //     Console.WriteLine("TO DO: " + todo);
        // }//end of foreach
        for(int u = 0; u < todoList.Count(); u++) {
            Console.WriteLine(u + " TO DO: " + todoList[u]);
        }
        Console.WriteLine("----------------------------");
       
    }//end of else if
    else if (z == 'C' || z == 'c'){
        Console.WriteLine("Okay, Goodbye!");
        break;
    } //end of second else if 
    else {
        Console.WriteLine("Wrong Input, try again: ");
    }//end of else
                       
}//end of for loop



