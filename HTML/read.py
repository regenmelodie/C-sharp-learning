from bs4 import BeautifulSoup
import bs4
import re

path = 'C:/Users/Regen/Desktop/C-sharp-learning/htmlFiles/李泽言_百度百科.html'

htmlfile = open(path, 'r', encoding='utf-8')
htmlhandle = htmlfile.read()
htmlfile.close()
soup = BeautifulSoup(htmlhandle, 'lxml')

#f = open('C:/Users/Regen/Desktop/C-sharp-learning/htmlFiles/text.txt', 'w', encoding='utf-8')
#f.writelines(soup.text)
#f.close()

f = open('C:/Users/Regen/Desktop/C-sharp-learning/htmlFiles/strings.txt', 'w', encoding='utf-8')
#print(list(soup._all_strings()))
lines = list(soup._all_strings())
length = len(lines)
for i in range(length):
    if lines[i]!='\n':
        f.write(lines[i] + '\n')

f.close()



