grammar CMinor;

cMinorType
    : ID
    | ID '<' cMinorTypeList '>'
    | cMinorType '[' ']'
    ;

cMinorTypeList : cMinorType (',' cMinorType)*;

cMinorConstant
    : BOOL
    | INT
    | FLOAT
    | DOUBLE
    | STRING
    ;

cMinorMember
    : ID
    | ID '<' cMinorTypeList'>'
    ;

cMinorExpression
    : cMinorConstant

    | cMinorMember

    | cMinorExpression '.' cMinorMember
    | cMinorExpression '(' cMinorExpressionList? ')'

    | '(' cMinorExpression ')'

    | cMinorExpression cMinorMultiplicativeOperator cMinorExpression
    | cMinorExpression cMinorAdditiveOperator cMinorExpression
    | cMinorExpression cMinorComparativeOperator cMinorExpression

    | cMinorExpression cMinorBooleanOperator cMinorExpression
    ;

cMinorMultiplicativeOperator : ('*' | '/' | '%');
cMinorAdditiveOperator : ('+' | '-');
cMinorComparativeOperator : ('<' '='? | '>' '='? | '=' '=' | '!' '=');

cMinorBooleanOperator : ('&' | '|');

cMinorExpressionList : cMinorExpression (',' cMinorExpression)*;

BOOL /*info: type=>bool*/ : ('true' | 'false');
INT /*info: type=>int*/ : ('-'|'+')? [0-9]+;
FLOAT /*info: type=>float*/ : ('-'|'+')? [0-9]+ ('.' [0-9]+)? 'f';
DOUBLE /*info: type=>double*/ : ('-'|'+')? [0-9]+ '.' [0-9]+;

STRING : '"' ('\\"'|.)*? '"';
ID : [A-Za-z_][A-Za-z0-9_]*;

WHITESPACE : [ \r\n\t]+ -> skip;
