import os.path

path = 'D:\Git\Selenium\wordfiletest.txt'

wordfiletest = open(path, 'r+')
while 1:
    line = wordfiletest.readline()
    if not line:
        break
    print line
    os.system('D:\Git\Sikuli\\runsikulix -r' + 'D:\Git\SikuliScripts\\' + line + '.sikuli')


