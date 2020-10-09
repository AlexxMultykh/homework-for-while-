static void For4()
        {
            int p = 10;
        for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * p);
            }
        }
static void For8()
	{
	    int m = 1;
	    int n = 10;
	    int s = 1;
	    for (int i = m; i <= n; i++)
		{
		    s *= i;
		}
	Console.WriteLine(s);
        }
static void For12()
	{
	int num = 3;
	double s = 1;
	for (int i = 1; i <= num; i++)
	    {
		s *= 1 + (i / 10.0);
	    }
	Console.WriteLine(s);
}
static void For16()
    {
        int N = 3;
        double A = 2;
        double A1 = 1;
        int s = 1;
        if (N > 0)
        {
            for (int i = 0; i < N; i++)
            {
            	A1 = A1 * A;
            	Console.Write(A1);
            	Console.Write(" ");
            	Console.WriteLine(s);
            	s++;
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }

static void For20()
    {
        int N = 4;
        double A = 1;
        double m = 1;
        double B = 0;
        if (N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                A = A * m;
                m++;
                Console.WriteLine(A);
                B = B + A;
            }
            Console.Write(B);
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
static void For24()
    {
        int n=1,z=1;
        double x=3, x1=1, factorial = 1, sum = 1;
        for(int i=1; i<= 2 * n; ++i)
            {
            factorial *= i;
            if (i % 2 == 0)
                {
                    x1 = x * x1;
                    z = (-z);
                    sum += z * ((x1 * x1) / factorial);

                }
            }  
        Console.WriteLine(sum);
    }
static void For28()
    {
        float Rez=1,a=1,Rez1=1,Rez2=1;
        int N = 4;
        for(int i=1; i < N; i++)
        {
            Rez1 *= 2 * i - 3;
            Rez2 *= 2 * i;
            a *= -1;
            Rez += Rez1 * a / Rez2;
        }
        Console.WriteLine(Rez);
    }
static void For32()
    {
        float A = 1;
        int N = 5;
        for(int i=1; i<N; i++)
        {
            A = (A + 1) / i;
            Console.WriteLine(A);
        }

    } 
    