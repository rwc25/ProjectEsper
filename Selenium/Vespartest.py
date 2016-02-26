import os.path

path = 'D:\Git\Selenium\wordfiletest.txt'

'''wordfiletest = open(path, 'r+')
text = wordfiletest.readline()
while 'Firefox' in text: #FireFox will be replaced with the file input
    print text
    os.system('C:\Github\Project_Esper\Sikuli\\runsikulix -r' + 'C:\Github\Project_Esper\SikuliScripts\\' + text + '.sikuli')
    text = wordfiletest.next()'''


wordfiletest = open(path, 'r+')
while 1:
    line = wordfiletest.readline()
    if not line:
        break
    print line
    os.system('D:\Git\Sikuli\\runsikulix -r' + 'D:\Git\SikuliScripts\\' + line + '.sikuli')


