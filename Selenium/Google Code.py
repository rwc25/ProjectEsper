__author__ = 'Mae'

from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.common.keys import Keys
import time
import csv
import os.path


driver = webdriver.Firefox()
driver.get('http://www.google.com')
input = "UW Tacoma"
sikuli = 'C:\SikuliX\\'

search = driver.find_element_by_name('q')
search.send_keys(input)
search.send_keys(Keys.ENTER)
input2 = "Admissions"
#links = WebDriverWait(driver, 2).until(lambda driver: driver.find_elements_by_link_text(input2))
#for link in links:
 #   link.click()

links = WebDriverWait(driver, 2).until(lambda driver: driver.find_elements_by_link_text("Admissions"))
for link in links:
    link.click()

os.system('C:\SikuliX\sikulixrun.cmd -r C:\Users\Mae\Desktop.sikuli')

time.sleep(5)

#Difficulties - working on Chrome


#result = driver.find_elements_by_xpath("//ol[@id="rso"]/li")[0] //make a list of results and get the first one
#result.find_element_by_xpath("./div/h3/a").click() //click its href