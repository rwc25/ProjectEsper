import os.path

path = 'wordfiletest.txt'

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
    os.system('C:\Github\Project_Esper\Sikuli\\runsikulix -r' + 'C:\Github\Project_Esper\SikuliScripts\\' + line + '.sikuli')

#for line in wordfiletest:
#    print line
#    os.system('C:\Github\Project_Esper\Sikuli\\runsikulix -r' + 'C:\Github\Project_Esper\SikuliScripts\\' + text + '.sikuli')



#if wordfiletest.read() in text:
 #   print text

#while True:
    #for index in path:
#nextword = wordfiletest.readline()
#if wordfiletest.readline() == 'Firefox':
 #   print nextword
            #os.system('C:\Github\Project_Esper\Sikuli\\runsikulix -r' + 'C:\Github\Project_Esper\SikuliScripts\\' + nextword + '.sikuli')
    #extword = wordfiletest.next()

