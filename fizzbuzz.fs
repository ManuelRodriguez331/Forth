#! /usr/bin/gforth

: buzz 
DUP
5 MOD 0=
IF DROP ." buzz " 
ELSE  .
THEN ;

: fizz 
DUP
3 MOD 0=
IF DROP ." fizz " 
ELSE buzz
THEN ;

: fizzandbuzz
DUP
15 MOD 0=
IF DROP ." fizzbuzz " 
ELSE fizz
THEN ;

: main
101 1 do
i
fizzandbuzz
loop ;

main
bye
