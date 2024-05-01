//Задача 1

// Задайте массив.Напишите программу,которая определяет,присутствует ли заданное число в массиве. 
// Программа долж навыдать ответ:Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// int[] array01 = { 1, 3, 4, 19, 3 };
// // int[] array02 = {-4,3,4,1};

// Console.WriteLine("Введите искомое число в массиве: ");
// int searchVar = Convert.ToInt32(Console.ReadLine());
// bool isExist = false;


// for(int i = 0; i < array01.Length; i++)
// {
//     if(array01[i] == searchVar)
//     {
//         isExist = true;
//         break;
//     }
// }
// string result = isExist ? "Да" : "Нет"; //тернарный оператор!!!
// Console.WriteLine(result);

// можно было так Console.WriteLine(isExist ? "Да" : "Нет"); было бы то же самое


// int[] array1=new int[5];
// int[] array2=new int[5] {3,6,8,3,9};
// int[] array3=new int[] {3,6,8,3,9};

int[] array = { 1, 3, 8, 4, 19, 3, 8 };
int num = 8;

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}

//string result = isExistNum ? "Да" : "Нет"; 
Console.WriteLine(isExistNum ? "Да" : "Нет");