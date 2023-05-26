// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int InputNumber()
{

    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
// void CreateArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 1);
//     }

// }
void InputArray(int[] arr){
     for (int i=0; i<arr.Length; i++){
       Console.Write("Введите число: ");
       int a =InputNumber(); 
       arr[i] = a;
     } 
    
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int Proverka(int[] arr){
    int count = 0;
    for (int i=0; i<arr.Length; i++){
       if(arr[i]>0){
        count++;
       }
     } 
    return count; 
}

Console.Write("сколько цифр хотите проверить ? ");
int size = InputNumber();
int[] array = new int[size];
InputArray(array);
PrintArray(array);
Console.WriteLine($"Цифр больше нуля {Proverka(array)} штук");