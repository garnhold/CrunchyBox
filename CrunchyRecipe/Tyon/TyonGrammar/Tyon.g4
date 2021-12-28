grammar Tyon;

tyonType
    : ID /*info: get_override*/ # tyonType_Normal /*info: base_type=>TyonType_Direct*/
    | ID /*info: get_override*/ '<' /*group:{*/ tyonType (',' tyonType)* /*group:}*/ '>' # tyonType_Templated /*info: base_type=>TyonType_Direct*/

    | tyonType '[' ']' # tyonType_Array
    ;

tyonObject : tyonType ('&' tyonAddress)? ('(' tyonValueList? ')')? '{' tyonVariable* '}';
tyonSurrogate : tyonType ':' tyonValue;

tyonArray : tyonType? '[' tyonValueList? ']';
tyonValueList : /*group:{*/ tyonValue (',' tyonValue)* /*group:}*/;

tyonValue
    : INT # tyonValue_Int
    | LONG # tyonValue_Long

    | FLOAT # tyonValue_Float
    | DOUBLE # tyonValue_Double
    | DECIMAL # tyonValue_Decimal

    | BOOL # tyonValue_Boolean
    | STRING /*info: custom_load_context*/ # tyonValue_String

    | 'null' # tyonValue_Null
    | 'typeof' '(' tyonType ')' # tyonValue_Type

    | '&' tyonAddress # tyonValue_InternalAddress
    | '@' tyonAddress # tyonValue_ExternalAddress

    | tyonArray # tyonValue_Array

    | tyonObject # tyonValue_Object
    | tyonSurrogate # tyonValue_Surrogate
    ;

tyonAddress
    : ID # tyonAddress_Identifier

    | INT # tyonAddress_Int
    | STRING /*info: custom_load_context*/ # tyonAddress_String
    ;

tyonVariable : ID '=' tyonValue ';';

INT /*info: type=>int*/ : ('-'|'+')? [0-9]+;
LONG /*info: type=>long*/ : ('-'|'+')? [0-9]+ ('L' | 'l');

FLOAT /*info: type=>float*/ : ('-'|'+')? [0-9]+ ('.' [0-9]+)? ('F' | 'f');
DOUBLE /*info: type=>double*/ : ('-'|'+')? [0-9]+ '.' [0-9]+;
DECIMAL /*info: type=>decimal*/ : ('-'|'+')? [0-9]+ ('.' [0-9]+)? ('M' | 'm');

BOOL /*info: type=>bool*/ : ('true' | 'false');
STRING : '"' ('\\"'|.)*? '"';

ID : [A-Za-z_][A-Za-z0-9_.]*;

WHITESPACE : [ \r\n\t]+ -> skip;
