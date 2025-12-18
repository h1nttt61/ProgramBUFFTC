def fibonacci(n):
    if n <= 0:
        return 0
    elif n == 1:
        return 1
    else:
        a, c = 0, 1
        for _ in range(2, n + 1):
            a, c = c , a + c
        return c

if __name__ == "__main__":
    print("fibonacci(10):", fibonacci(10))
