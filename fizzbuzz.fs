: fizz 
DUP
3 MOD 0=
IF ." fizz " 
ELSE  .
THEN ;

: buzz 
DUP
5 MOD 0=
IF ." buzz " 
ELSE  .
THEN ;

: main 101 1 do i fizz loop ;
