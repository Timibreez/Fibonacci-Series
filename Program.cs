// See https://aka.ms/new-console-template for more information
Console.Write("Please enter an Integer to find its Fibonacci Series: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Fibonacci(result));

static int Fibonacci(int n){
    int n1 = 0;
    int n2 = 1;
    int sum;

    for(int i = 2; i < n; i++){
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0? n1:n2;
}
