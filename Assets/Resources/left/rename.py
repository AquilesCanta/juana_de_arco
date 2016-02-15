from os import listdir
from os.path import isfile, join
import os
import subprocess
import json

files_title = 'left'
mypath = "."
print mypath
onlyfiles = [f for f in listdir(mypath) if isfile(join(mypath, f))]

for elem in onlyfiles:
	ending = elem[-6:]
	os.rename(elem, files_title + ending)
