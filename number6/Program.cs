Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
if (Convert.ToBoolean(a%2)){
    Console.WriteLine("Нечетное");
}else{
    Console.WriteLine("Четное");
}