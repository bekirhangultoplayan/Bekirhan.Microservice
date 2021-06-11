# Sending Email using ASP.NET Core
A simple example of a sending email project using ASP.NET Core.



Configure this file using the data in the table below (or other server), Gmail and Hotmail worked with me:

| Server Name  | SMTP Address | Port  | SSL |
| ------------- | ------------- | ------------- | ------------- |
| Gmail | smtp.gmail.com | 587 | Yes |
| Hotmail | smtp.live.com | 587 | Yes |


HOST
``` 
https://localhost:44340/mail/send
``` 

REQUEST
``` 
{
    "Content": {
        "Emails": ["bekirhangultoplayan@gmail.com"],
        "Subject": "Subject",
        "Message": "Message",
        "Attachments": null
    },
    "Sender": {
        "FromName": "Display Name",
        "FromAddress": "noreply@bekirhangultoplayan.com.tr",
        "ToEmail": null,
        "CcEmail": ["bekirhangultoplayan@gmail.com","bekirhangultoplayan@hotmail.com"],
        "BccEmail": null,
        "ServerAddress": "mail.bekirhangultoplayan.com..tr",
        "ServerPort": 587,
        "ServerUseSsl": true,
        "Username": "info@bekirhangultoplayan.com.tr",
        "Password": "password"
    }
}
```


 
License
-------

This example application is [MIT Licensed](https://github.com/bekirhangultoplayan/Bekirhan.Microservice/master/LICENSE).


About the author
----------------

Hello everyone, my name is Bekirhan Gultoplayan. I'm a .NET developer from Turkey. I hope you will enjoy this simple example application as much as I enjoy developing it. If you have any problems, you can post a [GitHub issue](https://github.com/bekirhangultoplayan/Bekirhan.Microservice/issues). You can reach me out at bekirhangultoplayan@gmail.com.
 
