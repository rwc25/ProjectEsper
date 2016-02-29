import csv
path = 'wordfiletest.txt'


wordfiletest = open(path, 'r+')
while 1:
    line = wordfiletest.readline()
    if not line:
        break
    print line

    with open('Action_List.csv', 'rb') as f: #looks at Action list
        reader = csv.reader(f)
        for row in reader:
            column = list(row[i] for i in [0])
            if line ==



   # os.system('D:\Git\Sikuli\\runsikulix -r' + 'D:\Git\SikuliScripts\\' + line + '.sikuli') #reads filename



