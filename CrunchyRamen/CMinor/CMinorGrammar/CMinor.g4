grammar CMinor;

cMinorType
    : ID # cMinorType_Normal
    | ID '<' cMinorTypeList '>' # cMinorType_Templated
    | cMinorType '[' ']' # cMinorType_Array
    ;

cMinorTypeList : /*group:{*/ cMinorType (',' cMinorType)* /*group:}*/;

cMinorLiteral
    : 'null' # cMinorLiteral_Null
    | BOOL # cMinorLiteral_Bool
    | INT # cMinorLiteral_Int
    | FLOAT # cMinorLiteral_Float
    | DOUBLE # cMinorLiteral_Double
    | STRING /*info: custom_load_context*/ # cMinorLiteral_String
    ;

cMinorExpression
    : cMinorLiteral # cMinorExpression_Literal

    | 'this' # cMinorExpression_This

    | ID # cMinorExpression_DirectIdentifier
    | cMinorExpression '.' ID # cMinorExpression_IndirectIdentifier

    | cMinorExpression '<' cMinorTypeList '>' '(' cMinorExpressionList? ')' # cMinorExpression_InvokeGeneric
    | cMinorExpression '(' cMinorExpressionList? ')' # cMinorExpression_Invoke
    | cMinorExpression '[' cMinorExpression ']' # cMinorExpression_Index

    | '(' cMinorExpression ')' # cMinorExpression_Group

    | cMinorExpression /*info: get_override*/ cMinorBinaryOperator_Multiplicative cMinorExpression /*info: get_override*/ # cMinorExpression_BinaryOperation_Multiplicative /*info: base_type=>CMinorExpression_BinaryOperation*/
    | cMinorExpression /*info: get_override*/ cMinorBinaryOperator_Additive cMinorExpression /*info: get_override*/ # cMinorExpression_BinaryOperation_Additive /*info: base_type=>CMinorExpression_BinaryOperation*/
    | cMinorExpression /*info: get_override*/ cMinorBinaryOperator_Comparative cMinorExpression /*info: get_override*/ # cMinorExpression_BinaryOperation_Comparative /*info: base_type=>CMinorExpression_BinaryOperation*/

    | cMinorExpression /*info: get_override*/ cMinorBinaryOperator_Boolean cMinorExpression /*info: get_override*/ # cMinorExpression_BinaryOperation_Boolean /*info: base_type=>CMinorExpression_BinaryOperation*/
    ;

cMinorBinaryOperator_Multiplicative /*info: base_type=>CMinorBinaryOperator*/
    : '*' # cMinorBinaryOperator_Multiplicative_Multiply
    | '/' # cMinorBinaryOperator_Multiplicative_Divide
    | '%' # cMinorBinaryOperator_Multiplicative_Modulo
    ;

cMinorBinaryOperator_Additive /*info: base_type=>CMinorBinaryOperator*/
    : '+' # cMinorBinaryOperator_Additive_Add
    | '-' # cMinorBinaryOperator_Additive_Subtract
    ;

cMinorBinaryOperator_Comparative /*info: base_type=>CMinorBinaryOperator*/
    : '<' # cMinorBinaryOperator_Comparative_LessThan
    | '<' '=' # cMinorBinaryOperator_Comparative_LessThanOrEqualTo
    | '>' # cMinorBinaryOperator_Comparative_GreaterThan
    | '>' '=' # cMinorBinaryOperator_Comparative_GreaterThanOrEqualTo
    | '=' '=' # cMinorBinaryOperator_Comparative_EqualTo
    | '!' '=' # cMinorBinaryOperator_Comparative_NotEqualTo
    ;

cMinorBinaryOperator_Boolean /*info: base_type=>CMinorBinaryOperator*/
    : '&' # cMinorBinaryOperator_Boolean_And
    | '|' # cMinorBinaryOperator_Boolean_Or
    ;

cMinorExpressionList : /*group:{*/ cMinorExpression (',' cMinorExpression)* /*group:}*/;

cMinorStatement
    : ID '=' cMinorExpression ';' # cMinorStatement_DirectAssign
    | cMinorExpression '.' ID '=' cMinorExpression ';' # cMinorStatement_IndirectAssign

    | ID cMinorBinaryOperator_Additive '=' cMinorExpression /*info: name=>assignment_expression, get_override*/ ';' # cMinorStatement_OperationAssign_DirectAdditive /*info: base_type=>CMinorStatement_OperationAssign*/
    | ID cMinorBinaryOperator_Multiplicative '=' cMinorExpression /*info: name=>assignment_expression, get_override*/ ';' # cMinorStatement_OperationAssign_DirectMultiplicative /*info: base_type=>CMinorStatement_OperationAssign*/
    | cMinorExpression '.' ID cMinorBinaryOperator_Additive '=' cMinorExpression /*info: name=>assignment_expression, get_override*/ ';' # cMinorStatement_OperationAssign_IndirectAdditive /*info: base_type=>CMinorStatement_OperationAssign*/
    | cMinorExpression '.' ID cMinorBinaryOperator_Multiplicative '=' cMinorExpression /*info: name=>assignment_expression, get_override*/ ';' # cMinorStatement_OperationAssign_IndirectMultiplicative /*info: base_type=>CMinorStatement_OperationAssign*/

    | cMinorExpression '<' cMinorTypeList '>' '(' cMinorExpressionList? ')' ';' # cMinorStatement_InvokeGeneric
    | cMinorExpression '(' cMinorExpressionList? ')' ';' # cMinorStatement_Invoke

    | '{' cMinorStatement* '}' # cMinorStatement_Block

    | 'if' '(' cMinorExpression ')' cMinorStatement ('else' cMinorStatement)? # cMinorStatement_If
    | 'while' '(' cMinorExpression ')' cMinorStatement # cMinorStatement_While
    ;

BOOL /*info: type=>bool*/ : ('true' | 'false');
INT /*info: type=>int*/ : ('-'|'+')? [0-9]+;
FLOAT /*info: type=>float*/ : ('-'|'+')? [0-9]+ ('.' [0-9]+)? 'f';
DOUBLE /*info: type=>double*/ : ('-'|'+')? [0-9]+ '.' [0-9]+;

STRING : '"' ('\\"'|.)*? '"';
ID : [A-Za-z_][A-Za-z0-9_]*;

WHITESPACE : [ \r\n\t]+ -> skip;
