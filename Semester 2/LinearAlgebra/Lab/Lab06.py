# -*- coding: utf-8 -*-
"""Lab6.ipynb

Automatically generated by Colab.

Original file is located at
    https://colab.research.google.com/drive/1lr7vauC3nXqs-8PHqjOO4DjTKLbvvVhn
"""

#Exercise 1:
import numpy as np
import sympy as sp
print("A1 = ")
a1 = np.array([[1, -7],[-2, -3]])
print(a1)
print("norm - 1 fo A1 = ",np.linalg.norm(a1, 1))
print()
print("A2 = ")
a2 = np.array([[-2, 8],[3, 1]])
print(a2)
print("norm - 1 fo A2 = ",np.linalg.norm(a2, 1))
print()
print("A3 = ")
a3 = np.array([[2, -8],[3, 1]])
print(a3)
print("norm - 1 fo A3 = ",np.linalg.norm(a3, 1))
print()
print("A4 = ")
a4 = np.array([[2, 3],[1, -1]])
print(a4)
print("norm - 1 fo A4 = ",np.linalg.norm(a4, 1))
print()
print("A5 = ")
a5 = np.array([[5, -4, 2],[-1, 2, 3],[-2, 1, 0]])
print(a5)
print("norm - 1 fo A5 = ",np.linalg.norm(a5, 1))

#Exercise 2:
import numpy as np
b1 = np.array([[1, -7],[-2, -3]])
print("norm infinity fo B1 = ",np.linalg.norm(b1, np.inf))
b2 = np.array([[3, 6],[1, 0]])
print("norm infinity fo B2 = ",np.linalg.norm(b2, np.inf))
b3 = np.array([[5, -4, 2],[-1, 2, 3],[-2, 1, 0]])
print("norm infinity fo B3 = ",np.linalg.norm(b3, np.inf))
b4 = np.array([[3, 6, -1],[3, 1, 0],[2, 4, -7]])
print("norm infinity fo B4 = ",np.linalg.norm(b4, np.inf))
b5 = np.array([[-3, 0, 0],[0, 4, 0],[0, 0, 2]])
print("norm infinity fo B5 = ",np.linalg.norm(b5, np.inf))

#Exercise 3:
c1 = np.array([[5, -4, 2],[-1, 2, 3],[-2, 1, 0]])
print("norm infinity fo C1 = ",np.linalg.norm(c1, 'fro'))
c2 = np.array([[1, 7, 3],[4, -2, -2],[-2, -1, 1]])
print("norm infinity fo C2 = ",np.linalg.norm(c2, 'fro'))
c3 = np.array([[2, 3],[1, -1]])
print("norm infinity fo C3 = ",np.linalg.norm(c3, 'fro'))

#Exercise 4:
import numpy as np
import math
#caua
u = np.array([[1], [1]])
v = np.array([[0], [1]])
u1 = np.linalg.norm(u,2)
v1 = np.linalg.norm(v,2)
dot = np.dot(u.T, v)/(u1*v1)
goc_r = math.acos(dot)
goc_d = math.degrees(goc_r)
print('a) = ',goc_d)
#caub
u = np.array([[1], [0]])
v = np.array([[0], [1]])
u1 = np.linalg.norm(u,2)
v1 = np.linalg.norm(v,2)
dot = np.dot(u.T, v)/(u1*v1)
goc_r = math.acos(dot)
goc_d = math.degrees(goc_r)
print('b) = ',goc_d)
#cauc
u = np.array([[-2], [3]])
v = np.array([[1/2], [-1/2]])
u1 = np.linalg.norm(u,2)
v1 = np.linalg.norm(v,2)
dot = np.dot(u.T, v)/(u1*v1)
goc_r = math.acos(dot)
goc_d = math.degrees(goc_r)
print('c) = ',goc_d)

