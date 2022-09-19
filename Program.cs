/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] array = new string[8] {"rojo", "uno", "blanco", "negro", "sol", "dos", "uva", "8loco"};
string[] finalArray = new string[array.Length];
void ShowThreeDigitsArrays (string[] array, string[] finalArray)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i].Length <= 3)
    {
        finalArray[count] = array[i];
        count = count + 1;
    }
   }

}
void PrintFinalArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{finalArray[i]} ");
}
ShowThreeDigitsArrays(array, finalArray);
PrintFinalArray(finalArray);
