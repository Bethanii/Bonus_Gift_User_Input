# Bonus_Gift_User_Input

Class assignment program requirements:

Part 1:
1.	Write and run a C# Console, .NET Core program that contains and does the following:

2.	Comment in the first several lines – outside of namespace boundary, including assignment name, your name, date, and description of program.

3.	Prompt for the following, in this order:

a.	Customer first name

b.	Customer last name
The prompt question for last name needs to include the first name variable, to personalize the question.

c.	The company name

d.	The item purchased
The prompt question for item purchased needs to include the company name variable, to personalize the question. 

e.	The quantity purchased. 
The prompt question for quantity purchased needs to include the item name variable, to personalize the question. 

f.	The cost for each item
The prompt question for item purchased needs to include the item name variable, to personalize the question.

g.	Write a blank line to the screen after asking for the cost.

h.	Add a Const variable (make sure to use the Const keyword) for the tax rate.  The tax rate will be .065.  (or, 1.065, depending on how you will calculated cost with tax)

i.	Ask if this item is taxable. I suggest requesting an answer of Y or N.  Make sure that case doesn’t matter (so that Y or y will represent Yes, for example)

a.	If the user indicates that the item is taxable, then Calculate the total cost, with tax, and save to a variable.
b.	If the user indicates that the item is not taxable, then Calculate the total cost, without tax, and save to a variable.

j.	Output your information in 4 lines like I did, using your variables in strings.  
a.	Make sure to use the ToString method on your cost variables in   order to format them correctly.  
b.	Make sure that all 7 of your variables are included in this output
c.	Also, see that case didn’t matter when I answered Y or N.

k.	End this portion of the program with the following:
a.	Write a blank line to the screen
b.	Write “Press any key to move on . . .” or something like that
c.	Use Console’s ReadKey() method to wait until a key is pressed
d.	Use Console’s Clear() method to clear the scree

l.	Create a single string and save it to a variable.  When you Write() or WriteLine() that variable, the output needs to look like this (so make sure your string includes \n and \t) :

m.	Ask the user to type in a 1, 2 or 3.  Save to a variable (string variable).  
a.	Keep asking until they type in a 1, 2 or 3. 
b.	Mine looks like this:

n.	Once a 1, 2, or 3 is entered, you’ll be out of that loop and the program can continue

o.	If the user chooses 1:
•	Output 2 lines, incorporating that person’s first and last name, and something that ties in the menu item they selected.

p.	 Otherwise, if the user chooses 2:
•	Output 2 lines, incorporating that person’s first name and company name, and something that ties in the menu item they selected.



