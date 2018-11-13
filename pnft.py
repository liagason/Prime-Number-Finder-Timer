import time
print('Prime Number Finder & Timer [Version: 1.0.0.1, Compiled: Tuesday, 13 Nov 2018]')
print('Copyright (c) 2018, Sotiris Liagas. All rights reserved.\n')
print('Primality test algorithm is based on trial division and is NOT optimized for speed.')
print('Source code & documentation are available at https://github.com/liagason\n\')
x = int(input('Find all prime numbers up to (e.g.: 500000):'))

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
