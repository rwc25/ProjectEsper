import os.path

path = 'wordfiletest.txt'

wordfiletest = open(path, 'r+')
while True:
    text = wordfiletest.read()
    if 'Firefox' in text: #FireFox will be replaced with the file input
        print text
    os.system('C:\Github\Project_Esper\Sikuli\\runsikulix -r' + 'C:\Github\Project_Esper\SikuliScripts\\' + text + '.sikuli')
