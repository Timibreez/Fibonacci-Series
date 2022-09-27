using System.Diagnostics;

Debug.Write("Please Enter a Positive Integer to get its Fibonacci series: ");

int result = Fibonacci(6);

Console.WriteLine(result);

static int Fibonacci(int n){
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {n}th number");
    int n1 = 0;
    int n2 = 1;
    int sum;

    for(int i = 2; i <= n; i++){
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
    }

    Debug.Assert(n2 == 5, "The return value should be 5 and it is not.");
    return n == 0? n1:n2;
}
