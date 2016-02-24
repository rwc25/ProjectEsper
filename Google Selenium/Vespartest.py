import os.path

path = 'C:\\Github\\Project_Esper\\Google Selenium\\wordfiletest.txt'

wordfiletest = open(path, 'r')
while True:
    text = wordfiletest.readline()
    if 'Firefox' in text: #FireFox will be replaced with the file input
        print text
os.system('C:\Github\Project_Esper\SikuliX\sikulixrun -r' + wordfiletest + 'C:\Github\Project_Esper\Firefox.sikuli')
