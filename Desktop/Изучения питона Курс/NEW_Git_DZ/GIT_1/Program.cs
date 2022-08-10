string[] array1 = new string[6] {"hello","2", "world",":-)", "1234","1567"};
string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)//пока длина массива будет больше i будет выполняться этот цикл
    {
    if(array1[i].Length <= 3)// условие при котором мы будем выводить элемент массива 
        {
        array2[count] = array1[i];
        count++;
        }
    }
}