# Golf-Club-System

Created For Computer Science College Coursework 2017.

A Golf Club System that contains nearly everything a golf club will require to function as a buisness apart from actual payment integration to allow real money to be transacted with this system as there isn't enough validation to ensure the payments are 100% valid and is best to integrate a well known payment system for actual use. Good foundation to use to edit so that it can be used for an actual golf course system. Will need some adjustments to make it work with deployed version but nothing drastic just a few pathing adjustments for where you will end up storing the database once a built version is made. Initial Login for an admin account should be auto filled initially so access to the account will be granted without prior setup after cloning repo.

# Login 

Simple login feature that uses text file to store the logins but the password is encrypted so only technically experienced can get the password. Once logged in you can access the homepage.

![Login Page](/readmeImages/LoginPage.png)

# Home Page

Uses WeatherAPI to get Weather at current time, can be expanded to be used on the booking to ensure people book on good weather. Has Links to all the different sections. And Has logout in bottom right.

![Home Page](/readmeImages/HomePage.png)

# Sales Menu Page

Has Cart for every sale you can make in the system such as the bookings and item purchases. Then you can either select it as visitor paying (if they don't want to sign up as member) or enter their name to select the membership you need to apply for the discount. Then data is stored in a database that records all the purchases/bookings made.

![Sales Menu Page](/readmeImages/SalesMenuPage.png)

# Driving Range/Golf Course Booking Date Page

This Page is shown when you press the "Add Golf Course Booking" or the "Add Driving Range Booking" button to allow you to select times that the customer wants to book for. Has validation to stop you selecting invalid times.

![BookingDatePage](/readmeImages/BookingDatePage.png)


# Driving Range Booking Page

Has a preset layout for the driving range which is two floors. You can swap between the driving range floors. Blue indicates the driving mat is currently selected, red indicates that the mat has already been booked for that time and green means you are able to book the mat.

![Driving Rabe Booking Page1](/readmeImages/DrivingRangeBookingPage1.png)
![Driving Rabe Booking Page2](/readmeImages/DrivingRangeBookingPage2.png)

# Golf Course Booking Page

Has preset layout for the golf course. You can select the holes that you want to play on so that you can play on a single hole if you want to practice on it. Option to select all holes in one button. And has colour coded holes, red = already fully booked, blue = currently selected, green = available.

![Golf Course Booking Page](/readmeImages/GolfCourseBookingPage.png)

# Item Sale Menu Page

Has search feature to allow you to find item incase there are lots of items added. You can see details of the items from the database as you click on them and update as you add them to the cart. You can either buy or lend an item and the number of buy/lend items are stored to ensure only items in stock can be sold (incase of employee mistakes). Displays total for the cart and once added it will go to the sales cart where you can finalise the purchase. 

![Item Sale Menu Page](/readmeImages/ItemSaleMenuPage.png)


# Member Pages

Has pages to add, edit and remove members from the database and also remove the bookings they may have made. These members can be then used to send emails to and use when making purchases and apply discounts automatically. 

## Add
![Member Add Page](/readmeImages/MemberAddPage.png)

## Edit
![Member Edit Page](/readmeImages/MemberEditPage.png)

## Delete
![Member Delete Page](/readmeImages/MemberDeletePage.png)

## Delete Member bookings
![Member Delete Bookings Page](/readmeImages/MemberBookingRemovePage.png)

# Item Pages

Has pages to add, edit and remove items from the database that are sold in the item sales menu.

## Add
![Item Add Page](/readmeImages/ItemAddPage.png)

## Edit
![Item Edit Page](/readmeImages/ItemEditPage.png)

## Delete
![Item Delete Page](/readmeImages/ItemDeletePage.png)

# Login Pages

Has pages to add, edit and remove logins to allow people use the system when it opens.

## Add
![Login Add Page](/readmeImages/LoginAddPage.png)

## Edit
![Login Edit Page](/readmeImages/LoginChangePage.png)

## Delete
![Login Delete Page](/readmeImages/LoginRemovePage.png)

# Mailing Pages

Has ability to compose a email body and header, attach files and folders and then it has option for you to zip those attachments so that they are smaller in size and then you can send that email to the selected membership types. Also has visualisation bar of how much data you can send before it will reject the email.

## Mailing Menu
![Mailing Menu Page](/readmeImages/MailingMenuPage.png)

## Compose Email
![Compose Email Page](/readmeImages/ComposeEmailPage.png)


# Report Generation Pages

You can create reports based on the data in the database from interacting with the system. You can customise the reports generated. There is an ability to make a report, bar chart, line chart and pie chart. Then you can display the data and you can save the data to the desktop in a png if it's a graph or as a word document if you choose report.

## Report Menu Page
![Report Menu Page](/readmeImages/ReportMenuPage.png)

## Report Create Page
![Report Create Page](/readmeImages/ReportCreateMenuPage.png)

## Report Pie chart Example
![Report Create Page](/readmeImages/ShowReportPage.png)


  
