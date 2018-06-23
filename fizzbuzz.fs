#! /usr/bin/gforth

\ title: fizzbuzz
\ description: prints out the numbers from 1 to 100 and 
\ determines additionally if the number can be divided by 3 or 5

\ nested if then cases:
\ https://www.forth.com/starting-forth/4-conditional-if-then-statements/

variable verbose

: check
DUP 15 MOD 0= IF ." fizzbuzz " DROP ELSE
DUP 3 MOD 0= IF ." fizz " DROP ELSE
DUP 5 MOD 0= IF ." buzz " DROP ELSE
. \ print number 
THEN THEN THEN ;

: welcome
verbose @ \ get variable
0= if 
  ." ---------------------------------"
  CR
  ." Fizzbuzz test in Forth. Have fun."
  CR
  ." ---------------------------------"
  CR
then
;

: main
0 verbose ! \ verbose=true
welcome
101 1 do i check loop ;

main
bye
