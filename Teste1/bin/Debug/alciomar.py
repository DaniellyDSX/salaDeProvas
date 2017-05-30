lines = tuple(open('BTI1MA.txt', 'r'))
arquivo = open('BTI1MA_result.txt', 'w')

for line in lines:
    arrayLine = line.split('	')    
    arrayLine[0]=arrayLine[0].zfill(7)
    arquivo.writelines(arrayLine)

arquivo.close()

