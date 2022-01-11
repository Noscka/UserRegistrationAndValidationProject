# User Registration And Validation Project Documentation
This program is for a project #1. It lets the user create and log into accounts and the passwords are hashed with salt as to make it more secure. It also lets the user import a wide range of accounts from a plain text file with the format being:
```
User1
Password0001
```
With as many Users wanted. This hashes, salts and adds the Users to the .json file with all the other users. The program doesn’t allow for Usernames to repeat and so if the accounts already exists and the user tries to create or import one with the same username, it’ll throw an error (doesn’t stop the program, just informs the User of the problem) as so they change the Username.

You can switch from Login to Signup on the left and once you typed in the Login/Signup information just press done on the left and it’ll create/sign you in. I know that it’s a security flaw to leave the signup and login page with the passwords and to not turn them into * but since this is just a project and not a real thing, I am doing this so its easier to test and use.
