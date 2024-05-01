// задача 3

// /*Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.*/

int[] array01 = { 1, 3, 2, 4, 2, 3 };
int[] array02 = new int[array01.Length/2];
// int i = 0;


int left = 0;
int right = array01.Length - 1;

while(left < right)
{
    array02[left] = array01[left] * array01[right];
    left++;
    right--;
}

for(int j = 0; j < array02.Length; j++)
{
    Console.Write(array02[j] + " ");
}

