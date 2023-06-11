Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("max : ");
if (a<b){
    if(b<c){
        Console.WriteLine(c);    
    }else{
        Console.WriteLine(b);
    }
}else if(a<c){
    Console.WriteLine(c);
}else{
    Console.WriteLine(a);
}