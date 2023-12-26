import smtplib

passowrd = 'kkegxnpobrgcotwv'
my_email = 'bouncyknight11@gmail.com'
with smtplib.SMTP('smtp.gmail.com') as connection:
    connection.starttls()
    connection.login(user=my_email, password=passowrd)
    connection.sendmail(
        from_addr='bouncyknight11@gmail.com',
        to_addrs='koolabadi80@gmail.com',
        msg='subject:Flight Notification\n\n hello'
    )


