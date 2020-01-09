grammar MExp;

mExpEntry : mExpExpression;

mExpExpression
    : NUMBER # mExpExpression_Constant

    | ID # mExpExpression_Term
    | mExpFunction # mExpExpression_Function

    | '(' mExpExpression ')' # mExpExpression_Group

    | mExpUnarySignOperator mExpExpression # mExpExpression_Sign

    | mExpExpression mExpBinaryMultiplicativeOperator mExpExpression # mExpExpression_Multiplicative
    | mExpExpression mExpBinaryAdditiveOperator mExpExpression # mExpExpression_Additive
    ;

mExpUnarySignOperator /*info: base_type=>MExpUnaryOperator*/
    : '-' # mExpUnaryOperator_Negate
    ;

mExpBinaryAdditiveOperator /*info: base_type=>MExpBinaryOperator*/
    : '+' # mExpBinaryAdditiveOperator_Addition
    | '-' # mExpBinaryAdditiveOperator_Subtraction
    ;

mExpBinaryMultiplicativeOperator /*info: base_type=>MExpBinaryOperator*/
    : '*' # mExpBinaryMultiplicativeOperator_Multiplication
    | '/' # mExpBinaryMultiplicativeOperator_Division
    | '%' # mExpBinaryMultiplicativeOperator_Modulo
    ;

mExpFunction : ID '(' /*group:{*/ (mExpExpression (',' mExpExpression)*)? /*group:}*/ ')';

NUMBER /*info: type=>float*/ : [0-9]+ ('.' [0-9]+)?;
ID : [A-Za-z_][A-Za-z0-9_]*;

WHITESPACE : [ \r\n\t]+ -> skip;