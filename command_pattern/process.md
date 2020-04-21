[TRY THIS AFTER KNOW REPOSITORY PATTERN]
[IMPLEMENT ONLY THE SHOPPING CART
AND THE SHOPPINGCART.BUSINESS
OTHER PROJECT IS NOT PART OF THIS
]




1) invoker invokes the command
2) and reciver is the thing which command runs
3) client can access the command and invoker
4) he can set the command and then run the invker to invoke this command
5) command stores all the information
    1) for a sopping cart the command will be like ad to cart
    2) it knows about shopping cart
    3) as well as check the stock is avilabe
    4) so all the info for execute this commnad


6) client can be considered as a button

7) the invoker is the command manager .

8) now the client also set the boundery like if the client knows from the command that the stock is over
then the invoker will no longer invoke the command


9) this design patter will automatically help to undo and redo the operation


