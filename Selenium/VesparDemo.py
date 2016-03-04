__author__ = 'Mae'

from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.common.keys import Keys
import time
import csv
import os.path


driver = webdriver.Firefox()
driver.get('https://www.facebook.com/Project.Vespar/')
input = "I tried the Vespar Alpha!"
sikuli = 'C:\SikuliX\\'

Login = driver.find_element_by_css_selector('#email')
Password = driver.find_element_by_css_selector('#pass')
SignIn = driver.find_element_by_css_selector('#u_0_1')

Login.send_keys("xxlilxaznxx@comcast.net")
Password.send_keys("syscofood")
SignIn.click()


path = 'D:\Git\Selenium\wordfiletest.txt'

wordfiletest = open(path, 'r+')
while 1:
    line = wordfiletest.readline()
    if not line:
        break
    print line
    os.system('D:\Git\Sikuli\\runsikulix -r' + 'D:\Git\SikuliScripts\\' + line + '.sikuli')


#Difficulties - working on Chrome


#result = driver.find_elements_by_xpath("//ol[@id="rso"]/li")[0] //make a list of results and get the first one
#result.find_element_by_xpath("./div/h3/a").click() //click its href