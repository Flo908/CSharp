//Un-comment below code and fix the issues
//Push to github


long RecursiveFibonacci(long first, long second, long count){

    count--;

    if(count == 0) {
        return second + first;
    }else{
        return RecursiveFibonacci(first + second, first, count);
    }
}

//You can't any numbers below 1 or above 92, this will crash the program 
while(true){
    Console.Write("Fibonacci of what number?\n> ");
    string text = Console.ReadLine();
    if (text == ""){
        Console.WriteLine("invalid input");
    }else if (text.StartsWith("-")){
       Console.WriteLine("You can't use negative numbers"); 
    }else{
        if(text.All(char.IsDigit)){
            long number = long.Parse(text);
            Console.WriteLine(number);
            long lastFibo = RecursiveFibonacci(1,1,number); 
            Console.WriteLine("Last fibo number was " + lastFibo);
        }else{
            Console.WriteLine("The Given String is Not a Number");
        }
    }
}   