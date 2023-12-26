from selenium import webdriver

chrome_driver_path = 'C:\Program Files\Google\Chrome\Application\chromedriver.exe'
driver = webdriver.Chrome(executable_path=chrome_driver_path)

driver.get('https://orteil.dashnet.org/cookieclicker/')


cookie = driver.find_element('bigCookie')
cookie.click()
