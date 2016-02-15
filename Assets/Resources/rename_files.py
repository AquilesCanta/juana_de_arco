from os import listdir
from os.path import isfile, join
import os
import subprocess
import json
import sys

if len(sys.argv) < 2:
	sys.exit("Please provide the name of the new files")


files_title = sys.argv[1]
mypath = "."
onlyfiles = [f for f in listdir(mypath) if isfile(join(mypath, f))]

for elem in onlyfiles:
        if elem == 'rename_files.py' or elem[-5:] == '.meta':
		continue
	ending = elem[-6:]
	if ending[0] == '0':
		ending = ending[1:]
	os.rename(elem, files_title + ending)
