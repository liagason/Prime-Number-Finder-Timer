import time

x = 500000

t0 = time.time()
for num in range(2,x):
    for i in range(2,x):
        if (num % i) == 0:
            break
        else:
            print(num)
            break
t1 = time.time()
total_time = t1-t0
print("Needed",total_time,"SECONDS to VERIFY AND PRINT all prime numbers up to",x)

t2 = time.time()
for num in range(2,x):
    for i in range(2,x):
        if (num % i) == 0:
            break
        else:
            break
t3 = time.time()
total_time = t3-t2
print("Needed",total_time,"SECONDS to JUST PRINT all prime numbers up to",x)

input()