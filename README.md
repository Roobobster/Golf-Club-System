# Golf-Club-System

A Golf Club System that contains nearly everything I golf club will require to function as a buisness.
Created For Computer Science College Coursework 2017.

# Login 

Simple login feature that uses text file to store the logins but the password is encrpyted so only technically experienced can get the password. Once logged in you can access the homepage.

![Login Page](/readmeImages/LoginPage.png)

# Home Page

Uses WeatherAPI to get Weather at current time, can be expanded to be used on the booking to ensure people book on good weather. Has Links to all the different sections. And Has logout in bottom right.

![Home Page](/readmeImages/HomePage.png)

# Sales Menu Page

Has Cart for every sale you can make in the system such as the bookings and item purchases. Then you can either select it as visitor paying (if they don't want to sign up as member)or enter their name to select the membership you need to apply for the discount. Then data is stored in a database that records all the purchases/bookings made.

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


Contains:

    -Driving Range Booking

    -Golf Course Booking

      -Individual Hole Bookings

    -Item Stock Storing

    -Item Selling

    -Item Lending

    -Report Generating

    -Weather API

    -Login Feature

    -Mailing

      -Adding Attatchments 

      -Send to all members
  
