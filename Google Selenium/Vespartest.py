import os.path

path = 'C:\\Github\\Project_Esper\\Jarvis\\writetome.txt'

wordfiletest = open(path, 'r')
while True:
    text = wordfiletest.readline()
    if 'Firefox' in text: #FireFox will be replaced with the file input
        print text
os.system('C:\Github\Project_Esper\SikuliX\sikulixrun -r' + 'C:\Github\Project_Esper\SikuliScripts\\' + text + '.sikuli')
