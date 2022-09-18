# PrimeNumberGenerator
This app generates a list of Prime Numbers in parallel, spreads the load over as many CPU's that you have.
To set the number of prime numbers you can gererate, in the main app change the parameter passed to the CalculationsClass constructor. 

Things to note

1.) 2 needs be added before all the calculations because one of the requirements of being a prime is that it shouldn't be divisible by two. So you have to first 
check if it is 2 and then add it immidiately to the list and this way you dont have to keep checking if the number is 2. If you check every time if the number is 2, you
you are wasting processing power. 

