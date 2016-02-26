import csv

with open('Action_List.csv', 'rb') as f:
    reader = csv.reader(f)
    for row in reader:
        content = list(row[i] for i in [0])
        print content