#Exercise 5:
import numpy as np
import math
#cau a
u = np.array([2, 3])
unit_u = u / np.linalg.norm(u)
print("Unit vector of u is", unit_u, "with 2-norm =", np.linalg.norm(unit_u))
#cau b
u = np.array([1, 2, 3])
unit_u = u / np.linalg.norm(u)
print("Unit vector of u is", unit_u, "with 2-norm =", np.linalg.norm(unit_u))
#cau c
u = np.array([1/2, -1/2, 1/4])
unit_u = u / np.linalg.norm(u)
print("Unit vector of u is", unit_u, "with 2-norm =", np.linalg.norm(unit_u))
#cau d
u = np.array([math.sqrt(2), 2, -math.sqrt(2), math.sqrt(2)])
unit_u = u / np.linalg.norm(u)
print("Unit vector of u is", unit_u, "with 2-norm =", np.linalg.norm(unit_u))

#Exercise 6:
import numpy as np
import math

v1 = np.array([1, 2, 3])
s2 = np.array([7, 4, 3])
s3 = np.array([2, 1, 9])

print("Distance between v1 and s2 =", np.linalg.norm(v1-s2))
print("Distance between v1 and s3 =", np.linalg.norm(v1-s3))
print("Distance between s2 and s3 =", np.linalg.norm(s2-s3))

#Exercise 7:
import numpy as np
E7 = np.array([[80,98,99,85,106,94],[71,92,76,95,100,92],[124,163,140,160,176,161]])
A7 = np.array([[1,2,3],[2,1,2],[3,2,4]])
A7_1 = np.linalg.inv(A7)
D7 = np.matmul(A7_1,E7)
print("message D = \n",D7)
lchar = list(map(chr, range(97 - 32, 123 - 32)))
lchar.append(" ")
print("lchar = ",lchar)
lchar_ship3 = []  #message
s = ""

for col in range(0,6):
    for row in range(0,3):
      k = int(round(D7[row,col],0))
      #print(k-4)
      #print(lchar[k - 4]) #shift 3 but index of list start with 0
      s += lchar[k - 4]
print("message = ",s)
print("end")

#Exercise 8:
import numpy as np

def linear_regression(x, y):
    X = np.vstack((np.ones(len(x)), x)).T
    beta = np.linalg.inv(X.T.dot(X)).dot(X.T).dot(y)
    return beta[0], beta[1]

x = np.array([1, 2, 3, 4, 5])
y = np.array([2, 4, 6, 8, 10])
intercept, slope = linear_regression(x, y)
print("Intercept:", intercept)
print("Slope:", slope)

#Exercise 9:
import numpy as np
from sklearn.metrics.pairwise import cosine_similarity

doc_term_matrix = np.array([[0, 4, 0, 0, 0, 2, 1, 3],
                            [3, 1, 4, 3, 1, 2, 0, 1],
                            [3, 0, 0, 0, 3, 0, 3, 0],
                            [0, 1, 0, 3, 0, 0, 2, 0],
                            [2, 2, 2, 3, 1, 4, 0, 2]])

cos_sim = cosine_similarity(doc_term_matrix)
print(cos_sim)

#Exercise 10:
import numpy as np

def retrieve_nearest_doc(q, doc_vectors):

    similarities = np.dot(doc_vectors, q) / (np.linalg.norm(doc_vectors, axis=1) * np.linalg.norm(q))

    nearest_doc_idx = np.argmax(similarities)

    return nearest_doc_idx

doc_vectors = np.array([[1.0, 0.5, 0.3, 0, 0, 0],
                        [0.5, 1.0, 0, 0, 0, 0],
                        [0, 1.0, 0.8, 0.7, 0, 0],
                        [0, 0.9, 1.0, 0.5, 0, 0],
                        [0, 0, 0, 1.0, 0, 1.0],
                        [0, 0, 0, 0, 0.7, 0],
                        [0.5, 0, 0.7, 0, 0, 0.9],
                        [0, 0.6, 0, 1.0, 0.3, 0.2]])

q = np.array([0, 0, 0.7, 0.5, 0, 0.3])

nearest_doc_idx = retrieve_nearest_doc(q, doc_vectors)

print("The nearest document is D{}".format(nearest_doc_idx+1))