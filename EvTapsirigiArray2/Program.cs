// 1.Parameter olaraq integer array variable-i ve bir integer value qebul eden
// ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
// Misal üçün int[] nums = { 1,5,7}
// deyə bir variable-mız var.yazdığımız metodu çağırıb arqument olaraq nums
// və 3 göndərsək nums arrayının dəyəri  {1,5,7,3} olmalıdır.


int[] nums = { 1, 5, 7 };

Arr(nums, 3);
static void Arr(int[] arr, int value)
{
    Array.Resize(ref arr, arr.Length + 1);
    arr[arr.Length - 1] = value;
    Console.WriteLine(string.Join(",", arr));
}



// 3.Qəbul etdiyi ədədlər siyahısının içərisindəki bütün ədədləri müsbət hala gətirən metod


int[] ints = { 7, -13, 17, -33, -3 };

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] < 0)
    {
        ints[i] *= -1;
    }
}
foreach (int i in ints)
{
    Console.WriteLine(i);
}


// 4.Verilən ədədin faktorialini çap edən alqoritma qurun.

int num = 4;
int x = 1;

for (int i = 1; i <= num; i++)
{
    x *= i;
}
Console.WriteLine(x);


// 5.Fibonacci ardıcıllığını çap edən alqoritma qurun



static int Fibonacci(int num)
{
    int a = 0;
    int b = 1;
    int sum = 0;

    if (num > 1)
    {
        for (int i = 2; i <= num; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return b;
    }
    else
    {
        return num;
    }
}

for (int i = 0; i < 15; i++)
{
    Console.WriteLine(Fibonacci(i));
}