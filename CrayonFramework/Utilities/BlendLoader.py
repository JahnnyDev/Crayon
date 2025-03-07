import bpy
import os
from decimal import Decimal

OBJECT_NAME = ''
OUTPUT_DIRECTORY = ''
OUTPUT_NAME = ''

USE_NORMAL_DATA = False;

if OUTPUT_NAME == '':
    OUTPUT_NAME = OBJECT_NAME


obj = bpy.data.objects[OBJECT_NAME]
mesh = obj.data

os.system('cls' if os.name == 'nt' else 'clear')
verts = list()
inds = list()

# get raw vertex data without vertex sharing
c = 0
verts.append(list())
if(USE_NORMAL_DATA):
    verts.append(list())
for f in mesh.polygons:
    for idx in f.vertices:
        co = mesh.vertices[idx].co
        
        x = Decimal(co.x)
        y = Decimal(co.y)
        z = Decimal(co.z)
        
        v = (round(x,3),round(z,3), round(y,3))
        verts[0].append(v)

        if(USE_NORMAL_DATA):
            no = mesh.vertices[idx].normal
            n_x = Decimal(no.x);
            n_y = Decimal(no.y);
            n_z = Decimal(no.z);
            n = (round(n_x,3),round(n_y,3), round(n_z,3))
            verts[1].append(n)

        inds.append(c)
        c+=1

# loop through and remove duplicates, re-evaluate indices
uVerts = list()
uInds = list()
uVerts.append(list())
if(USE_NORMAL_DATA):
    uVerts.append(list())
for i in range(c):
    if (verts[0][i] in uVerts[0]) == False:
        uVerts[0].append(verts[0][i])
        if(USE_NORMAL_DATA):
            uVerts[1].append(verts[1][i])
    uInds.append(uVerts[0].index(verts[0][i]))

   
        
# print to file
filePath = OUTPUT_DIRECTORY + '\\'+ OUTPUT_NAME + '.msh'

with open(filePath, 'w') as f:
    f.write('@REGION positions 3\n')
    for v in uVerts[0]:
        f.write(" ".join([str(v[0]), str(v[1]), str(v[2])]) + '\n')

    if(USE_NORMAL_DATA):
        f.write('@REGION normals 3\n')
        for n in uVerts[1]:
            f.write(" ".join([str(n[0]), str(n[1]), str(n[2])]) + '\n')

    f.write('@INDICES\n')
    for i in range(c//3):
        f.write(" ".join([str(uInds[3*i]), str(uInds[3*i + 1]), str(uInds[3*i + 2])]) + '\n')