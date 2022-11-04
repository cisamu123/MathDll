import clr
clr.AddReference('MathDll') # Add DLL to the code
from MathDll import * # Importing all from DLL

p = Addition() # Addition is class
p.Main(1,2) # Main is void
p = Subtraction() 
p.Main(5,36)
p = Multiplication()
p.Main(4,23)
p = Division()
p.Main(23,45)
