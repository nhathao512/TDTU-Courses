# -*- coding: utf-8 -*-
"""Lab2.ipynb

Automatically generated by Colab.

Original file is located at
    https://colab.research.google.com/drive/1GGPIBauKl8XM49UyXCLlWzFLoInHXFYv
"""

#Exercise 1:
import numpy as np
x = [1, 2, 3, 4, 5]
b = [1, 2, 3, 4, 5, 6]
vx = np.array(x)
vb = np.array(b)
c = np.arange(1, 31, 1)
d = np.arange(1, 26, 1)
print("vx =", vx)
print("vb =", vb)
print("vc =", c)
print("vd =", d)
#a
print()
A1 = np.tile(x, (5,1))
print("A1 =", A1)
print("A =", A1.T)
#b
print()
B = np.tile(b, (6,1))
print("B =", B)
#c
print()
C = np.reshape(c, (6, 5))
print("C =", C.T)
#d
print()
D = np.reshape(d, (5,5))
print("D =", D)

#Exercise 2:
a = int(input())
b = int(input())
C = np.random.randint(a, b, (5, 6))
print(C)

#Exercise 3:
import numpy as np
a = np.arange(1, 10, 1)
print(a)
A = np.reshape(a, (3,3))
print("A =", A)
B = np.flip(A, axis = 1)
print("B =", B)

#Exercise 4:
import numpy as np
a = np.arange(1, 10, 1)
print(a)
A = np.reshape(a, (3,3))
print("A =", A)
B = np.flip(A, axis = 0)
print("B =", B)

#Exercise 5:
import numpy as np
y = [1, 2, 4, 3],[2, 8, 9, 6],[16, 12, 11, 10],[31, 21, 14, 16],[22, 23, 25, 34]
Y = np.array(y)
print(Y.T)
#a
print()
print("x =")
x = Y.T[1, 1:4]
print(x)
print()
print("y =")
y = Y.T[:, 2:3]
print(y)
print()
print("A =")
A = Y.T[1:3, 1:4]
print(A)
print()
print("B =")
B = Y.T[:, [0,2,4]]
print(B)
print()
print("C =")
C = Y.T[1:4, [0,2,3,4]]
print(C)
print()
print("D =")
D = Y.T[Y.T > 12]
print(D)

#Exercise 6:
import numpy as np
A = np.array([[2, 4, 1],[6, 7, 2],[3, 5, 9]])
print(A)
print()
print("x1 =")
x1 = A[0, :]
print(x1)
print()
print("Y =")
Y = A[1:3, :]
print(Y)

#Exercise 7:
A = np.array([[2, 7, 9, 7],[3, 1, 5, 6],[8, 1, 2, 5]])
print(A)
print()
print("B =")
B = A[:, ::2]
print(B)
print()
print("C =")
C = A[1::2, :]
print(C)
print()
print("c)")
X = A.T
print(X)