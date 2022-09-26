Console.Write("Please Enter a Positive Integer to get its Fibonacci series: ");
int result = Fibonacci(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(result);

static int Fibonacci(int n){
    int n1 = 0;
    int n2 = 1;
    int sum;

    for(int i = 2; i <= n; i++){
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0? n1:n2;
}
